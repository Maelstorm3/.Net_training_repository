namespace ClassesAndInterfaces.Task_4
{
    public class MetalKey : KeyBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetalKey"/> class.
        /// </summary>
        /// <param name="keyType">Type of the key.</param>
        public MetalKey(string keyType)
            : base(keyType)
        {
        }

        /// <summary>
        /// Opens the door.
        /// </summary>
        public override void OpenTheDoor()
        {
            //do something
        }

    }
}
