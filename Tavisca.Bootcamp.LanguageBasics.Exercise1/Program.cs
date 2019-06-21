using System;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            string[] terms = equation.Split(new Char[] { '*', '=' });
            /*The first operand has a missing digit*/
            if (terms[0].Contains('?'))
            {
                int b = Int32.Parse(terms[1]);
                int c = Int32.Parse(terms[2]);
                if (c % b != 0)
                {
                    return (-1);
                }
                int a = c / b;
                string s = a.ToString();
                int indexofq = 0;
                int matches = 0;
                string A = terms[0];
                if (s.Length == A.Length)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (A[i] == '?')
                        {
                            indexofq = i;
                            continue;
                        }
                        if (A[i] == s[i])
                        {
                            matches = matches + 1;
                        }
                    }
                }
                else
                {
                    return (-1);
                }
                if (matches == (s.Length - 1))
                {
                    string s1 = s[indexofq].ToString();
                    return (Int32.Parse(s1));
                }
                else
                {
                    return (-1);
                }
            }
            /*The second operand has a missing digit*/
            if (terms[1].Contains('?'))
            {
                int a = Int32.Parse(terms[0]);
                int c = Int32.Parse(terms[2]);
                if (c % a != 0)
                {
                    return (-1);
                }
                int b = c / a;
                string s = b.ToString();
                int indexofq = 0;
                int matches = 0;
                string A = terms[1];
                if (s.Length == A.Length)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (A[i] == '?')
                        {
                            indexofq = i;
                            continue;
                        }
                        if (A[i] == s[i])
                        {
                            matches = matches + 1;
                        }
                    }
                }
                else
                {
                    return (-1);
                }
                if (matches == (s.Length - 1))
                {
                    string s1 = s[indexofq].ToString();
                    return (Int32.Parse(s1));
                }
                else
                {
                    return (-1);
                }
            }
            /*The RHS has a missing digit*/
            if (terms[2].Contains('?'))
            {
                int a = Int32.Parse(terms[0]);
                int b = Int32.Parse(terms[1]);
                int c = a * b;
                string s = c.ToString();
                int indexofq = 0;
                int matches = 0;
                string A = terms[2];
                if (s.Length == A.Length)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (A[i] == '?')
                        {
                            indexofq = i;
                            continue;
                        }
                        if (A[i] == s[i])
                        {
                            matches = matches + 1;
                        }
                    }
                }
                else
                {
                    return (-1);
                }
                if (matches == (s.Length - 1))
                {
                    string s1 = s[indexofq].ToString();
                    return (Int32.Parse(s1));
                }
                else
                {
                    return (-1);
                }
            }
            return 0;
        }
    }
}
