using UserManagement;
using ProductItem;

Console.WriteLine("Hello, World!");

List<int> numbers = [1, 2, 3];

foreach (var num in numbers)
{
    Console.WriteLine(num);
}

User user = new User();
user.name = "Alice";
user.age = 30;
user.hobbies = new List<string> { "Reading", "Hiking" };    

Console.WriteLine($"User: {user.name}, Age: {user.age}");

Item item = new Item(1, "Laptop", 999.99m);
Item item2 = new Item(2, "Mouse", 29.99m);
Item item3 = new Item(3, "Keyboard", 79.99m);
Item item4 = new Item(4, "Monitor", 299.99m);

List<Item> products = new List<Item> { item, item2, item3, item4 };

var expensiveProducts = products.Where(p=> p.Price > 100);

foreach (var product in expensiveProducts)
{
    Console.WriteLine(product.Name);
};

var mouse = products.FirstOrDefault(p=> p.Name == "Mouse");

Console.WriteLine(mouse != null ? $"Found product: {mouse.Name} at ${mouse.Price}" : "Product not found");

Console.WriteLine(await item.printName());
Console.WriteLine("LOOKS GOOD!");