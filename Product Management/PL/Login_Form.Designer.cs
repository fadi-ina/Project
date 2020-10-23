namespace Product_Management.PL
{
    partial class Login_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.butcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(127, 167);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // textid
            // 
            this.textid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textid.Location = new System.Drawing.Point(215, 136);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(257, 20);
            this.textid.TabIndex = 2;
            // 
            // textpass
            // 
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpass.Location = new System.Drawing.Point(215, 164);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(257, 20);
            this.textpass.TabIndex = 3;
            // 
            // butlogin
            // 
            this.butlogin.Location = new System.Drawing.Point(243, 227);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(75, 23);
            this.butlogin.TabIndex = 4;
            this.butlogin.Text = "Login";
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(355, 227);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(75, 23);
            this.butcancel.TabIndex = 5;
            this.butcancel.Text = "Cancel";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butcancel;
    }
}