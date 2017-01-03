namespace FormsProject
{
    partial class CalcForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblBilling = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpbxBilling = new System.Windows.Forms.GroupBox();
            this.txtSumBreakfast = new System.Windows.Forms.TextBox();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtRoomService = new System.Windows.Forms.TextBox();
            this.txtSumDeposit = new System.Windows.Forms.TextBox();
            this.txtSumClean = new System.Windows.Forms.TextBox();
            this.txtSumTax = new System.Windows.Forms.TextBox();
            this.txtSumNoVat = new System.Windows.Forms.TextBox();
            this.lblRoomService = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblClean = new System.Windows.Forms.Label();
            this.lblSumNoVat = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpbxBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.lblGuest);
            this.panel2.Controls.Add(this.lblBilling);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 100);
            this.panel2.TabIndex = 2;
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuest.Location = new System.Drawing.Point(189, 43);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(177, 34);
            this.lblGuest.TabIndex = 1;
            this.lblGuest.Text = "GuestName";
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBilling.Location = new System.Drawing.Point(35, 43);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(94, 34);
            this.lblBilling.TabIndex = 0;
            this.lblBilling.Text = "Billing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FormsProject.Resource1.bookIcon;
            this.picLogo.Location = new System.Drawing.Point(44, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // grpbxBilling
            // 
            this.grpbxBilling.Controls.Add(this.btnOK);
            this.grpbxBilling.Controls.Add(this.txtSumBreakfast);
            this.grpbxBilling.Controls.Add(this.lblBreakfast);
            this.grpbxBilling.Controls.Add(this.lblDays);
            this.grpbxBilling.Controls.Add(this.txtGrandTotal);
            this.grpbxBilling.Controls.Add(this.txtRoomService);
            this.grpbxBilling.Controls.Add(this.txtSumDeposit);
            this.grpbxBilling.Controls.Add(this.txtSumClean);
            this.grpbxBilling.Controls.Add(this.txtSumTax);
            this.grpbxBilling.Controls.Add(this.txtSumNoVat);
            this.grpbxBilling.Controls.Add(this.lblRoomService);
            this.grpbxBilling.Controls.Add(this.lblTotal);
            this.grpbxBilling.Controls.Add(this.lblDeposit);
            this.grpbxBilling.Controls.Add(this.lblTax);
            this.grpbxBilling.Controls.Add(this.lblClean);
            this.grpbxBilling.Controls.Add(this.lblSumNoVat);
            this.grpbxBilling.Location = new System.Drawing.Point(13, 110);
            this.grpbxBilling.Name = "grpbxBilling";
            this.grpbxBilling.Size = new System.Drawing.Size(695, 479);
            this.grpbxBilling.TabIndex = 4;
            this.grpbxBilling.TabStop = false;
            this.grpbxBilling.Text = "Bill";
            // 
            // txtSumBreakfast
            // 
            this.txtSumBreakfast.Enabled = false;
            this.txtSumBreakfast.Location = new System.Drawing.Point(193, 197);
            this.txtSumBreakfast.Name = "txtSumBreakfast";
            this.txtSumBreakfast.Size = new System.Drawing.Size(100, 22);
            this.txtSumBreakfast.TabIndex = 15;
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(16, 203);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(68, 17);
            this.lblBreakfast.TabIndex = 14;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(422, 26);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(40, 17);
            this.lblDays.TabIndex = 13;
            this.lblDays.Text = "Days";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(193, 235);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(100, 22);
            this.txtGrandTotal.TabIndex = 12;
            // 
            // txtRoomService
            // 
            this.txtRoomService.Location = new System.Drawing.Point(193, 158);
            this.txtRoomService.Name = "txtRoomService";
            this.txtRoomService.Size = new System.Drawing.Size(100, 22);
            this.txtRoomService.TabIndex = 11;
            this.txtRoomService.TextChanged += new System.EventHandler(this.txtRoomService_TextChanged);
            // 
            // txtSumDeposit
            // 
            this.txtSumDeposit.Enabled = false;
            this.txtSumDeposit.Location = new System.Drawing.Point(193, 127);
            this.txtSumDeposit.Name = "txtSumDeposit";
            this.txtSumDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtSumDeposit.TabIndex = 10;
            // 
            // txtSumClean
            // 
            this.txtSumClean.Enabled = false;
            this.txtSumClean.Location = new System.Drawing.Point(193, 96);
            this.txtSumClean.Name = "txtSumClean";
            this.txtSumClean.Size = new System.Drawing.Size(100, 22);
            this.txtSumClean.TabIndex = 9;
            // 
            // txtSumTax
            // 
            this.txtSumTax.Enabled = false;
            this.txtSumTax.Location = new System.Drawing.Point(193, 59);
            this.txtSumTax.Name = "txtSumTax";
            this.txtSumTax.Size = new System.Drawing.Size(100, 22);
            this.txtSumTax.TabIndex = 8;
            // 
            // txtSumNoVat
            // 
            this.txtSumNoVat.Enabled = false;
            this.txtSumNoVat.Location = new System.Drawing.Point(193, 26);
            this.txtSumNoVat.Name = "txtSumNoVat";
            this.txtSumNoVat.Size = new System.Drawing.Size(100, 22);
            this.txtSumNoVat.TabIndex = 7;
            // 
            // lblRoomService
            // 
            this.lblRoomService.AutoSize = true;
            this.lblRoomService.Location = new System.Drawing.Point(16, 164);
            this.lblRoomService.Name = "lblRoomService";
            this.lblRoomService.Size = new System.Drawing.Size(96, 17);
            this.lblRoomService.TabIndex = 6;
            this.lblRoomService.Text = "Room Service";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(14, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Grand Total";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(16, 130);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(56, 17);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(16, 64);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 17);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "CityTax";
            // 
            // lblClean
            // 
            this.lblClean.AutoSize = true;
            this.lblClean.Location = new System.Drawing.Point(16, 96);
            this.lblClean.Name = "lblClean";
            this.lblClean.Size = new System.Drawing.Size(63, 17);
            this.lblClean.TabIndex = 2;
            this.lblClean.Text = "Cleaning";
            // 
            // lblSumNoVat
            // 
            this.lblSumNoVat.AutoSize = true;
            this.lblSumNoVat.Location = new System.Drawing.Point(16, 32);
            this.lblSumNoVat.Name = "lblSumNoVat";
            this.lblSumNoVat.Size = new System.Drawing.Size(119, 17);
            this.lblSumNoVat.TabIndex = 0;
            this.lblSumNoVat.Text = "Cost without VAT ";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnOK.Location = new System.Drawing.Point(246, 399);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(153, 37);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 601);
            this.Controls.Add(this.grpbxBilling);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpbxBilling.ResumeLayout(false);
            this.grpbxBilling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpbxBilling;
        private System.Windows.Forms.Label lblSumNoVat;
        private System.Windows.Forms.Label lblRoomService;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblClean;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtRoomService;
        private System.Windows.Forms.TextBox txtSumDeposit;
        private System.Windows.Forms.TextBox txtSumClean;
        private System.Windows.Forms.TextBox txtSumTax;
        private System.Windows.Forms.TextBox txtSumNoVat;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtSumBreakfast;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Button btnOK;
    }
}