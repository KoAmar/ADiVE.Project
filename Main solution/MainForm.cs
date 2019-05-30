using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class MainForm : Form
    {
        private bool _firstLoop = true;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void SimpleCalcButton_Click(object sender, EventArgs e)
        {
            if (dataBox1 == null) return;
            dataBox1.NextStep_Button_Click();
            if (!dataBox1.IsCalculatedOnetime) return;
            
            ResultLabel.Visible = true;
            Thread.Sleep(1000);
            ResultLabel.Text = "Последний полученный резульат: "+dataBox1?.LastCalculatedResult.ToString(CultureInfo.InvariantCulture);

        }

        private void Size_KeyDown(object sender, KeyEventArgs e)
        {    
            
            if (e.KeyCode != Keys.Enter) return;
            if(!_firstLoop){if (MessageBox.Show("Вы действительно хотите сбросить данные в таблице?",
                    "Важный вопрос!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;}

            _firstLoop = false;
            if (int.TryParse(size.Text, out var value))
            {
                if (value > 0) dataBox1.SetSize(value);
                else MessageBox.Show("РАЗМЕР НЕ МОЖЕТ БЫТЬ МЕНЬШЕ ЕДЕНИЦЫ");
            }
            else
            {
                MessageBox.Show("Введённый размер должен быть целочисленным!");
            }
        }

        private static void CreateNewStepsForm()
        {
            var x = new StepsView();
            x.ShowDialog();
        }

        private void ShowDetailedStripButton_Click(object sender, EventArgs e)
        {
            new Thread(CreateNewStepsForm).Start() ;

        }

        private void animatedCheck_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = animatedCheck.Checked ? 100 : 1;
        }

    }
}
