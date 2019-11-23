using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCODE_WAR
{
    class fuction_exe
    {
        static double ComputeSD(double[] numArr, double average)
        {
            double total = 0, sd;
            int n;
            for (int i = 0; i < numArr.Length; i++)
            {
                total += Math.Pow(numArr[i] - average, 2);
            }
            n = numArr.Length;
            sd = Math.Sqrt(total / n);
            return sd;
        }

    }
}
