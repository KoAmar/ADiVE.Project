using System;
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
        private int _steps;

        public DataBox()
        {
            InitializeComponent();
            dataGridView.EditingControlShowing +=
                DataGridView_EditingControlShowing;
            _event = new ManualResetEvent(false);

        }
        public void ConnectLog(ref TextBox textBox)
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
            
            _myThread = new Thread(Calculate);
            _myThread.Start();
            _event?.Set();
            UpdateDataGrid();
        }

        private void MakeStep()
        {
            _event?.Set();
            Thread.Sleep(10);
            UpdateDataGrid();
            ++progressBar1.Value;
        }

        public void CalcAll(int waitTime)
        {
            for (int loop = 0; loop <= _steps; loop++)
            {
                Thread.Sleep(waitTime);
                NextStep();
            }
        }

        public void NextStep()
        {

            if (_myThread == null)
            {
                RestartCalculating();
                MakeStep();
            }
            else
            {
                if (_myThread.IsAlive)
                {
                    MakeStep();
                }
                else
                {
                    _myThread.Abort();
                    dataGridView.UseWaitCursor = false;
                    RestartCalculating();
                    MakeStep();
                }
            }
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
            _steps = CountSteps(size);
            progressBar1.Maximum = _steps + 1;
        }

        private static int CountSteps(int size)
        {
            var counter = 0;
            for (var str = 0; str < size; str++) counter += str;

            return counter;
        }

        private void UpdateDataGrid()
        {
            if (_calculator == null) return;
            for (var row = 0; row < dataGridView.RowCount; row++)
                for (var col = 0; col < dataGridView.ColumnCount; col++)
                    dataGridView[col, row].Value = Math.Round(_calculator.Matrix[row][col], 3);
            dataGridView.Refresh();
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
            dataBox._steps = _steps;
            dataBox.progressBar1.Maximum = _steps;
        }

        private void Calculate()
        {
            CheckForIllegalCrossThreadCalls = false;
            progressBar1.Value = progressBar1.Minimum;
            dataGridView.UseWaitCursor = true;
            dataGridView.ReadOnly = true;

            if (_event == null) return;
            _determinant = _calculator?.CalcOneStep(_event);
            if (_determinant != null)
            {
                DeterminantCalculated?.Invoke(_determinant);
            }

            dataGridView.ReadOnly = false;
            dataGridView.UseWaitCursor = false;
            MessageBox.Show("Вычисление завершено.");
        }
    }
}