using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Winform
{
    public partial class Student : Form
    {
        List<HocSinh> list = new List<HocSinh>();
        public Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }


        private void btn_show_Click(object sender, EventArgs e)
        {

            if (list.Count == 0)
            {
                MessageBox.Show("The list is empty.");
                return;
            }


            string msg = "";
            foreach (HocSinh o in list)
            {
                msg = msg + o.ToString() + "\n";
            }

            MessageBox.Show(msg);

        }

        private void btn_then_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                list.Add(new HocSinh(txt_name.Text, Convert.ToDouble(txt_toan.Text), Convert.ToDouble(txt_ly.Text), Convert.ToDouble(txt_hoa.Text)));
                clearText();
                MessageBox.Show("Thêm thành công.");
            }

        }

        private void clearText()
        {
            txt_name.Clear();
            txt_toan.Clear();
            txt_ly.Clear();
            txt_hoa.Clear();
        }
        private bool checkInput()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_ly.Text) || string.IsNullOrWhiteSpace(txt_hoa.Text) || string.IsNullOrWhiteSpace(txt_toan.Text))
            {
                MessageBox.Show("Both fields must be filled.");
                return false;
            }
            if (!double.TryParse(txt_toan.Text, out double toan) || !double.TryParse(txt_ly.Text, out double ly) || !double.TryParse(txt_hoa.Text, out double hoa))
            {
                MessageBox.Show("Invalid input for 'toán,' 'lý,' or 'hóa.' Please enter valid numeric values.");
                return false;
            }
            return true;
        }
        private void txt_name_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
