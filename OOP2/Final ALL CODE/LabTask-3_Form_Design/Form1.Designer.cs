
namespace LabTask_3_Form_Design
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRetypeemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRetypepassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSecurityquestion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSecurityanswer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbMobile = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(140, 55);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(287, 31);
            this.txtFirstname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(140, 106);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(287, 31);
            this.txtLastname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth:";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cbMonth.Location = new System.Drawing.Point(168, 154);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 24);
            this.cbMonth.TabIndex = 6;
            this.cbMonth.Text = "Month";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(306, 154);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 24);
            this.cbDay.TabIndex = 7;
            this.cbDay.Text = "Day";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "1997",
            "1998",
            "1999",
            "2000",
            "2001"});
            this.cbYear.Location = new System.Drawing.Point(455, 154);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 24);
            this.cbYear.TabIndex = 8;
            this.cbYear.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Account Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(220, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "(Your email address will be your username)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Re-Type Email:";
            // 
            // txtRetypeemail
            // 
            this.txtRetypeemail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypeemail.Location = new System.Drawing.Point(220, 366);
            this.txtRetypeemail.Name = "txtRetypeemail";
            this.txtRetypeemail.Size = new System.Drawing.Size(366, 31);
            this.txtRetypeemail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(220, 417);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 31);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "(Min. 8 characters. 1 number. case-sensitive )";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Re-Type Password:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtRetypepassword
            // 
            this.txtRetypepassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypepassword.Location = new System.Drawing.Point(220, 479);
            this.txtRetypepassword.Name = "txtRetypepassword";
            this.txtRetypepassword.Size = new System.Drawing.Size(254, 31);
            this.txtRetypepassword.TabIndex = 25;
            this.txtRetypepassword.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Security Question:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cbSecurityquestion
            // 
            this.cbSecurityquestion.FormattingEnabled = true;
            this.cbSecurityquestion.Items.AddRange(new object[] {
            "Are you a verified user?",
            "Are you robot?"});
            this.cbSecurityquestion.Location = new System.Drawing.Point(220, 531);
            this.cbSecurityquestion.Name = "cbSecurityquestion";
            this.cbSecurityquestion.Size = new System.Drawing.Size(207, 24);
            this.cbSecurityquestion.TabIndex = 27;
            this.cbSecurityquestion.Text = "Choose a security question";
            this.cbSecurityquestion.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 587);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Security Answer:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtSecurityanswer
            // 
            this.txtSecurityanswer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityanswer.Location = new System.Drawing.Point(220, 579);
            this.txtSecurityanswer.Name = "txtSecurityanswer";
            this.txtSecurityanswer.Size = new System.Drawing.Size(254, 31);
            this.txtSecurityanswer.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(217, 613);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "(Not case-sensitive)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(10, 660);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 33);
            this.label16.TabIndex = 31;
            this.label16.Text = "Contact Information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(88, 719);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 23);
            this.label17.TabIndex = 32;
            this.label17.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(220, 711);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 31);
            this.txtAddress.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(128, 760);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 23);
            this.label18.TabIndex = 34;
            this.label18.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(220, 760);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(254, 31);
            this.txtCity.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(117, 814);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 23);
            this.label19.TabIndex = 36;
            this.label19.Text = "State:";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Dhaka",
            "Gazipur",
            "Narayangonj",
            "Narsingdi",
            "Rajshahi",
            "Pabna",
            "Chottogram"});
            this.cbState.Location = new System.Drawing.Point(220, 817);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(144, 24);
            this.cbState.TabIndex = 37;
            this.cbState.Text = "Choose a state";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(85, 865);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 23);
            this.label20.TabIndex = 38;
            this.label20.Text = "Zip Code:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipcode.Location = new System.Drawing.Point(220, 865);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(112, 31);
            this.txtZipcode.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(105, 921);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 23);
            this.label22.TabIndex = 41;
            this.label22.Text = "Phone:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(220, 921);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 31);
            this.txtPhone.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(217, 955);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 16);
            this.label23.TabIndex = 43;
            this.label23.Text = "(No space or dash)";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // cbMobile
            // 
            this.cbMobile.FormattingEnabled = true;
            this.cbMobile.Items.AddRange(new object[] {
            "GP",
            "Airtel",
            "Robi",
            "Banglalink",
            "Teletalk"});
            this.cbMobile.Location = new System.Drawing.Point(480, 928);
            this.cbMobile.Name = "cbMobile";
            this.cbMobile.Size = new System.Drawing.Size(121, 24);
            this.cbMobile.TabIndex = 44;
            this.cbMobile.Text = "Mobile";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(884, 921);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 45;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitClick);
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox12.Location = new System.Drawing.Point(347, 869);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(80, 27);
            this.textBox12.TabIndex = 46;
            this.textBox12.Text = "Optional";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // rtOutput
            // 
            this.rtOutput.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtOutput.Location = new System.Drawing.Point(737, 12);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(444, 572);
            this.rtOutput.TabIndex = 48;
            this.rtOutput.Text = "";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbGender.Location = new System.Drawing.Point(157, 206);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(139, 24);
            this.cbGender.TabIndex = 49;
            this.cbGender.Text = "Choose a gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 1055);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.rtOutput);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMobile);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSecurityanswer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbSecurityquestion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRetypepassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRetypeemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRetypeemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRetypepassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSecurityquestion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSecurityanswer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbMobile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.ComboBox cbGender;
    }
}

