using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DeterminantCalculator
{
    public class TriangulationMethod
    {
        private DataGridViewEx _dataGridView;
        private TextBox _textBox;
        private ProgressBar _progressBar;
        private readonly double[][] _matrix;

        public TriangulationMethod(ref DataGridViewEx dataGrid, ref ProgressBar progressBar)
        {
            MessageBox.Show("creating");

            _dataGridView = dataGrid;
            _progressBar = progressBar;
            var localMatrix = new LinkedList<double[]>();
            for (var str = 0; str < dataGrid.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGrid.Rows[str].Cells.Count; col++)
                    rowValues.AddLast(double.Parse(dataGrid.Rows[str].Cells[col].Value.ToString()));
                localMatrix.AddLast(rowValues.ToArray());
            }

            _matrix = localMatrix.ToArray();
            MessageBox.Show("Created:\n" + MatrixToStr(_matrix));
        }


        public TriangulationMethod(ref DataGridViewEx dataGrid, ref ProgressBar progressBar, ref TextBox textBox) :
            this(ref dataGrid, ref progressBar)
        {
            _textBox = textBox;
        }

        public double CalcOneStep(ManualResetEvent resetEvent)
        {
            var size = _matrix.Length;
            MessageBox.Show("Matrix:\n"+MatrixToStr(_matrix));

            for (var str = 0; str < _matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {
                    MessageBox.Show("step");
                    resetEvent.Reset();
                    var mul = -(_matrix[j][str] / _matrix[str][str]);
                    var mul2 = MultiplyMas(_matrix[str], mul);
                    var newStr = FoldMasvs(_matrix[j], mul2);
                    _matrix[j] = newStr;
                    PrintMatrix(_matrix);
                    resetEvent.WaitOne();
                }
            }

            double determinant = 1;
            for (int i = 0, j = 0; i < _matrix.Length; i++, j++) determinant *= _matrix[i][j];
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

        private void UpdateDataGrid()
        {
            for (var row = 0; row < _dataGridView.RowCount; row++)
            for (var col = 0; col < _dataGridView.ColumnCount; col++)
                _dataGridView[col, row].Value = _matrix[row][col];
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