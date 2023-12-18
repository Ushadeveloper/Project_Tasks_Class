using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Matrix
{
    class matrixQuestion
    {
        public void matrixIdentity()
        {
            int[,] arr1 = new int[50, 50];
            int i, j, r1, c1;
            //ppppppp

            Console.Write("\n\n Check whether a given matrix is an Identity Matrix :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write(" Input the orders(2x2, 3x3, ...) of square matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = r1;

            Console.Write(" Input elements in the matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(" element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(" The matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write(" {0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    if ((i == j && arr1[i, j] != 1) || (i != j && arr1[i, j] != 0))
                    {
                        goto label;
                    }
                }
            }
            Console.WriteLine(" The matrix is an Identity Matrix.\n\n");
            return;
        label:
            Console.WriteLine("\n The matrix is not an Identity Matrix\n\n");

        }
        public void Squarematrix()
        {
      
                int i, j, n;
                int[,] arr1 = new int[50, 50];
                int[,] brr1 = new int[50, 50];
                int[,] crr1 = new int[50, 50];

                Console.Write("\n\naddition of two Matrices :\n");
                Console.Write("-----------------------------------------\n");
                Console.Write("Input the size of the square matrix (less than 5): ");
                n = Convert.ToInt32(Console.ReadLine());

                /* Stored values into the array*/
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }

                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", brr1[i, j]);
                }
                /* calculate the sum of the matrix */
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        crr1[i, j] = arr1[i, j] + brr1[i, j];
                Console.Write("\nThe Addition of two matrix is : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", crr1[i, j]);
                }
                Console.Write("\n\n");
            }



    }
}
