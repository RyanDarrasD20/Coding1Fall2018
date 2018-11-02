using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Watergun mygun = new Watergun();

            int[] intArray = new int[] { 9, 4, 7, 3, 8, 2, 1, 5, 6, 0 };

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }



            //int myInt = 5;
            //IntHolder myIntHolder = new IntHolder();
            //MutateInteger(myInt);
            //MutateIntHolder(myIntHolder);
            //Console.WriteLine(myInt);
            //Console.WriteLine(myIntHolder.myInt);
        }

        //Value type
        static void MutateInteger(int input)
        {
            input *= 5;
        }

        //Reference type
        static void MutateIntHolder(IntHolder input)
        {
            input.myInt *= 5;
        }
    }

    class IntHolder
    {
        public int myInt = 5;
        public IntHolder() { }
    }
}
