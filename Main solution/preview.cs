using System;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) progressBar1.PerformStep();
            else Close();
        }
    }
}
