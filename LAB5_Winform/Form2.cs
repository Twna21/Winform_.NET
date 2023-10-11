using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkBox1.Checked == true)
            {
                str = checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text + "\n";

            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text + "\n";
            }
     
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text;
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào bạn chọn.!!");
            }

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rad_do.Checked == true)
            {
                str = rad_do.Text + "\n";
            }
            if (rad_hong.Checked == true)
            {
                str = str + rad_hong.Text + "\n";

            }
            if (rad_tim.Checked == true)
            {
                str = str + rad_tim.Text + "\n";
            }
            if (rad_trang.Checked == true)
            {
                str = str + rad_trang.Text + "\n";
            }
            if (rad_vang.Checked == true)
            {
                str = str + rad_vang.Text + "\n";
            }
   
            if (str.Length > 0)
            {
                MessageBox.Show("Màu bạn thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có màu nào bạn chọn.!!");
            }
        }
    }
}
