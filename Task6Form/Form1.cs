namespace Task6Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Thread thread = new Thread(() =>
            {
                for (int i = (int)numericUpDownStart.Value, n = (int)numericUpDownEnd.Value; i <= n; i++)
                {
                    listBox1.Invoke(new Action(() => { listBox1.Items.Add(i); }));
                }
            });
            thread.Start();
        }
    }
}