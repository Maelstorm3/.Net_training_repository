namespace ClassesAndInterfaces.Task_2
{
    public class TypeExamplesCounter
    {
        private static int mCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeExamplesCounter"/> class.
        /// </summary>
        public TypeExamplesCounter()
        {
            mCount++;
        }

        /// <summary>
        /// Gets the count of examples.
        /// </summary>
        public static int Count
        {
            get
            {
                return mCount;
            }
        }
    }
}
