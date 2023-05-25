namespace v0525
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
            MessageBox.Show("Hello");

            MessageBox.Show($"‚±‚ñ‚É‚¿‚Í{textBox1.Text}‚³‚ñ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left++;
        }
    }
}