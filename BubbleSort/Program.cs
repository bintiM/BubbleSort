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

            Console.WriteLine("unsortiertes Array:");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
    


            int[] sorted = bubble(arr);

            Console.WriteLine("\nsortiertes Array:");

            for (int i = 0; i < sorted.Length; i++)
                Console.Write(sorted[i] + " ");

            Console.ReadKey();

        }

        public static int[] bubble(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++) // das Array einmal durchgehen
            {
                /*restliches unsortiertes Array durchsuchen, die größten Werte bubbeln nach rechts, der größte Wert landet nach der ersten Iteration ganz hinten, daher muss nicht mehr das ganze Array durchgegangen werden (array.Length - 1)
                 * */
                for (int j = 0; j < array.Length - 1 - i; j++) 
                    
                {
                    if (array[j] > array[j + 1]) // wenn die linke Position größer ist als rechts, dann muss getauscht werden
                    {
                        temp = array[j + 1]; // rechte Zahl merken
                        array[j + 1] = array[j]; // linke Zahl nach rechts schieben
                        array[j] = temp; // gemerkte Zahl nach links setzen
                    }
                }
            }
            return array;

        }

    }
}
