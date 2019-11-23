using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCODE_WAR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "charis";
                bool result = IsIsogram(str);
               
                // Declare an array



                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("ออกจากลูป");
                Console.ReadKey();
            }
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {

            a[1] = 1;
            a[0] = 2;
            a[2] = 3;
            b[0] = 2;
            return b;
        }

        public static bool XO(string input)
        {
            int xCounter = 0;
            int oCounter = 0;

            foreach (Char c in input)
            {
                if (Char.ToLower(c) == 'x') xCounter++;
                else if (Char.ToLower(c) == 'o') oCounter++;
            }

            return xCounter == oCounter;

        }

        public static string GetMiddle(string s)
        {
            if (s.Length % 2 != 0)
            {
                return s[((s.Length + 1) / 2) - 1].ToString();
            }
            else
            {
                return s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            }

        }


        public static bool IsIsogram(string str)
        {
            var chars = str.ToLower().ToCharArray();
            var hash = new HashSet<char>();

            foreach (var c in chars)
            {
                if (hash.Contains(c))
                {
                    return false;
                }
                else
                {
                    hash.Add(c);
                }
            }

            return true;
        }
  
    }
}








