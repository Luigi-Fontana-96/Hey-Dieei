using APL_FE.Forms.FunctionalityForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APL_FE.Models;


namespace APL_FE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            welcomeUsername.Text = Utente.utente.Username;
        }

        private void Exit_Click(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You are trying to close the application", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("BRAVOOOOOOOOOOOOOOOOOOOOOOO");
            }
            Application.Exit();
        }

        private void OpenForm(object child)
        {
            if (panelDisplay.Controls.Count > 0)
            {
                foreach (Control contr in panelDisplay.Controls)
                    contr.Dispose();

                panelDisplay.Controls.Clear();
            }

            if (child != null)
            {
                Form form = child as Form; //Child come tipo Form 
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelDisplay.Controls.Add(form);
                panelDisplay.Tag = form;
                form.Show();
                panelDisplay.Show();
            }
        }

        private void HomepageButton_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            OpenForm(form);
        }

        private void valutamaterieButton_Click(object sender, EventArgs e)
        {
            ValutaMaterie form = new ValutaMaterie();
            OpenForm(form);
        }

        private void valutaProfessoriButton_Click(object sender, EventArgs e)
        {
            ValutaProfessori form = new ValutaProfessori();
            OpenForm(form);
        }

        private void statisticheButton_Click(object sender, EventArgs e)
        {
            Statistiche form = new Statistiche();
            OpenForm(form);
        }

        private void cheprofButton_Click(object sender, EventArgs e)
        {
            CheProf form = new CheProf();
            OpenForm(form);
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome welcome = new Welcome();
            MessageBox.Show(string.Format("GoodBye {0}", Utente.utente.Username));
            this.Hide();
            welcome.Show();
        }


    }
}
