using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsAssignment
{
    internal class Uniques
    {
        public static void getUniques()
        {
            int[] intArray = { 1,1,2,2,3};

           ArrayList uniquelist = new ArrayList();

            foreach (int i in intArray)
            {
                if (!uniquelist.Contains(i))
                {
                    uniquelist.Add(i);
                }
            }

            foreach (int i in uniquelist)
            {
                Console.WriteLine(i);
            }
            






        }
    }
}
