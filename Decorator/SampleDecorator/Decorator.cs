using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public abstract class Decorator : Control, IDecorator
    {
        #region IDecorator Members

        public abstract System.Windows.Forms.Control Control
        {
            get;
            set;
        }

        public abstract void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e);

        #endregion
    }
}
