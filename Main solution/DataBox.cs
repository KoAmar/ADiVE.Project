using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DeterminantCalculator;

namespace Main_solution
{
    public partial class DataBox : UserControl
    {
        public delegate void DeterminantStateHandler(double? message);
        public event DeterminantStateHandler DeterminantCalculated;


        private static ManualResetEvent _event;
        private TriangulationMethod _calculator;
        private TextBox _texBox;
        private Thread _myThread;
        private double? _determinant;
        public int Steps { get; private set; }

        public DataBox()
        {
            InitializeComponent();
            dataGridView.EditingControlShowing +=
                DataGridView_EditingControlShowing;
            _event = new ManualResetEvent(true);

        }

        public void ConnectTextBox(ref TextBox textBox)
        {
            _texBox = textBox;
        }

        private static void DataGridView_EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Column_KeyPress;
            if (e.Control is TextBox tb) tb.KeyPress += Column_KeyPress;
        }

        private static void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                                           && e.KeyChar != '.'
                                           && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '.'
                && ((TextBox)sender).Text.IndexOf('.') > -1)
                e.Handled = true;

            if (e.KeyChar == '-'
                && ((TextBox)sender).Text.IndexOf('-') == 0)
                e.Handled = true;
        }

        private void RestartCalculating()
        {
            progressBar1.Value = progressBar1.Minimum;
            if (_texBox == null)
            {
                _calculator = new TriangulationMethod(ref dataGridView);
            }
            else
            {
                _calculator = new TriangulationMethod(ref dataGridView, ref _texBox);
            }
            //MessageBox.Show("new calc");
            _calculator.MatrixChanged += UpdateDataGrid;
            _myThread = new Thread(Calculate)
            {
                Priority = ThreadPriority.Highest
            };
            _myThread.Start();
        }

        public double CalcAll(int waitTime)
        {
            _calculator = new TriangulationMethod(ref dataGridView)
            {
                AutomaticMode = true
            };
            _calculator.MatrixChanged += UpdateDataGrid;
            _determinant = _calculator?.Calc(_event,waitTime);
            if (_determinant != null)
            {
                DeterminantCalculated?.Invoke(_determinant);
            }
            return (double)_determinant; 
        }

        public void NextStep()
        {
            Console.WriteLine("NextStep");
            if (_myThread == null)
            {
                RestartCalculating();
            }
            else
            {
                if (!_myThread.IsAlive)
                {
                    _myThread.Abort();
                    RestartCalculating();
                }
            }
            MakeStep();
        }

        private static void MakeStep()
        {
            Console.WriteLine("MakeStep");
            _event?.Set();
            //Thread.Sleep(1000);
        }

        public void SetSize(int size)
        {
            dataGridView.UseWaitCursor = false;
            dataGridView.Rows.Clear();
            dataGridView.RowCount = size;
            dataGridView.ColumnCount = size;
            for (var str = 0; str < size; str++)
            {
                dataGridView.Rows[str].HeaderCell.Value = (str + 1).ToString();
                for (var col = 0; col < size; col++)
                {
                    dataGridView.Columns[col].HeaderText = (col + 1).ToString();
                    dataGridView[col, str].Value = 1;
                }
            }


            progressBar1.Minimum = 0;
            progressBar1.Value = progressBar1.Minimum;
            Steps = CountSteps(size);
            progressBar1.Maximum = Steps;
        }

        private static int CountSteps(int size)
        {
            var counter = 0;
            for (var str = 0; str < size; str++) counter += str;

            return counter;
        }

        private void UpdateDataGrid(double[][] matrix)
        {
            //MessageBox.Show("up");
            if (matrix == null) return;
            for (var row = 0; row < dataGridView.RowCount; row++)
                for (var col = 0; col < dataGridView.ColumnCount; col++)
                    dataGridView[col, row].Value = Math.Round(matrix[row][col], 3);
            dataGridView.Refresh();
            ++progressBar1.Value;
        }
        public void CopyToDataGrid(DataBox dataBox)
        {
            dataBox.dataGridView.RowCount = dataGridView.RowCount;
            dataBox.dataGridView.ColumnCount = dataGridView.ColumnCount;
            for (var row = 0; row < dataGridView.RowCount; row++)
            {
                dataBox.dataGridView.Rows[row].HeaderCell.Value = (row + 1).ToString();
                for (var col = 0; col < dataGridView.ColumnCount; col++)
                {
                    dataBox.dataGridView.Columns[col].HeaderText = (col + 1).ToString();

                    dataBox.dataGridView[col, row].Value = dataGridView[col, row].Value;
                }
            }
            dataBox.progressBar1.Minimum = progressBar1.Minimum;
            dataBox.progressBar1.Value = progressBar1.Minimum;
            dataBox.Steps = Steps;
            dataBox.progressBar1.Maximum = Steps;
        }

        private void Calculate()
        {
            CheckForIllegalCrossThreadCalls = false;
            progressBar1.Value = progressBar1.Minimum;
            dataGridView.UseWaitCursor = true;
            dataGridView.ReadOnly = true;

            if (_event == null) return;
            _determinant = _calculator?.Calc(_event);
            if (_determinant != null)
            {
                DeterminantCalculated?.Invoke(_determinant);
            }

            dataGridView.ReadOnly = false;
            dataGridView.UseWaitCursor = false;
            //progressBar1.Value = progressBar1.Minimum;
            MessageBox.Show("Вычисление завершено.");
        }

        public double[][] CopyToArray()
        {
            var localMatrix = new LinkedList<double[]>();
            for (var str = 0; str < dataGridView.Rows.Count; str++)
            {
                var rowValues = new LinkedList<double>();
                for (var col = 0; col < dataGridView.Rows[str].Cells.Count; col++)
                    rowValues.AddLast(double.Parse(dataGridView.Rows[str].Cells[col].Value.ToString()));
                localMatrix.AddLast(rowValues.ToArray());
            }

            return localMatrix.ToArray();
        }
    }
}