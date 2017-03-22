namespace ClassesAndInterfaces.Task_4
{
    public class MagneticKey : KeyBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticKey"/> class.
        /// </summary>
        /// <param name="keyType">Type of the key.</param>
        public MagneticKey(string keyType)
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
