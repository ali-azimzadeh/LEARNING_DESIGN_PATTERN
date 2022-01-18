using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new Singletone.SingletoneForm());

            //Application.Run(new Memento.MementoSampleForm());

             //           Application.Run(new Decorator.Philosophy.DecoratorPhilosophyForm());
                      //  Application.Run(new Decorator.SampleDecorator.SampleDecoratorForm());

            Application.Run(new Observer.MediatorForm());

        }
    }
}
