using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsAssignment
{
    internal class SumOfDigits
    {

        public static void get_sum_of_digits()
        {
            Console.WriteLine("enter the number");
            string number=Convert.ToString( Console.ReadLine());
            int sum = 0;

            foreach(char c in number)
            {
                int each_digit=Convert.ToInt32(c);
                sum += each_digit;
                
            }
            Console.WriteLine(sum);








        }
    }
}
