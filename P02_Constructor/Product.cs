namespace P02_Constructor
{
    public class Product
    {
        //Constructor ชื่อเดียวกับคลาส
        //default when initialize an object
        public Product()
        {
            Console.WriteLine("Hello, Constructor");
        }
        public Product(int number)
        {
            Console.WriteLine(number);
        }
        public Product(int number, string name)
        {
            Console.WriteLine($"{number} {name}");
        }
        public void Productaaa()
        {

        }
    }
}
