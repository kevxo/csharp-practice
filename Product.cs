using UserManagement;

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
