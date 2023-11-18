namespace P06_Interface
{
    //ออกแบบโครงสร้าง ง่ายในการตรวจสอบ
    //Add Edit Delete Search
    internal interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductByAny(int number, string keyword);
        void DeleteById(Product product);
        void UpdateProduct(Product newProduct,Product oldProduct);
        Product InputProduct(Product product);
    }
}