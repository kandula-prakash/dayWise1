using System;

namespace arrayLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, n, sum = 0;


            Console.WriteLine("Sum of the array:  \n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input {0} elements in the array:",n);
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("elements - {0}",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for ( i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum of all elementsin the array is : {0}\n\n",sum);
        }
    }
}
