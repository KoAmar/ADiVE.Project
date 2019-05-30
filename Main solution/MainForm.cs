using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void SimpleCalcButton_Click(object sender, EventArgs e)
        {
            dataBox1.Step();
        }

        private void Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (MessageBox.Show("Вы действительно хотите сбросить данные в таблице?",
                    "Важный вопрос!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
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
