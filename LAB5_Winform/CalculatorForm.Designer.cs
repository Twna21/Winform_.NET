namespace LAB5_Winform
{
    partial class CalculatorForm
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
            this.KeyPreview = true;
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            number1 = new Label();
            number2 = new Label();
            btn_cong = new Button();
            lbl_result = new Label();
            txtKetQua = new TextBox();
            label4 = new Label();
            btn_tru = new Button();
            btn_nhan = new Button();
            btn_chia = new Button();
            btn_del = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(174, 75);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(199, 23);
            txtNum1.TabIndex = 0;
            txtNum1.KeyPress += txtSo1_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(174, 113);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(199, 23);
            txtNum2.TabIndex = 0;
            txtNum2.KeyPress += txtSo2_KeyPress;
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            number1.Location = new Point(59, 75);
            number1.Name = "number1";
            number1.Size = new Size(109, 25);
            number1.TabIndex = 1;
            number1.Text = "Số thứ nhất";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            number2.Location = new Point(59, 113);
            number2.Name = "number2";
            number2.Size = new Size(97, 25);
            number2.TabIndex = 1;
            number2.Text = "Số thứ hai";
            // 
            // btn_cong
            // 
            btn_cong.BackColor = SystemColors.ScrollBar;
            btn_cong.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cong.Location = new Point(59, 156);
            btn_cong.Name = "btn_cong";
            btn_cong.Size = new Size(58, 37);
            btn_cong.TabIndex = 2;
            btn_cong.Text = "+";
            btn_cong.UseVisualStyleBackColor = false;
            btn_cong.Click += btnCong_Click;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result.Location = new Point(59, 214);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(79, 25);
            lbl_result.TabIndex = 1;
            lbl_result.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(174, 214);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(199, 23);
            txtKetQua.TabIndex = 0;
            txtKetQua.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 338);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // btn_tru
            // 
            btn_tru.BackColor = SystemColors.ScrollBar;
            btn_tru.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tru.Location = new Point(123, 156);
            btn_tru.Name = "btn_tru";
            btn_tru.Size = new Size(58, 37);
            btn_tru.TabIndex = 2;
            btn_tru.Text = "-";
            btn_tru.UseVisualStyleBackColor = false;
            btn_tru.Click += btnTru_Click;
            // 
            // btn_nhan
            // 
            btn_nhan.BackColor = SystemColors.ScrollBar;
            btn_nhan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nhan.Location = new Point(187, 156);
            btn_nhan.Name = "btn_nhan";
            btn_nhan.Size = new Size(58, 37);
            btn_nhan.TabIndex = 2;
            btn_nhan.Text = "*";
            btn_nhan.UseVisualStyleBackColor = false;
            btn_nhan.Click += btnNhan_Click;
            // 
            // btn_chia
            // 
            btn_chia.BackColor = SystemColors.ScrollBar;
            btn_chia.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chia.Location = new Point(251, 156);
            btn_chia.Name = "btn_chia";
            btn_chia.Size = new Size(58, 37);
            btn_chia.TabIndex = 2;
            btn_chia.Text = "/";
            btn_chia.UseVisualStyleBackColor = false;
            btn_chia.Click += btnChia_Click;
            // 
            // btn_del
            // 
            btn_del.BackColor = SystemColors.ScrollBar;
            btn_del.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.Location = new Point(315, 156);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(58, 37);
            btn_del.TabIndex = 2;
            btn_del.Text = "DEL";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btnDEL_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 397);
            Controls.Add(btn_del);
            Controls.Add(btn_chia);
            Controls.Add(btn_nhan);
            Controls.Add(btn_tru);
            Controls.Add(btn_cong);
            Controls.Add(label4);
            Controls.Add(lbl_result);
            Controls.Add(number2);
            Controls.Add(txtKetQua);
            Controls.Add(number1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label number1;
        private Label number2;
        private Button btn_cong;
        private Label lbl_result;
        private TextBox txtKetQua;
        private Label label4;
        private Button btn_tru;
        private Button btn_nhan;
        private Button btn_chia;
        private Button btn_del;
    }
}