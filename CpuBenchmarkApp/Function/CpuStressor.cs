using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpuBenchmarkApp.Function
{
    public class CpuStressor
    {
        public static void stressProcessor(int number)
        {
            Console.WriteLine("Running item: " + number);

            Int64 counter = 0;
            Int64 maxCounterVal = 500000000;

            while (counter < maxCounterVal)
            {
                counter++;
            }
        }
    }
}
