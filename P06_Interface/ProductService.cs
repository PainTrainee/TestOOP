namespace P06_Interface
{
    public class ProductService
    {
        public ProductManagement ProductManagement { get; set; }
        public ProductService()
        {
            ProductManagement = new ProductManagement();
        }
        public void GenerateProduct(int number = 1)
        {
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                ProductManagement.AddProduct(new Product
                {
                    Id = i,
                    Name = "Coffee-" + i,
                    Type = rnd.Next(1,6),
                    Price = rnd.Next(10, 200)
                });
            }
        }
        public void DisplayProduct()
        {
            foreach (var item in ProductManagement.GetProducts())
            {
                Console.WriteLine($"{item.Id,5}{item.Name,10}{item.Type,5}{item.Price,10}");
            };
        }
        public List<Product> OrderByPrice()
        {
            var sort = ProductManagement.GetProducts().OrderBy(x => x.Price).ToList();
            return sort;
        }
        public List<TempGroup> GroupByPrice()
        {
            var temp = new List<TempGroup>();
            int tempGr;
            foreach (var item in ProductManagement.Products.OrderBy(p=>p.Price))
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ => 3,
                };
                temp.Add(new TempGroup { group = tempGr, groupType = item.Type });
            }
            return temp;
        }
        public void DisplayGroupByPrice()
        {
            var numOfGroup = GroupByPrice().GroupBy(p => p.group);
            foreach (var item in numOfGroup)
            {
                Console.WriteLine($"{NameOfPrice(item.Key)} {GroupByPrice().Count(p=>p.group == item.Key)}");
            }
        }
        public void DisplayPriceType()
        {
            var numOfGroup = GroupByPrice().GroupBy(p => p.group);
            Console.WriteLine($"Type{1,9}{2,5}{3,5}{4,5}{5,5}");
            foreach (var item in numOfGroup)
            {
                Console.Write($"{NameOfPrice(item.Key),8}");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{item.Count(x => x.groupType == i),5}");
                }
                Console.WriteLine();
            }
        }
        private string NameOfPrice(int price)
        {
            return price switch
            {
                1 => "10-100",
                2 => "101-200",
                _ => " ",
            };
        }
        public void SearchProduct()
        {
            Console.Write("Enter ID : ");
            var id = int.Parse(Console.ReadLine());
            var result = ProductManagement.GetProductById(id);
            if (result == null) { Console.WriteLine("Not Found"); }
            else { Console.WriteLine($"{result.Id,5} {result.Name,5} {result.Price,5} {result.Type,5}"); }
        }
    }
    public class TempGroup
    {
        public int group { get; set; }
        public int groupType { get; set; }
    }
    /*
        ประเภทสินค้า  1   2   3   4   5
        10-100
        101-200
    */
}
