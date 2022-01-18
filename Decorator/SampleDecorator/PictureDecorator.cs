using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public class PictureDecorator : Decorator
    {
        public System.Drawing.Image Image { get; set; }
        public System.Drawing.Point ImageLocation { get; set; }
        public System.Drawing.Size ImageSize { get; set; }

        public PictureDecorator(System.Windows.Forms.Control control,
            System.Drawing.Image image, 
            System.Drawing.Point imageLocation, 
            System.Drawing.Size imageSize)
        {
            Control = control;
            Image = image;
            ImageLocation = imageLocation;
            ImageSize = imageSize;

            Control.Paint += 
                new System.Windows.Forms.PaintEventHandler(OnPaint);
        }

        public override System.Windows.Forms.Control Control { get; set; }

        public override void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Pen oPen = 
                new System.Drawing.Pen(System.Drawing.Color.Red);


            System.Drawing.Rectangle rectangle = 
                new System.Drawing.Rectangle(ImageLocation, ImageSize);// (3, 1, 35, 46);

            e.Graphics
                .DrawImage(image: Image,rect: rectangle);//new System.Drawing.Point(Control.Location.X + 10, Control.Location.Y + 10));

            e.Graphics.DrawRectangle(
                pen: oPen,
                x: ImageLocation.X - 1,
                y: ImageLocation.Y - 1,
                width: ImageSize.Width + 1,
                height: ImageSize.Height + 1);//  2, 0, 36, 47);
        }
    }
}
