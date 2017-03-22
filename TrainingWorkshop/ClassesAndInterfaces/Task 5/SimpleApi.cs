using System.Linq;

namespace ClassesAndInterfaces.Task_5
{
    public static class SimpleApi
    {
        /// <summary>
        /// Deletes the specified product.
        /// </summary>
        public static void Delete(Product product)
        {
            if (product != null)
                Basket.ProductCollection.Remove(product);
        }

        /// <summary>
        /// Posts the specified product.
        /// </summary>
        public static void Post(Product product)
        {
            if (product != null)
                Basket.ProductCollection.Add(product);
        }

        /// <summary>
        /// Gets the total sum.
        /// </summary>
        public static int GetTotalSum()
        {
            int sum = 0;
            foreach (var product in Basket.ProductCollection.Where(p => p != null))
                sum += product.Cost;
            return sum;
        }
    }
}
