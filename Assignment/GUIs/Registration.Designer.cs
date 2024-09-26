namespace Assignment.GUIs
{
    partial class Registration
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
            this.namelbl = new System.Windows.Forms.Label();
            this.cnumberlbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.cnumbertxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.pwlbl = new System.Windows.Forms.Label();
            this.confpwlbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.pwtxt = new System.Windows.Forms.TextBox();
            this.confpwtxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(233, 129);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(47, 16);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name ";
            // 
            // cnumberlbl
            // 
            this.cnumberlbl.AutoSize = true;
            this.cnumberlbl.Location = new System.Drawing.Point(233, 190);
            this.cnumberlbl.Name = "cnumberlbl";
            this.cnumberlbl.Size = new System.Drawing.Size(103, 16);
            this.cnumberlbl.TabIndex = 2;
            this.cnumberlbl.Text = "Contact Number";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(450, 123);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(358, 22);
            this.nametxt.TabIndex = 3;
            // 
            // cnumbertxt
            // 
            this.cnumbertxt.Location = new System.Drawing.Point(450, 184);
            this.cnumbertxt.Name = "cnumbertxt";
            this.cnumbertxt.Size = new System.Drawing.Size(358, 22);
            this.cnumbertxt.TabIndex = 4;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(233, 249);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(41, 16);
            this.emaillbl.TabIndex = 7;
            this.emaillbl.Text = "Email";
            // 
            // pwlbl
            // 
            this.pwlbl.AutoSize = true;
            this.pwlbl.Location = new System.Drawing.Point(233, 301);
            this.pwlbl.Name = "pwlbl";
            this.pwlbl.Size = new System.Drawing.Size(67, 16);
            this.pwlbl.TabIndex = 8;
            this.pwlbl.Text = "Password";
            // 
            // confpwlbl
            // 
            this.confpwlbl.AutoSize = true;
            this.confpwlbl.Location = new System.Drawing.Point(233, 353);
            this.confpwlbl.Name = "confpwlbl";
            this.confpwlbl.Size = new System.Drawing.Size(115, 16);
            this.confpwlbl.TabIndex = 9;
            this.confpwlbl.Text = "Confirm Password";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(450, 243);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(358, 22);
            this.emailtxt.TabIndex = 10;
            // 
            // pwtxt
            // 
            this.pwtxt.Location = new System.Drawing.Point(450, 295);
            this.pwtxt.Name = "pwtxt";
            this.pwtxt.Size = new System.Drawing.Size(358, 22);
            this.pwtxt.TabIndex = 11;
            // 
            // confpwtxt
            // 
            this.confpwtxt.Location = new System.Drawing.Point(450, 347);
            this.confpwtxt.Name = "confpwtxt";
            this.confpwtxt.Size = new System.Drawing.Size(358, 22);
            this.confpwtxt.TabIndex = 12;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(26, 530);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 13;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(391, 437);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(185, 32);
            this.registerbtn.TabIndex = 14;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 583);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.confpwtxt);
            this.Controls.Add(this.pwtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.confpwlbl);
            this.Controls.Add(this.pwlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.cnumbertxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.cnumberlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label cnumberlbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox cnumbertxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label pwlbl;
        private System.Windows.Forms.Label confpwlbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox pwtxt;
        private System.Windows.Forms.TextBox confpwtxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button registerbtn;
    }
}