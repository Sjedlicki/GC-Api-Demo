namespace MockAssessment7DonutApi.Models
{
    public class HallOfFame
    {
        public Complete[] Complete { get; set; }
        public Tiny[] Tiny { get; set; }
    }

    public class Complete
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Innovation { get; set; }
        public int Year { get; set; }
    }

    public class Tiny
    {
        public string Name { get; set; }
        public string Invented { get; set; }
        public int Year { get; set; }
    }
}
