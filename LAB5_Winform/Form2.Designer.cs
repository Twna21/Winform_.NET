namespace LAB5_Winform
{
    partial class Form2
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rad_tim = new RadioButton();
            rad_hong = new RadioButton();
            rad_vang = new RadioButton();
            rad_trang = new RadioButton();
            rad_do = new RadioButton();
            btn_Sothich = new Button();
            btn_color = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 32);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Nghe nhạc";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(120, 32);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Xem phim";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 106);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 32);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Thể thao";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 144);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(133, 32);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "Đi mua sắm";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 178);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(113, 32);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "Di du lịch";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(85, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sở thích của bạn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rad_tim);
            groupBox2.Controls.Add(rad_hong);
            groupBox2.Controls.Add(rad_vang);
            groupBox2.Controls.Add(rad_trang);
            groupBox2.Controls.Add(rad_do);
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(341, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(204, 253);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Màu bạn thích";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rad_tim
            // 
            rad_tim.AutoSize = true;
            rad_tim.Location = new Point(16, 178);
            rad_tim.Name = "rad_tim";
            rad_tim.Size = new Size(62, 32);
            rad_tim.TabIndex = 0;
            rad_tim.TabStop = true;
            rad_tim.Text = "Tím";
            rad_tim.UseVisualStyleBackColor = true;
            // 
            // rad_hong
            // 
            rad_hong.AutoSize = true;
            rad_hong.Location = new Point(16, 142);
            rad_hong.Name = "rad_hong";
            rad_hong.Size = new Size(79, 32);
            rad_hong.TabIndex = 0;
            rad_hong.TabStop = true;
            rad_hong.Text = "Hồng";
            rad_hong.UseVisualStyleBackColor = true;
            // 
            // rad_vang
            // 
            rad_vang.AutoSize = true;
            rad_vang.Location = new Point(16, 106);
            rad_vang.Name = "rad_vang";
            rad_vang.Size = new Size(74, 32);
            rad_vang.TabIndex = 0;
            rad_vang.TabStop = true;
            rad_vang.Text = "Vàng";
            rad_vang.UseVisualStyleBackColor = true;
            // 
            // rad_trang
            // 
            rad_trang.AutoSize = true;
            rad_trang.Location = new Point(16, 70);
            rad_trang.Name = "rad_trang";
            rad_trang.Size = new Size(78, 32);
            rad_trang.TabIndex = 0;
            rad_trang.TabStop = true;
            rad_trang.Text = "Trắng";
            rad_trang.UseVisualStyleBackColor = true;
            // 
            // rad_do
            // 
            rad_do.AutoSize = true;
            rad_do.Location = new Point(16, 34);
            rad_do.Name = "rad_do";
            rad_do.Size = new Size(56, 32);
            rad_do.TabIndex = 0;
            rad_do.TabStop = true;
            rad_do.Text = "Đỏ";
            rad_do.UseVisualStyleBackColor = true;
            // 
            // btn_Sothich
            // 
            btn_Sothich.BackColor = SystemColors.ScrollBar;
            btn_Sothich.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sothich.Location = new Point(95, 332);
            btn_Sothich.Name = "btn_Sothich";
            btn_Sothich.Size = new Size(185, 36);
            btn_Sothich.TabIndex = 3;
            btn_Sothich.Text = "Sở thích của bạn";
            btn_Sothich.UseVisualStyleBackColor = false;
            btn_Sothich.Click += btnSoThich_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = SystemColors.ScrollBar;
            btn_color.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_color.Location = new Point(351, 332);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(185, 36);
            btn_color.TabIndex = 3;
            btn_color.Text = "Màu bạn thích";
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 457);
            Controls.Add(btn_color);
            Controls.Add(btn_Sothich);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Sothich;
        private Button btn_color;
        private RadioButton rad_do;
        private RadioButton rad_tim;
        private RadioButton rad_hong;
        private RadioButton rad_vang;
        private RadioButton rad_trang;
    }
}