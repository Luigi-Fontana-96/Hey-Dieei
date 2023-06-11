using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class UserInfo
    {
        [JsonProperty("Nome")]
        public string Nome { get; set; }


        [JsonProperty("Cognome")] 
        public string Cognome { get; set; }


        [JsonProperty("Username")]
        public string Username { get; set; }


        [JsonProperty("Password")]
        public string Password { get; set; }


        [JsonProperty("Email")]
        public string Email { get; set; }


        [JsonProperty("Matricola")]
        public string Matricola { get; set; }


        [JsonProperty("Sesso")]
        public string Sesso { get; set; }


        [JsonProperty("DataNascita")]
        public string DataNascita{ get; set; }
    }
}


