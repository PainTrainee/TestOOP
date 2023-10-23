using P02_Constructor;

//var products = new Product();
var products = new Product("Banana");
products.GenerateProducts(100);
//products.Display();
//static สามารถเข้าหาได้โดยตรงผ่านคลาส
Product.Products.Add(new Product { Id = 1, Name = "Test", Price = 100, Amount = 100 });
Console.WriteLine(Product.Products.Count);