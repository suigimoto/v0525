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
            MessageBox.Show("Hello");
            label1.Text = "Hello";
            textBox1.Text = "こんちは杉本さん";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}