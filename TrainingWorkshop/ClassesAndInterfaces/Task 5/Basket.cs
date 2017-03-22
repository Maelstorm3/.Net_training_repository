using System.Collections.Generic;

namespace ClassesAndInterfaces.Task_5
{
    public static class Basket
    {
        static List<Product> _ProductCollection;

        static Basket()
        {
            _ProductCollection = new List<Product>();
        }

        /// <summary>
        /// Gets or sets the product collection.
        /// </summary>
        public static List<Product> ProductCollection
        {
            get
            {
                return _ProductCollection;
            }
            set
            {
                _ProductCollection = value;
            }
        }

    }
}
