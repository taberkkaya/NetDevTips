namespace RequiredMember;

internal class Program
{
    static void Main(string[] args)
    {
        //Product product = new();
        //Product product = new("Test");
        Product product = new() { Name = "Test" };
    }

    public class Product
    {
        //public Product(string Name)
        //{
        //    Name = Name;
        //}
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
