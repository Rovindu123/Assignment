namespace Assignment.GUIs
{
    partial class AddAdmin
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
            this.adminrole = new System.Windows.Forms.RadioButton();
            this.organizerrole = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectuserbox = new System.Windows.Forms.ComboBox();
            this.savechangesbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminrole
            // 
            this.adminrole.AutoSize = true;
            this.adminrole.Location = new System.Drawing.Point(287, 200);
            this.adminrole.Name = "adminrole";
            this.adminrole.Size = new System.Drawing.Size(66, 20);
            this.adminrole.TabIndex = 0;
            this.adminrole.TabStop = true;
            this.adminrole.Text = "Admin";
            this.adminrole.UseVisualStyleBackColor = true;
            // 
            // organizerrole
            // 
            this.organizerrole.AutoSize = true;
            this.organizerrole.Location = new System.Drawing.Point(395, 201);
            this.organizerrole.Name = "organizerrole";
            this.organizerrole.Size = new System.Drawing.Size(86, 20);
            this.organizerrole.TabIndex = 1;
            this.organizerrole.TabStop = true;
            this.organizerrole.Text = "Organizer";
            this.organizerrole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select User";
            // 
            // selectuserbox
            // 
            this.selectuserbox.FormattingEnabled = true;
            this.selectuserbox.Location = new System.Drawing.Point(287, 144);
            this.selectuserbox.Name = "selectuserbox";
            this.selectuserbox.Size = new System.Drawing.Size(234, 24);
            this.selectuserbox.TabIndex = 5;
            // 
            // savechangesbtn
            // 
            this.savechangesbtn.Location = new System.Drawing.Point(221, 290);
            this.savechangesbtn.Name = "savechangesbtn";
            this.savechangesbtn.Size = new System.Drawing.Size(123, 41);
            this.savechangesbtn.TabIndex = 6;
            this.savechangesbtn.Text = "Save Changes";
            this.savechangesbtn.UseVisualStyleBackColor = true;
            this.savechangesbtn.Click += new System.EventHandler(this.savechangesbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.savechangesbtn);
            this.Controls.Add(this.selectuserbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.organizerrole);
            this.Controls.Add(this.adminrole);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton adminrole;
        private System.Windows.Forms.RadioButton organizerrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectuserbox;
        private System.Windows.Forms.Button savechangesbtn;
        private System.Windows.Forms.Button button2;
    }
}