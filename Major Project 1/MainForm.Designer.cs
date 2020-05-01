namespace Major_Project_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twentyfourMonthRadio = new System.Windows.Forms.RadioButton();
            this.eighteenMonthRadio = new System.Windows.Forms.RadioButton();
            this.twelveMonthRadio = new System.Windows.Forms.RadioButton();
            this.sixMonthRadio = new System.Windows.Forms.RadioButton();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.aprComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(418, 83);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 80);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "&Calculate Loan";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic and Industry Collaboration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Loan Calculator";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(418, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 80);
            this.label3.TabIndex = 3;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(418, 159);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(100, 80);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "&Accept Loan";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(418, 236);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 80);
            this.displayButton.TabIndex = 6;
            this.displayButton.Text = "&Display All Loans";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(418, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 80);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(418, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 120);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(429, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Interest:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(429, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Loans:";
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInterestLabel.Location = new System.Drawing.Point(432, 437);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(67, 18);
            this.totalInterestLabel.TabIndex = 10;
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoansLabel.Location = new System.Drawing.Point(432, 492);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(67, 18);
            this.totalLoansLabel.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(25, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loan Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(25, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Annual APR (%):";
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rebateCheckBox.Location = new System.Drawing.Point(28, 159);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(67, 19);
            this.rebateCheckBox.TabIndex = 2;
            this.rebateCheckBox.Text = "Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = false;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.rebateCheckBox_CheckedChanged);
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(122, 93);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(87, 23);
            this.loanTextBox.TabIndex = 0;
            this.loanTextBox.Click += new System.EventHandler(this.loanTextBox_Click);
            this.loanTextBox.TextChanged += new System.EventHandler(this.loanTextBox_TextChanged);
            this.loanTextBox.Enter += new System.EventHandler(this.loanTextBox_Enter);
            this.loanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanTextBox_KeyPress);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(15, 222);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(390, 289);
            this.listBox.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(25, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Month";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(94, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Interest";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(159, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Principal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(241, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Payment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(329, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.twentyfourMonthRadio);
            this.groupBox1.Controls.Add(this.eighteenMonthRadio);
            this.groupBox1.Controls.Add(this.twelveMonthRadio);
            this.groupBox1.Controls.Add(this.sixMonthRadio);
            this.groupBox1.Location = new System.Drawing.Point(230, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 85);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Months";
            // 
            // twentyfourMonthRadio
            // 
            this.twentyfourMonthRadio.AutoSize = true;
            this.twentyfourMonthRadio.Location = new System.Drawing.Point(66, 51);
            this.twentyfourMonthRadio.Name = "twentyfourMonthRadio";
            this.twentyfourMonthRadio.Size = new System.Drawing.Size(37, 19);
            this.twentyfourMonthRadio.TabIndex = 3;
            this.twentyfourMonthRadio.TabStop = true;
            this.twentyfourMonthRadio.Text = "24";
            this.twentyfourMonthRadio.UseVisualStyleBackColor = true;
            this.twentyfourMonthRadio.CheckedChanged += new System.EventHandler(this.twentyfourMonthRadio_CheckedChanged);
            // 
            // eighteenMonthRadio
            // 
            this.eighteenMonthRadio.AutoSize = true;
            this.eighteenMonthRadio.Location = new System.Drawing.Point(66, 26);
            this.eighteenMonthRadio.Name = "eighteenMonthRadio";
            this.eighteenMonthRadio.Size = new System.Drawing.Size(37, 19);
            this.eighteenMonthRadio.TabIndex = 2;
            this.eighteenMonthRadio.TabStop = true;
            this.eighteenMonthRadio.Text = "18";
            this.eighteenMonthRadio.UseVisualStyleBackColor = true;
            this.eighteenMonthRadio.CheckedChanged += new System.EventHandler(this.eighteenMonthRadio_CheckedChanged);
            // 
            // twelveMonthRadio
            // 
            this.twelveMonthRadio.AutoSize = true;
            this.twelveMonthRadio.Location = new System.Drawing.Point(13, 51);
            this.twelveMonthRadio.Name = "twelveMonthRadio";
            this.twelveMonthRadio.Size = new System.Drawing.Size(37, 19);
            this.twelveMonthRadio.TabIndex = 1;
            this.twelveMonthRadio.TabStop = true;
            this.twelveMonthRadio.Text = "12";
            this.twelveMonthRadio.UseVisualStyleBackColor = true;
            this.twelveMonthRadio.CheckedChanged += new System.EventHandler(this.twelveMonthRadio_CheckedChanged);
            // 
            // sixMonthRadio
            // 
            this.sixMonthRadio.AutoSize = true;
            this.sixMonthRadio.Location = new System.Drawing.Point(13, 26);
            this.sixMonthRadio.Name = "sixMonthRadio";
            this.sixMonthRadio.Size = new System.Drawing.Size(31, 19);
            this.sixMonthRadio.TabIndex = 0;
            this.sixMonthRadio.TabStop = true;
            this.sixMonthRadio.Text = "6";
            this.sixMonthRadio.UseVisualStyleBackColor = true;
            this.sixMonthRadio.CheckedChanged += new System.EventHandler(this.sixMonthRadio_CheckedChanged);
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(122, 157);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(87, 23);
            this.rebateTextBox.TabIndex = 3;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebateTextBox_KeyPress);
            // 
            // aprComboBox
            // 
            this.aprComboBox.FormattingEnabled = true;
            this.aprComboBox.Location = new System.Drawing.Point(122, 127);
            this.aprComboBox.Name = "aprComboBox";
            this.aprComboBox.Size = new System.Drawing.Size(87, 23);
            this.aprComboBox.TabIndex = 1;
            this.aprComboBox.TextChanged += new System.EventHandler(this.aprComboBox_TextChanged);
            this.aprComboBox.Click += new System.EventHandler(this.aprComboBox_Click);
            this.aprComboBox.Enter += new System.EventHandler(this.aprComboBox_Enter);
            this.aprComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aprComboBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(519, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aprComboBox);
            this.Controls.Add(this.rebateTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.rebateCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalLoansLabel);
            this.Controls.Add(this.totalInterestLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Loan Amortization App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twentyfourMonthRadio;
        private System.Windows.Forms.RadioButton eighteenMonthRadio;
        private System.Windows.Forms.RadioButton twelveMonthRadio;
        private System.Windows.Forms.RadioButton sixMonthRadio;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.ComboBox aprComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

