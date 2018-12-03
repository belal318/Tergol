using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "y";

            int[,] matrix = new int[1, 1] { { 1 } };

            do
            {
                matrix=PumpMatrix(matrix);
                PrintMat(matrix);
                Console.WriteLine("Do you want to continue?");
                x= Console.ReadLine();
            } while (x=="y");
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());// קליטת מספר
            //Console.WriteLine("enter a name");
            //string name = Console.ReadLine();// קליטת שם
            //string[] arr = { "belal", "kasam" };// קליטת מערך של סטרינגים
            //int[,] matrix = { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 5, 5 }, { 4, 4 } }; // מטריצה דו ממדית
            



        }

        static int[,] PumpMatrix(int[,] matrix)
        {
           
            int[,] newMat =new int [matrix.GetLength(0)+1,matrix.GetLength(1)+1];
            CopyMatrixValues(matrix, newMat);
            int i = 0;
            int j = 0;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for ( j = 0; j < matrix.GetLength(1); j++)
                {
                    newMat[i, matrix.GetLength(1)] += matrix[i, j];
                    newMat[matrix.GetLength(1), i] += matrix[j, i];
                }
            }
            return newMat;
        }
        static void CopyMatrixValues(int[,] sourceMatrix, int[,] destinationMatrix)
        {

           
            for (int i = 0; i < destinationMatrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < destinationMatrix.GetLength(1)-1; j++)
                {
                    destinationMatrix[i, j] = sourceMatrix[i, j];
                }
            }

        }
        private static void PrintMat(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)// הדפסת שורות
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// הדפסת עמודות
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine("\b ");
            }
        }
    }
}
