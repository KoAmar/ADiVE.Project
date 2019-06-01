using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DeterminantCalculator
{
    public class TriangulationMethod
    {
        public delegate void MatrixStateHandler(double[][] matrix);
        public event MatrixStateHandler MatrixChanged;

        private bool _automaticMode;

        private const int WidthOfTextbox = 52;
        private TextBox _textBox;
        private double[][] _matrix;

        public bool AutomaticMode { get => _automaticMode; set => _automaticMode = value; }

        public TriangulationMethod(ref DataGridViewEx dataGrid)
        {
            _automaticMode = false;

            var localMatrix = new LinkedList<double[]>();
            for (var str = 0; str < dataGrid.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGrid.Rows[str].Cells.Count; col++)
                    rowValues.AddLast(double.Parse(dataGrid.Rows[str].Cells[col].Value.ToString()));
                localMatrix.AddLast(rowValues.ToArray());
            }

            _matrix = localMatrix.ToArray();
        }

        public TriangulationMethod(ref DataGridViewEx dataGrid, ref TextBox textBox) :
            this(ref dataGrid)
        {
            _textBox = textBox;
        }

        private void CleanTextBox()
        {
            if (_textBox == null) return;
            _textBox.Text = "";
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

        private static string MatrixToStr(IEnumerable<double[]> matrix)
        {
            var sb = new StringBuilder();

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => sb.Append(i + " "));
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

        private static string ArrayToString(double[] array)
        {
            var sb = new StringBuilder();
            Array.ForEach(array, i => sb.Append(i + " "));
            return sb.ToString();
        }

        public double Calc(ManualResetEvent resetEvent, int waitTime = 1)
        {
            CleanTextBox();

            var size = _matrix.Length;


            int stepsCounter = 1;
            for (var str = 0; str < _matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {
                    if (_automaticMode)
                    {
                        Thread.Sleep(waitTime);
                    }
                    else
                    {
                        resetEvent.WaitOne();
                    }

                    PrintLine($"Шаг: {stepsCounter++}");
                    PrintLine(new string('˅', WidthOfTextbox));


                    var mul = -(_matrix[j][str] / _matrix[str][str]);
                    PrintLine($"-({_matrix[j][str]})" +
                        $"\r\n/\r\n" +
                        $"({_matrix[str][str]})" +
                        $"\r\n=\r\n" +
                        $"{mul}");
                    PrintLine(new string('˅', WidthOfTextbox));

                    var mul2 = MultiplyMas(_matrix[str], mul);
                    PrintLine($"({ArrayToString(_matrix[str])})" +
                        $"\r\n*\r\n" +
                        $"({mul})" +
                        $"\r\n=\r\n" +
                        $"{ArrayToString(mul2)}");
                    PrintLine(new string('˅', WidthOfTextbox));

                    var newStr = FoldMasvs(_matrix[j], mul2);
                    PrintLine($"({ArrayToString(_matrix[j])})" +
                        $"\r\n+\r\n" +
                        $"({ArrayToString(mul2)})" +
                        $"\r\n=\r\n" +
                        $"{ArrayToString(newStr)}");
                    PrintLine(new string('˅', WidthOfTextbox));

                    _matrix[j] = newStr;
                    Print(MatrixToStr(_matrix));
                    PrintLine(new string('=', WidthOfTextbox));

                    if(!_automaticMode) resetEvent.Reset();
                    MatrixChanged?.Invoke(_matrix);

                }
            }

            double determinant = 1;
            for (int i = 0, j = 0; i < size; i++, j++) determinant *= _matrix[i][j];
            PrintLine($"Определитель = {determinant}");

            return determinant;
        }

        private double[] FoldMasvs(double[] mas1, IReadOnlyList<double> mas2)
        {
            var newMas = new double[mas1.Length];
            Array.Copy(mas1, newMas, mas1.Length);
            for (var i = 0; i < mas2.Count; i++)
                newMas[i] += mas2[i];
            return newMas;
        }

        private double[] MultiplyMas(double[] mas, double value)
        {
            var newMas = new double[mas.Length];
            Array.Copy(mas, newMas, mas.Length);
            for (var i = 0; i < mas.Length; i++) newMas[i] *= value;

            return newMas;
        }
    }
}