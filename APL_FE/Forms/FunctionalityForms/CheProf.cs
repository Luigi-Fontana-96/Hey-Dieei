using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APL_FE.Models.Info;
using APL_FE.RestAPI;

namespace APL_FE.Forms.FunctionalityForms
{
    public partial class CheProf : Form
    {
        private List<string> domande = new List<string>();
        private List<int> risposte = new List<int>();
        private readonly BEClient _beClient;

        public CheProf()
        {
            InitializeComponent();
            _beClient = new BEClient();
            HideComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel.Visible = false;
            ShowComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            domande.Add(textBox1.Text);
            domande.Add(textBox2.Text);
            domande.Add(textBox3.Text);
            domande.Add(textBox4.Text);
            domande.Add(textBox5.Text);
            domande.Add(textBox6.Text);
            domande.Add(textBox7.Text);
            domande.Add(textBox8.Text);
            domande.Add(textBox9.Text);
            domande.Add(textBox10.Text);
            domande.Add(textBox11.Text);
            domande.Add(textBox12.Text);

            VerificaComboBox();

            if (risposte.Count < 12)
            {
                MessageBox.Show("BRO RIEMPI TUTTO");
                Console.WriteLine(risposte.Count);
            } 
            else
            {
                label2.Visible = true;
                risultatoLabel.Visible = true;

                string professore = SendResponse(risposte);
                Console.WriteLine(professore);

                profLabel.Visible = true;
                profLabel.Text = professore;

            }
        }

        private string SendResponse(List<int> risposte)
        {
            //string prof = "Professore TESTA";

            //Console.WriteLine(prof);

            string prof = _beClient.SeiilProf(risposte);
            for(int i = 0; i<12; i++)
            {
                Console.WriteLine(risposte[i]);
            }

            return prof;
        }

        private void VerificaComboBox()
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

        private void HideComponent()
        {
            risultatoLabel.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            profLabel.Visible = false;
            label2.Visible = false;
            
        }

        private void ShowComponent()
        {
            risultatoLabel.Visible = true;
            button1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
            comboBox10.Visible = true;
            comboBox11.Visible = true;
            comboBox12.Visible = true;
            button1.Visible = true;

        }
    }
}
