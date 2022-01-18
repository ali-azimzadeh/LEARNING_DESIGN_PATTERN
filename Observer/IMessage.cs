using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Observer
{
    public interface IMessage
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
