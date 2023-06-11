using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APL_FE.Models;
using APL_FE.Models.Info;
using APL_FE.RestAPI;


namespace APL_FE
{
    public partial class HomePage : Form
    {
        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore. 
        public HomePage()
        {
            InitializeComponent();

            _beClient = new BEClient();
            LoadInfoUser();
        }

        public void LoadInfoUser()
        {
            //Chiamata Get a rest API che restituisce le info in base all'username
            UserInfo userInfo = new UserInfo();

            Console.WriteLine(Utente.utente.Username);
            userInfo = _beClient.GetUserInfobyUsername(Utente.utente.Username);

            usernameLabel.Text = userInfo.Username;
            nomeLabel.Text = userInfo.Nome;
            cognomeLabel.Text = userInfo.Cognome;
            matricolaLabel.Text = userInfo.Matricola;
            sessoLabel.Text = userInfo.Sesso;
            mailLabel.Text = userInfo.Email;
            dataNascitaLabel.Text = userInfo.DataNascita;   

        }
    }
}
