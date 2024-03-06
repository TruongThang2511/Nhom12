namespace baitap
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
            label1 = new Label();
            txtusername = new TextBox();
            txtmatkhau = new TextBox();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 49);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(211, 47);
            txtusername.Margin = new Padding(3, 2, 3, 2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(110, 23);
            txtusername.TabIndex = 1;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(211, 93);
            txtmatkhau.Margin = new Padding(3, 2, 3, 2);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(110, 23);
            txtmatkhau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Mat khau";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(246, 140);
            btnlogin.Margin = new Padding(3, 2, 3, 2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(82, 22);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Dang Nhap";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnlogin);
            Controls.Add(txtmatkhau);
            Controls.Add(label2);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusername;
        private TextBox txtmatkhau;
        private Label label2;
        private Button btnlogin;
    }
}