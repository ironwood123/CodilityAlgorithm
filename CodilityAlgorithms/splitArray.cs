using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class splitArray
    {
        public static int Solution(int X, int[] A)
        {
            List<int> myList = new List<int>(A);
            List<int> listEqual = new List<int>();
            List<int> listNotEqual = new List<int>();
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == X)
                {
                    listEqual.Add(myList[i]);
                }
                else {
                    listNotEqual.Add(myList[i]);
                }

                if (listEqual.Count == listNotEqual.Count) break;
            }
            return 2*listEqual.Count;

        }
    }
}
