using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class arrayparam
    {

        public static void parray(params string[] ia)
        {
            //foreach (string i in ia)
            //{

            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < ia.Length; i++)
            {

                Console.WriteLine(ia[i]);
            }

        }
    }
}
