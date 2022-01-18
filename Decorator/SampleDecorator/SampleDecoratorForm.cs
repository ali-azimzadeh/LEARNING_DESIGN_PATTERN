using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    public partial class SampleDecoratorForm : Form
    {
        public SampleDecoratorForm()
        {
            InitializeComponent();
        }

        public Image Image { get; set; }

        private void SampleDecoratorForm_Load(object sender, EventArgs e)
        {
            string picPath =
                $"{Application.StartupPath}\\Test.jpg";

            byte[] arrayImage =
                CopyImageToByteArray(Image.FromFile(filename: picPath));

            System.IO.MemoryStream memoryStream =
                new System.IO.MemoryStream(arrayImage);

            Image = Bitmap.FromStream(memoryStream);

            memoryStream.Close();

            PictureDecorator picDecor =
                new PictureDecorator(this, Image, new Point(11, 31), new Size(500, 150));


            BorderDecorator borderDecorator = 
                new BorderDecorator(control: testButton);

            TextDecorator textDecorator =
                new TextDecorator(control: TextDecorButton, text: "Test Button");

            this.Refresh();

            this.Invalidate();
        }

        public static byte[] CopyImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Jpeg);

                return memoryStream.ToArray();
            }
        }
    }
}
