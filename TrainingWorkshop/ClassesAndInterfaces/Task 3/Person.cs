using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.Task_3
{
    public class Person
    {
        private List<Child> mChildren;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            mChildren = new List<Child>();
        }

        /// <summary>
        /// Adds the child.
        /// </summary>
        public void AddChild(string name, int age)
        {
            mChildren.Add(new Child() { Name = name, Age = age });
        }

        /// <summary>
        /// Gets the children count.
        /// </summary>
        public int GetChildrenCount()
        {
            return mChildren.Count;
        }

        class Child
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the age.
            /// </summary>
            public int Age { get; set; }
        }

    }
}
