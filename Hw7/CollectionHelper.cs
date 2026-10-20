using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hw7
{
    internal static class CollectionHelper
    {
        static public void PrintReverse<T>(this  IList<T> array)
        {
            for (int i = array.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void GetFirstElement<T>(this IList<T> array)
        {
            Console.WriteLine(array[0]);
        }
        public static void GetLastElement<T>(this IList<T> array)
        {
            Console.WriteLine(array[array.Count - 1]);
        }
        public static bool ContainsElement<T>(this IList<T> array, T x)
        {

            for (int i = 0; i < array.Count; i++)
            {

                if (array[i].Equals(x))
                {

                    return true;

                }

            }
            return false;

        }
        public static void CountElements<T>(this IList<T> array)
        {
            Console.WriteLine(array.Count);
        }
        public static int FindIndex<T>(this IList<T> array, T x)
        {
            for (int i = 0; i < array.Count; i++)
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
