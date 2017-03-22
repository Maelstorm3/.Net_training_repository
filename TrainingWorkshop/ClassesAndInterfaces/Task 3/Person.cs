using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.Task_3
{
    public class Person
    {
        List<Child> _Children = new List<Child>();

        /// <summary>
        /// Adds the child.
        /// </summary>
        public void AddChild(string name, int age)
        {
            _Children.Add(new Child() { Name = name, Age = age });
        }

        /// <summary>
        /// Gets the children count.
        /// </summary>
        public int GetChildrenCount()
        {
            return _Children.Count;
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
