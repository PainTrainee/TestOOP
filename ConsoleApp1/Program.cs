// See https://aka.ms/new-console-template for more information

//Global ใช้ทุกที่
string name = "Coffee";
string id = "11";
double price = 10;
double amount = 10;
double rate1 = 0.5;
Random rnd = new();
//เรียกใช้
//Input();
Display();
Update(ref id, ref name, ref price);
Display();

//void = no return value
void Display()
{
    Console.WriteLine($"ID : {id}");
    Console.WriteLine($"Name : {name}");
    Console.WriteLine($"Price : {price} Amount : {amount} Sum : {price * amount} Process : {Process(rate1)}");

}
void Input()
{
    Console.Write("ID : ");
    id = Console.ReadLine();
    Console.Write("Name : ");
    name = Console.ReadLine();
    Console.Write("Discount rate 0-1: ");
    rate1 = double.Parse(Console.ReadLine());
    price = rnd.Next(10, 100);
    amount = rnd.Next(1, 10);

}
double Process(double rate)
{
    //local เฉพาะที่
    var sum = price * amount;
    var result = sum - (sum * rate);
    return result;
}
//ref การส่งตัวแปรแบบอ้างอิง ชี้ตำแหน่งเดียวกันใน Memory
void Update(ref string Id, ref string Name, ref double Price)
{
    Id += "555";
    Name += "555";
    Price += 555;
}