using System;

namespace ClassesAndInterfaces.Task_4
{
   public enum KeyTypes
    {
        MetalKey,
        MagneticKey
    }

    public abstract class KeyBase : IKey
    {
        private KeyTypes mKeyType;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyBase"/> class.
        /// </summary>
        public KeyBase(KeyTypes keyType)
        {
            mKeyType = keyType;
        }

        /// <summary>
        /// Gets the type of the key.
        /// </summary>
        public KeyTypes KeyType
        {
            get
            {
                return mKeyType;
            }
        }

        /// <summary>
        /// Opens the door.
        /// </summary>
        public virtual void OpenTheDoor()
        {
            throw new NotImplementedException("Key is not found");
        }
    }
}
