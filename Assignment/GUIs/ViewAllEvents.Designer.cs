namespace Assignment.GUIs
{
    partial class ViewAllEvents
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.regtoeventbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Events";
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(32, 90);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(881, 349);
            this.datagrid.TabIndex = 1;
            // 
            // regtoeventbtn
            // 
            this.regtoeventbtn.Location = new System.Drawing.Point(393, 460);
            this.regtoeventbtn.Name = "regtoeventbtn";
            this.regtoeventbtn.Size = new System.Drawing.Size(132, 42);
            this.regtoeventbtn.TabIndex = 3;
            this.regtoeventbtn.Text = "Register to an event";
            this.regtoeventbtn.UseVisualStyleBackColor = true;
            this.regtoeventbtn.Click += new System.EventHandler(this.regtoeventbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(12, 505);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.regtoeventbtn);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewAllEvents";
            this.Text = "ViewAllEvents";
            this.Load += new System.EventHandler(this.ViewAllEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button regtoeventbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button button1;
    }
}