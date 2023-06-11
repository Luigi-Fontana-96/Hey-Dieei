using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class ArgomentiInfo
    {
        [JsonProperty("ArgomentoID")]
        public UInt16 ArgomentoID {  get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("MateriaID")]
        public UInt32 MateriaID { get; set; }   
    }
}
