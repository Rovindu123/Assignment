namespace Assignment.GUIs
{
    partial class CreateEvents
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
            this.eventnamelbl = new System.Windows.Forms.Label();
            this.venuelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.ticketpricelbl = new System.Windows.Forms.Label();
            this.maxpartlbl = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.eventnametxt = new System.Windows.Forms.TextBox();
            this.venuetxt = new System.Windows.Forms.TextBox();
            this.rslbl = new System.Windows.Forms.Label();
            this.ticketprctxt = new System.Windows.Forms.TextBox();
            this.timegours = new System.Windows.Forms.NumericUpDown();
            this.timemins = new System.Windows.Forms.NumericUpDown();
            this.maxparts = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.timegours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timemins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxparts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an Event";
            // 
            // eventnamelbl
            // 
            this.eventnamelbl.AutoSize = true;
            this.eventnamelbl.Location = new System.Drawing.Point(168, 144);
            this.eventnamelbl.Name = "eventnamelbl";
            this.eventnamelbl.Size = new System.Drawing.Size(78, 16);
            this.eventnamelbl.TabIndex = 1;
            this.eventnamelbl.Text = "Event name";
            // 
            // venuelbl
            // 
            this.venuelbl.AutoSize = true;
            this.venuelbl.Location = new System.Drawing.Point(168, 189);
            this.venuelbl.Name = "venuelbl";
            this.venuelbl.Size = new System.Drawing.Size(46, 16);
            this.venuelbl.TabIndex = 2;
            this.venuelbl.Text = "Venue";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(168, 281);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(38, 16);
            this.timelbl.TabIndex = 3;
            this.timelbl.Text = "Time";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(168, 235);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(36, 16);
            this.datelbl.TabIndex = 4;
            this.datelbl.Text = "Date";
            // 
            // ticketpricelbl
            // 
            this.ticketpricelbl.AutoSize = true;
            this.ticketpricelbl.Location = new System.Drawing.Point(168, 365);
            this.ticketpricelbl.Name = "ticketpricelbl";
            this.ticketpricelbl.Size = new System.Drawing.Size(81, 16);
            this.ticketpricelbl.TabIndex = 5;
            this.ticketpricelbl.Text = "Ticket Price ";
            // 
            // maxpartlbl
            // 
            this.maxpartlbl.AutoSize = true;
            this.maxpartlbl.Location = new System.Drawing.Point(168, 323);
            this.maxpartlbl.Name = "maxpartlbl";
            this.maxpartlbl.Size = new System.Drawing.Size(169, 16);
            this.maxpartlbl.TabIndex = 6;
            this.maxpartlbl.Text = "Max number of participants ";
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(301, 428);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(170, 48);
            this.createbtn.TabIndex = 7;
            this.createbtn.Text = "Create Event";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(506, 428);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(170, 48);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // eventnametxt
            // 
            this.eventnametxt.Location = new System.Drawing.Point(378, 144);
            this.eventnametxt.Name = "eventnametxt";
            this.eventnametxt.Size = new System.Drawing.Size(354, 22);
            this.eventnametxt.TabIndex = 9;
            this.eventnametxt.TextChanged += new System.EventHandler(this.eventnametxt_TextChanged);
            // 
            // venuetxt
            // 
            this.venuetxt.Location = new System.Drawing.Point(378, 183);
            this.venuetxt.Name = "venuetxt";
            this.venuetxt.Size = new System.Drawing.Size(354, 22);
            this.venuetxt.TabIndex = 10;
            // 
            // rslbl
            // 
            this.rslbl.AutoSize = true;
            this.rslbl.Location = new System.Drawing.Point(551, 363);
            this.rslbl.Name = "rslbl";
            this.rslbl.Size = new System.Drawing.Size(27, 16);
            this.rslbl.TabIndex = 13;
            this.rslbl.Text = ".Rs";
            // 
            // ticketprctxt
            // 
            this.ticketprctxt.Location = new System.Drawing.Point(378, 357);
            this.ticketprctxt.Name = "ticketprctxt";
            this.ticketprctxt.Size = new System.Drawing.Size(167, 22);
            this.ticketprctxt.TabIndex = 14;
            // 
            // timegours
            // 
            this.timegours.Location = new System.Drawing.Point(378, 281);
            this.timegours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.timegours.Name = "timegours";
            this.timegours.Size = new System.Drawing.Size(72, 22);
            this.timegours.TabIndex = 16;
            this.timegours.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timemins
            // 
            this.timemins.Location = new System.Drawing.Point(484, 280);
            this.timemins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timemins.Name = "timemins";
            this.timemins.Size = new System.Drawing.Size(72, 22);
            this.timemins.TabIndex = 17;
            this.timemins.ValueChanged += new System.EventHandler(this.timemins_ValueChanged);
            // 
            // maxparts
            // 
            this.maxparts.Location = new System.Drawing.Point(378, 316);
            this.maxparts.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.maxparts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxparts.Name = "maxparts";
            this.maxparts.Size = new System.Drawing.Size(120, 22);
            this.maxparts.TabIndex = 18;
            this.maxparts.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxparts.ValueChanged += new System.EventHandler(this.maxparts_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 235);
            this.dateTimePicker1.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // CreateEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 542);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maxparts);
            this.Controls.Add(this.timemins);
            this.Controls.Add(this.timegours);
            this.Controls.Add(this.ticketprctxt);
            this.Controls.Add(this.rslbl);
            this.Controls.Add(this.venuetxt);
            this.Controls.Add(this.eventnametxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.maxpartlbl);
            this.Controls.Add(this.ticketpricelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.venuelbl);
            this.Controls.Add(this.eventnamelbl);
            this.Controls.Add(this.label1);
            this.Name = "CreateEvents";
            this.Text = "CreateEvents";
            this.Load += new System.EventHandler(this.CreateEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timegours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timemins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxparts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eventnamelbl;
        private System.Windows.Forms.Label venuelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label ticketpricelbl;
        private System.Windows.Forms.Label maxpartlbl;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox eventnametxt;
        private System.Windows.Forms.TextBox venuetxt;
        private System.Windows.Forms.Label rslbl;
        private System.Windows.Forms.TextBox ticketprctxt;
        private System.Windows.Forms.NumericUpDown timegours;
        private System.Windows.Forms.NumericUpDown timemins;
        private System.Windows.Forms.NumericUpDown maxparts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}