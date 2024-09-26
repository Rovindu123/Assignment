namespace Assignment.GUIs
{
    partial class CreateBookings
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
            this.createbookingbtn = new System.Windows.Forms.Button();
            this.selectpartlbl = new System.Windows.Forms.Label();
            this.selecteventlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.eventselectbox = new System.Windows.Forms.ComboBox();
            this.partselectbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Bookings";
            // 
            // createbookingbtn
            // 
            this.createbookingbtn.Location = new System.Drawing.Point(253, 334);
            this.createbookingbtn.Name = "createbookingbtn";
            this.createbookingbtn.Size = new System.Drawing.Size(139, 44);
            this.createbookingbtn.TabIndex = 1;
            this.createbookingbtn.Text = "Create Booking";
            this.createbookingbtn.UseVisualStyleBackColor = true;
            this.createbookingbtn.Click += new System.EventHandler(this.createbookingbtn_Click);
            // 
            // selectpartlbl
            // 
            this.selectpartlbl.AutoSize = true;
            this.selectpartlbl.Location = new System.Drawing.Point(250, 242);
            this.selectpartlbl.Name = "selectpartlbl";
            this.selectpartlbl.Size = new System.Drawing.Size(118, 16);
            this.selectpartlbl.TabIndex = 2;
            this.selectpartlbl.Text = "Select Participants";
            this.selectpartlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // selecteventlbl
            // 
            this.selecteventlbl.AutoSize = true;
            this.selecteventlbl.Location = new System.Drawing.Point(250, 192);
            this.selecteventlbl.Name = "selecteventlbl";
            this.selecteventlbl.Size = new System.Drawing.Size(82, 16);
            this.selecteventlbl.TabIndex = 4;
            this.selecteventlbl.Text = "Select Event";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(449, 334);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(139, 44);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // eventselectbox
            // 
            this.eventselectbox.FormattingEnabled = true;
            this.eventselectbox.Location = new System.Drawing.Point(382, 192);
            this.eventselectbox.Name = "eventselectbox";
            this.eventselectbox.Size = new System.Drawing.Size(303, 24);
            this.eventselectbox.TabIndex = 5;
            // 
            // partselectbox
            // 
            this.partselectbox.FormattingEnabled = true;
            this.partselectbox.Location = new System.Drawing.Point(382, 242);
            this.partselectbox.Name = "partselectbox";
            this.partselectbox.Size = new System.Drawing.Size(303, 24);
            this.partselectbox.TabIndex = 6;
            // 
            // CreateBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partselectbox);
            this.Controls.Add(this.eventselectbox);
            this.Controls.Add(this.selecteventlbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.selectpartlbl);
            this.Controls.Add(this.createbookingbtn);
            this.Controls.Add(this.label1);
            this.Name = "CreateBookings";
            this.Text = "CreateBookings";
            this.Load += new System.EventHandler(this.CreateBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createbookingbtn;
        private System.Windows.Forms.Label selectpartlbl;
        private System.Windows.Forms.Label selecteventlbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ComboBox eventselectbox;
        private System.Windows.Forms.ComboBox partselectbox;
    }
}