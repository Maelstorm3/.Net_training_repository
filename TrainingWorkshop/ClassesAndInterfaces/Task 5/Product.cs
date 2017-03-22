namespace ClassesAndInterfaces.Task_5
{
    public class Product
    {
        string _Name;
        int _Id;
        int _Cost;

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product(int id)
        {
            _Id = id;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public int Id
        {
            get
            {
                return _Id;
            }
        }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        public int Cost
        {
            get
            {
                return _Cost;
            }
            set
            {
                _Cost = value;
            }
        }

    }
}
