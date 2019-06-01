using System;
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
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _firstLoop = true;
            _lastCalculatedResult = null;
            animationTimer.Start();
            _waitTime = 1;
        }


        private void SimpleCalcButton_Click(object sender, EventArgs e)
        {
            if (dataBox1 == null) return;
            dataBox1.DeterminantCalculated += DrawResult;
            var res = dataBox1.CalcAll(_waitTime);

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
            _waitTime = animatedCheck.Checked ? 1000 : 1;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (ResultLabel.ForeColor == Color.Red)
            {
                ResultLabel.ForeColor = Color.Black;

            }
            else { ResultLabel.ForeColor = Color.Red; }
        }

        private void SetSize_Button_Click(object sender, EventArgs e)
        {
            Setsize();
        }
    }
}
