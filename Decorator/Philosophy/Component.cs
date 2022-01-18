using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Decorator.Philosophy
{
    public class Component : object, IComponent
    {
        public Component() : base()
        {
        }

        public string Operation()
        {
            return ("I am developing... ");
        }
    }
}
