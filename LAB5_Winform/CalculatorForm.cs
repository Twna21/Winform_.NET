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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void txtSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int result = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
                txtKetQua.Text = result.ToString();

            }


        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int result = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
                txtKetQua.Text = result.ToString();
            }
       
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int result = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
                txtKetQua.Text = result.ToString();
            }
            
        }

        private void btnChia_Click(object sender, EventArgs e)
        {

            if (CheckInput() && Convert.ToInt32(txtNum2.Text) != 0)
            {
              
                double result = Convert.ToDouble(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
                txtKetQua.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Division by zero is not allowed.");
            }



        }
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Both fields must be filled.");
                return false;
            }



            return true;
        }
        private void btnDEL_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtKetQua.Clear();
        }
    }
}
