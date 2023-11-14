using P05_Interface.InterfaceTest;

namespace P05_Interface.ClassTest
{
    //how
    public class CTest : ITest
    {
        public int Id { get; set; }

        public string Name { get ; set ; }
        public CTest()
        {
            Input();
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name}");
        }

        public void Input()
        {
            Id = 1;
            Name = "aaa";
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
    }
}
