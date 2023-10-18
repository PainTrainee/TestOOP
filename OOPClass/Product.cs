
namespace OOPClass
{
    public class Product //แม่แบบ แบบฟอร์ม
    {
        //attributes, property คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        //default method get set
        //get อ่านค่า
        //set ใส่ค่า
        //Lambda , Arrow function
        public void Display() => Console.WriteLine($"{Id} {Name} {Price.ToString("#,###.##")} {Amount}");
        public void Input(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Amount = product.Amount;
        }
        public List<Product> GenerateProduct(int number = 10)
        {
            var products = new List<Product>();
            Random rnd = new();
            for (int i = 1; i <= number; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = "Coffee" + i,
                    Price = rnd.NextDouble() * 990 + 10,
                    Amount = rnd.Next(1, 10)
                });
            }
            return products;
        }
    }
}
