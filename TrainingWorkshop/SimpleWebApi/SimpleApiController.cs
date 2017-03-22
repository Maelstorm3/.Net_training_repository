using System.Collections.Generic;
using System.Web.Http;

namespace SimpleWebApi
{
    public class SimpleApiController : ApiController
    {
        IRepository _Repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleApiController"/> class.
        /// </summary>
        public SimpleApiController()
        {
            _Repository = new ProductsRepository();
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _Repository.GetProducts();
        }

        /// <summary>
        /// Posts the product.
        /// </summary>
        [HttpPost]
        public void PostProduct(Product product)
        {
            _Repository.PostProduct(product);
        }

        /// <summary>
        /// Deletes the product.
        /// </summary>
        [HttpDelete]
        public void DeleteProduct(Product product)
        {
            _Repository.DeleteProduct(product);
        }

    }
}
