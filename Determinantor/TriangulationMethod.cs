using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeterminantCalculator
{
    public class TriangulationMethod
    {
        private DataGridView dataGridView;
        private TextBox textBox;
        private double[][] matrix;
        
        public TriangulationMethod(ref DataGridView dataGrid, ref TextBox textBox)
        {
            for (var str = 0; str < dataGrid.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGrid.Rows[str].Cells.Count; col++)
                {
                    rowValues.AddLast(double.Parse(dataGrid.Rows[str].Cells[col].Value.ToString()));
                }

                matrix = new[]{rowValues.ToArray()};
            }
        }

        public void CalcOneStep()
        {
            var matrix = new[]
            {
                new double[] {-2, 1, 3, 2},
                new double[] {3, 0, -1, 2},
                new double[] {-5, 2, 3, 0},
                new double[] {4, -1, 2, -3}
            };

            PrintMatrix(matrix);

            var size = matrix.Length;

            for (var str = 0; str < matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {
                    var mul = -(matrix[j][str] / matrix[str][str]);
                    var mul2 = MultiplyMas(matrix[str], mul);
                    var newStr = FoldMasvs(matrix[j], mul2);
                    matrix[j] = newStr;
                    PrintMatrix(matrix);
                    Console.ReadKey();
                }
            }

            PrintMatrix(matrix);

            double determinant = 1;
            for (int i = 0, j = 0; i < matrix.Length; i++, j++)
            {
                determinant *= matrix[i][j];
            }

            Console.WriteLine($"Determinant: {determinant}");

            Console.ReadKey();
        }

        private static double[] FoldMasvs(double[] mas1, double[] mas2)
        {
            var newMas = new double[mas1.Length];
            Array.Copy(mas1, newMas, mas1.Length);
            for (var i = 0; i < mas2.Length; i++)
                newMas[i] += mas2[i];
            return newMas;
        }

        private static double[] MultiplyMas(double[] mas, double value)
        {
            var newMas = new double[mas.Length];
            Array.Copy(mas, newMas, mas.Length);
            for (var i = 0; i < mas.Length; i++)
            {
                newMas[i] *= value;
            }

            return newMas;
        }

        private static void PrintMatrix(double[][] matrix)
        {
            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));

            foreach (double[] str in matrix)
            {
                Array.ForEach(str, i => Console.Write(i + " "));
                Console.WriteLine();
            }

            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));
        }
    }
}