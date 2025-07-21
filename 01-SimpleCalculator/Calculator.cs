using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Calculator
    {
        int result;
        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int Subtract(int a, int b)
        {
            result = a - b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        { 
            result = a / b;
            return result;
        }
    }
}
