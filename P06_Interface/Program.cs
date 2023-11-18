using P06_Interface;

var ps = new ProductService();
ps.GenerateProduct(20);
ps.DisplayProduct();
//ps.DisplayPriceType();
//ps.SearchProduct();
ps.SearchByAny();