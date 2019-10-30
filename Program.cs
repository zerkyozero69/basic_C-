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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine(true);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {

            a[0] = 1;
            a[1] = 2;
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
        public static string CreatePhoneNumber(int[] numbers)
        {
            string ;
            int[] arr1 = new int[9];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, [j]);
            }
            Console.ReadKey();
        }
    }

    
}
