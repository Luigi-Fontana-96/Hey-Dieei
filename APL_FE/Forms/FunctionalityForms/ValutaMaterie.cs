using APL_FE.Forms.FunctionalityForms.QuestionForms;
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
    public partial class ValutaMaterie : Form
    {
        private readonly DomandeMaterie domandeMaterie = new DomandeMaterie();
        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore. 
        private MaterieInfo[] materie;
        private string materiaSelezionata;
        public ValutaMaterie()
        {
            InitializeComponent();
            _beClient = new BEClient();
            LoadMaterie();
        }

        private void LoadMaterie()
        {
            comboBoxMaterie.Items.Clear();

            //Chiamata che recupera lista delle materie
            materie = _beClient.GetMaterie();

            for (int i = 0; i < materie.Length; i++)
            {
                comboBoxMaterie.Items.Add(materie[i].NomeMateria);
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

        private void LoadQuestion(UInt32 IDMateria)
        {
            domandeMaterie.GeneraForm(IDMateria);
            OpenQuestion(domandeMaterie);
            
    }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bottone di conferma
            //Lui deve inviare a Go le risposte che sono state date delle varie domande
            domandeMaterie.VerificaRisposte();

            if (domandeMaterie.risposte.Count < domandeMaterie.num_argomenti)
            {
                MessageBox.Show("Inserisci tutte le risposte!!!");
            }
            else if (materiaSelezionata.Equals(comboBoxMaterie.Text))
            {
                domandeMaterie.InviaRisposte();
            }
            else
            {
                MessageBox.Show("ATTENZIONE! Non hai cliccato su Mostra Argomenti!");
            }

        }

        private void mostraButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMaterie.Text))
            {
                MessageBox.Show("Seleziona Almeno uno!");
            }
            else
            {
                for (int i = 0; i < materie.Length; i++)
                {
                    if (materie[i].NomeMateria.Equals(comboBoxMaterie.Text))
                    {
                        materiaSelezionata = materie[i].NomeMateria;
                        LoadQuestion(materie[i].MateriaID);
                    }
                }
            }

        }

    }
}
