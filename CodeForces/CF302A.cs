using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeForces
{
    class CF302A
    {

        public static void Main(String[] arg)
        {

            int k = int.Parse(Console.ReadLine());
            //Read Input and map it to int array
            string line = Console.ReadLine();
            
            Solve(line ,k );

        }


        public static void Solve(string s, int k)
        {
            if (k ==1)
            {
                Console.WriteLine("YES");
                Console.WriteLine(s);


            }

            else if (k > s.Length)
            {
                Console.WriteLine("NO");

            }

            else
            {
                bool[] alpha = new bool[26];
                List<int> starts = new List<int>();
                List<string> tokens = new List<string>();

                int i = 0;
                int prev = 0;
                alpha[(s[0] - 'a')] = true;

                while (i < s.Length)
                {
                  ///aaacass

                    for (int j = i+1; j < s.Length-1; j++)
                    {
                        if (!alpha[s[j] - 'a'])
                        {
                            alpha[(s[j] - 'a')] = true;
                            starts.Add(i);
                            prev = i;   
                            i = j;
                            
                           
                            break;
                        }
                    }

                    if (i == s.Length-2)
                    {
                        if (!alpha[s[s.Length-1] - 'a'])
                        {
                            prev = i;
                            i++;
                        }
                        else
                        {
                            tokens[tokens.Count - 1] += s[s.Length - 1];
                        }

                        break;
                    }
                    string temp = "";


                    
                    for (int j = prev; j < i; j++)
                    {
                        temp += s[j];

                    }
                    tokens.Add(temp);
                    
                }

                Console.WriteLine("YES");
                int index = tokens.Count/k;
                int l = 0;

                for (int j = 0; j < k; j++)
                {
                    string temp = "";
                    for (l = index * j; l < index * j + index && l < tokens.Count; l++)
                    {
                        temp += tokens[l];
                    }
                    if (l != tokens.Count -1)
                    {
                        temp += Environment.NewLine;
                    }

                    Console.Write(temp);

                   
                }
                if (l != tokens.Count )
                {
                    for (int m = l; m < tokens.Count; m++)
                    {
                        Console.Write(tokens[m]);
                    }
                }

            }

        }


        
    }
}
