namespace MVC_3.Models
{
    public class Prodotti
    {
        public int IdProdotto { get; set; }
        public string NomeProdotto { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string ImgCop { get; set; }
        public string ImgAgg { get; set; }
        public bool IsVisible { get; set; }

    }
}