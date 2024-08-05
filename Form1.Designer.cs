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
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtTienGui
            // 
            txtTienGui.Location = new Point(255, 59);
            txtTienGui.Name = "txtTienGui";
            txtTienGui.Size = new Size(100, 23);
            txtTienGui.TabIndex = 0;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Location = new Point(255, 102);
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.Size = new Size(100, 23);
            txtLaiSuat.TabIndex = 0;
            // 
            // txtSoNam
            // 
            txtSoNam.Location = new Point(255, 154);
            txtSoNam.Name = "txtSoNam";
            txtSoNam.Size = new Size(100, 23);
            txtSoNam.TabIndex = 0;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(70, 221);
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
            lblKQ.Location = new Point(275, 211);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(49, 15);
            lblKQ.TabIndex = 2;
            lblKQ.Text = "Ket Qua";
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
            label4.Location = new Point(70, 157);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "So Nam";
            // 
            // lblTienLai
            // 
            lblTienLai.AutoSize = true;
            lblTienLai.Location = new Point(472, 211);
            lblTienLai.Name = "lblTienLai";
            lblTienLai.Size = new Size(47, 15);
            lblTienLai.TabIndex = 2;
            lblTienLai.Text = "Tien Lai";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(446, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(26, 23);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 486);
            Controls.Add(btnThoat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTienLai);
            Controls.Add(lblKQ);
            Controls.Add(btnTinh);
            Controls.Add(txtSoNam);
            Controls.Add(txtLaiSuat);
            Controls.Add(txtTienGui);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnThoat;
    }
}
