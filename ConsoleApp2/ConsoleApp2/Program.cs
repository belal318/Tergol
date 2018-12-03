using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[1, 1] { { 1 } };
            do
            {
                matrix = PumpMatrix(matrix);
                PrintBoard(matrix);
                Console.WriteLine("ENTER...");

            } while (Console.ReadLine() == "y");

        }
        static void PrintBoard(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine("\b ");
            }
        }
        static int[,] PumpMatrix(int[,] matrix)
        {
            int[,] newMat = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
            CopyMatrixValues(matrix, newMat);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    newMat[i,matrix.GetLength(0)] += matrix[i, j];
                    newMat[matrix.GetLength(0), i] += matrix[i, j];
                }
            }
            return newMat;
        }

        static void CopyMatrixValues(int[,]sourceMatrix, int[,] destinationMatrix)
        {
            for (int i = 0; i < destinationMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < destinationMatrix.GetLength(1) - 1; j++)
                {
                    destinationMatrix[i, j] = sourceMatrix[i, j];
                }
            }
        }
    }
}
