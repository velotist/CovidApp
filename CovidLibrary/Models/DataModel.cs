namespace CovidApi.Models
{
    public class DataModel
    {
        public long Confirmed { get; set; }
        public long Recovered { get; set; }
        public long Deaths { get; set; }
        public string Country { get; set; }
    }
}