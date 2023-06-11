namespace APL_FE
{
    partial class HomePage
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            usernameLabel = new Label();
            nomeLabel = new Label();
            cognomeLabel = new Label();
            matricolaLabel = new Label();
            sessoLabel = new Label();
            groupBox1 = new GroupBox();
            mailLabel = new Label();
            dataNascitaLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(790, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 2;
            label1.Text = "HOME PAGE ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 3;
            label2.Text = "Riepilogo informazioni utente";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(6, 19);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(77, 22);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "label3";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.Location = new Point(6, 61);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(77, 22);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "label3";
            // 
            // cognomeLabel
            // 
            cognomeLabel.AutoSize = true;
            cognomeLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cognomeLabel.Location = new Point(155, 61);
            cognomeLabel.Name = "cognomeLabel";
            cognomeLabel.Size = new Size(77, 22);
            cognomeLabel.TabIndex = 6;
            cognomeLabel.Text = "label3";
            // 
            // matricolaLabel
            // 
            matricolaLabel.AutoSize = true;
            matricolaLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matricolaLabel.Location = new Point(6, 109);
            matricolaLabel.Name = "matricolaLabel";
            matricolaLabel.Size = new Size(77, 22);
            matricolaLabel.TabIndex = 7;
            matricolaLabel.Text = "label3";
            // 
            // sessoLabel
            // 
            sessoLabel.AutoSize = true;
            sessoLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sessoLabel.Location = new Point(6, 155);
            sessoLabel.Name = "sessoLabel";
            sessoLabel.Size = new Size(77, 22);
            sessoLabel.TabIndex = 8;
            sessoLabel.Text = "label3";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(dataNascitaLabel);
            groupBox1.Controls.Add(mailLabel);
            groupBox1.Controls.Add(usernameLabel);
            groupBox1.Controls.Add(sessoLabel);
            groupBox1.Controls.Add(nomeLabel);
            groupBox1.Controls.Add(matricolaLabel);
            groupBox1.Controls.Add(cognomeLabel);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(23, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 434);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info Utente";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mailLabel.Location = new Point(6, 204);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(77, 22);
            mailLabel.TabIndex = 9;
            mailLabel.Text = "label3";
            // 
            // dataNascitaLabel
            // 
            dataNascitaLabel.AutoSize = true;
            dataNascitaLabel.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascitaLabel.Location = new Point(6, 253);
            dataNascitaLabel.Name = "dataNascitaLabel";
            dataNascitaLabel.Size = new Size(77, 22);
            dataNascitaLabel.TabIndex = 10;
            dataNascitaLabel.Text = "label3";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1035, 641);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "HomePage";
            Text = "HomePage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label usernameLabel;
        private Label nomeLabel;
        private Label cognomeLabel;
        private Label matricolaLabel;
        private Label sessoLabel;
        private GroupBox groupBox1;
        private Label mailLabel;
        private Label dataNascitaLabel;
    }
}