using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradeCalc
{
    public partial class Form1 : Form
    {
        public static double grade1;
        public static double grade2;
        public static double grade3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAvg.Text = "Average: ";
            lblLetterGrade.Text = "Letter Grade: ";
            lblStatus.Text = "Status: ";
            bool canCalc = true;
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
                canCalc = false;
            }
            else if (txtGrade1.Text == "" || txtGrade2.Text == "" || txtGrade3.Text == "")
            {
                MessageBox.Show("Please enter all three grades.");
                if (txtGrade1.Text == "")
                {
                    txtGrade1.Focus();
                }
                else if (txtGrade2.Text == "")
                {
                    txtGrade2.Focus();
                }
                else
                {
                    txtGrade3.Focus();
                }
                canCalc = false;
            }
            else if (!double.TryParse(txtGrade1.Text, out grade1) || !double.TryParse(txtGrade2.Text, out grade2) || !double.TryParse(txtGrade3.Text, out grade3))
            {
                MessageBox.Show("Please enter valid numeric grades.");
                canCalc = false;
            }
            else if (grade1 < 0)
            {
                MessageBox.Show("Please enter a valid grade for Grade 1.");
                txtGrade1.Focus();
                canCalc = false;
            }
            else if (grade2 < 0)
            {
                MessageBox.Show("Please enter a valid grade for Grade 2.");
                txtGrade2.Focus();
                canCalc = false;
            }
            else if (grade3 < 0)
            {
                MessageBox.Show("Please enter a valid grade for Grade 3.");
                txtGrade3.Focus();
                canCalc = false;
            }
            if (canCalc)
            {
                double average = (grade1 + grade2 + grade3) / 3;
                lblAvg.Text = "Average: " + average.ToString("F2");
                string letterGrade;
                string status;
                if (average >= 90)
                {
                    letterGrade = "A";
                    status = "Pass";
                }
                else if (average >= 80)
                {
                    letterGrade = "B";
                    status = "Pass";
                }
                else if (average >= 70)
                {
                    letterGrade = "C";
                    status = "Pass";
                }
                else if (average >= 60)
                {
                    letterGrade = "D";
                    status = "Pass";
                }
                else
                {
                    letterGrade = "F";
                    status = "Fail";
                }
                lblLetterGrade.Text = "Letter Grade: " + letterGrade;
                lblStatus.Text = "Status: " + status;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            txtGrade1.Text = "";
            txtGrade2.Text = "";
            txtGrade3.Text = "";
            lblAvg.Text = "Average: ";
            lblLetterGrade.Text = "Letter Grade: ";
            lblStatus.Text = "Status: ";
        }
    }
}
