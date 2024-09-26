namespace Assignment.GUIs
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.pwlbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.pwtxt = new System.Windows.Forms.TextBox();
            this.showpw = new System.Windows.Forms.CheckBox();
            this.noacclbl = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 327);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(577, 299);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(99, 38);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Login ";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(751, 299);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(99, 38);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(484, 138);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(70, 16);
            this.usernamelbl.TabIndex = 5;
            this.usernamelbl.Text = "Username";
            // 
            // pwlbl
            // 
            this.pwlbl.AutoSize = true;
            this.pwlbl.Location = new System.Drawing.Point(484, 188);
            this.pwlbl.Name = "pwlbl";
            this.pwlbl.Size = new System.Drawing.Size(67, 16);
            this.pwlbl.TabIndex = 6;
            this.pwlbl.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(605, 138);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(257, 22);
            this.usernametxt.TabIndex = 7;
            // 
            // pwtxt
            // 
            this.pwtxt.Location = new System.Drawing.Point(605, 182);
            this.pwtxt.Name = "pwtxt";
            this.pwtxt.PasswordChar = '*';
            this.pwtxt.Size = new System.Drawing.Size(257, 22);
            this.pwtxt.TabIndex = 8;
            // 
            // showpw
            // 
            this.showpw.AutoSize = true;
            this.showpw.Location = new System.Drawing.Point(650, 239);
            this.showpw.Name = "showpw";
            this.showpw.Size = new System.Drawing.Size(125, 20);
            this.showpw.TabIndex = 9;
            this.showpw.Text = "Show Password";
            this.showpw.UseVisualStyleBackColor = true;
            this.showpw.CheckedChanged += new System.EventHandler(this.showpw_CheckedChanged);
            // 
            // noacclbl
            // 
            this.noacclbl.AutoSize = true;
            this.noacclbl.Location = new System.Drawing.Point(605, 425);
            this.noacclbl.Name = "noacclbl";
            this.noacclbl.Size = new System.Drawing.Size(170, 16);
            this.noacclbl.TabIndex = 10;
            this.noacclbl.Text = "Don\'t have an account yet ?";
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(650, 465);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(96, 43);
            this.signupbtn.TabIndex = 11;
            this.signupbtn.Text = "Register ";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 579);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.noacclbl);
            this.Controls.Add(this.showpw);
            this.Controls.Add(this.pwtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.pwlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label pwlbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox pwtxt;
        private System.Windows.Forms.CheckBox showpw;
        private System.Windows.Forms.Label noacclbl;
        private System.Windows.Forms.Button signupbtn;
    }
}