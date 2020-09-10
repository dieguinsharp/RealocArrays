using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realocando_Arrays
{
    class Realoc
    {
        public static int[] Size(ref int[] OldArray, int value)
        {
            int size_array = OldArray.Length + 1;

            int[] new_array = new int[size_array];

            for (int x = 0; x < OldArray.Length; x++)
            {
                if(x == (OldArray.Length - 1))
                {
                    new_array[x] = value;
                }else
                {
                    new_array[x] = OldArray[x];
                }               
            }

            return new_array;
            
        }
    }
}
