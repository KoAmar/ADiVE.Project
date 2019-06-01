using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class MainForm : Form
    {
        private bool _firstLoop;
        private int _waitTime;
        private double? _lastCalculatedResult;

        public MainForm()
        {
            var prev = new Preview();
            prev.ShowDialog();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _firstLoop = true;
            _lastCalculatedResult = null;
            animationTimer.Start();
            _waitTime = 0;
        }


        private void SimpleCalcButton_Click(object sender, EventArgs e)
        {
            if (dataBox1 == null) return;
            dataBox1.DeterminantCalculated += DrawResult;
            var res = dataBox1.CalcAll(_waitTime);
            toolStripDropDownButton1.Enabled = true;
            MessageBox.Show($"Полученный определитель: {res}");
        }
        
        private void DrawResult(double? determinant)
        {
            if (determinant != null)
            {
                ResultLabel.Visible = true;
                toolStripDropDownButton1.Enabled = true;
                _lastCalculatedResult = determinant;
                ResultLabel.Text = "  Последний полученный резульат: " +
                                   determinant.Value.ToString(CultureInfo.InvariantCulture);
            }
            dataBox1.DeterminantCalculated -= DrawResult;

        }

        private void Setsize()
        {
            if (!_firstLoop)
            {
                if (MessageBox.Show("Вы действительно хотите сбросить данные в таблице?",
                    "Важный вопрос!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            }

            if (int.TryParse(size.Text, out var value))
            {
                if (value > 0)
                {
                    _firstLoop = false;
                    simpleCalcButton.Enabled = true;
                    showDetailedStripButton.Enabled = true;
                    dataBox1.SetSize(value);
                }
                else MessageBox.Show("РАЗМЕР НЕ МОЖЕТ БЫТЬ МЕНЬШЕ ЕДЕНИЦЫ");
            }
            else
            {
                MessageBox.Show("Введённый размер должен быть целочисленным!");
            }
        }

        private void Size_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter) return;
            Setsize();
        }

        private void CreateNewStepsForm()
        {
            var x = new StepsView(dataBox1);
            x.ShowDialog();
        }

        private void ShowDetailedStripButton_Click(object sender, EventArgs e)
        {
            new Thread(CreateNewStepsForm).Start();
        }

        private void AnimatedCheck_CheckedChanged(object sender, EventArgs e)
        {
            _waitTime = animatedCheck.Checked ? 1000 : 0;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (ResultLabel.ForeColor == Color.Red)
            {
                ResultLabel.ForeColor = Color.Black;

            }
            else { ResultLabel.ForeColor = Color.Red; }
        }
        private void setSize_Button_Click(object sender, EventArgs e)
        {
            Setsize();
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var excel = new MExcel();
            if (_lastCalculatedResult != null)
                excel.DisplayInExcel(dataBox1.CopyToArray(), (double) _lastCalculatedResult);
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_lastCalculatedResult != null)
                MWord.CreateWordDoc(dataBox1.CopyToArray(), (double) _lastCalculatedResult);
        }
        
        private void aboutВPowerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ppoint = new Ppoint();
            ppoint.ShowPresentation();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.size = size.Text;
            Properties.Settings.Default.aChecked = animatedCheck.Checked;
            Properties.Settings.Default.Save(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            size.Text = Properties.Settings.Default.size;
            animatedCheck.Checked = Properties.Settings.Default.aChecked;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "Help.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
