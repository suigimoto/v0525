namespace v0525
{
    public partial class Form1 : Form
    {
        int vx = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
            MessageBox.Show("Hello");

            MessageBox.Show($"����ɂ���{textBox1.Text}����");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Left += 5;
            //label1.Top += 0;
            button4.Left += vx;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vx = 5;
            MessageBox.Show($"{vx}");
            vx = 10;
            MessageBox.Show($"{vx}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show($"{vx}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = -vx;
          //  MessageBox.Show($"{vx}");

        }
    }
}