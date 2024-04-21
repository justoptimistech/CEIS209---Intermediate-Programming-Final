namespace Top_CourseProject_part2
{
    partial class InputForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationDaysTextBox = new System.Windows.Forms.TextBox();
            this.VacationDaysLabel = new System.Windows.Forms.Label();
            this.LifeInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsuranceLabel = new System.Windows.Forms.Label();
            this.HealthInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsuranceLabel = new System.Windows.Forms.Label();
            this.EmployeeTypeLabel = new System.Windows.Forms.Label();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.HourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(49, 80);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(155, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(210, 77);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(312, 38);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(49, 140);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(153, 31);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(210, 140);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(312, 38);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(210, 212);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(312, 38);
            this.SSNTextBox.TabIndex = 2;
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(49, 215);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(78, 31);
            this.SSNLabel.TabIndex = 5;
            this.SSNLabel.Text = "SSN:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(210, 573);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(141, 64);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(381, 573);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 64);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(49, 289);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(137, 31);
            this.HireDateLabel.TabIndex = 8;
            this.HireDateLabel.Text = "Hire Date:";
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(210, 282);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(312, 38);
            this.HireDateTextBox.TabIndex = 3;
            this.HireDateTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysTextBox);
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysLabel);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceLabel);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceLabel);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(609, 77);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(625, 241);
            this.BenefitsGroupBox.TabIndex = 4;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // VacationDaysTextBox
            // 
            this.VacationDaysTextBox.Location = new System.Drawing.Point(274, 175);
            this.VacationDaysTextBox.Name = "VacationDaysTextBox";
            this.VacationDaysTextBox.Size = new System.Drawing.Size(242, 38);
            this.VacationDaysTextBox.TabIndex = 2;
            // 
            // VacationDaysLabel
            // 
            this.VacationDaysLabel.AutoSize = true;
            this.VacationDaysLabel.Location = new System.Drawing.Point(43, 175);
            this.VacationDaysLabel.Name = "VacationDaysLabel";
            this.VacationDaysLabel.Size = new System.Drawing.Size(198, 31);
            this.VacationDaysLabel.TabIndex = 14;
            this.VacationDaysLabel.Text = "Vacation Days:";
            // 
            // LifeInsuranceTextBox
            // 
            this.LifeInsuranceTextBox.Location = new System.Drawing.Point(274, 107);
            this.LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            this.LifeInsuranceTextBox.Size = new System.Drawing.Size(242, 38);
            this.LifeInsuranceTextBox.TabIndex = 1;
            this.LifeInsuranceTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LifeInsuranceLabel
            // 
            this.LifeInsuranceLabel.AutoSize = true;
            this.LifeInsuranceLabel.Location = new System.Drawing.Point(43, 107);
            this.LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            this.LifeInsuranceLabel.Size = new System.Drawing.Size(193, 31);
            this.LifeInsuranceLabel.TabIndex = 12;
            this.LifeInsuranceLabel.Text = "Life Insurance:";
            this.LifeInsuranceLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // HealthInsuranceTextBox
            // 
            this.HealthInsuranceTextBox.Location = new System.Drawing.Point(274, 37);
            this.HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            this.HealthInsuranceTextBox.Size = new System.Drawing.Size(242, 38);
            this.HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            this.HealthInsuranceLabel.AutoSize = true;
            this.HealthInsuranceLabel.Location = new System.Drawing.Point(43, 37);
            this.HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            this.HealthInsuranceLabel.Size = new System.Drawing.Size(228, 31);
            this.HealthInsuranceLabel.TabIndex = 10;
            this.HealthInsuranceLabel.Text = "Health Insurance:";
            // 
            // EmployeeTypeLabel
            // 
            this.EmployeeTypeLabel.AutoSize = true;
            this.EmployeeTypeLabel.Location = new System.Drawing.Point(49, 365);
            this.EmployeeTypeLabel.Name = "EmployeeTypeLabel";
            this.EmployeeTypeLabel.Size = new System.Drawing.Size(210, 31);
            this.EmployeeTypeLabel.TabIndex = 10;
            this.EmployeeTypeLabel.Text = "Employee Type:";
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(265, 363);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(114, 35);
            this.HourlyRadioButton.TabIndex = 5;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(408, 363);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(112, 35);
            this.SalaryRadioButton.TabIndex = 6;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // HourlyRateTextBox
            // 
            this.HourlyRateTextBox.Location = new System.Drawing.Point(307, 422);
            this.HourlyRateTextBox.Name = "HourlyRateTextBox";
            this.HourlyRateTextBox.Size = new System.Drawing.Size(312, 38);
            this.HourlyRateTextBox.TabIndex = 13;
            this.HourlyRateTextBox.Visible = false;
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(104, 425);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(166, 31);
            this.HourlyRateLabel.TabIndex = 14;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            this.HourlyRateLabel.Visible = false;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(307, 489);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(312, 38);
            this.HoursWorkedTextBox.TabIndex = 8;
            this.HoursWorkedTextBox.Visible = false;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(104, 492);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(195, 31);
            this.HoursWorkedLabel.TabIndex = 16;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            this.HoursWorkedLabel.Visible = false;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(307, 422);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(312, 38);
            this.SalaryTextBox.TabIndex = 7;
            this.SalaryTextBox.Visible = false;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(104, 425);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(99, 31);
            this.SalaryLabel.TabIndex = 18;
            this.SalaryLabel.Text = "Salary:";
            this.SalaryLabel.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 721);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.HourlyRateTextBox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.EmployeeTypeLabel);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label HireDateLabel;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.GroupBox BenefitsGroupBox;
        public System.Windows.Forms.TextBox VacationDaysTextBox;
        private System.Windows.Forms.Label VacationDaysLabel;
        public System.Windows.Forms.TextBox LifeInsuranceTextBox;
        private System.Windows.Forms.Label LifeInsuranceLabel;
        public System.Windows.Forms.TextBox HealthInsuranceTextBox;
        private System.Windows.Forms.Label HealthInsuranceLabel;
        public System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label EmployeeTypeLabel;
        public System.Windows.Forms.TextBox HourlyRateTextBox;
        public System.Windows.Forms.TextBox HoursWorkedTextBox;
        public System.Windows.Forms.RadioButton HourlyRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
        public System.Windows.Forms.Label HourlyRateLabel;
        public System.Windows.Forms.Label HoursWorkedLabel;
        public System.Windows.Forms.TextBox SalaryTextBox;
        public System.Windows.Forms.Label SalaryLabel;
    }
}