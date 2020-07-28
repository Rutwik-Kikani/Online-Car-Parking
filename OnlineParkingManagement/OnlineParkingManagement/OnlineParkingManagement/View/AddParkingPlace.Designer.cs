namespace OnlineParkingManagement.View
{
    partial class AddParkingPlace
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
            this.lblTitleAddParkingPlace = new System.Windows.Forms.Label();
            this.pnlAddParkingPlace = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFourRate = new System.Windows.Forms.TextBox();
            this.lblFourRate = new System.Windows.Forms.Label();
            this.txtTwoRate = new System.Windows.Forms.TextBox();
            this.lblTwoRate = new System.Windows.Forms.Label();
            this.txtFourCapacity = new System.Windows.Forms.TextBox();
            this.lblFourCapacity = new System.Windows.Forms.Label();
            this.txtTwoCapacity = new System.Windows.Forms.TextBox();
            this.lblTwoCapacity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtParkingName = new System.Windows.Forms.TextBox();
            this.lblParkingName = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddParkingPlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAddParkingPlace
            // 
            this.lblTitleAddParkingPlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleAddParkingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddParkingPlace.Location = new System.Drawing.Point(0, 0);
            this.lblTitleAddParkingPlace.Name = "lblTitleAddParkingPlace";
            this.lblTitleAddParkingPlace.Padding = new System.Windows.Forms.Padding(8);
            this.lblTitleAddParkingPlace.Size = new System.Drawing.Size(563, 71);
            this.lblTitleAddParkingPlace.TabIndex = 0;
            this.lblTitleAddParkingPlace.Text = "AddParkingPlace";
            this.lblTitleAddParkingPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAddParkingPlace
            // 
            this.pnlAddParkingPlace.Controls.Add(this.btnAdd);
            this.pnlAddParkingPlace.Controls.Add(this.txtFourRate);
            this.pnlAddParkingPlace.Controls.Add(this.lblFourRate);
            this.pnlAddParkingPlace.Controls.Add(this.txtTwoRate);
            this.pnlAddParkingPlace.Controls.Add(this.lblTwoRate);
            this.pnlAddParkingPlace.Controls.Add(this.txtFourCapacity);
            this.pnlAddParkingPlace.Controls.Add(this.lblFourCapacity);
            this.pnlAddParkingPlace.Controls.Add(this.txtTwoCapacity);
            this.pnlAddParkingPlace.Controls.Add(this.lblTwoCapacity);
            this.pnlAddParkingPlace.Controls.Add(this.txtAddress);
            this.pnlAddParkingPlace.Controls.Add(this.lblAddress);
            this.pnlAddParkingPlace.Controls.Add(this.txtParkingName);
            this.pnlAddParkingPlace.Controls.Add(this.lblParkingName);
            this.pnlAddParkingPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddParkingPlace.Location = new System.Drawing.Point(0, 71);
            this.pnlAddParkingPlace.Margin = new System.Windows.Forms.Padding(8);
            this.pnlAddParkingPlace.Name = "pnlAddParkingPlace";
            this.pnlAddParkingPlace.Padding = new System.Windows.Forms.Padding(8);
            this.pnlAddParkingPlace.Size = new System.Drawing.Size(563, 602);
            this.pnlAddParkingPlace.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(518, 58);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFourRate
            // 
            this.txtFourRate.Location = new System.Drawing.Point(15, 399);
            this.txtFourRate.Name = "txtFourRate";
            this.txtFourRate.Size = new System.Drawing.Size(518, 22);
            this.txtFourRate.TabIndex = 13;
            this.txtFourRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtFourRate_Validating);
            // 
            // lblFourRate
            // 
            this.lblFourRate.AutoSize = true;
            this.lblFourRate.Location = new System.Drawing.Point(12, 379);
            this.lblFourRate.Name = "lblFourRate";
            this.lblFourRate.Size = new System.Drawing.Size(67, 17);
            this.lblFourRate.TabIndex = 12;
            this.lblFourRate.Text = "FourRate";
            // 
            // txtTwoRate
            // 
            this.txtTwoRate.Location = new System.Drawing.Point(15, 345);
            this.txtTwoRate.Name = "txtTwoRate";
            this.txtTwoRate.Size = new System.Drawing.Size(518, 22);
            this.txtTwoRate.TabIndex = 11;
            this.txtTwoRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtTwoRate_Validating);
            // 
            // lblTwoRate
            // 
            this.lblTwoRate.AutoSize = true;
            this.lblTwoRate.Location = new System.Drawing.Point(12, 325);
            this.lblTwoRate.Name = "lblTwoRate";
            this.lblTwoRate.Size = new System.Drawing.Size(64, 17);
            this.lblTwoRate.TabIndex = 10;
            this.lblTwoRate.Text = "TwoRate";
            // 
            // txtFourCapacity
            // 
            this.txtFourCapacity.Location = new System.Drawing.Point(15, 290);
            this.txtFourCapacity.Name = "txtFourCapacity";
            this.txtFourCapacity.Size = new System.Drawing.Size(518, 22);
            this.txtFourCapacity.TabIndex = 9;
            this.txtFourCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.txtFourCapacity_Validating);
            // 
            // lblFourCapacity
            // 
            this.lblFourCapacity.AutoSize = true;
            this.lblFourCapacity.Location = new System.Drawing.Point(12, 270);
            this.lblFourCapacity.Name = "lblFourCapacity";
            this.lblFourCapacity.Size = new System.Drawing.Size(91, 17);
            this.lblFourCapacity.TabIndex = 8;
            this.lblFourCapacity.Text = "FourCapacity";
            // 
            // txtTwoCapacity
            // 
            this.txtTwoCapacity.Location = new System.Drawing.Point(15, 236);
            this.txtTwoCapacity.Name = "txtTwoCapacity";
            this.txtTwoCapacity.Size = new System.Drawing.Size(518, 22);
            this.txtTwoCapacity.TabIndex = 7;
            this.txtTwoCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.txtTwoCapacity_Validating);
            // 
            // lblTwoCapacity
            // 
            this.lblTwoCapacity.AutoSize = true;
            this.lblTwoCapacity.Location = new System.Drawing.Point(12, 216);
            this.lblTwoCapacity.Name = "lblTwoCapacity";
            this.lblTwoCapacity.Size = new System.Drawing.Size(88, 17);
            this.lblTwoCapacity.TabIndex = 6;
            this.lblTwoCapacity.Text = "TwoCapacity";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 118);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(518, 86);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtParkingName
            // 
            this.txtParkingName.Location = new System.Drawing.Point(15, 62);
            this.txtParkingName.Name = "txtParkingName";
            this.txtParkingName.Size = new System.Drawing.Size(518, 22);
            this.txtParkingName.TabIndex = 3;
            this.txtParkingName.Validating += new System.ComponentModel.CancelEventHandler(this.txtParkingName_Validating);
            // 
            // lblParkingName
            // 
            this.lblParkingName.AutoSize = true;
            this.lblParkingName.Location = new System.Drawing.Point(12, 42);
            this.lblParkingName.Name = "lblParkingName";
            this.lblParkingName.Size = new System.Drawing.Size(93, 17);
            this.lblParkingName.TabIndex = 2;
            this.lblParkingName.Text = "ParkingName";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddParkingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 673);
            this.Controls.Add(this.pnlAddParkingPlace);
            this.Controls.Add(this.lblTitleAddParkingPlace);
            this.Name = "AddParkingPlace";
            this.Text = "AddParkingPlace";
            this.pnlAddParkingPlace.ResumeLayout(false);
            this.pnlAddParkingPlace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAddParkingPlace;
        private System.Windows.Forms.Panel pnlAddParkingPlace;
        private System.Windows.Forms.Label lblParkingName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtParkingName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTwoCapacity;
        private System.Windows.Forms.TextBox txtTwoCapacity;
        private System.Windows.Forms.TextBox txtFourRate;
        private System.Windows.Forms.Label lblFourRate;
        private System.Windows.Forms.TextBox txtTwoRate;
        private System.Windows.Forms.Label lblTwoRate;
        private System.Windows.Forms.TextBox txtFourCapacity;
        private System.Windows.Forms.Label lblFourCapacity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}