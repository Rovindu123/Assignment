namespace Assignment.GUIs
{
    partial class RegisterToEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.eventselectbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register to an event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select an event";
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(347, 285);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(140, 34);
            this.regbtn.TabIndex = 2;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(547, 282);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(140, 37);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // eventselectbox
            // 
            this.eventselectbox.FormattingEnabled = true;
            this.eventselectbox.Location = new System.Drawing.Point(445, 207);
            this.eventselectbox.Name = "eventselectbox";
            this.eventselectbox.Size = new System.Drawing.Size(271, 24);
            this.eventselectbox.TabIndex = 11;
            // 
            // RegisterToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 534);
            this.Controls.Add(this.eventselectbox);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterToEvent";
            this.Text = "RegisterToEvent";
            this.Load += new System.EventHandler(this.RegisterToEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ComboBox eventselectbox;
    }
}