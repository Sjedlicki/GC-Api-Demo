using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Models
{
    public class DonutResponse
    {
        public int Count { get; set; }
        public IEnumerable<Donut> Results { get; set; }
    }
}
