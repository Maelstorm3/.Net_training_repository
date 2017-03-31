namespace ClassesAndInterfaces.Task_5
{
    public class Product
    {
        private string mName;
        private int mId;
        private int mCost;

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product(int id)
        {
            mId = id;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public int Id
        {
            get
            {
                return mId;
            }
        }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        public int Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }

    }
}
