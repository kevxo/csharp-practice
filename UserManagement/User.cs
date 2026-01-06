namespace UserManagement;

public class User
{
    public string name { get; set; } = string.Empty;
    public int age { get; set; }
    public List<string> hobbies { get; set; } = new List<string>();
}
    