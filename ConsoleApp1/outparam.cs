using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class outparam
    {

        public static void test(int a, int b, out int sum, out int product)
        {
            sum = a + b;

            product = a * b;


        }

       
    }
}
