using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AnagramsProblem2
    {
        public static IList<string> Anagrams(string[] strs)
        {

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            HashSet<string> hashGroup = new HashSet<string>();
            for (int i = 0; i < strs.Length; i++)
            {
                string hashValue = GetWordValue(strs[i]);
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


        public static List<string> GetAnagrams(HashSet<string> hashGroup, Dictionary<string, List<string>> dic)
        {
            List<string> anagrams = new List<string>();
            List<string> hashList = hashGroup.ToList();
            for (int i = 0; i < hashGroup.Count; i++)
            {
                anagrams.AddRange(dic[hashList[i]]);
            }

            return anagrams;
        }

        public static string GetWordValue(string str)
        {
            char[] word = str.ToCharArray();
            Array.Sort(word);
            return new string(word);
        }
    }
}
