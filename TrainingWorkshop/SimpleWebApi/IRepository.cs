using System.Collections.Generic;

namespace SimpleWebApi
{
    public interface IRepository
    {
        List<Product> GetProducts();
        void DeleteProduct(Product product);
        void PostProduct(Product product);
    }
}
