using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class encapsulation
    {

        private int stdno;


        public int student
        {
            get { return stdno; }

            set
            {

                if (value > 0)
                {
                    stdno = value;
                }
                else
                {
                    Console.WriteLine("enter positive value");
                }
            }

        }
    }
}
