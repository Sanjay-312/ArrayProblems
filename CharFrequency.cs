using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsAssignment
{
    internal class CharFrequency
    {
        

        public static void getCharFrequency()
        {
            int[] intArray = { 10, 10, 10, 20, 20, 25, 30 };

            ArrayList uniquelist = new ArrayList();

            foreach (int i in intArray)
            {
                if (!uniquelist.Contains(i))
                {
                    uniquelist.Add(i);
                }
            }

            
        }

                                        
    }
}
