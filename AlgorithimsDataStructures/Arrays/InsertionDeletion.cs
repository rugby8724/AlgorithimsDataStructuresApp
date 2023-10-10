using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsDataStructures.Arrays
{
    internal class InsertionDeletion
    {
        public static void InsertAndDelete()
        {
            // Inserting at the End of an Array
            int[] intArray = new int[10];

            // make a variable to keep the length because .Length is based off capacity
            // and does not track the actual index
            int length = 0;

            // this adds data for us
            for (int i = 0; i < 8; i++)
            {
                intArray[length] = i;
                length++;
            }

            // for inserting to the end
            //intArray[length] = 8;
            //length++;

            // inserting at the start of an array

            //for(int i =3; i >= 0; i--)
            //{
            //    // this is moving all the values
            //    intArray[i+1] = intArray[i];

            //}
            //intArray[0] = 20;
            //length++;


            for (int i = length; i >= 2; i--)
            {
                //shifting each one position
                intArray[i + 1] = intArray[i];
            }

            intArray[2] = 8;

        }
    }
}
