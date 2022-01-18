using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Observer
{
    public interface IObserver
    {
        void Update(IMessage message);
    }
}
