using APL_FE.Forms.FunctionalityForms.QuestionForms;
using APL_FE.Models.Info;
using APL_FE.RestAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APL_FE.Forms.FunctionalityForms
{
    public partial class ValutaProfessori : Form
    {
        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore.
        private readonly DomandeProfessori domandeProfessori = new DomandeProfessori();
        private ProfessoriInfo[] professori;
        public ValutaProfessori()
        {
            InitializeComponent();
            _beClient = new BEClient();
            LoadProfessori();
        }
        private void LoadProfessori()
        {
            comboProfessori.Items.Clear();
            //Chiamata che recupera lista dei professori
            professori = _beClient.GetProfessori();

            for (int i = 0; i < professori.Length; i++)
            {
                comboProfessori.Items.Add(professori[i].Professore);
            }

        }


        private void OpenQuestion(object child)
        {
            if (child != null)
            {
                Form form = child as Form; //Child come tipo Form 
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                questionPanel.Controls.Add(form);
                questionPanel.Tag = form;
                form.Show();
                questionPanel.Show();
            }
        }

        private void LoadQuestion(string professore)
        {
            domandeProfessori.Prof(professore);
            OpenQuestion(domandeProfessori);
        }

        private void mostraButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboProfessori.Text))
            {
                MessageBox.Show("Seleziona Almeno uno!");
            }
            else
            {
                LoadQuestion(comboProfessori.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bottone di conferma
            //Lui deve inviare a Go le risposte che sono state date delle varie domande
            domandeProfessori.VerificaRisposte();

            if (domandeProfessori.risposte.Count < domandeProfessori.num_domande)
            {
                MessageBox.Show("Inserisci tutte le risposte!!!");
            }
            else if(domandeProfessori.profSelezionato.Equals(comboProfessori.Text))
            {
                domandeProfessori.InviaRisposte();
            }
            else
            {
                MessageBox.Show("ATTENZIONE! Non hai cliccato su Genera Questionario!");
            }
        }
    }


}
