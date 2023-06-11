using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class MaterieInfo
    {
        [JsonProperty("ID")]
        public UInt16 ID { get; set; }

        [JsonProperty("MateriaID")]
        public UInt32 MateriaID { get; set; }

        [JsonProperty("NomeMateria")]
        public string NomeMateria { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}
