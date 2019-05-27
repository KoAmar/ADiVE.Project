using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[][] matrix = new double[][] {
            //    new double[] { 5,  7,  6 },
            //    new double[] { 3,  16, 19 },
            //    new double[] { 13, 10, 7 }
            //};
            double[][] matrix = new double[][] {
                new double[] { -2,  1, 3, 2 },
                new double[] { 3, 0, -1, 2 },
                new double[] { -5, 2, 3, 0 },
                new double[] { 4, -1, 2, -3 }
            };
            //double[][] matrix = new double[][] {
            //    new double[] { 11,  -2 },
            //    new double[] { 7, 5}
            //};
            //double[][] matrix = new double[][] {
            //    new double[] { 1, 2, 3 },
            //    new double[] { 4, 5, 6 },
            //    new double[] { 7, 8, 9 }
            //};

            PrintMatrix(matrix);

            int size = matrix.Length;

            for (int str = 0; str < matrix.Length; str++)
            {
                int imax = ColMax(matrix, str, size);
                //SwapStrs(ref matrix, str, imax);

                for (int j = str + 1; j < size; j++)
                {
                    double mul = -(matrix[j][str] / matrix[str][str]);
                    double[] mul2 = MultiplyMas(matrix[str], mul);
                    double[] newStr = FoldMasvs(matrix[j], mul2);
                    matrix[j] = newStr;
                    PrintMatrix(matrix);
                    Console.ReadKey();
                }
            }

            PrintMatrix(matrix);

            double determinant = 1;
            for (int i = 0, j =0; i < matrix.Length; i++, j++)
            {
                determinant*=matrix[i][j];
            }

            Console.WriteLine($"Determinant: {determinant}");

            Console.ReadKey();

        }
        static double[] FoldMasvs(double[] mas1, double[] mas2)
        {
            double[] newMas = new double[mas1.Length];
            Array.Copy(mas1, newMas, mas1.Length);
            for (int i = 0; i < mas2.Length; i++)
                newMas[i] += mas2[i];
            return newMas;
        }

        static double[] MultiplyMas(double[] mas, double value)
        {
            double[] newMas = new double[mas.Length];
            Array.Copy(mas, newMas, mas.Length);
            //mas.CopyTo(newMas,0);
            for (int i = 0; i < mas.Length; i++)
            {
                newMas[i] *= value;
            }
            return newMas;

        }



        static void SwapStrs(ref double[][] matrix, int str1, int str2)
        {
            double[] tempt = matrix[str1];
            matrix[str1] = matrix[str2];
            matrix[str2] = tempt;
        }

        static void PrintMatrix(double[][] matrix)
        {
            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));

            foreach (double[] str in matrix)
            {
                Array.ForEach(str, i => Console.Write(i + " "));
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));

        }

        static int ColMax(double[][] matrix, int i, int size)
        {
            int maxColStrIndex = i;

            double maxValue = -double.MaxValue;

            for (int str = i; str < size; str++)
            {
                double currMax = matrix[str][i];
                if (currMax > maxValue)
                {
                    //Console.WriteLine($"{currMax}>{maxValue}");
                    maxValue = currMax;
                    maxColStrIndex = str;
                }
            }
            return maxColStrIndex;
        }
    }
}
