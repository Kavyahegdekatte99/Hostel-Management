namespace hostel_management
{
    partial class Fees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Payments = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.USN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Periode = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paymentId = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Addfees = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 24);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 83);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1163, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 42);
            this.label7.TabIndex = 3;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 813);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1298, 48);
            this.panel7.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Powered By Codespace";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(629, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 32);
            this.label11.TabIndex = 56;
            this.label11.Text = "Payments";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payments
            // 
            this.Payments.BackgroundColor = System.Drawing.Color.White;
            this.Payments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Payments.Location = new System.Drawing.Point(454, 181);
            this.Payments.Name = "Payments";
            this.Payments.RowHeadersWidth = 62;
            this.Payments.RowTemplate.Height = 28;
            this.Payments.Size = new System.Drawing.Size(803, 478);
            this.Payments.TabIndex = 57;
            this.Payments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Payments_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(53, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 10);
            this.panel3.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(48, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 26);
            this.label9.TabIndex = 62;
            this.label9.Text = "USN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // USN
            // 
            this.USN.FormattingEnabled = true;
            this.USN.Location = new System.Drawing.Point(167, 337);
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(215, 28);
            this.USN.TabIndex = 63;
            this.USN.SelectedIndexChanged += new System.EventHandler(this.USN_SelectionChangeCommitted);
            this.USN.SelectionChangeCommitted += new System.EventHandler(this.USN_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(48, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 68;
            this.label5.Text = "Month";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Periode
            // 
            this.Periode.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.Periode.CalendarTrailingForeColor = System.Drawing.Color.Crimson;
            this.Periode.CausesValidation = false;
            this.Periode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periode.Location = new System.Drawing.Point(167, 511);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(215, 26);
            this.Periode.TabIndex = 69;
            this.Periode.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(45, 438);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 10);
            this.panel5.TabIndex = 71;
            // 
            // paymentId
            // 
            this.paymentId.BackColor = System.Drawing.SystemColors.Control;
            this.paymentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentId.ForeColor = System.Drawing.Color.Crimson;
            this.paymentId.Location = new System.Drawing.Point(53, 229);
            this.paymentId.Name = "paymentId";
            this.paymentId.Size = new System.Drawing.Size(169, 28);
            this.paymentId.TabIndex = 76;
            this.paymentId.Text = "PaymentId";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.SystemColors.Control;
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Crimson;
            this.Amount.Location = new System.Drawing.Point(46, 404);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(169, 28);
            this.Amount.TabIndex = 77;
            this.Amount.Text = "Amount";
            this.Amount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Addfees
            // 
            this.Addfees.FlatAppearance.BorderSize = 0;
            this.Addfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addfees.ForeColor = System.Drawing.Color.Crimson;
            this.Addfees.Location = new System.Drawing.Point(36, 585);
            this.Addfees.Name = "Addfees";
            this.Addfees.Size = new System.Drawing.Size(89, 41);
            this.Addfees.TabIndex = 72;
            this.Addfees.Text = "Add";
            this.Addfees.UseVisualStyleBackColor = true;
            this.Addfees.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(131, 585);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 41);
            this.button6.TabIndex = 73;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(236, 585);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 41);
            this.button7.TabIndex = 74;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(331, 585);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 41);
            this.button8.TabIndex = 75;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button4_Click);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 861);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.paymentId);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Addfees);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.USN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Payments);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Payments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox USN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Periode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox paymentId;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button Addfees;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}