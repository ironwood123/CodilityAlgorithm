using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MinMaxDivision
    {
        public static int Solution(int K, int M, int[] A)
        {
            List<int> myList = new List<int>(A);
            myList.Sort();
            int sum=0;
            int reminder;
            for (int i = 0; i < myList.Count; i++) {
                sum += myList[1];
            }
            reminder = sum % K;

            return 0;
        }
    }
}
