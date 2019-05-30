using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class DataBox : UserControl
    {
        private static ManualResetEvent _event;
        private DeterminantCalculator.TriangulationMethod _calculator;
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
            if (e.Control is TextBox tb)
            {
                tb.KeyPress += Column_KeyPress;
            }
        }

        private static void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                                           && e.KeyChar != '.'
                                           && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && ((TextBox) sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-'
                && ((TextBox) sender).Text.IndexOf('-') == 0)
            {
                e.Handled = true;
            }
        }

        public void Step()
        {
            _event?.Set();
            
            if (_myThread==null)
            {
                _calculator = new DeterminantCalculator.TriangulationMethod(ref dataGridView,
                    ref progressBar1);
                _myThread = new Thread(Calculate);
                _myThread.Start();
                
            }
            else
            {    
                if ( _myThread.IsAlive)
                {
                    MessageBox.Show("I am alive!");
                }
                else
                {    
                    _calculator = new DeterminantCalculator.TriangulationMethod(ref dataGridView,
                        ref progressBar1);
                    _myThread = new Thread(Calculate);
                    _myThread.Start();
                }
            }
        }


        public void SetSize(int size)
        {
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

            MessageBox.Show(CountSteps(size).ToString());
            _event = new ManualResetEvent(false);
            _calculator = new DeterminantCalculator.TriangulationMethod(ref dataGridView,
                ref progressBar1);
        }

        private static int CountSteps(int size)
        {
            var counter = 0;
            for (var str = 0; str < size; str++)
            {
                counter += str;
            }

            return counter;
        }

        private void Calculate()
        {
            if (_event == null) return;
            var determinant = _calculator?.CalcOneStep(_event);
            if (determinant != null) MessageBox.Show("Result: "+
                                                     ((double) determinant).
                                                     ToString(CultureInfo.InvariantCulture));
        }
    }
}