using System.Collections.Generic;

namespace SimpleWebApi
{
    public class ProductsRepository : IRepository
    {
        List<Product> _Products;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsRepository"/> class.
        /// </summary>
        public ProductsRepository()
        {
            _Products = new List<Product>() {
                new Product() { Id=1, Name="1"},
                new Product() { Id=2, Name="2"}
            };
        }

        /// <summary>
        /// Deletes the product.
        /// </summary>
        public void DeleteProduct(Product product)
        {
            if (product != null)
                _Products.Remove(product);
        }

        /// <summary>
        /// Productses this instance.
        /// </summary>
        public List<Product> GetProducts()
        {
            return _Products;
        }

        /// <summary>
        /// Posts the product.
        /// </summary>
        public void PostProduct(Product product)
        {
            if (product != null)
                _Products.Add(product);
        }

    }
}
