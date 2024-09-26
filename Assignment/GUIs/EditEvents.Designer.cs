namespace Assignment.GUIs
{
    partial class EditEvents
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savechangesbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectevent = new System.Windows.Forms.Label();
            this.eventnamelbl = new System.Windows.Forms.Label();
            this.venuelbl = new System.Windows.Forms.Label();
            this.ticketpricelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selecteventbox = new System.Windows.Forms.ComboBox();
            this.eventnametxt = new System.Windows.Forms.TextBox();
            this.eventvenuetxt = new System.Windows.Forms.TextBox();
            this.ticketpricetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // savechangesbtn
            // 
            this.savechangesbtn.Location = new System.Drawing.Point(295, 402);
            this.savechangesbtn.Name = "savechangesbtn";
            this.savechangesbtn.Size = new System.Drawing.Size(110, 36);
            this.savechangesbtn.TabIndex = 1;
            this.savechangesbtn.Text = "Save Changes";
            this.savechangesbtn.UseVisualStyleBackColor = true;
            this.savechangesbtn.Click += new System.EventHandler(this.savechangesbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(499, 402);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(110, 36);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Events";
            // 
            // selectevent
            // 
            this.selectevent.AutoSize = true;
            this.selectevent.Location = new System.Drawing.Point(243, 63);
            this.selectevent.Name = "selectevent";
            this.selectevent.Size = new System.Drawing.Size(82, 16);
            this.selectevent.TabIndex = 4;
            this.selectevent.Text = "Select Event";
            // 
            // eventnamelbl
            // 
            this.eventnamelbl.AutoSize = true;
            this.eventnamelbl.Location = new System.Drawing.Point(201, 131);
            this.eventnamelbl.Name = "eventnamelbl";
            this.eventnamelbl.Size = new System.Drawing.Size(44, 16);
            this.eventnamelbl.TabIndex = 5;
            this.eventnamelbl.Text = "Name";
            // 
            // venuelbl
            // 
            this.venuelbl.AutoSize = true;
            this.venuelbl.Location = new System.Drawing.Point(201, 172);
            this.venuelbl.Name = "venuelbl";
            this.venuelbl.Size = new System.Drawing.Size(46, 16);
            this.venuelbl.TabIndex = 6;
            this.venuelbl.Text = "Venue";
            // 
            // ticketpricelbl
            // 
            this.ticketpricelbl.AutoSize = true;
            this.ticketpricelbl.Location = new System.Drawing.Point(201, 359);
            this.ticketpricelbl.Name = "ticketpricelbl";
            this.ticketpricelbl.Size = new System.Drawing.Size(78, 16);
            this.ticketpricelbl.TabIndex = 13;
            this.ticketpricelbl.Text = "Ticket Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximum Number Of Participants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date";
            // 
            // selecteventbox
            // 
            this.selecteventbox.FormattingEnabled = true;
            this.selecteventbox.Location = new System.Drawing.Point(372, 55);
            this.selecteventbox.Name = "selecteventbox";
            this.selecteventbox.Size = new System.Drawing.Size(257, 24);
            this.selecteventbox.TabIndex = 14;
            // 
            // eventnametxt
            // 
            this.eventnametxt.Location = new System.Drawing.Point(448, 125);
            this.eventnametxt.Name = "eventnametxt";
            this.eventnametxt.Size = new System.Drawing.Size(290, 22);
            this.eventnametxt.TabIndex = 15;
            // 
            // eventvenuetxt
            // 
            this.eventvenuetxt.Location = new System.Drawing.Point(448, 166);
            this.eventvenuetxt.Name = "eventvenuetxt";
            this.eventvenuetxt.Size = new System.Drawing.Size(290, 22);
            this.eventvenuetxt.TabIndex = 16;
            // 
            // ticketpricetxt
            // 
            this.ticketpricetxt.Location = new System.Drawing.Point(448, 353);
            this.ticketpricetxt.Name = "ticketpricetxt";
            this.ticketpricetxt.Size = new System.Drawing.Size(224, 22);
            this.ticketpricetxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = ".Rs";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(573, 260);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(448, 260);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown2.TabIndex = 21;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(448, 309);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown3.TabIndex = 22;
            // 
            // EditEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketpricetxt);
            this.Controls.Add(this.eventvenuetxt);
            this.Controls.Add(this.eventnametxt);
            this.Controls.Add(this.selecteventbox);
            this.Controls.Add(this.ticketpricelbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.venuelbl);
            this.Controls.Add(this.eventnamelbl);
            this.Controls.Add(this.selectevent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savechangesbtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EditEvents";
            this.Text = "EditEvents";
            this.Load += new System.EventHandler(this.EditEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button savechangesbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectevent;
        private System.Windows.Forms.Label eventnamelbl;
        private System.Windows.Forms.Label venuelbl;
        private System.Windows.Forms.Label ticketpricelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selecteventbox;
        private System.Windows.Forms.TextBox eventnametxt;
        private System.Windows.Forms.TextBox eventvenuetxt;
        private System.Windows.Forms.TextBox ticketpricetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}