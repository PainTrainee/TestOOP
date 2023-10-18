
namespace OOPClass
{
    public class Product //แม่แบบ แบบฟอร์ม
    {
        //attributes, property คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        //default method get set
        //get อ่านค่า
        //set ใส่ค่า
        //Lambda , Arrow function
        public void Display() => Console.WriteLine($"{Id} {Name} {Price} {Amount}");
    }
}
