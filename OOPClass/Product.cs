
namespace OOPClass
{
    public class CarSeller
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Topsale { get; set; }
        public double Rate { get; set; }
        public List<CarSeller> Generate(int number)
        {
            var products = new List<CarSeller>();
            Random rnd = new();
            for (int i = 1; i <= number; i++)
            {
                products.Add(new CarSeller
                {
                    Id = i.ToString(),
                    Name = "Employee" + i,
                    Salary = rnd.NextDouble() * 990 + 10,
                    Topsale = rnd.Next(10, 5000),
                    Rate = rnd.NextDouble()
                });
            }
            return products;
        }
        public void Display() => Console.WriteLine($"{Id} {Name} {Salary.ToString("#,###.##")} {Topsale} {Rate.ToString("#,###.##")} {((Salary + (Topsale * Rate)) - ((Salary + (Topsale * Rate)) * 0.05)):#,###.##}");
    }
}
