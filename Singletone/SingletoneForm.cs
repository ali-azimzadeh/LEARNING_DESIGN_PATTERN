using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
    public partial class SingletoneForm : Form
    {
        public SingletoneForm()
        {
            InitializeComponent();
        }

        float fltA = 18.25f;
        float fltB = 19.75f;
        float fltC = 17.50f;

        float fltResult;
        private void SingletoneForm_Load(object sender, EventArgs e)
        {

        }
        private void utilites1Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            Utilities1 oUtilities1 = new Utilities1();
            fltResult = 
                oUtilities1.Average(fltA, fltB, fltC);

            MessageBox.Show($"The average: {fltResult}");
            // **************************************************
        }

        private void utilites2Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            // Why we let the user to create no useful object!
            Utilities2 oUtilities2 = new Utilities2(); 
            
            fltResult = 
                Utilities2.Average(fltA, fltB, fltC);

            MessageBox.Show("The average: {0}", fltResult.ToString());
            // **************************************************
        }

        private void utilites3Button_Click(object sender, EventArgs e)
        {
            // Utilities3 oUtilities3 = new Utilities3(); // User can not create any object!
            fltResult = Utilities3.Average(fltA, fltB, fltC);

            MessageBox.Show("The average: {0}", fltResult.ToString());
            // **************************************************
        }

        private void utilites4Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            // Utilities4 oUtilities4 = new Utilities4(); // User can not create any object!
            fltResult = Utilities4.Average(fltA, fltB, fltC);

            MessageBox.Show("The average: {0}", fltResult.ToString());
            // **************************************************
        }

        private void manager1Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            // *** NO COMPILE ERROR, NO RUNTIME ERROR ***********
            // **************************************************
            Manager1 obj1 = new Manager1();
            Manager1 obj2 = new Manager1(); // You should not create more that one instance!
        }

        private void manager2Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            // *** NO COMPILE ERROR, BUT RUNTIME ERROR **********
            // **************************************************
            Manager2 obj3 = new Manager2();
            Manager2 obj31 = new Manager2(); //Runtime Error!
        }

        private void manager3Button_Click(object sender, EventArgs e)
        {
            // **************************************************
            // *** COMPILE ERROR ********************************
            // **************************************************
            // Supervisor3 obj5 = new Supervisor3();

            Manager3.GetInstance().Age = 20;
            Manager3.GetInstance().FullName = "Ali Reza Alavi";
            Manager3.GetInstance().ShowInfo();

            // OR

            Manager3 obj6 = Manager3.GetInstance();

            obj6.Age = 30;
            obj6.FullName = "Sara Ahmadi";
            obj6.ShowInfo();
        }
    }
}
