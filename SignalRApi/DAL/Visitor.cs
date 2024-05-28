namespace SignalRApi.DAL
{
    public enum ECity
    {
        Londra = 1,
        Berlin = 2,
        Köln = 3,
        Istanbul = 4,
        Frankfurt = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
