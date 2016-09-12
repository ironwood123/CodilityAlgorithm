using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program simulate knight move on chess board. starting point(0,0), ending point (int A, int B) */
namespace ConsoleApplication2
{
    public class Knight
    {
        public static int solution(int A, int B)
        {
            int X = 0, Y = 0;
            int count = 0;
            if ((((A - X) % 2) ^ ((Y - B) % 2)) == 0)
                return -1;
            while (X != A && Y != B)
            {
                int distX = A - X;
                int distY = B - Y;
                if (Math.Abs(distX) > Math.Abs(distY))
                {
                    X += distX > 0 ? 2 : -2;
                    Y += distY > 0 ? 1 : -1;
                }
                else
                {
                    X += distX > 0 ? 1 : -1;
                    Y += distY > 0 ? 2 : -2;
                }
                count++;
            }
            if (count > 100000000) return -2; 
            return count;

        }
    }
}
