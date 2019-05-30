using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DeterminantCalculator
{
    public class TriangulationMethod
    {
        private TextBox _textBox;
        private ProgressBar _progressBar;
        public readonly double[][] Matrix;

        public TriangulationMethod(ref DataGridViewEx dataGrid, ref ProgressBar progressBar)
        {
            MessageBox.Show("creating");

            _progressBar = progressBar;
            var localMatrix = new LinkedList<double[]>();
            for (var str = 0; str < dataGrid.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGrid.Rows[str].Cells.Count; col++)
                    rowValues.AddLast(double.Parse(dataGrid.Rows[str].Cells[col].Value.ToString()));
                localMatrix.AddLast(rowValues.ToArray());
            }

            Matrix = localMatrix.ToArray();
            MessageBox.Show("Created:\n" + MatrixToStr(Matrix));
        }


        public TriangulationMethod(ref DataGridViewEx dataGrid, ref ProgressBar progressBar, ref TextBox textBox) :
            this(ref dataGrid, ref progressBar)
        {
            _textBox = textBox;
        }

        public double CalcOneStep(ManualResetEvent resetEvent)
        {
            var size = Matrix.Length;
            MessageBox.Show("Matrix:\n"+MatrixToStr(Matrix));

            for (var str = 0; str < Matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {
                    resetEvent.Reset();
                    
                    var mul = -(Matrix[j][str] / Matrix[str][str]);
                    var mul2 = MultiplyMas(Matrix[str], mul);
                    var newStr = FoldMasvs(Matrix[j], mul2);
                    Matrix[j] = newStr;
                    PrintMatrix(Matrix);

                    resetEvent.WaitOne();
                }
            }

            double determinant = 1;
            for (int i = 0, j = 0; i < Matrix.Length; i++, j++) determinant *= Matrix[i][j];
            MessageBox.Show("determinant = "+determinant);
            
            return determinant;
        }


        private void Print(string text)
        {
            if (_textBox == null) return;
            if (_textBox.Text.Length > 0)
                _textBox.Text += text;
            else
                _textBox.Text = text;
        }

        private void PrintLine(string text)
        {
            if (_textBox == null) return;
            if (_textBox.Text.Length > 0)
                _textBox.Text += text + "\r\n";
            else
                _textBox.Text = text + "\r\n";
        }

        private void PrintLine()
        {
            if (_textBox == null) return;
            if (_textBox.Text.Length > 0)
                _textBox.Text += "\r\n";
            else
                _textBox.Text = "\r\n";
        }

        private static string MatrixToStr(IEnumerable<double[]> matrix)
        {
            var result = "";

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => result += i + " ");
                result += "\n";
            }

            return result;
        }

        private void PrintMatrix(double[][] matrix)
        {
            PrintLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => Print(i + " "));
                PrintLine();
            }

            PrintLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));
        }



        private static double[] FoldMasvs(double[] mas1, IReadOnlyList<double> mas2)
        {
            var newMas = new double[mas1.Length];
            Array.Copy(mas1, newMas, mas1.Length);
            for (var i = 0; i < mas2.Count; i++)
                newMas[i] += mas2[i];
            return newMas;
        }

        private static double[] MultiplyMas(double[] mas, double value)
        {
            var newMas = new double[mas.Length];
            Array.Copy(mas, newMas, mas.Length);
            for (var i = 0; i < mas.Length; i++) newMas[i] *= value;

            return newMas;
        }
    }
}