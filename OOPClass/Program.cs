// See https://aka.ms/new-console-template for more information

using OOPClass;
//List ไม่จำกัดจำนวน
//var products = new Product();
//products.GenerateProduct(100).ForEach(product => product.Display());

//ข้อ 3 หน้า 2

var asdf = new CarSeller();
Console.Write("Enter number of employees to generate : ");
asdf.Generate(int.Parse(Console.ReadLine())).ForEach(x => x.Display());
