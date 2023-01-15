using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        bool checker = false;
        bool plus = false;
        bool minus = false;
        bool mnog = false;
        bool divide = false;

        string text_one;
        string text_two;
        #endregion

        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        #region TextBox for showing data
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(checker == false)
            {
                text_one = textBox1.Text;
            }else
            {
                text_two = textBox1.Text;
            }

        }
        #endregion

        #region Buttons with Mathematical Operators
        private void button11_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            checker= true;
            divide = true;
            button15.Enabled = true;
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            mnog = true;
            textBox1.Text = "";
            button15.Enabled = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            minus = true;
            textBox1.Text = "";
            button15.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checker = true;
            plus = true;
            textBox1.Text = "";
            button15.Enabled = true;
        }
        

        
        private void button15_Click(object sender, EventArgs e)
        {
            string result = "";

            if (plus == true) result = (Convert.ToInt32(text_one) + Convert.ToInt32(text_two)).ToString();
            else if (minus == true) result = (Convert.ToInt32(text_one) - Convert.ToInt32(text_two)).ToString();
            else if (mnog == true) result = (Convert.ToInt32(text_one) * Convert.ToInt32(text_two)).ToString();
            else if (divide == true) result = (Convert.ToInt32(text_one) / Convert.ToInt32(text_two)).ToString();
            textBox1.Text = result;
            text_one = result;
            plus = false;
            minus = false;
            mnog = false;
            divide = false;

            
            button15.Enabled = false;

        }
        #endregion

        #region Clear Button
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            checker = false;


        }
        #endregion
        
        #region Buttons with Numbers
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }
        #endregion

    }
}
