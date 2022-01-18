using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Observer
{
    public partial class MediatorForm : Form,IMediator
    {
        public MediatorForm()
        {
            InitializeComponent();
        }

        private System.Collections.Generic.List<IObserver> _observers;
        private System.Collections.Generic.List<IObserver> Observers
        {
            get
            {
                if (_observers == null)
                {
                    _observers = 
                        new System.Collections.Generic.List<IObserver>();
                }

                return (_observers);
            }
        }

        private void MediatorForm_Load(object sender, EventArgs e)
        {
            ObserverForm observerForm1 = new ObserverForm(this);
            observerForm1.Show();

            ObserverForm observerForm2 = new ObserverForm(this);
            observerForm2.Show();
        }

        #region IMediator Members
        public void NotifyObservers(IMessage message)
        {
            foreach (IObserver oObserver in Observers)
            {
                oObserver.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
          //  lblFullName.Text = (txtFirstName.Text + " " + txtLastName.Text).Trim();
            Message message = 
                new Message(firstName:firstNameTextBox.Text,lastNameTextBox.Text);

            NotifyObservers(message);
        }
    }
}
