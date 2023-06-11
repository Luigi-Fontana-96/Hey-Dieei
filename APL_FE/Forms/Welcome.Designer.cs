namespace APL_FE
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            loginText = new Label();
            usernameText = new Label();
            passowordText = new Label();
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            loginButton = new Button();
            signupLabel = new Label();
            linkSignup = new LinkLabel();
            nameSignup = new Label();
            cognomeSignup = new Label();
            usernameSignup = new Label();
            passwordSignup = new Label();
            nameSignupBox = new TextBox();
            cognomeSignupBox = new TextBox();
            usernameSignupBox = new TextBox();
            passwordSignupBox = new TextBox();
            sessoBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            sessoSignup = new Label();
            dataSignup = new Label();
            buttonSignup = new Button();
            mailSignupBox = new TextBox();
            mailSignup = new Label();
            mostraCheckbox1 = new CheckBox();
            mostraCheckBox2 = new CheckBox();
            matricolaSignup = new Label();
            matricolaSignupBox = new TextBox();
            SuspendLayout();
            // 
            // loginText
            // 
            loginText.AutoSize = true;
            loginText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginText.Location = new Point(100, 110);
            loginText.Name = "loginText";
            loginText.Size = new Size(71, 25);
            loginText.TabIndex = 0;
            loginText.Text = "LOGIN";
            // 
            // usernameText
            // 
            usernameText.AutoSize = true;
            usernameText.Location = new Point(63, 157);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(60, 15);
            usernameText.TabIndex = 1;
            usernameText.Text = "Username";
            // 
            // passowordText
            // 
            passowordText.AutoSize = true;
            passowordText.Location = new Point(63, 197);
            passowordText.Name = "passowordText";
            passowordText.Size = new Size(57, 15);
            passowordText.TabIndex = 2;
            passowordText.Text = "Password";
            // 
            // usernametextBox
            // 
            usernametextBox.BackColor = Color.White;
            usernametextBox.Location = new Point(129, 154);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(100, 23);
            usernametextBox.TabIndex = 3;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(129, 194);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(100, 23);
            passwordtextBox.TabIndex = 4;
            passwordtextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Azure;
            loginButton.Location = new Point(96, 238);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "ENTRA";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += Login_click;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signupLabel.Location = new Point(434, 110);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(84, 25);
            signupLabel.TabIndex = 6;
            signupLabel.Text = "SIGNUP";
            // 
            // linkSignup
            // 
            linkSignup.AutoSize = true;
            linkSignup.Location = new Point(63, 293);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(163, 15);
            linkSignup.TabIndex = 7;
            linkSignup.TabStop = true;
            linkSignup.Text = "Non sei registrato? Clicca qui!";
            linkSignup.MouseClick += LinkSignup_Click;
            // 
            // nameSignup
            // 
            nameSignup.AutoSize = true;
            nameSignup.Location = new Point(379, 157);
            nameSignup.Name = "nameSignup";
            nameSignup.Size = new Size(40, 15);
            nameSignup.TabIndex = 8;
            nameSignup.Text = "Nome";
            // 
            // cognomeSignup
            // 
            cognomeSignup.AutoSize = true;
            cognomeSignup.Location = new Point(379, 197);
            cognomeSignup.Name = "cognomeSignup";
            cognomeSignup.Size = new Size(60, 15);
            cognomeSignup.TabIndex = 9;
            cognomeSignup.Text = "Cognome";
            // 
            // usernameSignup
            // 
            usernameSignup.AutoSize = true;
            usernameSignup.Location = new Point(379, 238);
            usernameSignup.Name = "usernameSignup";
            usernameSignup.Size = new Size(60, 15);
            usernameSignup.TabIndex = 10;
            usernameSignup.Text = "Username";
            // 
            // passwordSignup
            // 
            passwordSignup.AutoSize = true;
            passwordSignup.Location = new Point(379, 281);
            passwordSignup.Name = "passwordSignup";
            passwordSignup.Size = new Size(57, 15);
            passwordSignup.TabIndex = 11;
            passwordSignup.Text = "Password";
            // 
            // nameSignupBox
            // 
            nameSignupBox.Location = new Point(458, 154);
            nameSignupBox.Name = "nameSignupBox";
            nameSignupBox.Size = new Size(100, 23);
            nameSignupBox.TabIndex = 12;
            // 
            // cognomeSignupBox
            // 
            cognomeSignupBox.Location = new Point(458, 194);
            cognomeSignupBox.Name = "cognomeSignupBox";
            cognomeSignupBox.Size = new Size(100, 23);
            cognomeSignupBox.TabIndex = 13;
            // 
            // usernameSignupBox
            // 
            usernameSignupBox.Location = new Point(458, 235);
            usernameSignupBox.Name = "usernameSignupBox";
            usernameSignupBox.Size = new Size(100, 23);
            usernameSignupBox.TabIndex = 14;
            // 
            // passwordSignupBox
            // 
            passwordSignupBox.Location = new Point(458, 278);
            passwordSignupBox.Name = "passwordSignupBox";
            passwordSignupBox.Size = new Size(100, 23);
            passwordSignupBox.TabIndex = 15;
            passwordSignupBox.UseSystemPasswordChar = true;
            // 
            // sessoBox
            // 
            sessoBox.FormattingEnabled = true;
            sessoBox.Items.AddRange(new object[] { "M", "F", "ND" });
            sessoBox.Location = new Point(458, 398);
            sessoBox.Name = "sessoBox";
            sessoBox.Size = new Size(100, 23);
            sessoBox.TabIndex = 16;
            sessoBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(458, 442);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // sessoSignup
            // 
            sessoSignup.AutoSize = true;
            sessoSignup.Location = new Point(379, 406);
            sessoSignup.Name = "sessoSignup";
            sessoSignup.Size = new Size(36, 15);
            sessoSignup.TabIndex = 18;
            sessoSignup.Text = "Sesso";
            // 
            // dataSignup
            // 
            dataSignup.AutoSize = true;
            dataSignup.Location = new Point(379, 450);
            dataSignup.Name = "dataSignup";
            dataSignup.Size = new Size(73, 15);
            dataSignup.TabIndex = 19;
            dataSignup.Text = "Data Nascita";
            // 
            // buttonSignup
            // 
            buttonSignup.Location = new Point(434, 479);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(75, 23);
            buttonSignup.TabIndex = 20;
            buttonSignup.Text = "REGISTRATI";
            buttonSignup.UseVisualStyleBackColor = true;
            buttonSignup.Click += Signup_Click;
            // 
            // mailSignupBox
            // 
            mailSignupBox.Location = new Point(458, 323);
            mailSignupBox.Name = "mailSignupBox";
            mailSignupBox.Size = new Size(100, 23);
            mailSignupBox.TabIndex = 21;
            // 
            // mailSignup
            // 
            mailSignup.AutoSize = true;
            mailSignup.Location = new Point(379, 326);
            mailSignup.Name = "mailSignup";
            mailSignup.Size = new Size(30, 15);
            mailSignup.TabIndex = 22;
            mailSignup.Text = "Mail";
            // 
            // mostraCheckbox1
            // 
            mostraCheckbox1.AutoSize = true;
            mostraCheckbox1.Location = new Point(235, 193);
            mostraCheckbox1.Name = "mostraCheckbox1";
            mostraCheckbox1.Size = new Size(63, 19);
            mostraCheckbox1.TabIndex = 23;
            mostraCheckbox1.Text = "Mostra";
            mostraCheckbox1.UseVisualStyleBackColor = true;
            mostraCheckbox1.CheckedChanged += mostraCheckbox1_CheckedChanged;
            // 
            // mostraCheckBox2
            // 
            mostraCheckBox2.AutoSize = true;
            mostraCheckBox2.Location = new Point(564, 280);
            mostraCheckBox2.Name = "mostraCheckBox2";
            mostraCheckBox2.Size = new Size(63, 19);
            mostraCheckBox2.TabIndex = 24;
            mostraCheckBox2.Text = "Mostra";
            mostraCheckBox2.UseVisualStyleBackColor = true;
            mostraCheckBox2.CheckedChanged += mostraCheckBox2_CheckedChanged;
            // 
            // matricolaSignup
            // 
            matricolaSignup.AutoSize = true;
            matricolaSignup.Location = new Point(379, 366);
            matricolaSignup.Name = "matricolaSignup";
            matricolaSignup.Size = new Size(57, 15);
            matricolaSignup.TabIndex = 25;
            matricolaSignup.Text = "Matricola";
            // 
            // matricolaSignupBox
            // 
            matricolaSignupBox.Location = new Point(458, 363);
            matricolaSignupBox.Name = "matricolaSignupBox";
            matricolaSignupBox.Size = new Size(100, 23);
            matricolaSignupBox.TabIndex = 26;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(789, 553);
            Controls.Add(matricolaSignupBox);
            Controls.Add(matricolaSignup);
            Controls.Add(mostraCheckBox2);
            Controls.Add(mostraCheckbox1);
            Controls.Add(mailSignup);
            Controls.Add(mailSignupBox);
            Controls.Add(buttonSignup);
            Controls.Add(dataSignup);
            Controls.Add(sessoSignup);
            Controls.Add(dateTimePicker1);
            Controls.Add(sessoBox);
            Controls.Add(passwordSignupBox);
            Controls.Add(usernameSignupBox);
            Controls.Add(cognomeSignupBox);
            Controls.Add(nameSignupBox);
            Controls.Add(passwordSignup);
            Controls.Add(usernameSignup);
            Controls.Add(cognomeSignup);
            Controls.Add(nameSignup);
            Controls.Add(linkSignup);
            Controls.Add(signupLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordtextBox);
            Controls.Add(usernametextBox);
            Controls.Add(passowordText);
            Controls.Add(usernameText);
            Controls.Add(loginText);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeyDieei";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginText;
        private Label usernameText;
        private Label passowordText;
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Button loginButton;
        private Label signupLabel;
        private LinkLabel linkSignup;
        private Label nameSignup;
        private Label cognomeSignup;
        private Label usernameSignup;
        private Label passwordSignup;
        private TextBox nameSignupBox;
        private TextBox cognomeSignupBox;
        private TextBox usernameSignupBox;
        private TextBox passwordSignupBox;
        private ComboBox sessoBox;
        private DateTimePicker dateTimePicker1;
        private Label sessoSignup;
        private Label dataSignup;
        private Button buttonSignup;
        private TextBox mailSignupBox;
        private Label mailSignup;
        private CheckBox mostraCheckbox1;
        private CheckBox mostraCheckBox2;
        private Label matricolaSignup;
        private TextBox matricolaSignupBox;
    }
}