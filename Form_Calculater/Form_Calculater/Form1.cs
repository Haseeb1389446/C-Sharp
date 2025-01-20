using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            int rezult = num1 + num2;

            if (txt_num1.Text != "" && txt_num2.Text != "")
            {
                lbl_rezult.Text = "The Rezult Is " + rezult;
            }
            else
            {
                lbl_rezult.Text = "Plzzz Fill Out The Fields Properly...";
            }

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            int rezult = num1 - num2;

            if (txt_num1.Text != "" && txt_num2.Text != "")
            {
                lbl_rezult.Text = "The Rezult Is " + rezult;
            }
            else
            {
                lbl_rezult.Text = "Plzzz Fill Out The Fields Properly...";
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            int rezult = num1 * num2;

            if (txt_num1.Text != "" && txt_num2.Text != "")
            {
                lbl_rezult.Text = "The Rezult Is " + rezult;
            }
            else
            {
                lbl_rezult.Text = "Plzzz Fill Out The Fields Properly...";
            }



        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            int rezult = num1 / num2;

            if (txt_num1.Text != "" && txt_num2.Text != "")
            {
                lbl_rezult.Text = "The Rezult Is " + rezult;
            }
            else
            {
                lbl_rezult.Text = "Plzzz Fill Out The Fields Properly...";
            }
        }
    }
}
