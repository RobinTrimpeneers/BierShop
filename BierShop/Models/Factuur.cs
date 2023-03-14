namespace BierShop.Models
{
    public class Factuur
    {
        public int FactuurID { get; set; }
        public int KlantID { get; set; }
        public DateTime OrderDatum { get; set; }
    }
}
