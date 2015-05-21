using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AnagramsProblem
    {
        public static IList<string> Anagrams(string[] strs)
        {

            Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();
            HashSet<int> hashGroup = new HashSet<int>();
            for (int i = 0; i < strs.Length; i++)
            {
                int hashValue = GetWordValue(strs[i]);
                if (hashValue == -1)
                    continue;
                if (dic.ContainsKey(hashValue))
                {
                    dic[hashValue].Add(strs[i]);
                    hashGroup.Add(hashValue);
                }
                else
                {
                    dic.Add(hashValue, new List<string>() { strs[i] });
                }

            }

            if (hashGroup.Count == 0 | strs.Length == 1)
                return new List<string>();
            List<string> anagrams = GetAnagrams(hashGroup, dic);
            return anagrams;
        }


        public static List<string> GetAnagrams(HashSet<int> hashGroup, Dictionary<int, List<string>> dic)
        {
            List<string> anagrams = new List<string>();
            List<int> hashList = hashGroup.ToList();
            for (int i = 0; i < hashGroup.Count; i++)
            {
                anagrams.AddRange(dic[hashList[i]]);
            }

            return anagrams;
        }

        public static int GetWordValue(string str)
        {

            long value = 0;
            int alphaIndex = 0;
            int charVal;
            for (int i = 0; i < str.Length; i++)
            {
                alphaIndex = str[i] - 'a';
                charVal = 1 << alphaIndex;
                //16 8 4 2 1
                if (value + charVal > Int32.MaxValue)
                {
                    value = (value + charVal) % Int32.MaxValue;
                }
                else
                    value += charVal;

               // Debug.WriteLine((char)str[i] + " " + charVal + " " + value);
            }

            return (int)value ;
        }
    }
}
