namespace Assignment.GUIs
{
    partial class DeleteBooking
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
            this.selecteventlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.selectpartlbl = new System.Windows.Forms.Label();
            this.deletebookingbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventselectbox = new System.Windows.Forms.ComboBox();
            this.partselectorbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selecteventlbl
            // 
            this.selecteventlbl.AutoSize = true;
            this.selecteventlbl.Location = new System.Drawing.Point(238, 195);
            this.selecteventlbl.Name = "selecteventlbl";
            this.selecteventlbl.Size = new System.Drawing.Size(82, 16);
            this.selecteventlbl.TabIndex = 9;
            this.selecteventlbl.Text = "Select Event";
            this.selecteventlbl.Click += new System.EventHandler(this.selecteventlbl_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(494, 325);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(139, 44);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // selectpartlbl
            // 
            this.selectpartlbl.AutoSize = true;
            this.selectpartlbl.Location = new System.Drawing.Point(238, 252);
            this.selectpartlbl.Name = "selectpartlbl";
            this.selectpartlbl.Size = new System.Drawing.Size(118, 16);
            this.selectpartlbl.TabIndex = 7;
            this.selectpartlbl.Text = "Select Participants";
            this.selectpartlbl.Click += new System.EventHandler(this.selectpartlbl_Click);
            // 
            // deletebookingbtn
            // 
            this.deletebookingbtn.Location = new System.Drawing.Point(284, 325);
            this.deletebookingbtn.Name = "deletebookingbtn";
            this.deletebookingbtn.Size = new System.Drawing.Size(139, 44);
            this.deletebookingbtn.TabIndex = 6;
            this.deletebookingbtn.Text = "Delete Booking";
            this.deletebookingbtn.UseVisualStyleBackColor = true;
            this.deletebookingbtn.Click += new System.EventHandler(this.createbookingbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delete Bookings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventselectbox
            // 
            this.eventselectbox.FormattingEnabled = true;
            this.eventselectbox.Location = new System.Drawing.Point(415, 195);
            this.eventselectbox.Name = "eventselectbox";
            this.eventselectbox.Size = new System.Drawing.Size(230, 24);
            this.eventselectbox.TabIndex = 10;
            // 
            // partselectorbox
            // 
            this.partselectorbox.FormattingEnabled = true;
            this.partselectorbox.Location = new System.Drawing.Point(415, 244);
            this.partselectorbox.Name = "partselectorbox";
            this.partselectorbox.Size = new System.Drawing.Size(230, 24);
            this.partselectorbox.TabIndex = 11;
            // 
            // DeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partselectorbox);
            this.Controls.Add(this.eventselectbox);
            this.Controls.Add(this.selecteventlbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.selectpartlbl);
            this.Controls.Add(this.deletebookingbtn);
            this.Controls.Add(this.label1);
            this.Name = "DeleteBooking";
            this.Text = "DeleteBooking";
            this.Load += new System.EventHandler(this.DeleteBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selecteventlbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label selectpartlbl;
        private System.Windows.Forms.Button deletebookingbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventselectbox;
        private System.Windows.Forms.ComboBox partselectorbox;
    }
}