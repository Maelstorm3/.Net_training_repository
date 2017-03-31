using System.Linq;
using System;
using System.Collections.Generic;

namespace ClassesAndInterfaces.Task_5
{
    public class SimpleApi
    {
        private Basket mBasket;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleApi"/> class.
        /// </summary>
        public SimpleApi(Basket basket)
        {
            mBasket = basket;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        public IEnumerable<Product> Get()
        {
            return mBasket.ProductCollection;
        }

        /// <summary>
        /// Deletes the specified product.
        /// </summary>
        public int Delete(Product product)
        {
            if(product!=null)
            {
                var productId = product.Id;
                mBasket.ProductCollection.Remove(product);
                return productId;
            }
            else
            {
                throw new Exception("Product is null");
            }
        }

        /// <summary>
        /// Posts the specified product.
        /// </summary>
        public int Post(Product product)
        {
            if (product != null)
            {
                var productId = product.Id;
                mBasket.ProductCollection.Add(product);
                return productId;
            }
            else
            {
                throw new Exception("New product is null");
            }
        }

        /// <summary>
        /// Gets the total sum.
        /// </summary>
        public int GetTotalSum()
        {
            int sum = default(int);
            foreach (var product in mBasket.ProductCollection.Where(p => p != null))
            {
                sum += product.Cost;
            }
            return sum;
        }
    }
}
