// See https://aka.ms/new-console-template for more information
using OOPClass;
//List ไม่จำกัดจำนวน
var products = new Product();
products.GenerateProduct(100).ForEach(product => product.Display());
