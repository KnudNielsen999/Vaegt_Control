namespace Vaegt_Library.Vaegt_Library
{
    public class MaalsaetningModel
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public decimal? MaalVaegtKg { get; set; }
        public DateTime? MaalDato { get; set; }
        public TimeOnly? MaaltidsTidspunkt { get; set; }
        public int? VisceralFatMaal { get; set; }
        public decimal? BmiMaal { get; set; }
    }
}