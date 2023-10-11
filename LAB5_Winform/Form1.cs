namespace LAB5_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this program?", "Ask the user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Dispose();
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name: " + txt_Name.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers==Keys.Alt && e.KeyCode == Keys.H)
            {
                txt_Name.Text = "Hello FPT UNIVERSITY";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("You just click right button Mouse.");
            }
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("You just click left button Mouse.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this program?", "Ask the user",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

   
    }
}