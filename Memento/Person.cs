using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Memento
{
    [Serializable]
    public class Person : object
    {
        public Person() : base()
        {
        }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
