using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class ValArgomenti
    {
        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("ArgomentoID")]
        public UInt32 ArgomentoID { get; set; }

        [JsonProperty("Valutazione")]
        public UInt16 Valutazione { get; set; } 
    }
}
