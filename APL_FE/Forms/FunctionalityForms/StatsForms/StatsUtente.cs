using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APL_FE.RestAPI;
using APL_FE.Models.Info;
using System.Collections;

namespace APL_FE.Forms.FunctionalityForms.StatsForms
{
    public partial class StatsUtente : Form
    {
        private StatisticheInfo[] statisticheInfo;
        private StatisticheProfessori[] professori;
        private readonly BEClient _beClient;

        public StatsUtente()
        {
            InitializeComponent();
            _beClient = new BEClient();
            MostraClassificaArgomenti();
            MostraClassificaProfessori();
        }

        private void MostraClassificaArgomenti()
        {
            statisticheInfo = _beClient.GetArgomentiUserStat();
            int x = 43;
            double media;
            if (statisticheInfo != null)
            {
                for (int i = 0; i < statisticheInfo.Length; i++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Location = new Point(12, x);
                    label.Size = new Size(38, 15);
                    label.TabIndex = 2;
                    label.Text = statisticheInfo[i].Materia;

                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Location = new Point(350, x);
                    label2.Size = new Size(38, 15);
                    label2.TabIndex = 2;
                    media = Math.Round(statisticheInfo[i].Media, 2);
                    label2.Text = media.ToString();

                    Controls.Add(label);
                    Controls.Add(label2);
                    x = x + 30;
                }
            } else
            {
                MessageBox.Show("Non sono presenti valutazioni degli argomenti nel DB");
            }
        }

        private void MostraClassificaProfessori()
        {
            professori = _beClient.GetProfUserStat();
            int x = 43;
            double media;
            if (professori != null)
            {
                for (int i = 0; i < professori.Length; i++)
                {
                    Label label3 = new Label();
                    label3.AutoSize = true;
                    label3.Location = new Point(433, x);
                    label3.Size = new Size(38, 15);
                    label3.TabIndex = 2;
                    label3.Text = professori[i].Professore;

                    Label label4 = new Label();
                    label4.AutoSize = true;
                    label4.Location = new Point(649, x);
                    label4.Size = new Size(38, 15);
                    label4.TabIndex = 2;
                    media = Math.Round(professori[i].Media, 2);
                    label4.Text = media.ToString();

                    Controls.Add(label3);
                    Controls.Add(label4);
                    x = x + 30;
                }
            } else
            {
                MessageBox.Show("Nessuna valutazione dei Professori nel DB");
            }
        }


    }
}
