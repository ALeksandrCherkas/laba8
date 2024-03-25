namespace laba8.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateOnly Date { get; set; }
        public ProductsModel(int id, string name, int price, DateOnly date)
        {
            Id = id;
            Name = name;
            Price = price;
            Date = date;
        }
    }

}
