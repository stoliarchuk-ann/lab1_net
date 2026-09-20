namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saveFileDialog1 = new SaveFileDialog();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            label2 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox2 = new PictureBox();
            menuStrip2 = new MenuStrip();
            масивиToolStripMenuItem = new ToolStripMenuItem();
            одновимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            двовимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(90, 27);
            textBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 41);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 7;
            label1.Text = "xn";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 40);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 9;
            label3.Text = "xk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 41);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 10;
            label4.Text = "h";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 41);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 11;
            label5.Text = "a";
            // 
            // button1
            // 
            button1.Location = new Point(490, 61);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 12;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 328);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.Width = 125;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 87);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 14;
            label2.Text = "Результати";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(318, 110);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(470, 328);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(609, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { масивиToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 19;
            menuStrip2.Text = "menuStrip2";
            // 
            // масивиToolStripMenuItem
            // 
            масивиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одновимірніМасивиToolStripMenuItem, двовимірніМасивиToolStripMenuItem });
            масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            масивиToolStripMenuItem.Size = new Size(77, 24);
            масивиToolStripMenuItem.Text = "Масиви";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            одновимірніМасивиToolStripMenuItem.Size = new Size(239, 26);
            одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            одновимірніМасивиToolStripMenuItem.Click += одновимірніМасивиToolStripMenuItem_Click;
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            двовимірніМасивиToolStripMenuItem.Size = new Size(239, 26);
            двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            двовимірніМасивиToolStripMenuItem.Click += двовимірніМасивиToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(chart1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem масивиToolStripMenuItem;
        private ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
    }
}
