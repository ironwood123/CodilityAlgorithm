using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class BinaryGap
    {
        //Find longest sequence of zeroes in a binary representation of an integer
        public static int Solution(int N)
        {
            List<int> occurenceCount = new List<int>();
            int Counter = 0, value;

            if (N == 0)
            {
                Console.WriteLine(0);
                return 0;
            }

            else
            {
                string binaryRep = Convert.ToString(N, 2);

                // find the first occurence of 1 
                int FirstIndex = binaryRep.IndexOf("1");

                // find the last occurence of 1
                int LastIndex = binaryRep.LastIndexOf("1");

                for (int i = FirstIndex; i < LastIndex + 1;)
                {

                    value = i;

                    while (binaryRep[value++] != '1')
                    {
                        Counter = Counter + 1;
                    }
                    occurenceCount.Add(Counter);
                    i = value;
                    Counter = 0;
                }
                return occurenceCount.Max();
            }
        }
    }
}
