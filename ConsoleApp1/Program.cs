// See https://aka.ms/new-console-template for more information

//Global ใช้ทุกที่
string Name = "Coffee";
string Id = "11";
double Price = 10;
double Amount = 10;
double rate1 = 0.5;
Random rnd = new();
//เรียกใช้
//Input();
//Display();
//Update(ref id, ref name, ref price);
//Display();

rate1 = Cal(out string id, out string name, out double price, out double amount);
Id = id;
Name = name;
Price = price;
Amount = amount;
Console.WriteLine($"{Id} {Name} {Price} {Amount}");
Display();
Console.WriteLine($"Summary = {Summary(1, 2, 3, 4, 5)}");
//void = no return value
void Display()
{
    Console.WriteLine($"ID : {Id}");
    Console.WriteLine($"Name : {Name}");
    Console.WriteLine($"Price : {Price} Amount : {Amount} Sum : {Price * Amount} Process : {Process(rate1)}");
}
void Input()
{
    Console.Write("ID : ");
    Id = Console.ReadLine();
    Console.Write("Name : ");
    Name = Console.ReadLine();
    Console.Write("Discount rate 0-1: ");
    rate1 = double.Parse(Console.ReadLine());
    Price = rnd.Next(10, 100);
    Amount = rnd.Next(1, 10);

}
double Process(double rate)
{
    //local เฉพาะที่
    var sum = Price * Amount;
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
//out พารามิเตอร์แบบส่งออกอย่างเดียว
double Cal(out string id,out string name, out double price, out double amount)
{
    id = "777";
    name = "Banana";
    price = 5;
    amount = 5;
    return 0.1;
}
//params การส่ง array หรือชุดของข้อมูลไปเป็นพารามิเตอร์
double Summary(params int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.Write(item + " ");
    }
    return numbers.Sum();
}