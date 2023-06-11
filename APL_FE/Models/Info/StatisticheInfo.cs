using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_FE.Models.Info
{
    [Serializable]
    public class StatisticheInfo
    {
        [JsonProperty("Materia")]
        public string Materia { get; set; }

        [JsonProperty("Media")]
        public float Media { get; set; }
    }

    [Serializable]
    public class StatisticheProfessori
    {
        [JsonProperty("Professore")]
        public string Professore { get; set; }

        [JsonProperty("Media")]
        public float Media { get; set; }
    }
}
