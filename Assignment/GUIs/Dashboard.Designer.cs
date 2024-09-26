namespace Assignment.GUIs
{
    partial class Dashboard
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
            this.unamelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.dashboardgrid = new System.Windows.Forms.DataGridView();
            this.createeventbtn = new System.Windows.Forms.Button();
            this.editeventbtn = new System.Windows.Forms.Button();
            this.deleteeventbtn = new System.Windows.Forms.Button();
            this.addparttoeventbtn = new System.Windows.Forms.Button();
            this.viewallbookingsbtn = new System.Windows.Forms.Button();
            this.removepartbtn = new System.Windows.Forms.Button();
            this.addadminbtn = new System.Windows.Forms.Button();
            this.registertoeventbtn = new System.Windows.Forms.Button();
            this.viewalleventsbtn = new System.Windows.Forms.Button();
            this.unregfromeventbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // unamelbl
            // 
            this.unamelbl.AutoSize = true;
            this.unamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelbl.Location = new System.Drawing.Point(776, 39);
            this.unamelbl.Name = "unamelbl";
            this.unamelbl.Size = new System.Drawing.Size(94, 20);
            this.unamelbl.TabIndex = 1;
            this.unamelbl.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Events";
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelbl.ForeColor = System.Drawing.Color.Red;
            this.rolelbl.Location = new System.Drawing.Point(776, 68);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(47, 20);
            this.rolelbl.TabIndex = 3;
            this.rolelbl.Text = "Role";
            // 
            // dashboardgrid
            // 
            this.dashboardgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardgrid.Location = new System.Drawing.Point(190, 130);
            this.dashboardgrid.Name = "dashboardgrid";
            this.dashboardgrid.RowHeadersWidth = 51;
            this.dashboardgrid.RowTemplate.Height = 24;
            this.dashboardgrid.Size = new System.Drawing.Size(561, 350);
            this.dashboardgrid.TabIndex = 4;
            // 
            // createeventbtn
            // 
            this.createeventbtn.Location = new System.Drawing.Point(27, 130);
            this.createeventbtn.Name = "createeventbtn";
            this.createeventbtn.Size = new System.Drawing.Size(126, 48);
            this.createeventbtn.TabIndex = 5;
            this.createeventbtn.Text = "Create an event";
            this.createeventbtn.UseVisualStyleBackColor = true;
            this.createeventbtn.Click += new System.EventHandler(this.createeventbtn_Click);
            // 
            // editeventbtn
            // 
            this.editeventbtn.Location = new System.Drawing.Point(27, 242);
            this.editeventbtn.Name = "editeventbtn";
            this.editeventbtn.Size = new System.Drawing.Size(126, 48);
            this.editeventbtn.TabIndex = 6;
            this.editeventbtn.Text = "Edit an event";
            this.editeventbtn.UseVisualStyleBackColor = true;
            this.editeventbtn.Click += new System.EventHandler(this.editeventbtn_Click);
            // 
            // deleteeventbtn
            // 
            this.deleteeventbtn.Location = new System.Drawing.Point(27, 379);
            this.deleteeventbtn.Name = "deleteeventbtn";
            this.deleteeventbtn.Size = new System.Drawing.Size(126, 48);
            this.deleteeventbtn.TabIndex = 7;
            this.deleteeventbtn.Text = "Delete an event";
            this.deleteeventbtn.UseVisualStyleBackColor = true;
            this.deleteeventbtn.Click += new System.EventHandler(this.deleteeventbtn_Click);
            // 
            // addparttoeventbtn
            // 
            this.addparttoeventbtn.Location = new System.Drawing.Point(790, 130);
            this.addparttoeventbtn.Name = "addparttoeventbtn";
            this.addparttoeventbtn.Size = new System.Drawing.Size(126, 48);
            this.addparttoeventbtn.TabIndex = 10;
            this.addparttoeventbtn.Text = "Add a participant to an event";
            this.addparttoeventbtn.UseVisualStyleBackColor = true;
            this.addparttoeventbtn.Click += new System.EventHandler(this.addparttoeventbtn_Click);
            // 
            // viewallbookingsbtn
            // 
            this.viewallbookingsbtn.Location = new System.Drawing.Point(790, 210);
            this.viewallbookingsbtn.Name = "viewallbookingsbtn";
            this.viewallbookingsbtn.Size = new System.Drawing.Size(126, 48);
            this.viewallbookingsbtn.TabIndex = 9;
            this.viewallbookingsbtn.Text = "View All Bookings";
            this.viewallbookingsbtn.UseVisualStyleBackColor = true;
            this.viewallbookingsbtn.Click += new System.EventHandler(this.viewallbookingsbtn_Click);
            // 
            // removepartbtn
            // 
            this.removepartbtn.Location = new System.Drawing.Point(790, 295);
            this.removepartbtn.Name = "removepartbtn";
            this.removepartbtn.Size = new System.Drawing.Size(126, 64);
            this.removepartbtn.TabIndex = 8;
            this.removepartbtn.Text = "Remove participants from an event";
            this.removepartbtn.UseVisualStyleBackColor = true;
            this.removepartbtn.Click += new System.EventHandler(this.removepartbtn_Click);
            // 
            // addadminbtn
            // 
            this.addadminbtn.Location = new System.Drawing.Point(790, 388);
            this.addadminbtn.Name = "addadminbtn";
            this.addadminbtn.Size = new System.Drawing.Size(126, 48);
            this.addadminbtn.TabIndex = 11;
            this.addadminbtn.Text = "Add a new admin";
            this.addadminbtn.UseVisualStyleBackColor = true;
            this.addadminbtn.Click += new System.EventHandler(this.addadminbtn_Click);
            // 
            // registertoeventbtn
            // 
            this.registertoeventbtn.Location = new System.Drawing.Point(190, 498);
            this.registertoeventbtn.Name = "registertoeventbtn";
            this.registertoeventbtn.Size = new System.Drawing.Size(126, 48);
            this.registertoeventbtn.TabIndex = 12;
            this.registertoeventbtn.Text = "Register to an event";
            this.registertoeventbtn.UseVisualStyleBackColor = true;
            this.registertoeventbtn.Click += new System.EventHandler(this.registertoeventbtn_Click);
            // 
            // viewalleventsbtn
            // 
            this.viewalleventsbtn.Location = new System.Drawing.Point(415, 498);
            this.viewalleventsbtn.Name = "viewalleventsbtn";
            this.viewalleventsbtn.Size = new System.Drawing.Size(126, 48);
            this.viewalleventsbtn.TabIndex = 13;
            this.viewalleventsbtn.Text = "View all events";
            this.viewalleventsbtn.UseVisualStyleBackColor = true;
            this.viewalleventsbtn.Click += new System.EventHandler(this.viewalleventsbtn_Click);
            // 
            // unregfromeventbtn
            // 
            this.unregfromeventbtn.Location = new System.Drawing.Point(625, 498);
            this.unregfromeventbtn.Name = "unregfromeventbtn";
            this.unregfromeventbtn.Size = new System.Drawing.Size(126, 48);
            this.unregfromeventbtn.TabIndex = 14;
            this.unregfromeventbtn.Text = "Unregister from an event";
            this.unregfromeventbtn.UseVisualStyleBackColor = true;
            this.unregfromeventbtn.Click += new System.EventHandler(this.unregfromeventbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(863, 532);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 28);
            this.logoutbtn.TabIndex = 15;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(413, 80);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(103, 30);
            this.refreshbtn.TabIndex = 16;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 572);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.unregfromeventbtn);
            this.Controls.Add(this.viewalleventsbtn);
            this.Controls.Add(this.registertoeventbtn);
            this.Controls.Add(this.addadminbtn);
            this.Controls.Add(this.addparttoeventbtn);
            this.Controls.Add(this.viewallbookingsbtn);
            this.Controls.Add(this.removepartbtn);
            this.Controls.Add(this.deleteeventbtn);
            this.Controls.Add(this.editeventbtn);
            this.Controls.Add(this.createeventbtn);
            this.Controls.Add(this.dashboardgrid);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unamelbl);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label unamelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.DataGridView dashboardgrid;
        private System.Windows.Forms.Button createeventbtn;
        private System.Windows.Forms.Button editeventbtn;
        private System.Windows.Forms.Button deleteeventbtn;
        private System.Windows.Forms.Button addparttoeventbtn;
        private System.Windows.Forms.Button viewallbookingsbtn;
        private System.Windows.Forms.Button removepartbtn;
        private System.Windows.Forms.Button addadminbtn;
        private System.Windows.Forms.Button registertoeventbtn;
        private System.Windows.Forms.Button viewalleventsbtn;
        private System.Windows.Forms.Button unregfromeventbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}