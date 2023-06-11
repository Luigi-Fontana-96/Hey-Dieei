using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class ValProfessori
    {
        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Professore")]
        public string Professore { get; set; }

        [JsonProperty("Valutazione")]
        public UInt16 Valutazione { get; set; }
    }
}
