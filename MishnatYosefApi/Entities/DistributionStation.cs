namespace MishnatYosefApi.Entities
{
    public class DistributionStation
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int CounFamily { get; set; }
        public DayOfWeek Day { get; set; }
        public DistributionStation(int id, string address, int counFamily, DayOfWeek day)
        {
            Id = id;
            Address = address;
            CounFamily = counFamily;
            Day = day;
        }
    }
}
