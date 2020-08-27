using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Models
{

    public class GrandCircus
    {
        public string Organization { get; set; }
        public Room[] Rooms { get; set; }
        public Ceo Ceo { get; set; }
        public Language[] Languages { get; set; }
    }

    public class Ceo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Room
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
        public Creator Creator { get; set; }
    }

    public class Creator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
