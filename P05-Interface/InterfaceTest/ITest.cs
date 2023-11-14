namespace P05_Interface.InterfaceTest
{
    public interface ITest
    {
        //what
        int Id { get; set; }
        string Name { get; set; }
        void Input();
        void Output();
        void Display();
    }
}
