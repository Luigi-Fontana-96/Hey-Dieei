namespace APL_FE
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            menuBox = new GroupBox();
            cheprofButton = new Button();
            statisticheButton = new Button();
            valutaProfessoriButton = new Button();
            valutamaterieButton = new Button();
            homepageButton = new Button();
            panelDisplay = new Panel();
            welcomeUsername = new Label();
            logoutLabel = new LinkLabel();
            menuBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Bentornato";
            // 
            // menuBox
            // 
            menuBox.Controls.Add(cheprofButton);
            menuBox.Controls.Add(statisticheButton);
            menuBox.Controls.Add(valutaProfessoriButton);
            menuBox.Controls.Add(valutamaterieButton);
            menuBox.Controls.Add(homepageButton);
            menuBox.Location = new Point(12, 57);
            menuBox.Name = "menuBox";
            menuBox.Size = new Size(168, 271);
            menuBox.TabIndex = 1;
            menuBox.TabStop = false;
            menuBox.Text = "Menu";
            // 
            // cheprofButton
            // 
            cheprofButton.FlatStyle = FlatStyle.Popup;
            cheprofButton.ForeColor = SystemColors.ActiveCaptionText;
            cheprofButton.Location = new Point(6, 219);
            cheprofButton.Name = "cheprofButton";
            cheprofButton.Size = new Size(156, 23);
            cheprofButton.TabIndex = 4;
            cheprofButton.Text = "Che Professore sei?";
            cheprofButton.UseVisualStyleBackColor = true;
            cheprofButton.Click += cheprofButton_Click;
            // 
            // statisticheButton
            // 
            statisticheButton.FlatStyle = FlatStyle.Popup;
            statisticheButton.ForeColor = SystemColors.ActiveCaptionText;
            statisticheButton.Location = new Point(6, 170);
            statisticheButton.Name = "statisticheButton";
            statisticheButton.Size = new Size(156, 23);
            statisticheButton.TabIndex = 3;
            statisticheButton.Text = "Statistiche";
            statisticheButton.UseVisualStyleBackColor = true;
            statisticheButton.Click += statisticheButton_Click;
            // 
            // valutaProfessoriButton
            // 
            valutaProfessoriButton.FlatStyle = FlatStyle.Popup;
            valutaProfessoriButton.ForeColor = SystemColors.ActiveCaptionText;
            valutaProfessoriButton.Location = new Point(6, 123);
            valutaProfessoriButton.Name = "valutaProfessoriButton";
            valutaProfessoriButton.Size = new Size(156, 23);
            valutaProfessoriButton.TabIndex = 2;
            valutaProfessoriButton.Text = "Valuta Professori";
            valutaProfessoriButton.UseVisualStyleBackColor = true;
            valutaProfessoriButton.Click += valutaProfessoriButton_Click;
            // 
            // valutamaterieButton
            // 
            valutamaterieButton.FlatStyle = FlatStyle.Popup;
            valutamaterieButton.ForeColor = SystemColors.ActiveCaptionText;
            valutamaterieButton.Location = new Point(6, 79);
            valutamaterieButton.Name = "valutamaterieButton";
            valutamaterieButton.Size = new Size(156, 23);
            valutamaterieButton.TabIndex = 1;
            valutamaterieButton.Text = "Valuta Materie";
            valutamaterieButton.UseVisualStyleBackColor = true;
            valutamaterieButton.Click += valutamaterieButton_Click;
            // 
            // homepageButton
            // 
            homepageButton.FlatStyle = FlatStyle.Popup;
            homepageButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            homepageButton.ForeColor = SystemColors.ActiveCaptionText;
            homepageButton.Location = new Point(6, 35);
            homepageButton.Name = "homepageButton";
            homepageButton.Size = new Size(156, 23);
            homepageButton.TabIndex = 0;
            homepageButton.Text = "HomePage";
            homepageButton.UseVisualStyleBackColor = true;
            homepageButton.Click += HomepageButton_Click;
            // 
            // panelDisplay
            // 
            panelDisplay.BackgroundImage = Properties.Resources.Screenshot_2023_03_15_09563822;
            panelDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            panelDisplay.Location = new Point(192, 6);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1051, 680);
            panelDisplay.TabIndex = 2;
            // 
            // welcomeUsername
            // 
            welcomeUsername.AutoSize = true;
            welcomeUsername.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeUsername.Location = new Point(12, 24);
            welcomeUsername.Name = "welcomeUsername";
            welcomeUsername.Size = new Size(57, 21);
            welcomeUsername.TabIndex = 3;
            welcomeUsername.Text = "label2";
            welcomeUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Location = new Point(22, 355);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(47, 15);
            logoutLabel.TabIndex = 4;
            logoutLabel.TabStop = true;
            logoutLabel.Text = "LogOut";
            logoutLabel.LinkClicked += logoutLabel_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1251, 695);
            Controls.Add(logoutLabel);
            Controls.Add(welcomeUsername);
            Controls.Add(panelDisplay);
            Controls.Add(menuBox);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += Exit_Click;
            Load += Home_Load;
            menuBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox menuBox;
        private Button cheprofButton;
        private Button statisticheButton;
        private Button valutaProfessoriButton;
        private Button valutamaterieButton;
        private Button homepageButton;
        private Panel panelDisplay;
        private Label welcomeUsername;
        private LinkLabel logoutLabel;
    }
}