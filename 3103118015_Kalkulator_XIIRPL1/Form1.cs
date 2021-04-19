using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3103118015_Kalkulator_XIIRPL1
{
    public partial class Form1 : Form
    {
        String function = "";
        Double firstnum, secondnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Angka(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (TbAngka.Text == "0")
                TbAngka.Text = "";

            if (a.Text == ".")
            {
                if (!TbAngka.Text.Contains("."))
                    TbAngka.Text = TbAngka.Text + ",";
            }

            else
            {
                TbAngka.Text = TbAngka.Text + a.Text;
            }
        }

        private void BtC_Click(object sender, EventArgs e)
        {
            TbAngka.Text = "0";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (TbAngka.Text.Length > 0)
            {
                TbAngka.Text = TbAngka.Text.Remove(TbAngka.Text.Length - 1, 1);
            }

            if (TbAngka.Text == "")
            {
                TbAngka.Text = "0";
            }
        }

        private void BtnHasil_Click(object sender, EventArgs e)
        {
            lbl.Text = " ";
            secondnum = double.Parse(TbAngka.Text);
            switch (function)
            {
                case "+":
                    TbAngka.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    TbAngka.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "x":
                    TbAngka.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    TbAngka.Text = Convert.ToString(firstnum / secondnum);
                    break;
                default:
                    break;
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void PlusMin_Click(object sender, EventArgs e)
        {
            if (TbAngka.Text.Contains("-"))
            {
                TbAngka.Text = TbAngka.Text.Remove(0, 1);
            }
            else
            {
                TbAngka.Text = "-" + TbAngka.Text;
            }
        }

        private void Function(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            firstnum = Double.Parse(TbAngka.Text);
            function = a.Text;
            TbAngka.Text = "";
            lbl.Text = firstnum + " " + function;
        }
    }
}
