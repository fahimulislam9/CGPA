namespace CGPA
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Stat_Click(object sender, EventArgs e)
        {

        }

        private void toc_Click(object sender, EventArgs e)
        {

        }

        private void adbmslab_Click(object sender, EventArgs e)
        {

        }

        private void dt_Click(object sender, EventArgs e)
        {

        }

        private void oslab_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            try
            {
                // int n1, n2, n3, n4, n5, n6, n7, n8, n9;


                f2.n1 = int.Parse(m1.Text);
                f2.n2 = int.Parse(m2.Text);
                f2.n3 = int.Parse(m3.Text);
                f2.n4 = int.Parse(m4.Text);
                f2.n5 = int.Parse(m5.Text);
                f2.n6 = int.Parse(m6.Text);
                f2.n7 = int.Parse(m7.Text);
                f2.n8 = int.Parse(m8.Text);
                f2.n9 = int.Parse(m9.Text);

                if (f2.n1 < 0 || f2.n1 > 100 || f2.n2 < 0 || f2.n2 > 100 || f2.n3 < 0 || f2.n3 > 100 || f2.n4 < 0 || f2.n4 > 100 || f2.n5 < 0 || f2.n5 > 100 || f2.n6 < 0 || f2.n6 > 100 || f2.n7 < 0 || f2.n7 > 100 || f2.n8 < 0 || f2.n8 > 100 || f2.n9 < 0 || f2.n9 > 100)
                {
                    MessageBox.Show("Input should be between 0 and 100.");
                    return;
                }


                f2.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Every box must be filled");
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            m1.Clear();
            m2.Clear();
            m3.Clear();
            m4.Clear();
            m5.Clear();
            m6.Clear();
            m7.Clear();
            m8.Clear();
            m9.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}