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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Main_solution.MainForm));
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
            this.dataBox1 = new Main_solution.DataBox();
            this.SettingsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.animatedCheck = new System.Windows.Forms.CheckBox();
            this.boxForSize = new System.Windows.Forms.GroupBox();
            this.size = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GridLv1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GridLv2.SuspendLayout();
            this.SettingsGrid.SuspendLayout();
            this.boxForSize.SuspendLayout();
            this.SuspendLayout();
            this.GridLv1.ColumnCount = 1;
            this.GridLv1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridLv1.Controls.Add(this.toolStrip1, 0, 0);
            this.GridLv1.Controls.Add(this.GridLv2, 0, 1);
            this.GridLv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv1.Location = new System.Drawing.Point(0, 0);
            this.GridLv1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridLv1.Name = "GridLv1";
            this.GridLv1.RowCount = 2;
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.GridLv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.GridLv1.Size = new System.Drawing.Size(933, 519);
            this.GridLv1.TabIndex = 2;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripDropDownButton2, this.toolStripSeparator1, this.toolStripDropDownButton1,
                this.showDetailedStripButton, this.simpleCalcButton, this.resultSeparator, this.ResultLabel
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.helpToolStripMenuItem, this.aboutВPowerPointToolStripMenuItem, this.helpToolStripMenuItem1});
            this.toolStripDropDownButton2.Image =
                ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton2.Text = "Помощь";
            this.helpToolStripMenuItem.Image =
                ((System.Drawing.Image) (resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "About";
            this.aboutВPowerPointToolStripMenuItem.Image =
                ((System.Drawing.Image) (resources.GetObject("aboutВPowerPointToolStripMenuItem.Image")));
            this.aboutВPowerPointToolStripMenuItem.Name = "aboutВPowerPointToolStripMenuItem";
            this.aboutВPowerPointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutВPowerPointToolStripMenuItem.Text = "About в PowerPoint";
            this.helpToolStripMenuItem1.Image =
                ((System.Drawing.Image) (resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.exelToolStripMenuItem, this.wordToolStripMenuItem});
            this.toolStripDropDownButton1.Image =
                ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripDropDownButton1.Text = "Экспортировать";
            this.exelToolStripMenuItem.Image =
                ((System.Drawing.Image) (resources.GetObject("exelToolStripMenuItem.Image")));
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exelToolStripMenuItem.Text = "Excel";
            this.wordToolStripMenuItem.Image =
                ((System.Drawing.Image) (resources.GetObject("wordToolStripMenuItem.Image")));
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.showDetailedStripButton.Image =
                ((System.Drawing.Image) (resources.GetObject("showDetailedStripButton.Image")));
            this.showDetailedStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showDetailedStripButton.Name = "showDetailedStripButton";
            this.showDetailedStripButton.Size = new System.Drawing.Size(136, 22);
            this.showDetailedStripButton.Text = "Показать пошагово";
            this.showDetailedStripButton.Click += new System.EventHandler(this.ShowDetailedStripButton_Click);
            this.simpleCalcButton.Image = ((System.Drawing.Image) (resources.GetObject("simpleCalcButton.Image")));
            this.simpleCalcButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.simpleCalcButton.Name = "simpleCalcButton";
            this.simpleCalcButton.Size = new System.Drawing.Size(88, 22);
            this.simpleCalcButton.Text = "Вычислить";
            this.simpleCalcButton.Click += new System.EventHandler(this.SimpleCalcButton_Click);
            this.resultSeparator.Name = "resultSeparator";
            this.resultSeparator.Size = new System.Drawing.Size(6, 25);
            this.resultSeparator.Visible = false;
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(22, 22);
            this.ResultLabel.Text = "res";
            this.ResultLabel.Visible = false;
            this.GridLv2.ColumnCount = 2;
            this.GridLv2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43243F));
            this.GridLv2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56757F));
            this.GridLv2.Controls.Add(this.dataBox1, 1, 0);
            this.GridLv2.Controls.Add(this.SettingsGrid, 0, 0);
            this.GridLv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLv2.Location = new System.Drawing.Point(4, 39);
            this.GridLv2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridLv2.Name = "GridLv2";
            this.GridLv2.RowCount = 1;
            this.GridLv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridLv2.Size = new System.Drawing.Size(925, 477);
            this.GridLv2.TabIndex = 4;
            this.dataBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBox1.Location = new System.Drawing.Point(118, 3);
            this.dataBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.Size = new System.Drawing.Size(803, 471);
            this.dataBox1.TabIndex = 3;
            this.SettingsGrid.ColumnCount = 1;
            this.SettingsGrid.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsGrid.Controls.Add(this.animatedCheck, 0, 1);
            this.SettingsGrid.Controls.Add(this.boxForSize, 0, 0);
            this.SettingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsGrid.Location = new System.Drawing.Point(4, 3);
            this.SettingsGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.RowCount = 2;
            this.SettingsGrid.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.SettingsGrid.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SettingsGrid.Size = new System.Drawing.Size(106, 471);
            this.SettingsGrid.TabIndex = 4;
            this.animatedCheck.AutoSize = true;
            this.animatedCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedCheck.Location = new System.Drawing.Point(4, 403);
            this.animatedCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animatedCheck.Name = "animatedCheck";
            this.animatedCheck.Size = new System.Drawing.Size(98, 65);
            this.animatedCheck.TabIndex = 1;
            this.animatedCheck.Text = "Анимация";
            this.animatedCheck.UseVisualStyleBackColor = true;
            this.animatedCheck.CheckedChanged += new System.EventHandler(this.animatedCheck_CheckedChanged);
            this.boxForSize.Controls.Add(this.size);
            this.boxForSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxForSize.Location = new System.Drawing.Point(4, 3);
            this.boxForSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxForSize.Name = "boxForSize";
            this.boxForSize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxForSize.Size = new System.Drawing.Size(98, 394);
            this.boxForSize.TabIndex = 2;
            this.boxForSize.TabStop = false;
            this.boxForSize.Text = "Размер";
            this.size.Dock = System.Windows.Forms.DockStyle.Top;
            this.size.Location = new System.Drawing.Point(4, 19);
            this.size.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(90, 23);
            this.size.TabIndex = 0;
            this.size.Text = "2";
            this.size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Size_KeyDown);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.GridLv1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Вычислитель определителя методом триангуляции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

