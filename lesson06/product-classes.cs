
Product apple = new Product("Apple", 0.50m);
Product tv = new Product("TV", 100.00m);
apple.PrintLabel();
tv.PrintLabel();
tv.ApplyDiscount();
tv.PrintLabel();

class Product
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0.0m;
    public Product(string Name, decimal Price)
    {
        this.Name = Name;
        this.Price = Price;
    }

    public void PrintLabel()
    {
        Console.WriteLine($"{Name} : ${Price}");
    }

    public void ApplyDiscount()
    {
        Price = Price - (Price * 0.1m);
    }
}
