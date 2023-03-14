namespace BierShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int voorraad {get; set; }
        public string Naam { get; set; }
        public string Brouwerij { get; set; }
        public string soort { get; set; }
        public string foto { get; set; }
        public string beschrijving { get; set; }
        public double Verkoopprijs { get; set; }
        public double Alcohol { get; set; }

    }
}
