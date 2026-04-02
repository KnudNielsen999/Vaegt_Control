namespace Vaegt_Library
{
    public class WeightEntry
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public DateTime Date { get; set; }
        public double WeightKg { get; set; }
        public int? VisceralFatRating { get; set; }
        public decimal? BMI { get; set; }
        public string? Note { get; set; }
    }
}
