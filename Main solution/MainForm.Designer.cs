namespace Main_solution
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GridLv1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.showDetailedStripButton = new System.Windows.Forms.ToolStripButton();
            this.simpleCalcButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.resultSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ResultLabel = new System.Windows.Forms.ToolStripLabel();
            this.GridLv2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataBox1 = new Main_solution.DataBox();
            this.SettingsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.animatedCheck = new System.Windows.Forms.CheckBox();
            this.boxForSize = new System.Windows.Forms.GroupBox();
            this.size = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridLv1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GridLv2.SuspendLayout();
            this.SettingsGrid.SuspendLayout();
            this.boxForSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridLv1
            // 
            this.GridLv1.ColumnCount = 1;
            this.GridLv1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridLv1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridLv1.Controls.Add(this.toolStrip1, 0, 0);
            this.GridLv1.Controls.Add(this.GridLv2, 0, 1);
            this.GridLv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv1.Location = new System.Drawing.Point(0, 0);
            this.GridLv1.Name = "GridLv1";
            this.GridLv1.RowCount = 2;
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.111111F));
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.88889F));
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridLv1.Size = new System.Drawing.Size(800, 450);
            this.GridLv1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.showDetailedStripButton,
            this.simpleCalcButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.resultSeparator,
            this.ResultLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // showDetailedStripButton
            // 
            this.showDetailedStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showDetailedStripButton.Image")));
            this.showDetailedStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showDetailedStripButton.Name = "showDetailedStripButton";
            this.showDetailedStripButton.Size = new System.Drawing.Size(136, 22);
            this.showDetailedStripButton.Text = "Показать пошагово";
            // 
            // simpleCalcButton
            // 
            this.simpleCalcButton.Image = ((System.Drawing.Image)(resources.GetObject("simpleCalcButton.Image")));
            this.simpleCalcButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.simpleCalcButton.Name = "simpleCalcButton";
            this.simpleCalcButton.Size = new System.Drawing.Size(88, 22);
            this.simpleCalcButton.Text = "Вычислить";
            this.simpleCalcButton.Click += new System.EventHandler(this.SimpleCalcButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "Экспортировать в:";
            // 
            // resultSeparator
            // 
            this.resultSeparator.Name = "resultSeparator";
            this.resultSeparator.Size = new System.Drawing.Size(6, 25);
            this.resultSeparator.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(22, 22);
            this.ResultLabel.Text = "res";
            this.ResultLabel.Visible = false;
            // 
            // GridLv2
            // 
            this.GridLv2.ColumnCount = 2;
            this.GridLv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16161F));
            this.GridLv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.83839F));
            this.GridLv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridLv2.Controls.Add(this.dataBox1, 1, 0);
            this.GridLv2.Controls.Add(this.SettingsGrid, 0, 0);
            this.GridLv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv2.Location = new System.Drawing.Point(3, 34);
            this.GridLv2.Name = "GridLv2";
            this.GridLv2.RowCount = 1;
            this.GridLv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridLv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridLv2.Size = new System.Drawing.Size(794, 413);
            this.GridLv2.TabIndex = 4;
            // 
            // dataBox1
            // 
            this.dataBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBox1.Location = new System.Drawing.Point(131, 3);
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.Size = new System.Drawing.Size(660, 407);
            this.dataBox1.TabIndex = 3;
            // 
            // SettingsGrid
            // 
            this.SettingsGrid.ColumnCount = 1;
            this.SettingsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsGrid.Controls.Add(this.animatedCheck, 0, 1);
            this.SettingsGrid.Controls.Add(this.boxForSize, 0, 0);
            this.SettingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsGrid.Location = new System.Drawing.Point(3, 3);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.RowCount = 2;
            this.SettingsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.18919F));
            this.SettingsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.SettingsGrid.Size = new System.Drawing.Size(122, 407);
            this.SettingsGrid.TabIndex = 4;
            // 
            // animatedCheck
            // 
            this.animatedCheck.AutoSize = true;
            this.animatedCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedCheck.Location = new System.Drawing.Point(3, 366);
            this.animatedCheck.Name = "animatedCheck";
            this.animatedCheck.Size = new System.Drawing.Size(116, 38);
            this.animatedCheck.TabIndex = 1;
            this.animatedCheck.Text = "Анимация";
            this.animatedCheck.UseVisualStyleBackColor = true;
            // 
            // boxForSize
            // 
            this.boxForSize.Controls.Add(this.size);
            this.boxForSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxForSize.Location = new System.Drawing.Point(3, 3);
            this.boxForSize.Name = "boxForSize";
            this.boxForSize.Size = new System.Drawing.Size(116, 357);
            this.boxForSize.TabIndex = 2;
            this.boxForSize.TabStop = false;
            this.boxForSize.Text = "Размер";
            // 
            // size
            // 
            this.size.Dock = System.Windows.Forms.DockStyle.Top;
            this.size.Location = new System.Drawing.Point(3, 16);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(110, 20);
            this.size.TabIndex = 0;
            this.size.Text = "5";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.powerPointToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // exelToolStripMenuItem
            // 
            this.exelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exelToolStripMenuItem.Image")));
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exelToolStripMenuItem.Text = "Excel";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wordToolStripMenuItem.Image")));
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // powerPointToolStripMenuItem
            // 
            this.powerPointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("powerPointToolStripMenuItem.Image")));
            this.powerPointToolStripMenuItem.Name = "powerPointToolStripMenuItem";
            this.powerPointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerPointToolStripMenuItem.Text = "PowerPoint";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridLv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Вычислитель определителя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GridLv1.ResumeLayout(false);
            this.GridLv1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GridLv2.ResumeLayout(false);
            this.SettingsGrid.ResumeLayout(false);
            this.SettingsGrid.PerformLayout();
            this.boxForSize.ResumeLayout(false);
            this.boxForSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GridLv1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel GridLv2;
        private DataBox dataBox1;
        private System.Windows.Forms.TableLayoutPanel SettingsGrid;
        private System.Windows.Forms.CheckBox animatedCheck;
        private System.Windows.Forms.GroupBox boxForSize;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator resultSeparator;
        private System.Windows.Forms.ToolStripLabel ResultLabel;
        private System.Windows.Forms.ToolStripButton showDetailedStripButton;
        private System.Windows.Forms.ToolStripButton simpleCalcButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerPointToolStripMenuItem;
    }
}

