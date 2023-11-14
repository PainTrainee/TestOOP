namespace P06_Interface
{
    internal interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }
}
