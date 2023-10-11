namespace LAB5_Winform
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_name = new Label();
            lbl_toan = new Label();
            lbl_ly = new Label();
            lbl_hoa = new Label();
            txt_name = new TextBox();
            txt_toan = new TextBox();
            txt_ly = new TextBox();
            txt_hoa = new TextBox();
            btn_then = new Button();
            btn_show = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.Location = new Point(72, 57);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(72, 28);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Họ Tên";
            lbl_name.Click += label1_Click;
            // 
            // lbl_toan
            // 
            lbl_toan.AutoSize = true;
            lbl_toan.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_toan.Location = new Point(72, 119);
            lbl_toan.Name = "lbl_toan";
            lbl_toan.Size = new Size(53, 28);
            lbl_toan.TabIndex = 0;
            lbl_toan.Text = "Toán";
            // 
            // lbl_ly
            // 
            lbl_ly.AutoSize = true;
            lbl_ly.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ly.Location = new Point(77, 177);
            lbl_ly.Name = "lbl_ly";
            lbl_ly.Size = new Size(30, 28);
            lbl_ly.TabIndex = 0;
            lbl_ly.Text = "Lý";
            // 
            // lbl_hoa
            // 
            lbl_hoa.AutoSize = true;
            lbl_hoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hoa.Location = new Point(77, 243);
            lbl_hoa.Name = "lbl_hoa";
            lbl_hoa.Size = new Size(48, 28);
            lbl_hoa.TabIndex = 0;
            lbl_hoa.Text = "Hóa";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(175, 53);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(222, 32);
            txt_name.TabIndex = 1;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_toan
            // 
            txt_toan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_toan.Location = new Point(175, 115);
            txt_toan.Name = "txt_toan";
            txt_toan.Size = new Size(222, 32);
            txt_toan.TabIndex = 1;
            // 
            // txt_ly
            // 
            txt_ly.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ly.Location = new Point(175, 173);
            txt_ly.Name = "txt_ly";
            txt_ly.Size = new Size(222, 32);
            txt_ly.TabIndex = 1;
            // 
            // txt_hoa
            // 
            txt_hoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_hoa.Location = new Point(175, 239);
            txt_hoa.Name = "txt_hoa";
            txt_hoa.Size = new Size(222, 32);
            txt_hoa.TabIndex = 1;
            // 
            // btn_then
            // 
            btn_then.BackColor = SystemColors.ControlLight;
            btn_then.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_then.Location = new Point(74, 301);
            btn_then.Name = "btn_then";
            btn_then.Size = new Size(118, 54);
            btn_then.TabIndex = 2;
            btn_then.Text = "Thêm";
            btn_then.UseVisualStyleBackColor = false;
            btn_then.Click += btn_then_Click;
            // 
            // btn_show
            // 
            btn_show.BackColor = SystemColors.ControlLight;
            btn_show.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show.Location = new Point(279, 301);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(118, 54);
            btn_show.TabIndex = 3;
            btn_show.Text = "Hiển thị";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 459);
            Controls.Add(btn_show);
            Controls.Add(btn_then);
            Controls.Add(txt_hoa);
            Controls.Add(txt_ly);
            Controls.Add(txt_toan);
            Controls.Add(txt_name);
            Controls.Add(lbl_hoa);
            Controls.Add(lbl_ly);
            Controls.Add(lbl_toan);
            Controls.Add(lbl_name);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_toan;
        private Label lbl_ly;
        private Label lbl_hoa;
        private TextBox txt_name;
        private TextBox txt_toan;
        private TextBox txt_ly;
        private TextBox txt_hoa;
        private Button btn_then;
        private Button btn_show;
    }
}