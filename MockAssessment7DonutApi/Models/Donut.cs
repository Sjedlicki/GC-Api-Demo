namespace MockAssessment7DonutApi.Models
{
    public class Donuts
    {
        public int Count { get; set; }
        public Donut[] Results { get; set; }
    }

    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Photo { get; set; }
        public string[] Extras { get; set; }
    }
}
