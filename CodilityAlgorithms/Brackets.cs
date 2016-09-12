using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Brackets
    {
        public static bool Solution(string S)
        { int j;
            for (int i=0; i<S.Length; i++) {
                switch (S[i]) {
                    case '{':
                        j = S.IndexOf('{');
                        if (S[S.Length - (j + 1)] != '}') return false;                       
                        break;
                    case '[':
                        j = S.IndexOf('[');
                        if (S[S.Length - (j + 1)] != ']') return false;
                        break;
                    case '(':
                        j = S.IndexOf('(');
                        if (S[S.Length - (j + 1)] != ')') return false;
                        break;
                    case ')':
                        j = S.IndexOf(')');
                        if (S[S.Length - (j + 1)] != '(') return false;
                        break;
                    case ']':
                        j = S.IndexOf(']');
                        if (S[S.Length - (j + 1)] != '[') return false;
                        break;
                    case '}':
                        j = S.IndexOf('}');
                        if (S[S.Length - (j + 1)] != '{') return false;
                        break;

                }                                
            }

            return true;
        }
    }
}
