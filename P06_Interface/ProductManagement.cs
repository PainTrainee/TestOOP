namespace P06_Interface
{
    public class ProductManagement : IProductManagement
    {
        public List<Product> Products { get; set; }
        public ProductManagement()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product GetProductById(int productId)
        {
            //alternative
            //Products.Where(p => p.Id == productId).FirstOrDefault();
            //Products.Find(p => p.Id.Equals(productId));
            return Products.FirstOrDefault(p => p.Id == productId);
        }

        public List<Product> GetProductByAny(int number = 0, string keyword = "")
        {
            if (String.IsNullOrEmpty(keyword)) keyword = "XXX";
            var result = Products.Where(p=>p.Name.ToUpper().Contains(keyword.ToUpper()) || 
            p.Id.Equals(number) ||
            p.Price > number ||
            p.Type.Equals(number)).ToList();
            return result;
        }

        public void DeleteById(Product product)
        {
            if (product == null) return;
            Products.Remove(product);
        }

        public void UpdateProduct(Product newProduct, Product oldProduct)
        {
            var index = Products.IndexOf(oldProduct);
            Products.Remove(oldProduct);
            Products.Insert(index, newProduct);
        }

        public Product InputProduct(Product product)
        {
            Console.WriteLine($"Product Id : {product.Id}");
            Console.Write("Input Name");
            product.Name = Console.ReadLine();
            Console.Write("Input Price");
            product.Price = int.Parse(Console.ReadLine());
            Console.Write("Input Type");
            product.Type = int.Parse(Console.ReadLine());
            return product;
        }
    }
}
