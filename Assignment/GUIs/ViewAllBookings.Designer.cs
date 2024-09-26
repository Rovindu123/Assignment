namespace Assignment.GUIs
{
    partial class ViewAllBookings
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
            this.removepartbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.allbookingsgrid = new System.Windows.Forms.DataGridView();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allbookingsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Bookings";
            // 
            // removepartbtn
            // 
            this.removepartbtn.Location = new System.Drawing.Point(36, 100);
            this.removepartbtn.Name = "removepartbtn";
            this.removepartbtn.Size = new System.Drawing.Size(160, 48);
            this.removepartbtn.TabIndex = 2;
            this.removepartbtn.Text = "Remove Participants from an Event";
            this.removepartbtn.UseVisualStyleBackColor = true;
            this.removepartbtn.Click += new System.EventHandler(this.removepartbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(36, 498);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // allbookingsgrid
            // 
            this.allbookingsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allbookingsgrid.Location = new System.Drawing.Point(236, 100);
            this.allbookingsgrid.Name = "allbookingsgrid";
            this.allbookingsgrid.RowHeadersWidth = 51;
            this.allbookingsgrid.RowTemplate.Height = 24;
            this.allbookingsgrid.Size = new System.Drawing.Size(690, 433);
            this.allbookingsgrid.TabIndex = 15;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(130, 261);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 16;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // ViewAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 545);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.allbookingsgrid);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.removepartbtn);
            this.Controls.Add(this.label1);
            this.Name = "ViewAllBookings";
            this.Text = "ViewAllBookings";
            this.Load += new System.EventHandler(this.ViewAllBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allbookingsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removepartbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView allbookingsgrid;
        private System.Windows.Forms.Button refreshbtn;
    }
}