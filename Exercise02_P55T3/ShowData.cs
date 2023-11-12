namespace Exercise02_P55T3
{
    internal class ShowData
    {
        public GenerateData GenerateData { get; set; }
        public ShowData()
        {
            GenerateData = new GenerateData(25);
        }
        public void Display()
        {
            foreach (var emp in GenerateData.SortBySection())
            {
                Console.WriteLine($"{emp.Section,3} {SectionText(emp.Section),-15} {emp.Id} {emp.Age,3}");
            }
        }
        public void DisplayBySectionGroup()
        {
            foreach (var group in GenerateData.GroupBySection())
            {
                Console.WriteLine(SectionText(group.Key));
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Section,3} {SectionText(emp.Section),-15} {emp.Id} {emp.Age,3}");
                }
            }
        }
        public void DisplaySectionAge()
        {
            Console.WriteLine("\t\tSection");
            Console.WriteLine($"AgeRange {SectionText(1),-8}{SectionText(2),-10}{SectionText(3),-5}{SectionText(4),-10}{SectionText(5),-8}");
            string[] yearrange = { "25-30" ,"31-40","41-50","51-60"};
            foreach (var range in yearrange) //year 
            {
                int[] agerange = { int.Parse(range.Split("-")[0]), int.Parse(range.Split("-")[1]) };
                Console.Write($"{range,-5}");
                foreach (var group in GenerateData.GroupBySection()) //section group
                {
                    int index = 0;
                    foreach (var item in group) //member
                    {
                        if (item.Age >= agerange[0] && item.Age <= agerange[1])
                        {
                            index++; 
                        }
                    }
                    Console.Write($"{index,8}");
                }
                Console.WriteLine();
            }
        }
        public string SectionText(int section)
        {
            string text = null;
            switch (section)
            {
                case 1: text = "Account"; break;
                case 2: text = "Person"; break;
                case 3: text = "IT"; break;
                case 4: text = "Marketing"; break;
                case 5: text = "Sale"; break;
                case 6: text = "Section6"; break;
            }
            return text;
        }
        public void DisplayByGroupAge()
        {
            foreach (var group in GenerateData.GroupByAge())
            {
                Console.Write($"{NameOfAge(group.Key),5}");
                for (int i = 1; i < 5; i++)
                {
                    Console.Write($"{group.Count(p => p.Section == i),5}");
                }
                Console.WriteLine();
            }
        }
        public string NameOfAge(int age)
        {
            string text = null;
            switch (age)
            {
                case 1: text = "25-30"; break;
                case 2: text = "31-40"; break;
                case 3: text = "41-50"; break;
                case 4: text = "51-60"; break;
            }
            return text;
        }
    }
}