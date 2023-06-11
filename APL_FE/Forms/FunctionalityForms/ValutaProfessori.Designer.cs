namespace APL_FE.Forms.FunctionalityForms
{
    partial class ValutaProfessori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValutaProfessori));
            questionPanel = new Panel();
            buttonConferma = new Button();
            comboProfessori = new ComboBox();
            mostraButton = new Button();
            SuspendLayout();
            // 
            // questionPanel
            // 
            questionPanel.AutoScroll = true;
            questionPanel.BorderStyle = BorderStyle.Fixed3D;
            questionPanel.Location = new Point(10, 63);
            questionPanel.Name = "questionPanel";
            questionPanel.Size = new Size(1014, 498);
            questionPanel.TabIndex = 10;
            // 
            // buttonConferma
            // 
            buttonConferma.Location = new Point(934, 576);
            buttonConferma.Name = "buttonConferma";
            buttonConferma.Size = new Size(75, 23);
            buttonConferma.TabIndex = 8;
            buttonConferma.Text = "Conferma";
            buttonConferma.UseVisualStyleBackColor = true;
            buttonConferma.Click += button1_Click;
            // 
            // comboProfessori
            // 
            comboProfessori.FormattingEnabled = true;
            comboProfessori.Location = new Point(90, 24);
            comboProfessori.Name = "comboProfessori";
            comboProfessori.Size = new Size(336, 23);
            comboProfessori.TabIndex = 6;
            // 
            // mostraButton
            // 
            mostraButton.Location = new Point(432, 23);
            mostraButton.Name = "mostraButton";
            mostraButton.Size = new Size(123, 23);
            mostraButton.TabIndex = 11;
            mostraButton.Text = "Mostra Questionario";
            mostraButton.UseVisualStyleBackColor = true;
            mostraButton.Click += mostraButton_Click;
            // 
            // ValutaProfessori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1035, 641);
            Controls.Add(mostraButton);
            Controls.Add(questionPanel);
            Controls.Add(buttonConferma);
            Controls.Add(comboProfessori);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ValutaProfessori";
            Text = "ValutaProfessori";
            ResumeLayout(false);
        }

        #endregion

        private Panel questionPanel;
        private Button buttonConferma;
        private ComboBox comboProfessori;
        private Button mostraButton;
    }
}