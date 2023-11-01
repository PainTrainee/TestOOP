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
    }
}
