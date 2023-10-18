// See https://aka.ms/new-console-template for more information
using OOPClass;

////Object วัตถุ
//Product product = new Product();
//Product ton = new Product();
//Product Sumo = new Product();

//product.Name = "Coffee";
//product.Id = 1;
//product.Price = 10;
//product.Amount = 20;

//ton.Id = 2;
//ton.Name = "Pseudo-Brain";
//ton.Price = 20;
//ton.Amount = 20;
//product.Input(new Product { Id = 1, Name = "Coffee", Price = 10, Amount = 20 });
//ton.Input(new Product { Id = 2, Name = "Pseudo-Brain", Price = 20, Amount = 20 });

////Reuse ใช้ซ้ำ
//product.Display();
//ton.Display();
Random rnd = new Random();
//List ไม่จำกัดจำนวน
List<Product> product = new List<Product>();
for (int i = 1; i <= 10; i++)
{
    product.Add(new Product 
    { 
        Id = i, 
        Name = "Coffee"+i, 
        Price = rnd.NextDouble() * 990 + 10, 
        Amount = rnd.Next(1, 10)
    });
}
product.ForEach(p => p.Display());