namespace Task6Form
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDownStart = new NumericUpDown();
            numericUpDownEnd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(284, 155);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 0;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 424);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 87);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "end";
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Location = new Point(284, 34);
            numericUpDownStart.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(125, 27);
            numericUpDownStart.TabIndex = 3;
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Location = new Point(284, 110);
            numericUpDownEnd.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(125, 27);
            numericUpDownEnd.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(numericUpDownEnd);
            Controls.Add(numericUpDownStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownStart;
        private NumericUpDown numericUpDownEnd;
    }
}