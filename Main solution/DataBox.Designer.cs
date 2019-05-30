namespace Main_solution
{   

    partial class DataBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.progressBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView = new DeterminantCalculator.DataGridViewEx();
            this.MainGrid.SuspendLayout();
            this.progressBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.SuspendLayout();
            this.MainGrid.ColumnCount = 1;
            this.MainGrid.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainGrid.Controls.Add(this.progressBox, 0, 1);
            this.MainGrid.Controls.Add(this.dataGridView, 0, 0);
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.Location = new System.Drawing.Point(0, 0);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowCount = 2;
            this.MainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainGrid.Size = new System.Drawing.Size(824, 621);
            this.MainGrid.TabIndex = 0;
            this.progressBox.Controls.Add(this.progressBar1);
            this.progressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBox.Location = new System.Drawing.Point(4, 530);
            this.progressBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBox.Name = "progressBox";
            this.progressBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBox.Size = new System.Drawing.Size(816, 88);
            this.progressBox.TabIndex = 5;
            this.progressBox.TabStop = false;
            this.progressBox.Text = "Прогреесс вычисления";
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(4, 19);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(808, 66);
            this.progressBar1.TabIndex = 0;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(4, 3);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.Size = new System.Drawing.Size(816, 521);
            this.dataGridView.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataBox";
            this.Size = new System.Drawing.Size(824, 621);
            this.MainGrid.ResumeLayout(false);
            this.progressBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainGrid;
        private DeterminantCalculator.DataGridViewEx dataGridView;
        private System.Windows.Forms.GroupBox progressBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
