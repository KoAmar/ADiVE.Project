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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GridLv1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutВPowerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailedStripButton = new System.Windows.Forms.ToolStripButton();
            this.simpleCalcButton = new System.Windows.Forms.ToolStripButton();
            this.resultSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ResultLabel = new System.Windows.Forms.ToolStripLabel();
            this.GridLv2 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.animatedCheck = new System.Windows.Forms.CheckBox();
            this.boxForSize = new System.Windows.Forms.GroupBox();
            this.setSize_Button = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.dataBox1 = new Main_solution.DataBox();
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
            this.GridLv1.Controls.Add(this.toolStrip1, 0, 0);
            this.GridLv1.Controls.Add(this.GridLv2, 0, 1);
            this.GridLv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv1.Location = new System.Drawing.Point(0, 0);
            this.GridLv1.Name = "GridLv1";
            this.GridLv1.RowCount = 2;
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.GridLv1.Size = new System.Drawing.Size(800, 450);
            this.GridLv1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.showDetailedStripButton,
            this.simpleCalcButton,
            this.resultSeparator,
            this.ResultLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutВPowerPointToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton2.Text = "Помощь";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "About";
            // 
            // aboutВPowerPointToolStripMenuItem
            // 
            this.aboutВPowerPointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutВPowerPointToolStripMenuItem.Image")));
            this.aboutВPowerPointToolStripMenuItem.Name = "aboutВPowerPointToolStripMenuItem";
            this.aboutВPowerPointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutВPowerPointToolStripMenuItem.Text = "About в PowerPoint";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exelToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripDropDownButton1.Text = "Экспортировать";
            // 
            // exelToolStripMenuItem
            // 
            this.exelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exelToolStripMenuItem.Image")));
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exelToolStripMenuItem.Text = "Excel";
            this.exelToolStripMenuItem.Click += new System.EventHandler(this.exelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wordToolStripMenuItem.Image")));
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // showDetailedStripButton
            // 
            this.showDetailedStripButton.Enabled = false;
            this.showDetailedStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showDetailedStripButton.Image")));
            this.showDetailedStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showDetailedStripButton.Name = "showDetailedStripButton";
            this.showDetailedStripButton.Size = new System.Drawing.Size(136, 22);
            this.showDetailedStripButton.Text = "Показать пошагово";
            this.showDetailedStripButton.Click += new System.EventHandler(this.ShowDetailedStripButton_Click);
            // 
            // simpleCalcButton
            // 
            this.simpleCalcButton.Enabled = false;
            this.simpleCalcButton.Image = ((System.Drawing.Image)(resources.GetObject("simpleCalcButton.Image")));
            this.simpleCalcButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.simpleCalcButton.Name = "simpleCalcButton";
            this.simpleCalcButton.Size = new System.Drawing.Size(88, 22);
            this.simpleCalcButton.Text = "Вычислить";
            this.simpleCalcButton.Click += new System.EventHandler(this.SimpleCalcButton_Click);
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
            this.GridLv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43243F));
            this.GridLv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56757F));
            this.GridLv2.Controls.Add(this.dataBox1, 1, 0);
            this.GridLv2.Controls.Add(this.SettingsGrid, 0, 0);
            this.GridLv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv2.Location = new System.Drawing.Point(3, 34);
            this.GridLv2.Name = "GridLv2";
            this.GridLv2.RowCount = 1;
            this.GridLv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridLv2.Size = new System.Drawing.Size(794, 413);
            this.GridLv2.TabIndex = 4;
            // 
            // SettingsGrid
            // 
            this.SettingsGrid.ColumnCount = 1;
            this.SettingsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsGrid.Controls.Add(this.animatedCheck, 0, 1);
            this.SettingsGrid.Controls.Add(this.boxForSize, 0, 0);
            this.SettingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsGrid.Location = new System.Drawing.Point(3, 3);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.RowCount = 2;
            this.SettingsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.SettingsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SettingsGrid.Size = new System.Drawing.Size(92, 407);
            this.SettingsGrid.TabIndex = 4;
            // 
            // animatedCheck
            // 
            this.animatedCheck.AutoSize = true;
            this.animatedCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedCheck.Location = new System.Drawing.Point(3, 348);
            this.animatedCheck.Name = "animatedCheck";
            this.animatedCheck.Size = new System.Drawing.Size(86, 56);
            this.animatedCheck.TabIndex = 1;
            this.animatedCheck.Text = "Анимация";
            this.animatedCheck.UseVisualStyleBackColor = true;
            this.animatedCheck.CheckedChanged += new System.EventHandler(this.AnimatedCheck_CheckedChanged);
            // 
            // boxForSize
            // 
            this.boxForSize.Controls.Add(this.setSize_Button);
            this.boxForSize.Controls.Add(this.size);
            this.boxForSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxForSize.Location = new System.Drawing.Point(3, 3);
            this.boxForSize.Name = "boxForSize";
            this.boxForSize.Size = new System.Drawing.Size(86, 339);
            this.boxForSize.TabIndex = 2;
            this.boxForSize.TabStop = false;
            this.boxForSize.Text = "Размер";
            // 
            // setSize_Button
            // 
            this.setSize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setSize_Button.Location = new System.Drawing.Point(3, 42);
            this.setSize_Button.Name = "setSize_Button";
            this.setSize_Button.Size = new System.Drawing.Size(80, 38);
            this.setSize_Button.TabIndex = 1;
            this.setSize_Button.Text = "Задать";
            this.setSize_Button.UseVisualStyleBackColor = true;
            this.setSize_Button.Click += new System.EventHandler(this.setSize_Button_Click);
            // 
            // size
            // 
            this.size.Dock = System.Windows.Forms.DockStyle.Top;
            this.size.Location = new System.Drawing.Point(3, 16);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(80, 20);
            this.size.TabIndex = 0;
            this.size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Size_KeyDown);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 2000;
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // dataBox1
            // 
            this.dataBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBox1.Location = new System.Drawing.Point(101, 3);
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.Size = new System.Drawing.Size(690, 407);
            this.dataBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridLv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Вычислитель определителя методом триангуляции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.TableLayoutPanel GridLv2;
        private Main_solution.DataBox dataBox1;
        private System.Windows.Forms.TableLayoutPanel SettingsGrid;
        private System.Windows.Forms.CheckBox animatedCheck;
        private System.Windows.Forms.GroupBox boxForSize;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator resultSeparator;
        private System.Windows.Forms.ToolStripLabel ResultLabel;
        private System.Windows.Forms.ToolStripButton showDetailedStripButton;
        private System.Windows.Forms.ToolStripButton simpleCalcButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutВPowerPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button setSize_Button;
    }
}

