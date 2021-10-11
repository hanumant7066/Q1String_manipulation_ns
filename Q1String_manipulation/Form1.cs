using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1String_manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void concatination_button_Click(object sender, EventArgs e)
        {
            string str1 = this.string1_textBox.Text;
            string str2 = this.string2_textBox.Text;

            if (string.IsNullOrWhiteSpace(str1))
            {
                str1 = null;
            }
            if (string.IsNullOrWhiteSpace(str2))
            {
                str2 = null;
            }

            try
            {
                this.result_textBox.Text = str1 + str2;
            }
            catch (Exception ex)
            {

                MessageBox.Show("concatination is not possible" + ex.ToString());
            }
        }

        private bool CheckStringNull(string str1, string str2)
        {
            
            if (string.IsNullOrWhiteSpace(str1))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            return true;
        }
        private void check_equal_button_Click(object sender, EventArgs e)
        {
            string str1 = this.string1_textBox.Text;
            string str2 = this.string2_textBox.Text;

            if (CheckStringNull(str1, str2))
            {
                if (str1.Equals(str2))
                    this.result_textBox.Text = true.ToString();
                else
                    this.result_textBox.Text = false.ToString();
            }
            else
                MessageBox.Show("Please Provide input in TextBoxes");
        }

        private string getRev(string str2)
        {
            string rev = null;
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                rev += str2[i];
            }
            return rev;
        }
        private void check_palindrom_button_Click(object sender, EventArgs e)
        {
            string str1 = this.string1_textBox.Text;
            // string str2 = this.string2_textBox.Text;

            if (!string.IsNullOrWhiteSpace(str1))
            {
                string rev = getRev(str1);
                
                if (str1.Equals(rev))
                    this.result_textBox.Text = true.ToString();
                else
                    this.result_textBox.Text = false.ToString();
            }
            else
                MessageBox.Show("Please Provide input in TextBox");

        }

        private void reverse_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.string1_textBox.Text))
            {
                MessageBox.Show("String 1 is Empty");
                return;
            }
            this.result_textBox.Text = getRev(this.string1_textBox.Text);
        }

        private void reverse_s2_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.string2_textBox.Text))
            {
                MessageBox.Show("String 2 is Empty");
                return;
            }
            this.result_textBox.Text = getRev(this.string2_textBox.Text);


        }
    }
}
