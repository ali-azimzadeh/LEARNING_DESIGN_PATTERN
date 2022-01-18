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
    public partial class ObserverForm : Form ,IObserver
    {
        public ObserverForm(IMediator mediator)
        {
            InitializeComponent();
            
            Mediator = mediator;
            Mediator.RegisterObserver(this);
        }

        public IMediator Mediator { get; set; }

        private void ObserverForm_Load(object sender, EventArgs e)
        {

        }

        #region IObserver Members
        public void Update(IMessage message)
        {
            messageListBox
                .Items
                .Add(message.ToString())
                ;
        }
        #endregion

        private void ObserverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mediator.UnregisterObserver(this);
        }
    }
}
