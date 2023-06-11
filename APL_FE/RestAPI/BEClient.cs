using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net;
using System.Net.Cache;
using APL_FE.Models;
using APL_FE.Models.Info;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


//Con questa classe gestiamo le funzioni che verranno inoltrate a GO
namespace APL_FE.RestAPI
{
    public class BEClient
    {
        private readonly HttpClient _httpClient;

        public BEClient() 
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:8080");
        }

        #region USER
        //Verificare se sono presenti nel DB username e password
        public bool GetUsernamePassword(UserInfo utente)
        {
            bool verifica;

            verifica = PostLogin(_httpClient, utente);

            return verifica;
            
        }

        private static bool PostLogin(HttpClient httpClient, UserInfo utente)
        {
            bool success = false;
            try
            {
                var response = httpClient.PostAsJsonAsync("/user/login", utente).Result;
                
                if (response.IsSuccessStatusCode)
                {

                    Console.WriteLine("POST request successful!");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return success;
            }

            return success;
        }

        public bool PutUserDB(UserInfo utente)
        {
            bool verifica = PutUser(_httpClient, utente);
            return verifica;
        }

        private static bool PutUser(HttpClient httpClient, UserInfo utente)
        {
            bool success = false;
            try
            {
                var response = httpClient.PutAsJsonAsync("/user/signup", utente).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("PUT request successful!");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return success;
            }
            return success;
        }

        public UserInfo GetUserInfobyUsername(string username)
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("/user/" + username).Result;

                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);
               
                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                UserInfo userInfo = JsonConvert.DeserializeObject<UserInfo>(json);
                Console.WriteLine(userInfo);

                return userInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region VALUTA MATERIE
        //Funzioni di chiamata per la valutazione delle materie
        public MaterieInfo[] GetMaterie()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("/Materie").Result;
                Console.WriteLine("GET MATERIE SUCCESS");

                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                MaterieInfo[] materie = JsonConvert.DeserializeObject<MaterieInfo[]>(json);
                Console.WriteLine(materie);
                for (int i = 0; i < materie.Length; i++)
                {
                    Console.WriteLine(materie[i].NomeMateria);  
                }

                return materie;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public ArgomentiInfo[] GetArgomenti(UInt32 IDMateria)
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("/Argomenti/" + IDMateria).Result;
                Console.WriteLine("GET ARGOMENTI SUCCESS");

                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                ArgomentiInfo[] argomenti = JsonConvert.DeserializeObject<ArgomentiInfo[]>(json);
                Console.WriteLine(argomenti);
                for (int i = 0; i < argomenti.Length; i++)
                {
                    Console.WriteLine(argomenti[i].Nome);
                }

                return argomenti;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }
       public bool PostValutazioniArgomenti(List<ValArgomenti> valutazioni)
        {
            bool success = false;
            try
            {
                var response = _httpClient.PostAsJsonAsync("/Val_Argomenti", valutazioni).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("POST request successful!");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return success;
            }

            return success;
        }

        #endregion

        #region VALUTA PROFESSORI
        public ProfessoriInfo[] GetProfessori()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("/Professori").Result;
                Console.WriteLine("GET PROFESSORI SUCCESS");

                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                ProfessoriInfo[] professori = JsonConvert.DeserializeObject<ProfessoriInfo[]>(json);
                Console.WriteLine(professori);
                for (int i = 0; i < professori.Length; i++)
                {
                    Console.WriteLine(professori[i].Professore);
                }

                return professori;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public bool PostValutazioniProfessori(List<ValProfessori> valutazioni)
        {
            bool success = false;
            try
            {
                var response = _httpClient.PostAsJsonAsync("/Val_Professori", valutazioni).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("POST request successful!");
                    success = true;
                }
                else
                {
                    string res = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("Error: " + response.StatusCode);
                    Console.WriteLine(res);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return success;
            }

            return success;
        }

        #endregion

        #region STATISTICHE
        public StatisticheInfo[] GetArgomentiUserStat()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("Statistiche/argomenti/"+ Utente.utente.Username).Result;
               
                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                Console.WriteLine("GET STAT ARGOMENTI SUCCESS");
                StatisticheInfo[] argomentiStat = JsonConvert.DeserializeObject<StatisticheInfo[]>(json);
                Console.WriteLine(argomentiStat);

                return argomentiStat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public StatisticheProfessori[] GetProfUserStat()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("Statistiche/professori/"+Utente.utente.Username).Result;
               
                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                Console.WriteLine("GET STAT PROFESSORI SUCCESS");
                StatisticheProfessori[] professori = JsonConvert.DeserializeObject<StatisticheProfessori[]>(json);
                Console.WriteLine(professori);

                return professori;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public StatisticheInfo[] GetArgGeneralStat()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("Statistiche/argomenti").Result;
                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                Console.WriteLine("GET STAT ARGOMENTI SUCCESS");
                StatisticheInfo[] argomentiStat = JsonConvert.DeserializeObject<StatisticheInfo[]>(json);
                Console.WriteLine(argomentiStat);

                return argomentiStat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public StatisticheProfessori[] GetProfGeneralStat()
        {
            try
            {
                string json;
                var response = _httpClient.GetAsync("Statistiche/professori").Result;
                json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Generic error calling API");
                }
                Console.WriteLine("GET STAT PROFESSORI SUCCESS");
                StatisticheProfessori[] professori = JsonConvert.DeserializeObject<StatisticheProfessori[]>(json);
                Console.WriteLine(professori);

                return professori;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region CHE PROF
        public string SeiilProf(List<int> risposte)
        {
            string prof = string.Empty;
            try
            {
                var response = _httpClient.PostAsJsonAsync("/Cheprof", risposte).Result;

                string res = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(res);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("POST request successful!");
                    Console.WriteLine(res);
                    prof = res;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                    Console.WriteLine(res);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return prof;
            }

            return prof;
        }
        #endregion

    }
}
