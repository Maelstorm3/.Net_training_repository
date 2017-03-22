using System;

namespace ClassesAndInterfaces.Task_4
{
    public abstract class KeyBase : IKey
    {
        string _KeyType;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyBase"/> class.
        /// </summary>
        public KeyBase(string keyType)
        {
            _KeyType = keyType;
        }

        /// <summary>
        /// Gets the type of the key.
        /// </summary>
        public string KeyType
        {
            get
            {
                return _KeyType;
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
