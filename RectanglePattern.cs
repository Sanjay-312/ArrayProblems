using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsAssignment
{
    internal class RectanglePattern
    {

        public static void get_rectangle_pattern()
        {
            Console.WriteLine("enter the number");
            int number=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
               if(i==1 || i == number)
               {
                    string str=new string('*', number);
                    Console.WriteLine(str);
               }
               else
               {
                    string str= new string(' ',(number-2));
                    Console.WriteLine("*"+str+"*");

                }
            }
        }
    }
}
