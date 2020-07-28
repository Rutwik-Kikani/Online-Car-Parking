namespace OnlineParkingManagement.View
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddPP = new System.Windows.Forms.Button();
            this.dgvPPDetails = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1353, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Car Parking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1154, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1245, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPP
            // 
            this.btnAddPP.AutoSize = true;
            this.btnAddPP.Location = new System.Drawing.Point(1022, 33);
            this.btnAddPP.Name = "btnAddPP";
            this.btnAddPP.Size = new System.Drawing.Size(126, 34);
            this.btnAddPP.TabIndex = 3;
            this.btnAddPP.Text = "AddParkingPlace";
            this.btnAddPP.UseVisualStyleBackColor = true;
            this.btnAddPP.Click += new System.EventHandler(this.btnAddPP_Click);
            // 
            // dgvPPDetails
            // 
            this.dgvPPDetails.AllowUserToAddRows = false;
            this.dgvPPDetails.AllowUserToDeleteRows = false;
            this.dgvPPDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPPDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPPDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPPDetails.Location = new System.Drawing.Point(12, 110);
            this.dgvPPDetails.Name = "dgvPPDetails";
            this.dgvPPDetails.ReadOnly = true;
            this.dgvPPDetails.RowHeadersWidth = 51;
            this.dgvPPDetails.RowTemplate.Height = 24;
            this.dgvPPDetails.Size = new System.Drawing.Size(1329, 328);
            this.dgvPPDetails.TabIndex = 4;
            this.dgvPPDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPPDetails_CellClick);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(OnlineParkingManagement.View.Reservation);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.dgvPPDetails);
            this.Controls.Add(this.btnAddPP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Button btnAddPP;
        private System.Windows.Forms.DataGridView dgvPPDetails;
    }
}