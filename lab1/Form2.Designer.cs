namespace lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            A = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { A });
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 445);
            dataGridView1.TabIndex = 0;
            // 
            // A
            // 
            A.HeaderText = "A";
            A.MinimumWidth = 6;
            A.Name = "A";
            A.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(652, 19);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 1;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 136);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Результат:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(665, 136);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Закрити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "N = ";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 27);
            textBox1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn A;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox1;
    }
}