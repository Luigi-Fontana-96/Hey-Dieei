using APL_FE.Models;
using APL_FE.Models.Info;
using APL_FE.RestAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APL_FE.Forms.FunctionalityForms.QuestionForms
{

    public partial class DomandeProfessori : Form
    {
        public List<int> risposte = new List<int>();
        public string profSelezionato;

        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore. 
        public int num_domande = 6;
        public DomandeProfessori()
        {
            InitializeComponent();
            _beClient = new BEClient();
        }

        public void Prof(string professore)
        {
            ClearComboBox();
            risposte.Clear();

            profSelezionato = professore;
        }

        private void ClearComboBox()
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
            comboBox6.SelectedItem = null;
        }

        public void InviaRisposte()
        {
            List<ValProfessori> valProfessori = new List<ValProfessori>();
            //Qui avverrà la chiamata al metodo REST API
            for (int i = 0; i < num_domande; i++)
            {
                Console.WriteLine(profSelezionato);
                Console.WriteLine(risposte[i]);
                Console.WriteLine(Utente.utente.Username);

                var val = new ValProfessori
                {
                    Username = Utente.utente.Username,
                    Professore = profSelezionato,
                    Valutazione = (ushort)risposte[i],
                };

                valProfessori.Add(val);
            }

            bool invia = _beClient.PostValutazioniProfessori(valProfessori);

            if (invia)
            {
                MessageBox.Show("Form sottoscritto con successo!");
            }
            else
            {
                MessageBox.Show("Form non sottoscritto! Problemi con le REST oppure Questionario già sottoscritto");
            }
        }

        public void VerificaRisposte()
        {
            foreach (Control c in Controls)
            {
                if (c is ComboBox risp)
                {
                    if (risp.Text.Length > 0)
                    {
                        risposte.Add(int.Parse(risp.Text));
                    }
                }
            }
        }
    }
}
