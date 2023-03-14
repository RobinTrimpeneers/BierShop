using BierShop.Models;
using MySql.Data.MySqlClient;
namespace BierShop.Persistence
{
    public class PersistenceCode
    {
         PersistenceCode pc = new PersistenceCode();
         string connstring = "server=localhost;user id=root;password=Test123;database=dbcloud";

        //Load alle producten
        public List<Product> LoadProducten()
        {
            
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string qry = "select * from tblproducten";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dtr = cmd.ExecuteReader();
            List<Product> lijst = new List<Product>();
            while (dtr.Read())
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(dtr["ProductID"]);
                product.beschrijving = Convert.ToString(dtr["Beschrijving"]);
                product.Alcohol = Convert.ToInt32(dtr["Alcoholgehalte"]);
                product.Verkoopprijs = Convert.ToDouble(dtr["Verkoopprijs"]);
                product.Naam = Convert.ToString(dtr["Naam"]);
                product.Brouwerij = Convert.ToString(dtr["Brouwerij"]);
                product.foto = Convert.ToString(dtr["foto"]);
                product.soort = Convert.ToString(dtr["soort"]);
                product.voorraad = Convert.ToInt32(dtr["voorraad"]);
                lijst.Add(product);
            }
            conn.Close();
            return lijst;
        }
        

        //load 1 product
        public Product Load1Product(int ID)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string qry = "select * from tblproducten where id=" + ID;
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dtr = cmd.ExecuteReader();
            Product product = new Product();
            while (dtr.Read())
            {
                
                product.ProductID = Convert.ToInt32(dtr["ProductID"]);
                product.beschrijving = Convert.ToString(dtr["Beschrijving"]);
                product.Alcohol = Convert.ToInt32(dtr["Alcoholgehalte"]);
                product.Verkoopprijs = Convert.ToDouble(dtr["Verkoopprijs"]);
                product.Naam = Convert.ToString(dtr["Naam"]);
                product.Brouwerij = Convert.ToString(dtr["Brouwerij"]);
                product.foto = Convert.ToString(dtr["foto"]);
                product.soort = Convert.ToString(dtr["soort"]);
                product.voorraad = Convert.ToInt32(dtr["voorraad"]);
              
            }
            conn.Close();
            return product;
        }
        

        //Zet in winkelmand
        public void ZetInWinkelmand(Winkelmandje winkelmandje)
        {

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string qry = "insert into tblwinkelmandje (klantID, productID,Aantal)";

        }
    }
}
