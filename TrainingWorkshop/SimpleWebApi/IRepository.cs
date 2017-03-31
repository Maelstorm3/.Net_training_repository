using System.Collections.Generic;

namespace SimpleWebApi
{
    public interface IRepository
    {
        List<Product> GetProducts();
        int DeleteProduct(Product product);
        int PostProduct(Product product);
    }
}
