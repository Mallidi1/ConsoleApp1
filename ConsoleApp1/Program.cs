using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region value param

            //value param gives the out wich we declared on the maim method

            //int r = 20;

            //value.test(r);

            //Console.WriteLine(r);

            #endregion

            #region ref param

            //ref param gives the value which we declared on the class it does not take controller value

            //string a = "Mallidi";

            //reference.test(ref a);

            //Console.WriteLine(a);

            #endregion

            #region out param

            //by using out param we can writ multiple return's for a single method


            //int sumresult;

            //int productresult;

            //outparam.test(6, 4, out sumresult, out productresult);

            //Console.WriteLine("your sum result is :" + sumresult);
            //Console.WriteLine("your prod result is :" + productresult);

            //Console.WriteLine("your sum result is {0}", sumresult);
            //Console.WriteLine("your prod result is {0}", productresult);

            //Console.WriteLine("your sumresult and prod result is {0},{1}", sumresult, productresult);

            #endregion

            #region array param

            //string[] arr = new string[] {"satish","reddy","mallidi"};

            //arrayparam.parray("satish","reddy","mallidi");

            #endregion

            #region encapsulation

            //encapsulation e = new encapsulation();

            //e.student = +100;

            //Console.WriteLine(e.student);

            #endregion

            #region while loop
            //int i = 0;

            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region do while

            //int i = 10;

            //do
            //{
            //    Console.WriteLine(i);

            //    i++;
            //} while (i < 10);

            #endregion

            #region for loop

            //int i=0;

            //for(i=0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region for each

            //int[] array = new int[] { 10, 20, 30, 40, 50, 60 };

            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region reverse & palendrome 

            //string str, revstring = "";
            //Console.WriteLine("enter string");
            //str = Console.ReadLine();
            //str = str.ToLower();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    revstring = revstring + str[i];
            //}

            //Console.WriteLine("reverse string : {0} ", revstring);
            //if (str == revstring)
            //{
            //    Console.WriteLine("\nstring is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("\nstring is not palindrome");
            //}

            //Console.ReadLine();

            #endregion

            #region no of words
            ////ask user to enter sentence
            //Console.WriteLine("enter a sentence:");
            ////read the sentence
            //string sentence = Console.ReadLine();
            ////split the setence and storein word
            //string[] words = sentence.Split(' ');
            ////count the words
            //int countwords = words.Length;
            ////print the counted words
            //Console.WriteLine("no of words in sentence :" + countwords);
            //Console.ReadLine();
            #endregion










        }
    }
}
