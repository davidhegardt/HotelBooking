namespace FormsProject
{
    partial class bookForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxBook = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.boxBreakfast = new System.Windows.Forms.ComboBox();
            this.boxPayment = new System.Windows.Forms.ComboBox();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.boxRoom = new System.Windows.Forms.ComboBox();
            this.lblBfust = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.boxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpbxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(201, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            // 
            // grpbxBook
            // 
            this.grpbxBook.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbxBook.Controls.Add(this.lblPrice);
            this.grpbxBook.Controls.Add(this.btnCancel);
            this.grpbxBook.Controls.Add(this.btnBook);
            this.grpbxBook.Controls.Add(this.boxBreakfast);
            this.grpbxBook.Controls.Add(this.boxPayment);
            this.grpbxBook.Controls.Add(this.btnFemale);
            this.grpbxBook.Controls.Add(this.btnMale);
            this.grpbxBook.Controls.Add(this.boxRoom);
            this.grpbxBook.Controls.Add(this.lblBfust);
            this.grpbxBook.Controls.Add(this.lblCheckOut);
            this.grpbxBook.Controls.Add(this.lblCheckIn);
            this.grpbxBook.Controls.Add(this.lblPayment);
            this.grpbxBook.Controls.Add(this.lblAvail);
            this.grpbxBook.Controls.Add(this.lblRoomType);
            this.grpbxBook.Controls.Add(this.boxCountry);
            this.grpbxBook.Controls.Add(this.lblCountry);
            this.grpbxBook.Controls.Add(this.lblGender);
            this.grpbxBook.Controls.Add(this.dateCheckOut);
            this.grpbxBook.Controls.Add(this.dateCheckIn);
            this.grpbxBook.Controls.Add(this.txtLName);
            this.grpbxBook.Controls.Add(this.txtFName);
            this.grpbxBook.Controls.Add(this.label2);
            this.grpbxBook.Controls.Add(this.lblFName);
            this.grpbxBook.Location = new System.Drawing.Point(201, 107);
            this.grpbxBook.Name = "grpbxBook";
            this.grpbxBook.Size = new System.Drawing.Size(503, 486);
            this.grpbxBook.TabIndex = 2;
            this.grpbxBook.TabStop = false;
            this.grpbxBook.Text = "Book";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(298, 171);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 20);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Pris";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(285, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBook.Location = new System.Drawing.Point(104, 427);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(105, 32);
            this.btnBook.TabIndex = 20;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // boxBreakfast
            // 
            this.boxBreakfast.FormattingEnabled = true;
            this.boxBreakfast.Location = new System.Drawing.Point(171, 262);
            this.boxBreakfast.Name = "boxBreakfast";
            this.boxBreakfast.Size = new System.Drawing.Size(121, 24);
            this.boxBreakfast.TabIndex = 19;
            // 
            // boxPayment
            // 
            this.boxPayment.FormattingEnabled = true;
            this.boxPayment.Location = new System.Drawing.Point(171, 229);
            this.boxPayment.Name = "boxPayment";
            this.boxPayment.Size = new System.Drawing.Size(121, 24);
            this.boxPayment.TabIndex = 18;
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(282, 103);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(75, 21);
            this.btnFemale.TabIndex = 17;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(130, 104);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(59, 21);
            this.btnMale.TabIndex = 16;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // boxRoom
            // 
            this.boxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRoom.FormattingEnabled = true;
            this.boxRoom.Location = new System.Drawing.Point(171, 167);
            this.boxRoom.Name = "boxRoom";
            this.boxRoom.Size = new System.Drawing.Size(121, 24);
            this.boxRoom.TabIndex = 15;
            this.boxRoom.SelectedIndexChanged += new System.EventHandler(this.boxRoom_SelectedIndexChanged);
            // 
            // lblBfust
            // 
            this.lblBfust.AutoSize = true;
            this.lblBfust.Location = new System.Drawing.Point(21, 262);
            this.lblBfust.Name = "lblBfust";
            this.lblBfust.Size = new System.Drawing.Size(68, 17);
            this.lblBfust.TabIndex = 14;
            this.lblBfust.Text = "Breakfast";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(282, 305);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(83, 17);
            this.lblCheckOut.TabIndex = 13;
            this.lblCheckOut.Text = "Check Out";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(24, 305);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(70, 17);
            this.lblCheckIn.TabIndex = 12;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(21, 229);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(63, 17);
            this.lblPayment.TabIndex = 11;
            this.lblPayment.Text = "Payment";
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvail.Location = new System.Drawing.Point(301, 205);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(95, 20);
            this.lblAvail.TabIndex = 10;
            this.lblAvail.Text = "Availibility";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(21, 167);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(76, 17);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "Room type";
            // 
            // boxCountry
            // 
            this.boxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCountry.FormattingEnabled = true;
            this.boxCountry.Location = new System.Drawing.Point(171, 130);
            this.boxCountry.Name = "boxCountry";
            this.boxCountry.Size = new System.Drawing.Size(121, 24);
            this.boxCountry.TabIndex = 8;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(21, 137);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(115, 17);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country of Origin";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 104);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.Location = new System.Drawing.Point(282, 328);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dateCheckOut.TabIndex = 5;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateCheckIn.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateCheckIn.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateCheckIn.Location = new System.Drawing.Point(24, 328);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dateCheckIn.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(104, 72);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(254, 22);
            this.txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(104, 43);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(254, 22);
            this.txtFName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(21, 43);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(76, 17);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 617);
            this.Controls.Add(this.grpbxBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "bookForm";
            this.Text = "BookForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpbxBook.ResumeLayout(false);
            this.grpbxBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxBook;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox boxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblBfust;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.ComboBox boxRoom;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.ComboBox boxBreakfast;
        private System.Windows.Forms.ComboBox boxPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblPrice;
    }
}