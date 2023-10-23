namespace HW1
{
    public class Employee
    {
        //properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Sale { get; set; }
        public double Rate { get; set; }
        //method
        List<Employee> Generate(int number = 1)
        {
            var data = new List<Employee>();
            Random rnd = new();
            for (int i = 0; i < number; i++)
            {
                data.Add(new Employee
                {
                    Id = i,
                    Name = "Employee" + i,
                    Salary = rnd.Next(10000, 1000001),
                    Sale = rnd.Next(500_000, 1000_001),
                    Rate = rnd.NextDouble() * 10
                }) ;
            }
            return data;
        }
        public void Display(int number)
        {
            var IncomeData = Generate(number);
            foreach (var data in IncomeData)
            {
                var income = data.Salary + data.Sale * data.Rate;
                var tax = income * 0.05;
                var net = income - tax;
                Console.WriteLine($"{data.Id} {data.Name} {data.Salary} {data.Sale} {data.Rate} {income} {tax} {net}");
            }
        }
    }
}
