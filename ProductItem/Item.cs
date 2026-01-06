namespace ProductItem;
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public async Task<string> printName()
    {
      Console.WriteLine("Printing name asynchronously...");  
      await Task.Delay(1000);

      return Name;  
    }
}