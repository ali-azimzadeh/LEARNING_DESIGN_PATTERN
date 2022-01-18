using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Decorator.Philosophy
{
    public class MyDecorator : Object, IComponent
    {
        public IComponent Component { get; set; }

        public MyDecorator(IComponent component):base()
        {
            Component = component;
        }
        public string Operation()
        {
            string message = Component.Operation();

            message += " and drink a cup coffee";

            return message;
        }
    }
}
