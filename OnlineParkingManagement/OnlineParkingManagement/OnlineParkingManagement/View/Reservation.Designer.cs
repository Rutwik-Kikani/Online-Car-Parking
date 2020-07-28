namespace OnlineParkingManagement.View
{
    partial class Reservation
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
            this.dtime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.vtype = new System.Windows.Forms.ComboBox();
            this.atime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.vname = new System.Windows.Forms.TextBox();
            this.vnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtime
            // 
            this.dtime.CustomFormat = "dd/MM/yyyy | hh:mm tt";
            this.dtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime.Location = new System.Drawing.Point(193, 417);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(236, 22);
            this.dtime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(602, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vtype
            // 
            this.vtype.FormattingEnabled = true;
            this.vtype.Items.AddRange(new object[] {
            "2-Wheeler",
            "4-Wheeler"});
            this.vtype.Location = new System.Drawing.Point(193, 167);
            this.vtype.Name = "vtype";
            this.vtype.Size = new System.Drawing.Size(236, 24);
            this.vtype.TabIndex = 3;
            // 
            // atime
            // 
            this.atime.CustomFormat = "dd/MM/yyyy | hh:mm tt";
            this.atime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.atime.Location = new System.Drawing.Point(193, 358);
            this.atime.Name = "atime";
            this.atime.Size = new System.Drawing.Size(236, 22);
            this.atime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(36);
            this.label2.Size = new System.Drawing.Size(602, 96);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vname
            // 
            this.vname.Location = new System.Drawing.Point(193, 227);
            this.vname.Name = "vname";
            this.vname.Size = new System.Drawing.Size(236, 22);
            this.vname.TabIndex = 6;
            // 
            // vnumber
            // 
            this.vnumber.Location = new System.Drawing.Point(193, 283);
            this.vnumber.Name = "vnumber";
            this.vnumber.Size = new System.Drawing.Size(236, 22);
            this.vnumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registration number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vehicle type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Arrival Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Departure Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vnumber);
            this.Controls.Add(this.vname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atime);
            this.Controls.Add(this.vtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtime);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vtype;
        private System.Windows.Forms.DateTimePicker atime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vname;
        private System.Windows.Forms.TextBox vnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}