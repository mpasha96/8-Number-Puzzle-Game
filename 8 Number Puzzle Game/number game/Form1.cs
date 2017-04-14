using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace number_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;

        //up button
        private void button10_Click(object sender, EventArgs e)
        {
            count = 1;

            if (button4.Text == "" && count == 1)
            {
                button4.Text = button1.Text;
                button1.Text = "";
                count = count + 1;


            }
            if (button5.Text == "" && count == 1)
            {
                button5.Text = button2.Text;
                button2.Text = "";
                count = count + 1;
            }
            if (button6.Text == "" && count == 1)
            {
                button6.Text = button3.Text;
                button3.Text = "";
                count = count + 1;
            }
            if (button7.Text == "" && count == 1)
            {
                button7.Text = button4.Text;
                button4.Text = "";
                count = count + 1;
            }
            if (button8.Text == "" && count == 1)
            {
                button8.Text = button5.Text;
                button5.Text = "";
                count = count + 1;
            }
            if (button9.Text == "" && count == 1)
            {
                button9.Text = button6.Text;
                button6.Text = "";
                count = count + 1;
            }
        }

        //down button
        private void button11_Click(object sender, EventArgs e)
        {
            count = 1;
            if (button1.Text == "" && count == 1)
            {
                button1.Text = button4.Text;
                button4.Text = "";
                count = count + 1;
            }
            if (button2.Text == "" && count == 1)
            {
                button2.Text = button5.Text;
                button5.Text = "";
                count = count + 1;
            }
            if (button3.Text == "" && count == 1)
            {
                button3.Text = button6.Text;
                button6.Text = "";
                count = count + 1;
            }
            if (button4.Text == "" && count == 1)
            {
                button4.Text = button7.Text;
                button7.Text = "";
                count = count + 1;
            }
            if (button5.Text == "" && count == 1)
            {
                button5.Text = button8.Text;
                button8.Text = "";
                count = count + 1;
            }
            if (button6.Text == "" && count == 1)
            {
                button6.Text = button9.Text;
                button9.Text = "";
                count = count + 1;
            }
            win();
        }

        //right button
        private void button12_Click(object sender, EventArgs e)
        {
            count = 1;
            if (button1.Text == "" && count == 1)
            {
                button1.Text = button2.Text;
                button2.Text = "";
                count = count + 1;
            }
            if (button2.Text == "" && count == 1)
            {
                button2.Text = button3.Text;
                button3.Text = "";
                count = count + 1;
            }
            if (button4.Text == "" && count == 1)
            {
                button4.Text = button5.Text;
                button5.Text = "";
                count = count + 1;
            }
            if (button5.Text == "" && count == 1)
            {
                button5.Text = button6.Text;
                button6.Text = "";
                count = count + 1;
            }
            if (button7.Text == "" && count == 1)
            {
                button7.Text = button8.Text;
                button8.Text = "";
                count = count + 1;
            }
            if (button8.Text == "" && count == 1)
            {
                button8.Text = button9.Text;
                button9.Text = "";
                count = count + 1;
            }
            win();
        }

        //left button
        private void button13_Click(object sender, EventArgs e)
        {
            count = 1;
            if (button2.Text == "" && count == 1)
            {
                button2.Text = button1.Text;
                button1.Text = "";
                count = count + 1;
            }
            if (button5.Text == "" && count == 1)
            {
                button5.Text = button4.Text;
                button4.Text = "";
                count = count + 1;
            }
            if (button8.Text == "" && count == 1)
            {
                button8.Text = button7.Text;
                button7.Text = "";
                count = count + 1;
            }
            if (button3.Text == "" && count == 1)
            {
                button3.Text = button2.Text;
                button2.Text = "";
                count = count + 1;
            }
            if (button6.Text == "" && count == 1)
            {
                button6.Text = button5.Text;
                button5.Text = "";
                count = count + 1;
            }
            if (button9.Text == "" && count == 1)
            {
                button9.Text = button8.Text;
                button8.Text = "";
                count = count + 1;
            }
            win();
        }

        //conditions for win
        public void win()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "")
            {
                //disabling all buttons after win
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                MessageBox.Show("Congratulations!!! You Won The 8 Number Puzzle");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
