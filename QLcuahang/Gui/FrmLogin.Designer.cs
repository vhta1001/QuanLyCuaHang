
namespace Gui
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconuser = new System.Windows.Forms.Label();
            this.iconPass = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.CheckHienMK = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.iconlogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.iconuser, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.iconPass, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDN, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPass, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.CheckHienMK, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.iconlogin, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 460);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // iconuser
            // 
            this.iconuser.Image = ((System.Drawing.Image)(resources.GetObject("iconuser.Image")));
            this.iconuser.Location = new System.Drawing.Point(23, 220);
            this.iconuser.Name = "iconuser";
            this.iconuser.Size = new System.Drawing.Size(34, 39);
            this.iconuser.TabIndex = 1;
            // 
            // iconPass
            // 
            this.iconPass.Image = ((System.Drawing.Image)(resources.GetObject("iconPass.Image")));
            this.iconPass.Location = new System.Drawing.Point(23, 275);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(34, 39);
            this.iconPass.TabIndex = 2;
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.txtTenDN, 2);
            this.txtTenDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(70)))));
            this.txtTenDN.Location = new System.Drawing.Point(84, 224);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(292, 27);
            this.txtTenDN.TabIndex = 3;
            this.txtTenDN.Text = "Username";
            this.txtTenDN.Enter += new System.EventHandler(this.txtTenDN_Enter);
            this.txtTenDN.Leave += new System.EventHandler(this.txtTenDN_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPass, 2);
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(70)))));
            this.txtPass.Location = new System.Drawing.Point(84, 279);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(292, 27);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // CheckHienMK
            // 
            this.CheckHienMK.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.CheckHienMK, 2);
            this.CheckHienMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckHienMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(70)))));
            this.CheckHienMK.Location = new System.Drawing.Point(83, 333);
            this.CheckHienMK.Name = "CheckHienMK";
            this.CheckHienMK.Size = new System.Drawing.Size(148, 24);
            this.CheckHienMK.TabIndex = 5;
            this.CheckHienMK.Text = "Hiện mật khẩu";
            this.CheckHienMK.UseVisualStyleBackColor = true;
            this.CheckHienMK.CheckedChanged += new System.EventHandler(this.CheckHienMK_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel2.SetColumnSpan(this.btnLogin, 2);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(70)))));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(24, 389);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 47);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(70)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(204, 389);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconlogin
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.iconlogin, 3);
            this.iconlogin.Image = ((System.Drawing.Image)(resources.GetObject("iconlogin.Image")));
            this.iconlogin.Location = new System.Drawing.Point(23, 20);
            this.iconlogin.Name = "iconlogin";
            this.iconlogin.Size = new System.Drawing.Size(347, 200);
            this.iconlogin.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(400, 460);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLogin_Paint_1);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label iconlogin;
        private System.Windows.Forms.Label iconuser;
        private System.Windows.Forms.Label iconPass;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox CheckHienMK;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}