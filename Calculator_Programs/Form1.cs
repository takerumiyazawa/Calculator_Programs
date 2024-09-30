using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Programs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Label_overwrite = true;
        private void zero_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = zero.Text;
            }
            else
            {
                Num_Label.Text += zero.Text;
            }
        }
        private void one_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = one.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += one.Text;
            }
        }
        private void two_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = two.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += two.Text;
            }
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = three.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += three.Text;
            }
        }
        private void four_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = four.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += four.Text;
            }
        }
        private void five_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = five.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += five.Text;
            }
        }
        private void six_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = six.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += six.Text;
            }
        }
        private void seven_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = seven.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += seven.Text;
            }
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = eight.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += eight.Text;
            }
        }
        private void nine_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = nine.Text;
                Label_overwrite = false;

            }
            else
            {
                Num_Label.Text += nine.Text;
            }
        }
    }
}
