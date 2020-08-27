using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Models
{
    [DataContract]
    public class Planet
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "colors")]
        public string[] Colors { get; set; }

        [DataMember(Name = "million-miles-from-sun")]
        public Distance MillionMilesFromSun { get; set; }
    }

    public class Distance
    {
        public int Min { get; set; }
        public int Average { get; set; }
        public int Max { get; set; }
    }
}
