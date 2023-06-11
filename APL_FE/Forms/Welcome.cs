using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Text;
using APL_FE.RestAPI;
using APL_FE.Models;
using APL_FE.Models.Info;

namespace APL_FE
{
    public partial class Welcome : Form
    {
        private readonly BEClient _beClient; //Readonly in modo che il campo non possa puntare ad un altro valore. 
        public Welcome()
        {
            InitializeComponent();

            _beClient = new BEClient(); //Creazione del client per connettersi al backend
            HideSignupElement();
        }

        private void Login_click(object sender, EventArgs e)
        {
            string loginUser = usernametextBox.Text;
            string loginPassword = passwordtextBox.Text;

            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(loginPassword))
                MessageBox.Show("Please check the Username and Password fields");
            else
            {
                var utente = new UserInfo { Username = loginUser, Password = loginPassword };
                if (GetUserLogin(utente))
                {
                    Utente.utente = utente;
                    //Apertura del secondo form che poi sarà la Dashboard finale
                    Home home = new Home();
                    this.Hide();
                    home.Show();

                    MessageBox.Show(string.Format("Welcome {0}", loginUser));
                }
                else
                {
                    MessageBox.Show("Username and/or Password non trovati");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LinkSignup_Click(object sender, MouseEventArgs e)
        {
            ShowSignupElement();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string usernameSignup = usernameSignupBox.Text;
            string passwordSignup = passwordSignupBox.Text;
            string emailSignup = mailSignupBox.Text;
            string nameSignup = nameSignupBox.Text;
            string surnameSignup = cognomeSignupBox.Text;
            string sessoSignup = sessoBox.Text;
            string matricolaSignup = matricolaSignupBox.Text;
            string dataNascita = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(usernameSignup) || string.IsNullOrEmpty(passwordSignup) || string.IsNullOrEmpty(emailSignup) || string.IsNullOrEmpty(nameSignup)
                || string.IsNullOrEmpty(surnameSignup) || sessoBox.SelectedIndex == -1 || string.IsNullOrEmpty(matricolaSignup))
                MessageBox.Show("Please check that all fields are filled on the Sign up form");
            else if (dateTimePicker1.Value.Year > 2005)
            {
                MessageBox.Show("Probabilmente sei un po piccolo per essere all'università!");
            }
            else
            {
                var utente = new UserInfo
                {
                    Username = usernameSignup,
                    Password = passwordSignup,
                    Email = emailSignup,
                    Nome = nameSignup,
                    Cognome = surnameSignup,
                    Matricola = matricolaSignup,
                    DataNascita = dataNascita,
                    Sesso = sessoSignup
                };
                if (PutUser(utente))
                {
                    Utente.utente = utente;
                    Home ho = new Home();
                    this.Hide();
                    ho.Show();
                    MessageBox.Show(string.Format("Welcome {0}", usernameSignup));
                }
                else
                {
                    MessageBox.Show("Riprovare! Username e/o email già in uso!");
                }

            }
        }



        private void HideSignupElement()
        {
            signupLabel.Visible = false;
            nameSignup.Visible = false;
            cognomeSignup.Visible = false;
            usernameSignup.Visible = false;
            passwordSignup.Visible = false;
            nameSignupBox.Visible = false;
            cognomeSignupBox.Visible = false;
            usernameSignupBox.Visible = false;
            passwordSignupBox.Visible = false;
            sessoBox.Visible = false;
            dateTimePicker1.Visible = false;
            sessoSignup.Visible = false;
            dataSignup.Visible = false;
            buttonSignup.Visible = false;
            mailSignupBox.Visible = false;
            mailSignup.Visible = false;
            mostraCheckBox2.Visible = false;
            matricolaSignup.Visible = false;
            matricolaSignupBox.Visible = false;
        }

        private void ShowSignupElement()
        {
            signupLabel.Visible = true;
            nameSignup.Visible = true;
            cognomeSignup.Visible = true;
            usernameSignup.Visible = true;
            passwordSignup.Visible = true;
            nameSignupBox.Visible = true;
            cognomeSignupBox.Visible = true;
            usernameSignupBox.Visible = true;
            passwordSignupBox.Visible = true;
            sessoBox.Visible = true;
            dateTimePicker1.Visible = true;
            sessoSignup.Visible = true;
            dataSignup.Visible = true;
            buttonSignup.Visible = true;
            mailSignupBox.Visible = true;
            mailSignup.Visible = true;
            mostraCheckBox2.Visible = true;
            matricolaSignup.Visible = true;
            matricolaSignupBox.Visible = true;
        }

        private void mostraCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraCheckbox1.Checked)
            {
                passwordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void mostraCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraCheckBox2.Checked)
            {
                passwordSignupBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordSignupBox.UseSystemPasswordChar = true;
            }
        }

        private bool GetUserLogin(UserInfo utente)
        {
            //Chiamata alla funzione rest per il login
            bool userLogin = _beClient.GetUsernamePassword(utente);
            //bool userLogin = true;
            return userLogin;
        }

        private bool PutUser(UserInfo utente)
        {
            //Chiamatáalla funzione rest per il signup dell'utente
            bool putUser = _beClient.PutUserDB(utente);
            //bool putUser = true;
            return putUser;
        }

    }
}

