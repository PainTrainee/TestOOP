using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P02_Constructor
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        static public int Test {  get; set; }
        //Constructor ชื่อเดียวกับคลาส
        //default when initialize an object
        public Product()
        {
            //Products = new List<Product>();
        }
        public Product(int number)
        {
            Console.WriteLine(number);
        }
        public Product(string Name)
        {
            Products = new List<Product>();
            //this คือ ระบุว่าเป็น properties ภายในคลาส
            this.Name = Name;
        }
        //static การมีอยู่ การฝัง
        static public List<Product> Products { get; set; } = new List<Product>();
        public void GenerateProducts(int number = 1)
        {
            Random rnd = new();
            for (int i = 1; i <= number; i++)
            {
                Products.Add(new Product
                {
                    Id = i,
                    Name = Name + i,
                    Price = rnd.NextDouble() * 990 + 10,
                    Amount = rnd.Next(10, 5000)
                });
            }
        }
        public void Display() 
        {
            Products.ForEach(p => Console.WriteLine($"{p.Id} {p.Name} {p.Price:N2} {p.Amount}"));
        }

    }
}
