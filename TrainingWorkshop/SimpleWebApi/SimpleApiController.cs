using System.Collections.Generic;
using System.Web.Http;

namespace SimpleWebApi
{
    public class SimpleApiController : ApiController
    {
        private IRepository mRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleApiController"/> class.
        /// </summary>
        public SimpleApiController()
        {
            mRepository = new ProductsRepository();
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        [HttpGet]
        public List<Product> GetProducts()
        {
            return mRepository.GetProducts();
        }

        /// <summary>
        /// Posts the product.
        /// </summary>
        [HttpPost]
        public void PostProduct(Product product)
        {
            mRepository.PostProduct(product);
        }

        /// <summary>
        /// Deletes the product.
        /// </summary>
        [HttpDelete]
        public void DeleteProduct(Product product)
        {
            mRepository.DeleteProduct(product);
        }

    }
}
