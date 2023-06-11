namespace APL_FE.Forms.FunctionalityForms
{
    partial class ValutaMaterie
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
            comboBoxMaterie = new ComboBox();
            confermaButton = new Button();
            questionPanel = new Panel();
            mostraButton = new Button();
            SuspendLayout();
            // 
            // comboBoxMaterie
            // 
            comboBoxMaterie.FormattingEnabled = true;
            comboBoxMaterie.Location = new Point(108, 32);
            comboBoxMaterie.Name = "comboBoxMaterie";
            comboBoxMaterie.Size = new Size(469, 23);
            comboBoxMaterie.TabIndex = 0;
            // 
            // confermaButton
            // 
            confermaButton.Location = new Point(933, 578);
            confermaButton.Name = "confermaButton";
            confermaButton.Size = new Size(75, 23);
            confermaButton.TabIndex = 3;
            confermaButton.Text = "Conferma";
            confermaButton.UseVisualStyleBackColor = true;
            confermaButton.Click += button1_Click;
            // 
            // questionPanel
            // 
            questionPanel.AutoScroll = true;
            questionPanel.BorderStyle = BorderStyle.Fixed3D;
            questionPanel.Location = new Point(9, 65);
            questionPanel.Name = "questionPanel";
            questionPanel.Size = new Size(1014, 498);
            questionPanel.TabIndex = 5;
            // 
            // mostraButton
            // 
            mostraButton.Location = new Point(583, 31);
            mostraButton.Name = "mostraButton";
            mostraButton.Size = new Size(120, 23);
            mostraButton.TabIndex = 6;
            mostraButton.Text = "Mostra Argomenti";
            mostraButton.UseVisualStyleBackColor = true;
            mostraButton.Click += mostraButton_Click;
            // 
            // ValutaMaterie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1035, 641);
            Controls.Add(mostraButton);
            Controls.Add(questionPanel);
            Controls.Add(confermaButton);
            Controls.Add(comboBoxMaterie);
            MaximizeBox = false;
            Name = "ValutaMaterie";
            Text = "Valuta Materie";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMaterie;
        private Button confermaButton;
        private Panel questionPanel;
        private Button mostraButton;
    }
}