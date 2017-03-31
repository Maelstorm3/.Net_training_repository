using System;
using System.Collections.Generic;

namespace SimpleWebApi
{
    public class ProductsRepository : IRepository
    {
        private List<Product> mProducts;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsRepository"/> class.
        /// </summary>
        public ProductsRepository()
        {
            mProducts = new List<Product>();
            Products = GetProducts();
        }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        public List<Product> Products
        {
            get
            {
                return mProducts;
            }
            set
            {
                mProducts = value;
            }
        }

        /// <summary>
        /// Deletes the product.
        /// </summary>
        public int DeleteProduct(Product product)
        {
            if (product != null)
            {
                var productId = product.Id;
                mProducts.Remove(product);
                return productId;
            }
            else
            {
                throw new Exception("Product is null");
            }
        }

        /// <summary>
        /// Productses this instance.
        /// </summary>
        public List<Product> GetProducts()
        {
            //get some data from somewhere
            return new List<Product>()
            {
                new Product() {Id=1, Name="1" },
                new Product() {Id=2, Name="2" }
            };
        }

        /// <summary>
        /// Posts the product.
        /// </summary>
        public int PostProduct(Product product)
        {
            if (product != null)
            {
                var productId = product.Id;
                mProducts.Add(product);
                return productId;
            }
            else
            {
                throw new Exception("New product is null");
            }
        }

    }
}
