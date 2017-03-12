using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 9, 1, 4, 6, 7, 3, 2, 8 };

            int[] sorted = bubble(arr);

            for(int i = 0; i < sorted.Length; i++)
                Console.Write(sorted[i] + " ");

            Console.ReadKey();

        }

        public static int[] bubble(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;

        }

    }
}
