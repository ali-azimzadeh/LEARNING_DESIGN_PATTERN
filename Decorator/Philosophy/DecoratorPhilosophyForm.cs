using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Decorator.Philosophy
{
    public partial class DecoratorPhilosophyForm : Form
    {
        public DecoratorPhilosophyForm()
        {
            InitializeComponent();
        }

        IComponent component = new Component();

        private void componentButton_Click(object sender, EventArgs e)
        {
            string result = component.Operation();

            MessageBox.Show(result);
        }

        private void myDecoratorButton_Click(object sender, EventArgs e)
        {
            MyDecorator myDecorator = 
                new MyDecorator(component: component);

            string result = myDecorator.Operation();

            MessageBox.Show(result);
        }
    }
}
