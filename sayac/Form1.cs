namespace sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                sayi += 1;
                label1.Text = sayi.ToString();
            }
            else
            {
                sayi += int.Parse(textBox1.Text);
                label1.Text = sayi.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = 0;
            label1.Text = sayi.ToString();
        }
    }
}