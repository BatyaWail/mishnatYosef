using MishnatYosefApi.Entities;

namespace MishnatYosefApi
{
    public class DataContext
    {
        public List<Client> clients { get; set; }
        public List<DistributionStation> distributionStations { get; set; }
        public List<Product> products { get; set; }
        public DataContext()
        {
            clients = new List<Client>()
        {
            new Client(0,"batya wail","0504119712","breslev 18 bney brak"),
            new Client(1,"yeudit cohen","0504116146","chagai 3 bney brak"),
            new Client(2,"batya","0504119785","ezra 5 bney brak"),
            new Client(3,"wais yosi","035702504","tifrach")
        };
            distributionStations = new List<DistributionStation>()
        {
            new DistributionStation(0,"breslev 11-9 bb",30,DayOfWeek.Tuesday),
            new DistributionStation(1,"tifrach",10,DayOfWeek.Saturday),
            new DistributionStation(2,"AAAA",40,DayOfWeek.Monday),
        };
            products = new List<Product>()
        {
            new Product(0,"oil","A",4.5),
            new Product(1,"chocolat","B",6),
            new Product(2,"eges","A",25)
        };
        }
    }
}
