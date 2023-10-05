using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA
{
    public partial class Form2 : Form
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int n3 { get; set; }
        public int n4 { get; set; }
        public int n5 { get; set; }
        public int n6 { get; set; }
        public int n7 { get; set; }
        public int n8 { get; set; }
        public int n9 { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            double cr1 = 3, cr2 = 2, cr3 = 3, cr4 = 3, cr5 = 1.5, cr6 = 3, cr7 = 1.5, cr8 = 1.5, cr9 = 1.5;
            double totalcr = 20;



            double gPt1 = gradCalc(n1).gp;
            double gPt2 = gradCalc(n2).gp;
            double gPt3 = gradCalc(n3).gp;
            double gPt4 = gradCalc(n4).gp;
            double gPt5 = gradCalc(n5).gp;
            double gPt6 = gradCalc(n6).gp;
            double gPt7 = gradCalc(n7).gp;
            double gPt8 = gradCalc(n8).gp;
            double gPt9 = gradCalc(n9).gp;


            double totalCGrade = (cr1 * gPt1) + (cr2 * gPt2) + (cr3 * gPt3) + (cr4 * gPt4) + (cr5 * gPt5) + (cr6 * gPt6) + (cr7 * gPt7) + (cr8 * gPt8) + (cr9 * gPt9);
            double cg = totalCGrade / totalcr;

            gpa.Text = cg.ToString("F2");

            g1.Text = gPt1.ToString();
            g2.Text = gPt2.ToString();
            g3.Text = gPt3.ToString();
            g4.Text = gPt4.ToString();
            g5.Text = gPt5.ToString();
            g6.Text = gPt6.ToString();
            g7.Text = gPt7.ToString();
            g8.Text = gPt8.ToString();
            g9.Text = gPt9.ToString();


            l1.Text = gradCalc(n1).lg;
            l2.Text = gradCalc(n2).lg;
            l3.Text = gradCalc(n3).lg;
            l4.Text = gradCalc(n4).lg;
            l5.Text = gradCalc(n5).lg;
            l6.Text = gradCalc(n6).lg;
            l7.Text = gradCalc(n7).lg;
            l8.Text = gradCalc(n8).lg;
            l9.Text = gradCalc(n9).lg;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        public (string lg, double gp) gradCalc(int mark)
        {
            if (mark >= 80)
            {
                return ("A+", 4.0);

            }
            else if (mark >= 75)
            {
                return ("A", 3.75);
            }
            else if (mark >= 70)
            {
                return ("A-", 3.50);
            }
            else if (mark >= 65)
            {
                return ("B+", 3.25);
            }
            else if (mark >= 60)
            {
                return ("B", 3.0);
            }
            else if (mark >= 55)
            {
                return ("B-", 2.75);
            }
            else if (mark >= 50)
            {
                return ("C+", 2.5);
            }
            else if (mark >= 45)
            {
                return ("C", 2.25);
            }
            else if (mark >= 40)
            {
                return ("D", 2.0);
            }
            else
            {
                return ("F", 0.0);
            }

        }
    }
}
