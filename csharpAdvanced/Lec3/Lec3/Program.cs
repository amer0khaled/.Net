using Lec3.Assignment1;
using Lec3.Assignment2;

namespace Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            //ArrayUtils.ReverseArray(arr);

            //foreach (int i in arr) 
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            
            //var result = ArrayUtils.FindMax(arr);
            //Console.WriteLine(result);

            Cache<int, int> cache = new Cache<int, int>();

            cache.add(1, 2);
            cache.add(2, 14);
            cache.add(3, 62);
            cache.add(4, 22);

            var x = cache.Retrieve(3);
            Console.WriteLine(x);

            cache.remove(3);

            cache.PrintCache();




        }
    }
}
