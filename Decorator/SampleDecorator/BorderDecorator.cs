using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public class BorderDecorator : Decorator
    {
        public override System.Windows.Forms.Control Control { get; set; }

        public BorderDecorator(System.Windows.Forms.Control control)
        {
            Control = control;

            Control.MouseLeave += Control_MouseLeave;

            Control.Paint += 
                new System.Windows.Forms.PaintEventHandler(OnPaint);

            Control.MouseEnter += Control_MouseEnter;

            Control.MouseMove += Control_MouseMove;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            System.Drawing.Graphics oGraphics = Control.CreateGraphics();

            oGraphics.DrawRectangle
                (
                    System.Drawing.Pens.Red,
                    e.X,
                    e.Y,
                    2,
                    2
                );
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control.BackColor = Color.Beige;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control.BackColor = Color.Khaki;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen oPen = 
                new System.Drawing.Pen(System.Drawing.Color.Red);

            e.Graphics
                .DrawRectangle(oPen, 0, 0, Control.Width - 1, Control.Height - 1);

            e.Graphics
                .DrawRectangle(oPen, 0, 0, Control.Width - 2, Control.Height - 2);

            e.Graphics
                .DrawRectangle(oPen, 0, 0, Control.Width - 3, Control.Height - 3);
        }

    
    }
}
