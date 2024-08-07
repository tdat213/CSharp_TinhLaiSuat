namespace CSharp_TinhLaiSuat
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
            txtTienGui = new TextBox();
            txtLaiSuat = new TextBox();
            txtSoNam = new TextBox();
            btnTinh = new Button();
            lblKQ = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTienLai = new Label();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTienGui
            // 
            txtTienGui.Location = new Point(172, 54);
            txtTienGui.Name = "txtTienGui";
            txtTienGui.Size = new Size(185, 23);
            txtTienGui.TabIndex = 0;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Location = new Point(172, 97);
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.Size = new Size(185, 23);
            txtLaiSuat.TabIndex = 0;
            // 
            // txtSoNam
            // 
            txtSoNam.Location = new Point(172, 143);
            txtSoNam.Name = "txtSoNam";
            txtSoNam.Size = new Size(185, 23);
            txtSoNam.TabIndex = 0;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(70, 229);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 1;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(272, 229);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 15);
            lblKQ.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "So Tien Gui";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 102);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "Lai Suat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 151);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "So Nam";
            // 
            // lblTienLai
            // 
            lblTienLai.AutoSize = true;
            lblTienLai.Location = new Point(261, 283);
            lblTienLai.Name = "lblTienLai";
            lblTienLai.Size = new Size(0, 15);
            lblTienLai.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 229);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Ket Qua :";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 283);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Tien Lai :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 486);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTienLai);
            Controls.Add(lblKQ);
            Controls.Add(btnTinh);
            Controls.Add(txtSoNam);
            Controls.Add(txtLaiSuat);
            Controls.Add(txtTienGui);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTienGui;
        private TextBox txtLaiSuat;
        private TextBox txtSoNam;
        private Button btnTinh;
        private Label lblKQ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTienLai;
        private Label label1;
        private Label label5;
    }
}
