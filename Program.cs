using System;

namespace sumOfTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] matA = new int[20, 20];
            int[,] matB = new int[20, 20];
            int[,] matC = new int[20, 20];
            Console.WriteLine("\nAddition of two matrix: \n");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("elements in the first matrix \n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("element [{0},{1}]:", i, j);
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("elements in tne second matrix \n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("element [{0},{1}]:", i, j);
                    matB[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\nfirst matrix is \n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("{0}\t", matA[i, j]);
                }
            }
            Console.WriteLine("\nsecond matrix is\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("{0}\t", matB[i, j]);
                }
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        matC[i, j] = matA[i, j] + matB[i, j];
                Console.WriteLine("\nadding two matrix\n");

                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("\n");
                }
                for (j = 0; j < n; j++)
                    Console.WriteLine("{0}\t", matC[i, j]);
            }
            Console.WriteLine("\n\n");
            Console.ReadLine();
         }
     }

 }
    

