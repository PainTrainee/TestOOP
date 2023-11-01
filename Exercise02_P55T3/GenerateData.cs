namespace Exercise02_P55T3
{
    internal class GenerateData
    {
        public List<Employee> Employees;
        public GenerateData(int number)
        {
            Employees = new List<Employee>();
            CreateEmployee(number);
        }
        public void CreateEmployee(int number)
        {
            Random rnd = new();
            for (int i = 0; i < number; i++)
            {
                Employees.Add(new Employee
                {
                    Id = i,
                    Section = rnd.Next(1, 6),
                    Age = rnd.Next(25, 61),
                }) ;
            }
        }
        public List<Employee> SortBySection() => Employees.OrderBy(p => p.Section).ToList();
        public dynamic GroupBySection() 
        {
            Employees = SortBySection();
            return Employees.GroupBy(p => p.Section).ToList(); 
        }
    }
}
