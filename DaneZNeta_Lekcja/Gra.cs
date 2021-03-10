namespace DaneZNeta_Lekcja
{
    public class Gra
    {
        private string _title;
        private string _salePrice;
        private string _normalPrice;
        private string _streamRatingText;

        public string title { get => _title; set => _title = value; }
        public string salePrice { get => _salePrice; set => _salePrice = value; }
        public string normalPrice { get => _normalPrice; set => _normalPrice = value; }
        public string steamRatingText { get => _streamRatingText; set => _streamRatingText = value; }

        public override string ToString()
        {
            return $"{title} {salePrice}$ {normalPrice}$ {steamRatingText}";
        }
    }
}