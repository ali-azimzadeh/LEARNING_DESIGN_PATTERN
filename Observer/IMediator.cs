using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Observer
{
    public interface IMediator
    {
        void NotifyObservers(IMessage message);
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
    }
}
