namespace ClassesAndInterfaces.Task_2
{
    public class AbleToCountTypeExamplesClass
    {
        static int _CountOfExamples;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbleToCountTypeExamplesClass"/> class.
        /// </summary>
        public AbleToCountTypeExamplesClass()
        {
            _CountOfExamples++;
        }

        /// <summary>
        /// Gets the count of examples.
        /// </summary>
        public static int CountOfExamples
        {
            get
            {
                return _CountOfExamples;
            }
        }
    }
}
