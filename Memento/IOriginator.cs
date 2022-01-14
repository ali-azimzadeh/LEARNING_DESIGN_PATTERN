using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Memento
{
    public interface IOriginator
    {
        Memento CreateMemnto();
        void SetMemnto(Memento memnto);
    }
}
