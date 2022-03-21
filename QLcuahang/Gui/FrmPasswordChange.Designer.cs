
namespace Gui
{
    partial class FrmPasswordChange
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtrepeatPass = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPass.Location = new System.Drawing.Point(39, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(257, 30);
            this.txtPass.TabIndex = 0;
            this.txtPass.Text = "Nhập vào mật khẩu cũ ";
            this.txtPass.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtPass.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtNewPass
            // 
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNewPass.Location = new System.Drawing.Point(39, 112);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(257, 30);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Text = "Nhập mật khẩu mới";
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // txtrepeatPass
            // 
            this.txtrepeatPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtrepeatPass.Location = new System.Drawing.Point(39, 177);
            this.txtrepeatPass.Name = "txtrepeatPass";
            this.txtrepeatPass.Size = new System.Drawing.Size(257, 30);
            this.txtrepeatPass.TabIndex = 2;
            this.txtrepeatPass.Text = "Nhập lại mật khẩu mới";
            this.txtrepeatPass.Enter += new System.EventHandler(this.txtrepeatPass_Enter);
            this.txtrepeatPass.Leave += new System.EventHandler(this.txtrepeatPass_Leave);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(39, 243);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(201, 243);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtrepeatPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPass);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPasswordChange";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmPasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtrepeatPass;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}