namespace Task7Form
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
            listBox1 = new ListBox();
            labelMax = new Label();
            labelMin = new Label();
            labelAvg = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(106, 424);
            listBox1.TabIndex = 0;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(124, 12);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(40, 20);
            labelMax.TabIndex = 1;
            labelMax.Text = "Max:";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(127, 100);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(37, 20);
            labelMin.TabIndex = 1;
            labelMin.Text = "Min:";
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Location = new Point(127, 182);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(40, 20);
            labelAvg.TabIndex = 1;
            labelAvg.Text = "AVG:";
            // 
            // button1
            // 
            button1.Location = new Point(142, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 450);
            Controls.Add(button1);
            Controls.Add(labelAvg);
            Controls.Add(labelMin);
            Controls.Add(labelMax);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label labelMax;
        private Label labelMin;
        private Label labelAvg;
        private Button button1;
    }
}