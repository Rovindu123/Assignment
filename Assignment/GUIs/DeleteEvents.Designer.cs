namespace Assignment.GUIs
{
    partial class DeleteEvents
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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteeventbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventselectbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select event";
            // 
            // deleteeventbtn
            // 
            this.deleteeventbtn.Location = new System.Drawing.Point(285, 236);
            this.deleteeventbtn.Name = "deleteeventbtn";
            this.deleteeventbtn.Size = new System.Drawing.Size(126, 48);
            this.deleteeventbtn.TabIndex = 19;
            this.deleteeventbtn.Text = "Delete Event";
            this.deleteeventbtn.UseVisualStyleBackColor = true;
            this.deleteeventbtn.Click += new System.EventHandler(this.deleteeventbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(481, 236);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(126, 48);
            this.cancelbtn.TabIndex = 18;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Delete Event";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventselectbox
            // 
            this.eventselectbox.FormattingEnabled = true;
            this.eventselectbox.Location = new System.Drawing.Point(328, 158);
            this.eventselectbox.Name = "eventselectbox";
            this.eventselectbox.Size = new System.Drawing.Size(279, 24);
            this.eventselectbox.TabIndex = 22;
            this.eventselectbox.SelectedIndexChanged += new System.EventHandler(this.eventselectbox_SelectedIndexChanged);
            // 
            // DeleteEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventselectbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteeventbtn);
            this.Controls.Add(this.cancelbtn);
            this.Name = "DeleteEvents";
            this.Text = "DeleteEvents";
            this.Load += new System.EventHandler(this.DeleteEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteeventbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventselectbox;
    }
}