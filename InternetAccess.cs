using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetAcces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string questionOne = "Do you want internet access?";
                string caption = "Internet Access";
                string unLimited = "Do you want unlimited access for $19.95 per month?";
                string choiceTwo = "Limited access";
                double priceTwo = 10.95;
                double priceThree = 9.00;
                if (MessageBox.Show(questionOne, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    choiceTwo = "No internet access";
                    priceTwo -= priceTwo;
                }
                else
                    if (MessageBox.Show(questionOne, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (MessageBox.Show(unLimited, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        choiceTwo = "Unlimited access";
                        priceTwo += priceThree;
                    }
                MessageBox.Show(choiceTwo + " total is: " + priceTwo.ToString("C2") + " per month", caption);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string question = "Do you want internet access?";
                string caption = "Internet Access";
                string unLimited = "Do you want unlimited access for $19.95 per month?";
                string OptionTwo = "Limited access";
                double priceTwo = 10.95;
                double priceThree = 9.00;
                if (MessageBox.Show(question, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    OptionTwo = "No internet access";
                    priceTwo -= priceTwo;
                }
                else
                    if (MessageBox.Show(question, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (MessageBox.Show(unLimited, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OptionTwo = "Unlimited access";
                        priceTwo += priceThree;
                    }
                MessageBox.Show(OptionTwo + " total is: " + priceTwo.ToString("C2") + " per month", caption);
            }
        }
    }
}
