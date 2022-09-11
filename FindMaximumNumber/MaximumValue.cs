using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class MaximumValue
    {
        public int[] arr;

        public MaximumValue(int[] arr)
        {
            this.arr = arr;
        }

        public void MaxValue()
        {
            Array.Sort(arr);
            Console.WriteLine("Sorting an array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
            int n = arr.Length;
            
            Console.WriteLine("Maxmum value is  " + arr[n-1]);
        }
    }
}
