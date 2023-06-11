namespace APL_FE.Forms.FunctionalityForms
{
    partial class Statistiche
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
            textBox1 = new TextBox();
            statsPanel = new Panel();
            linkStats1 = new LinkLabel();
            linkStats2 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Statistiche";
            // 
            // statsPanel
            // 
            statsPanel.BackColor = SystemColors.Control;
            statsPanel.BorderStyle = BorderStyle.Fixed3D;
            statsPanel.Location = new Point(147, 14);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(875, 614);
            statsPanel.TabIndex = 1;
            // 
            // linkStats1
            // 
            linkStats1.AutoSize = true;
            linkStats1.Location = new Point(12, 75);
            linkStats1.Name = "linkStats1";
            linkStats1.Size = new Size(99, 15);
            linkStats1.TabIndex = 2;
            linkStats1.TabStop = true;
            linkStats1.Text = "Statistiche Utente";
            linkStats1.VisitedLinkColor = Color.Blue;
            linkStats1.LinkClicked += FormStatUtente;
            // 
            // linkStats2
            // 
            linkStats2.AutoSize = true;
            linkStats2.Location = new Point(12, 111);
            linkStats2.Name = "linkStats2";
            linkStats2.Size = new Size(107, 15);
            linkStats2.TabIndex = 3;
            linkStats2.TabStop = true;
            linkStats2.Text = "Statistiche Generali";
            linkStats2.VisitedLinkColor = Color.Blue;
            linkStats2.LinkClicked += FormStatGen;
            // 
            // Statistiche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1035, 641);
            Controls.Add(linkStats2);
            Controls.Add(linkStats1);
            Controls.Add(statsPanel);
            Controls.Add(textBox1);
            Name = "Statistiche";
            Text = "Statistiche";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel statsPanel;
        private LinkLabel linkStats1;
        private LinkLabel linkStats2;
    }
}