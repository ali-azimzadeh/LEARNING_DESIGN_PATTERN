using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public interface IDecorator
    {
        System.Windows.Forms.Control Control { get; set; }
        void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e);
    }
}
