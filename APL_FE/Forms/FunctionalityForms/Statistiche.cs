using APL_FE.Forms.FunctionalityForms.StatsForms;
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
using APL_FE.Models.Info;
using APL_FE.RestAPI;

namespace APL_FE.Forms.FunctionalityForms
{
    public partial class Statistiche : Form
    {
        public Statistiche()
        {
            InitializeComponent();
        }
        private void OpenStats(object child)
        {
            if (statsPanel.Controls.Count > 0)
            {
                foreach (Control contr in statsPanel.Controls)
                    contr.Dispose();

                statsPanel.Controls.Clear();
            }

            if (child != null)
            {
                Form form = child as Form; //Child come tipo Form 
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                statsPanel.Controls.Add(form);
                statsPanel.Tag = form;
                form.Show();
                statsPanel.Show();

            }
        }

        private void FormStatUtente(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StatsUtente stat = new StatsUtente();
            OpenStats(stat);
        }

        private void FormStatGen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generali generali = new Generali();
            OpenStats(generali);
        }
    }
}
