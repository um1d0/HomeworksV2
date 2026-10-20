using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    internal static class ArrayHelper
    {
        static public void PrintReverse<T>(this T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void GetFirstElement<T>(this T[] array)
        {
            Console.WriteLine(array[0]);
        }
        public static void GetLastElement<T>(this T[] array)
        {
            Console.WriteLine(array[array.Length - 1]);
        }
        public static bool ContainsElement<T>(this T[] array, T x)
        {

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i].Equals(x))
                {

                    return true;

                }

            }
            return false;

        }
        public static void CountElements<T>(this T[] array)
        {
            Console.WriteLine(array.Length);
        }
        public static int FindIndex<T>(this T[] array, T x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(x))
                {
                    return i;
                }
               

            }
            return -1;

            
        }


    }
}
