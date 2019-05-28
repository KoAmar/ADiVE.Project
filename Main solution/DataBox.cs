using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_solution
{
    

    public partial class DataBox : UserControl
    {
        public DataBox()
        {
            InitializeComponent();
            dataGridView.EditingControlShowing +=
                new DataGridViewEditingControlShowingEventHandler(DataGridView_EditingControlShowing);
        }

        #region MAGIC CODE!!
        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (e.Control is TextBox tb)
            {
                tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
            }

        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

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
            //dataGridView.cells
            ////создание колонки
            //DataGridViewTextBoxColumn dgvAge;
            //dgvAge = new DataGridViewTextBoxColumn();
            ////установка свойств
            //dgvAge.Name = "dgvAge";
            //dgvAge.HeaderText = "Возраст";
            //dgvAge.Width = 100;
            ////добавили колонку
            //dataGridView.Columns.Add(dgvAge);
            ////либо
            //dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            //{ Name = "dgvAge", HeaderText = "Возраст", Width = 100 });
        }
    }

}
