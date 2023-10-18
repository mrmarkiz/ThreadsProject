namespace Task7Form
{
    public partial class Form1 : Form
    {
        private int[] arr = new int[10000];
        public Form1()
        {
            Random rnd = new Random();
            InitializeComponent();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000000);
                listBox1.Items.Add(arr[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadMax = new Thread(() =>
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                }
                labelMax.Invoke(() => { labelMax.Text = $"Max: {max}"; });
            });
            threadMax.Start();

            Thread threadMin = new Thread(() =>
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                }
                labelMin.Invoke(() => { labelMin.Text = $"Min: {min}"; });
            });
            threadMin.Start();

            Thread threadAvg = new Thread(() =>
            {
                int sum = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                labelAvg.Invoke(() => { labelAvg.Text = $"AVG: {(sum) / arr.Length}"; });
            });
            threadAvg.Start();
        }
    }
}