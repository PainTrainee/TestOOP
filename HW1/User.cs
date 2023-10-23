namespace HW1
{
    public class User
    {
        public Employee Employee { get; set; } = new Employee();
        public void Display(int number)
        {
            var IncomeData = Employee.Generate(number);
            //var e = new Employee();
            //var IncomeData = e.Generate(number);
            foreach (var data in IncomeData)
            {
                var income = data.Salary + data.Sale * data.Rate;
                var tax = income * 0.05;
                var net = income - tax;
                Console.WriteLine($"{data.Id,5} {data.Name,10} {Show(data.Salary),8} {Show(data.Sale),8} {Show(data.Rate),5} {Show(income),15} {Show(tax),15} {Show(net),15}");
            }
        }
        string Show(double number)
        {
            
            return number.ToString("#,###.##");
        }
    }
}
