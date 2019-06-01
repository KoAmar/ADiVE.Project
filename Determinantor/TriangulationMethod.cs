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


        private const int WIDTH_OF_TEXTBOX = 52;
        private TextBox _textBox;
        public readonly double[][] Matrix;

        public TriangulationMethod(ref DataGridViewEx dataGrid)
        {
            var localMatrix = new LinkedList<double[]>();
            for (var str = 0; str < dataGrid.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGrid.Rows[str].Cells.Count; col++)
                    rowValues.AddLast(double.Parse(dataGrid.Rows[str].Cells[col].Value.ToString()));
                localMatrix.AddLast(rowValues.ToArray());
            }

            Matrix = localMatrix.ToArray();
//            MessageBox.Show("Created:\n" + MatrixToStr(Matrix));
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

        private string ArrayToString(double[] array)
        {
            StringBuilder sb = new StringBuilder();

            Array.ForEach(array, i => sb.Append(i+" "));
            string s = sb.ToString();

            return s;
        }

        private void PrintMatrix(double[][] matrix)
        {
            if (_textBox == null) return;

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => Print(i + " "));
                PrintLine();
            }

        }

        public double Calc(ManualResetEvent resetEvent)
        {
            CleanTextBox();

            var size = Matrix.Length;

            int stepsCounter = 1;
            for (var str = 0; str < Matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {   
                    resetEvent.Reset();
                    PrintLine($"Шаг: {stepsCounter++}");
                    PrintLine(new string('˅', WIDTH_OF_TEXTBOX));


                    var mul = -(Matrix[j][str] / Matrix[str][str]);
                    PrintLine($"-({Matrix[j][str]})" +
                        $"\r\n/\r\n" +
                        $"({Matrix[str][str]})" +
                        $"\r\n=\r\n" +
                        $"{mul}");
                    PrintLine(new string('˅', WIDTH_OF_TEXTBOX));

                    var mul2 = MultiplyMas(Matrix[str], mul);
                    PrintLine($"({ArrayToString(Matrix[str])})" +
                        $"\r\n*\r\n" +
                        $"({mul})" +
                        $"\r\n=\r\n" +
                        $"{ArrayToString(mul2)}");
                    PrintLine(new string('˅', WIDTH_OF_TEXTBOX));

                    var newStr = FoldMasvs(Matrix[j], mul2);
                    PrintLine($"({ArrayToString(Matrix[j])})" +
                        $"\r\n+\r\n" +
                        $"({ArrayToString(mul2)})" +
                        $"\r\n=\r\n" +
                        $"{ArrayToString(newStr)}");
                    PrintLine(new string('˅', WIDTH_OF_TEXTBOX));

                    Matrix[j] = newStr;
                    PrintMatrix(Matrix);
                    PrintLine(new string('=', WIDTH_OF_TEXTBOX));


                    resetEvent.WaitOne();
                }
            }

            double determinant = 1;
            for (int i = 0, j = 0; i < size; i++, j++) determinant *= Matrix[i][j];
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