namespace P06_Interface
{
    //ออกแบบโครงสร้าง ง่ายในการตรวจสอบ
    internal interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }
}
