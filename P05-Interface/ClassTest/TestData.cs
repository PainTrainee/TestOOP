using P05_Interface.InterfaceTest;

namespace P05_Interface.ClassTest
{
    internal class TestData : ITest
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }

        public void Display()
        {
            Console.WriteLine("Your Id is " + Id);
            Console.WriteLine("Your Name is " + Name);
        }

        public void Input()
        {
            Id = 2;
            Name = "foo";
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
    }
}
