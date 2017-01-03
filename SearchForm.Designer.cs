namespace FormsProject
{
    partial class SearchForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpbxSearch = new System.Windows.Forms.GroupBox();
            this.cmbxBook = new System.Windows.Forms.ComboBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.btnSearchGuest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBookS = new System.Windows.Forms.Label();
            this.lblGuestS = new System.Windows.Forms.Label();
            this.cmbxGuest = new System.Windows.Forms.ComboBox();
            this.txtGuestSearch = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.cmbxCountry = new System.Windows.Forms.ComboBox();
            this.cmbxRoomType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Location = new System.Drawing.Point(203, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 108);
            this.panel2.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(35, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(110, 34);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 108);
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
            // grpbxSearch
            // 
            this.grpbxSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpbxSearch.Controls.Add(this.dateTimePicker1);
            this.grpbxSearch.Controls.Add(this.cmbxRoomType);
            this.grpbxSearch.Controls.Add(this.cmbxCountry);
            this.grpbxSearch.Controls.Add(this.btnSearchBook);
            this.grpbxSearch.Controls.Add(this.txtGuestSearch);
            this.grpbxSearch.Controls.Add(this.cmbxGuest);
            this.grpbxSearch.Controls.Add(this.lblGuestS);
            this.grpbxSearch.Controls.Add(this.lblBookS);
            this.grpbxSearch.Controls.Add(this.btnCancel);
            this.grpbxSearch.Controls.Add(this.btnSearchGuest);
            this.grpbxSearch.Controls.Add(this.txtBookSearch);
            this.grpbxSearch.Controls.Add(this.lblSearchFor);
            this.grpbxSearch.Controls.Add(this.cmbxBook);
            this.grpbxSearch.Location = new System.Drawing.Point(203, 116);
            this.grpbxSearch.Name = "grpbxSearch";
            this.grpbxSearch.Size = new System.Drawing.Size(490, 538);
            this.grpbxSearch.TabIndex = 4;
            this.grpbxSearch.TabStop = false;
            this.grpbxSearch.Text = "Search";
            // 
            // cmbxBook
            // 
            this.cmbxBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBook.FormattingEnabled = true;
            this.cmbxBook.Location = new System.Drawing.Point(223, 120);
            this.cmbxBook.Name = "cmbxBook";
            this.cmbxBook.Size = new System.Drawing.Size(205, 24);
            this.cmbxBook.TabIndex = 0;
            this.cmbxBook.SelectedIndexChanged += new System.EventHandler(this.cmbxBook_SelectedIndexChanged);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(105, 120);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(112, 24);
            this.lblSearchFor.TabIndex = 1;
            this.lblSearchFor.Text = "Search for:";
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(31, 171);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(397, 22);
            this.txtBookSearch.TabIndex = 2;
            // 
            // btnSearchGuest
            // 
            this.btnSearchGuest.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearchGuest.Location = new System.Drawing.Point(31, 478);
            this.btnSearchGuest.Name = "btnSearchGuest";
            this.btnSearchGuest.Size = new System.Drawing.Size(173, 31);
            this.btnSearchGuest.TabIndex = 3;
            this.btnSearchGuest.Text = "Search";
            this.btnSearchGuest.UseVisualStyleBackColor = true;
            this.btnSearchGuest.Click += new System.EventHandler(this.btnSearchGuest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblBookS
            // 
            this.lblBookS.AutoSize = true;
            this.lblBookS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookS.Location = new System.Drawing.Point(31, 59);
            this.lblBookS.Name = "lblBookS";
            this.lblBookS.Size = new System.Drawing.Size(198, 29);
            this.lblBookS.TabIndex = 5;
            this.lblBookS.Text = "Booking Search";
            // 
            // lblGuestS
            // 
            this.lblGuestS.AutoSize = true;
            this.lblGuestS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestS.Location = new System.Drawing.Point(31, 280);
            this.lblGuestS.Name = "lblGuestS";
            this.lblGuestS.Size = new System.Drawing.Size(170, 29);
            this.lblGuestS.TabIndex = 6;
            this.lblGuestS.Text = "Guest Search";
            // 
            // cmbxGuest
            // 
            this.cmbxGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxGuest.FormattingEnabled = true;
            this.cmbxGuest.Location = new System.Drawing.Point(223, 338);
            this.cmbxGuest.Name = "cmbxGuest";
            this.cmbxGuest.Size = new System.Drawing.Size(205, 24);
            this.cmbxGuest.TabIndex = 7;
            this.cmbxGuest.SelectedIndexChanged += new System.EventHandler(this.cmbxGuest_SelectedIndexChanged);
            // 
            // txtGuestSearch
            // 
            this.txtGuestSearch.Location = new System.Drawing.Point(31, 394);
            this.txtGuestSearch.Name = "txtGuestSearch";
            this.txtGuestSearch.Size = new System.Drawing.Size(397, 22);
            this.txtGuestSearch.TabIndex = 8;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearchBook.Location = new System.Drawing.Point(31, 225);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(173, 31);
            this.btnSearchBook.TabIndex = 9;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // cmbxCountry
            // 
            this.cmbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCountry.FormattingEnabled = true;
            this.cmbxCountry.Location = new System.Drawing.Point(307, 364);
            this.cmbxCountry.Name = "cmbxCountry";
            this.cmbxCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbxCountry.TabIndex = 10;
            this.cmbxCountry.Visible = false;
            // 
            // cmbxRoomType
            // 
            this.cmbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRoomType.FormattingEnabled = true;
            this.cmbxRoomType.Location = new System.Drawing.Point(292, 150);
            this.cmbxRoomType.Name = "cmbxRoomType";
            this.cmbxRoomType.Size = new System.Drawing.Size(136, 24);
            this.cmbxRoomType.TabIndex = 11;
            this.cmbxRoomType.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 656);
            this.Controls.Add(this.grpbxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpbxSearch.ResumeLayout(false);
            this.grpbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpbxSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.ComboBox cmbxBook;
        private System.Windows.Forms.Label lblGuestS;
        private System.Windows.Forms.Label lblBookS;
        private System.Windows.Forms.TextBox txtGuestSearch;
        private System.Windows.Forms.ComboBox cmbxGuest;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.ComboBox cmbxCountry;
        private System.Windows.Forms.ComboBox cmbxRoomType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}