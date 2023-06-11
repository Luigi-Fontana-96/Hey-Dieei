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

namespace APL_FE.Forms.FunctionalityForms.QuestionForms
{
    public partial class DomandeMaterie : Form
    {
        public List<int> risposte = new List<int>();
        private ArgomentiInfo[] argomenti;
        
        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore. 
        public int num_argomenti;
        public DomandeMaterie()
        {
            InitializeComponent();
            _beClient = new BEClient();
        }

        public void GeneraForm(UInt32 IDMateria)
        {
            if (Controls.Count > 0)
            {
                foreach (Control contr in Controls)
                    contr.Dispose();

                Controls.Clear();
            }

            risposte.Clear();
            int x = 12;
            //Chiamata API per recuperare le domande della relativa materia 
            argomenti = _beClient.GetArgomenti(IDMateria);
            num_argomenti = argomenti.Length;
            

            //In base al numero di domande presenti generiamo il form
            for (int i = 0; i < argomenti.Length; i++)
            {
                ComboBox comboBox = new ComboBox();
                comboBox.FormattingEnabled = true;
                comboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
                comboBox.Location = new Point(810, x);
                comboBox.Name = "comboBox" + i;
                comboBox.Size = new Size(114, 23);
                comboBox.TabIndex = 3;

                RichTextBox richTextBox = new RichTextBox();
                richTextBox.Location = new Point(12, x);
                richTextBox.Name = "richTextBox" + i;
                richTextBox.Size = new Size(743, 33);
                richTextBox.TabIndex = 4;
                richTextBox.Text = argomenti[i].Nome;
                
                Controls.Add(comboBox);
                Controls.Add(richTextBox);
                x = x + 60;
            }
            
        }

        public void InviaRisposte()
        {
            List<ValArgomenti> valArgomenti = new List<ValArgomenti>();
            //Qui avverrà la chiamata al metodo REST API
            for (int i = 0; i < num_argomenti; i++)
            {
                
                Console.WriteLine(argomenti[i].ArgomentoID);
                Console.WriteLine(risposte[i]);
                Console.WriteLine(Utente.utente.Username);

                var val = new ValArgomenti
                {
                    Username = Utente.utente.Username,
                    Valutazione = (ushort)risposte[i],
                    ArgomentoID = argomenti[i].ArgomentoID
                };

                valArgomenti.Add(val);
            }

            bool invia = _beClient.PostValutazioniArgomenti(valArgomenti);

            if(invia)
            {
                MessageBox.Show("Form sottoscritto con successo!");

            }
            else
            {
                MessageBox.Show("Form non sottoscritto! Problemi alle API oppure Form già sottoscritto!");
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

//SQL request 
//CREATE TABLE VAL_ARGOMENTI (ID int AUTO_INCREMENT, username varchar(255), argomentoID int, valutazione int, PRIMARY KEY(ID));
