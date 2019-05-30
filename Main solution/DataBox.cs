using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DeterminantCalculator;

namespace Main_solution
{
    public partial class DataBox : UserControl
    {
        public bool IsCalculatedOnetime = false; 
        public double LastCalculatedResult; 
        private static ManualResetEvent _event;
        private TriangulationMethod _calculator;
        private Thread _myThread;

        public DataBox()
        {
            InitializeComponent();
            dataGridView.EditingControlShowing +=
                DataGridView_EditingControlShowing;
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
                && ((TextBox) sender).Text.IndexOf('.') > -1)
                e.Handled = true;

            if (e.KeyChar == '-'
                && ((TextBox) sender).Text.IndexOf('-') == 0)
                e.Handled = true;
        }

        private void RestartCalculating()
        {
            dataGridView.UseWaitCursor = true;
            progressBar1.Value = 0;
            _calculator = new TriangulationMethod(ref dataGridView,
                ref progressBar1);
            _myThread = new Thread(Calculate);
            _myThread.Start();
            _event?.Set();
        }

        private void MakeStep()
        {
            _event?.Set();
            progressBar1.Value++;
            UpdateDataGrid();
        }

        public void NextStep_Button_Click()
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
                dataGridView.Rows[str].HeaderCell.Value = str.ToString();
                for (var col = 0; col < size; col++)
                {
                    dataGridView.Columns[col].HeaderText = col.ToString();
                    dataGridView[col, str].Value = 0;
                }
            }

            _event = new ManualResetEvent(false);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = CountSteps(size);
        }

        private static int CountSteps(int size)
        {
            var counter = 1;
            for (var str = 0; str < size; str++) counter += str;

            return counter;
        }

        private void UpdateDataGrid()
        {
            if (_calculator == null) return;
            for (var row = 0; row < dataGridView.RowCount; row++)
            for (var col = 0; col < dataGridView.ColumnCount; col++)
                dataGridView[col, row].Value = Math.Round(_calculator.Matrix[row][col], 3);
        }

        private void Calculate()
        {
            if (_event == null) return;
            var determinant = _calculator?.CalcOneStep(_event);
            if (determinant == null) return;
            IsCalculatedOnetime = true;
            LastCalculatedResult = (double) determinant;
            dataGridView.UseWaitCursor = false;
        }
    }
}