// See https://aka.ms/new-console-template for more information

//Global ใช้ทุกที่
string name = "";
string id = "";
double price = 0;
double amount = 0;
double rate1 = 0;
Random rnd = new();
//เรียกใช้
Input();
Display();

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
