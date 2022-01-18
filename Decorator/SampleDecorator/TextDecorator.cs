using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public class TextDecorator : Decorator
    {
        public TextDecorator(Control control,string text)
        {
            Control = control;

            CustomText = text;

            Control.Paint += OnPaint;
        }
        public override System.Windows.Forms.Control Control { get; set; }

        public string CustomText { get; set; }

        public override void OnPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen oPen = 
                new System.Drawing.Pen(System.Drawing.Color.Red);

            e.Graphics.DrawString
                (
                    CustomText,
                    new System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold),
                    System.Drawing.Brushes.Red,
                    10,
                    10
                );
        }
    }
}
