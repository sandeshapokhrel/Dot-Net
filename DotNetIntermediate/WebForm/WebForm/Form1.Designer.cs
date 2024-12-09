namespace WebForm
{
    partial class RollNumber
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
            dataGridView1 = new DataGridView();
            Roll = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Roll, Name });
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(242, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Roll
            // 
            Roll.HeaderText = "Roll";
            Roll.Name = "Roll";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 3;
            label1.Text = "Roll";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // RollNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "RollNumber";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Roll;
        private DataGridViewTextBoxColumn Name;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}
