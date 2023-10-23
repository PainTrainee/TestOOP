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
        public List<Employee> Generate(int number = 1)
        {
            var data = new List<Employee>();
            Random rnd = new();
            for (int i = 0; i < number; i++)
            {
                data.Add(new Employee
                {
                    Id = i,
                    Name = "Employee" + i,
                    Salary = rnd.Next(10000, 100001),
                    Sale = rnd.Next(50_000, 100_001),
                    Rate = rnd.NextDouble() * 10
                }) ;
            }
            return data;
        }
    }
}
