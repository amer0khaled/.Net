using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3.Assignment1
{
    public class ArrayUtils
    {
        public static void ReverseArray<T>(T[] arr)
        {
            if (arr != null)
                Array.Reverse(arr);
        }

        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array can't be null or empty");

            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }

            return max;

        }


    }
}
