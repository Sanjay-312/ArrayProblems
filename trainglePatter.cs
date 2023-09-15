using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeProblemsAssignment
{
    internal class trainglePattern
    {
        public static void patternTriangle()
        {
            Console.WriteLine("enter the number");
            int number=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string str = new string('*',number-i );
                Console.WriteLine(str);
            }
        }
    }
}
