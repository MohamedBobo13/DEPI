using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    public class Calc
    {
        public  static int Sum(int n1,int n2)
        {
            return n1 + n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Muti(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
