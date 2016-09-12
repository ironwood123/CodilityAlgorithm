using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MinPerimeterRectangle
    {
        public static int Solution(int N)
        {
            int i, j;
            int per = int.MaxValue;
            for (i = 1; i <= N; i++) {
                for (j=1; j<= N; j++) {
                    if (i * j == N)
                    {
                        if (2 * (i + j) < per) per = 2 * (i + j);
                    }
                }
            }

            return per;
        }
    }
}
