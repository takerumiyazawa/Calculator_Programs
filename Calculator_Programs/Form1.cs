﻿using System;
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
        private double dNum; 
        private double dNum_Pool; 
        private enum MarksType 
        {
            NON,
            PLUS,
            MINUS,
            MULTIPLIED,
            DEVIDED,
            PERCENT
        }
        private MarksType mType = MarksType.NON;

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

        private bool Num_Dot = false; // .ドット の有無判定

private void plus_Click(object sender, EventArgs e)// +ボタン
{
　　Num_Dot = false;
　　Label_overwrite = true;
　　Num_PoolMethod();
　　mType = MarksType.PLUS;
}
private void minus_Click(object sender, EventArgs e)// -ボタン
{
　　Num_Dot = false;
　　Label_overwrite = true;
　　Num_PoolMethod();
　　mType = MarksType.MINUS;
}
private void multiplied_Click(object sender, EventArgs e)// ×ボタン
{
　　Num_Dot = false;
　　Label_overwrite = true;
　　Num_PoolMethod();
　　mType = MarksType.MULTIPLIED;
}
private void divided_Click(object sender, EventArgs e)// ÷ボタン
{
　　Num_Dot = false;
　　Label_overwrite = true;
　　Num_PoolMethod();
　　mType = MarksType.DEVIDED;
}
private void percent_Click(object sender, EventArgs e)// %ボタン
{
　　Num_Dot = false;
　　Label_overwrite = true;
　　mType = MarksType.PERCENT;
　　Num_PoolMethod();
　　mType = MarksType.NON;
}
private void equal_Click(object sender, EventArgs e)// =ボタン
{
　　Num_PoolMethod();
　　mType = MarksType.NON;
　　Num_Dot = false;
　　Label_overwrite = true;
}

private void all_clear_Click(object sender, EventArgs e)//AC(AllClear)ボタン
{
    Num_Label.Text = "0";
    Label_overwrite = true;
    Num_Dot = false;
}

private void dot_Click(object sender, EventArgs e)// .ドットボタン
{
　　if (Num_Dot == false)
　　{
　　　　Num_Label.Text = Num_Label.Text + ".";
　　　　Num_Dot = true;
　　　　Label_overwrite = false;
　　}
}

private void sign_Click(object sender, EventArgs e)// .ドットボタン
{
　　if (Num_Label.Text.Contains("-"))
　　{
　　　　Num_Label.Text = Num_Label.Text.Replace("-", "");
　　}
　　else
　　{
　　　　Num_Label.Text = "-" + Num_Label.Text;
　　}
}

        private void Num_PoolMethod()
        {
            dNum = double.Parse(Num_Label.Text);
            switch (mType)
            {
                case MarksType.NON:
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS:
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DEVIDED:
                    dNum_Pool /= dNum;
                    break;
                case MarksType.PERCENT:
                    dNum_Pool = dNum * 0.01;
                    break;
            }
            Num_Label.Text = dNum_Pool.ToString();
        }

    }
}
