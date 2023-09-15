using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsAssignment
{
    internal class Duplicate
    {
        public static void getDuplicates()
        {
            int[] intArray = { 10,15,23,26,10,26};

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        Console.WriteLine(intArray[j]);  

                    }

                }
            }
        }
    }
}
