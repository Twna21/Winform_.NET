namespace LAB5_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_name = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_Name = new TextBox();
            btn_show = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.Location = new Point(34, 61);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(110, 30);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Full Name";
            lbl_name.Click += btnShow_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(180, 59);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(223, 34);
            txt_Name.TabIndex = 2;
            txt_Name.TextChanged += textBox1_TextChanged;
            // 
            // btn_show
            // 
            btn_show.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show.Location = new Point(180, 97);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(75, 34);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btnShow_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.Location = new Point(328, 99);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 34);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btnExit_Click;
            this.KeyPreview = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 298);
            Controls.Add(btn_exit);
            Controls.Add(btn_show);
            Controls.Add(txt_Name);
            Controls.Add(lbl_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
     
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_Name;
        private Button btn_show;
        private Button btn_exit;
    }
}