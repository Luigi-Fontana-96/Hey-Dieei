using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class ProfessoriInfo
    {
        [JsonProperty("ID")]
        public UInt16 ID { get; set; }

        [JsonProperty("Professore")]
        public string Professore { get; set; }

        [JsonProperty("MateriaID")]
        public UInt32 MateriaID { get; set; }

        [JsonProperty("NomeMateria")]
        public string NomeMateria { get; set; }
    }
}
