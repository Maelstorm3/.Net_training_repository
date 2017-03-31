using System.Collections.Generic;

namespace ClassesAndInterfaces.Task_5
{
    public class Basket
    {
        private List<Product> mProductCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Basket"/> class.
        /// </summary>
        public Basket()
        {
            mProductCollection = new List<Product>();
        }

        /// <summary>
        /// Gets or sets the product collection.
        /// </summary>
        public List<Product> ProductCollection
        {
            get
            {
                return mProductCollection;
            }
            set
            {
                mProductCollection = value;
            }
        }

    }
}
