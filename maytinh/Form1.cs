using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinh
{
    public partial class Form1 : Form
    {
        public string result;
        public string currentNum= string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (currentNum == string.Empty)
            {
                result += '0';
                txtResult.Text = result;
                currentNum = "0";
            }
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (currentNum[0] == '0')
            {
                result.Replace("0", "1");
                txtResult.Text = result;
                currentNum = "1";
            }
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '2';
                txtResult.Text = result;
                currentNum = "2";
            }
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (currentNum == ")")
            {
                result.Remove(result.Length - 1);
                result += '3';
                txtResult.Text = result;
                currentNum = "3";
            }
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '4';
                txtResult.Text = result;
                currentNum = "4";
            }
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '5';
                txtResult.Text = result;
                currentNum = "5";
            }
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '6';
                txtResult.Text = result;
                currentNum = "6";
            }
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '7';
                txtResult.Text = result;
                currentNum = "7";
            }
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '8';
                txtResult.Text = result;
                currentNum = "8";
            }
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (currentNum == "0")
            {
                result.Remove(result.Length - 1);
                result += '9';
                txtResult.Text = result;
                currentNum = "9";
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtResult.Text + "\n" + result);
        }
        private void btnTranf_Click(object sender, EventArgs e)
        {
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            result += " + ";
            txtResult.Text += " + ";
            currentNum = "";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            result += " - ";
            txtResult.Text += " - ";
            currentNum = "";
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            result += " * ";
            txtResult.Text += " * ";
            currentNum = "";
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            result += " / ";
            txtResult.Text += " / ";
            currentNum = "";
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
        }
    }
}
