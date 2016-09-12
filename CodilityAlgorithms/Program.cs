using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
//    A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

//S is empty;
//S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
//S has the form "VW" where V and W are properly nested strings.
//For example, the string "{[()()]}" is properly nested but "([)()]" is not.

//Write a function:

//int solution(char* S);
//    that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

//    For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

//    Assume that:

//    N is an integer within the range[0..200, 000];
//    string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
//Complexity:

//expected worst-case time complexity is O(N);
//    expected worst-case space complexity is O(N) (not counting the storage required for input arguments).
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToString(1082342342, 2));
            Console.WriteLine("Binary Gap: " + BinaryGap.Solution(1082342342));

            int[] arr = { 3, 8, 9, 7, 6 };

            List<int> arrRotation = CyclicRotation.Solution(arr, 3);
            Console.WriteLine("Cyclic Rotation: " );
            for(int i=0; i<arrRotation.Count; i++) { 
                Console.WriteLine(arrRotation[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Permutation Check: ");

            int[] arrPerm = { 4, 1,  3 };
            Boolean chk = PermCheck.Solution(arrPerm);
            Console.WriteLine("True or False: " + chk);

            Console.WriteLine(" ");
            Console.WriteLine("Nax Slice Sum: ");

            int[] arrMaxSliceSum = { 3, 5, -6, 12, 0 };
            int maxslicesum = MaxSliceSum.Solution(arrMaxSliceSum);
            Console.WriteLine("Max Slice Sum is: " + maxslicesum);


            Console.WriteLine(" ");
            Console.WriteLine("Triangle: ");

            int[] arrTriangle = { 10, 2, 5, 1, 8, 20 };
            int[] arrTriangle2 = { 10, 50, 5, 1};
            bool isTriangle = Triangle.Solution(arrTriangle);
            Console.WriteLine("Can form Triangle? " + isTriangle);
            isTriangle = Triangle.Solution(arrTriangle2);
            Console.WriteLine("Can form Triangle2? " + isTriangle);


            Console.WriteLine(" ");
            Console.WriteLine("Brackets Determine whether a given string of parentheses is properly nested: ");

            string S = "{[()()]}";
            string S1 = "([)()]";
            bool isBrackets = Brackets.Solution(S);
            bool isBrackets1 = Brackets.Solution(S1);
            Console.WriteLine("Is nested brackets?  " + isBrackets);
            Console.WriteLine("Is nested brackets?  " + isBrackets1);

            Console.WriteLine(" ");
            int perimeter = MinPerimeterRectangle.Solution(30);
            Console.WriteLine("MinPerimeterRectangle: " + perimeter);

            //Console.WriteLine(" ");
            //int[] A = {5,5,1,7,2,3,5 };
            //int k = splitArray.Solution(4,5);
            //Console.WriteLine("Split Array K: " + k);

            int k = Knight.solution(4, 5);
            Console.WriteLine("Knight moves: " + k);


            int[] A = { -1,3,-4,5,1,-6,2,1 };
            int s = EquilibriumIndex.solution(A);
            Console.WriteLine("Equilibrium Index is: " + s);
            Console.ReadLine();
        }
    }
}
