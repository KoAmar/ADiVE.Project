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
            double[][] matrix = new double[][] {
                new double[] { 5,  7,  6 },
                new double[] { 3,  0, 19 },
                new double[] { 13, 10, 7 }
            };

            //Console.WriteLine(ColMax(matrix, 1, 3));
            //PrintMatrix(matrix);
            //matrix[0] = MultiplyMas(matrix[0], 0);
            //matrix[1] = FoldMasvs(new double[] {1, 1, 1}, new double[] { 2, 2, 2 });
            //PrintMatrix(matrix);

            PrintMatrix(matrix);

            int size = matrix.Length;

            for (int str = 0; str < matrix.Length; str++)
            {
                int imax = ColMax(matrix, str, size);
                SwapStrs(ref matrix, str, imax);

                for (int j = str + 1; j < size; j++)
                {
                    double mul = -matrix[j][str] / matrix[str][str];
                    double[] newStr = FoldMasvs(matrix[j], MultiplyMas(matrix[str], mul));
                    Console.WriteLine($"new: j");
                    matrix[j] = newStr;
                }
            }

            PrintMatrix(matrix);
            Console.ReadKey();

        }

        static double[] FoldMasvs(double[] mas1, double[] mas2)
        {
            for (int i = 0; i < mas2.Length; i++)
                mas1[i] += mas2[i];
            return mas1;
        }

        static double[] MultiplyMas(double[] mas, double value)
        {
            double[] newMas = mas;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] *= value;
            }
            return mas;
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
                    Console.WriteLine($"{currMax}>{maxValue}");
                    maxValue = currMax;
                    maxColStrIndex = str;
                }
            }
            return maxColStrIndex;
        }
    }
}
