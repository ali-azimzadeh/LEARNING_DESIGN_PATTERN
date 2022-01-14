using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_DESIGN_PATTERN.Memento
{
    public partial class MementoSampleForm : Form
    {
        public MementoSampleForm()
        {
            InitializeComponent();
        }

        private PersonHandler _personHandler = null;
        public PersonHandler PersonHandler
        {
            get
            {
                if(_personHandler == null)
                {
                    _personHandler = new PersonHandler();
                }

                return (_personHandler);
            }
        }

        private System.Collections.Generic.List<Memento> _myMementoes;
        protected System.Collections.Generic.List<Memento> MyMementoes
        {
            get
            {
                if (_myMementoes == null)
                {
                    _myMementoes = new List<Memento>();
                }

                return (_myMementoes);
            }
        }


        private List<Person> _people = null;
        private List<Person> People
        {
            get
            {
                if (_people == null)
                {
                    _people = new List<Person>();
                }

                return (_people);
            }
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            peopleListView
                .Items
                .Add(firstNameTextBox.Text)
                ;

            peopleListView
                .Items[peopleListView.Items.Count - 1]
                .SubItems
                .Add(lastNameTextBox.Text)
                ;

            peopleListView
                .Items[peopleListView.Items.Count - 1]
                .SubItems
                .Add(ageNumericUpDown.Value.ToString())
                ;

            People.Add(new Person
            {
                Age = 
                    (int)ageNumericUpDown.Value,

                FirstName = 
                    firstNameTextBox.Text,

                LastName = 
                    lastNameTextBox.Text
            });

            EmptyForm();

            if (peopleListView.Items.Count > 0)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void EmptyForm()
        {
            firstNameTextBox.Clear();

            lastNameTextBox.Clear();

            ageNumericUpDown.ResetText();
        }

        private async void saveButton_ClickAsync(object sender, EventArgs e)
        {
            MyMementoes.Clear();

            foreach(Person person in People)
            {
                PersonHandler.People.Add(person);
            }

            MyMementoes.Add(PersonHandler.CreateMemnto());


            //****************************************************
            //  Binary Format
            //****************************************************
            System.IO.FileStream oFileStream =
                      new System.IO.FileStream($"{Application.StartupPath}\\PersonData.Bin"
                      , System.IO.FileMode.Create, System.IO.FileAccess.Write);


            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter =
                new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            binaryFormatter.Serialize(oFileStream, MyMementoes);

            oFileStream.Close();


            //****************************************************
            //  Json Format
            //****************************************************
            //string fileName = Application.StartupPath + "\\PersonData.json";
            //using FileStream createStream = File.Create(fileName);
            //await JsonSerializer.SerializeAsync(createStream, MyMementoes);
            //await createStream.DisposeAsync();

            MessageBox.Show("Data has been saved successfully!");

            peopleListView.Items.Clear();

            saveButton.Enabled = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists($"{Application.StartupPath}\\PersonData.Bin") == true)
            {
                System.IO.FileStream oFile =
                                  new System.IO.FileStream($"{Application.StartupPath}\\PersonData.Bin",
                                      System.IO.FileMode.Open,
                                      System.IO.FileAccess.Read);

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                System.Collections.Generic.List<Memento> oMementoes =
                    (System.Collections.Generic.List<Memento>)binaryFormatter.Deserialize(oFile);

                oFile.Close();

                MessageBox.Show("Data has been retrieved successfully!");

                foreach (Memento memento in oMementoes)
                {
                    PersonHandler.SetMemnto(memnto: memento);

                    foreach(Person person in PersonHandler.People)
                    {
                        peopleListView
                            .Items
                            .Add(person.FirstName)
                            ;

                        peopleListView
                            .Items[peopleListView.Items.Count - 1]
                            .SubItems
                            .Add(person.LastName)
                            ;

                        peopleListView
                            .Items[peopleListView.Items.Count - 1]
                            .SubItems
                            .Add(person.Age.ToString())
                            ;
                    }
                }
            }
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lastNameTextBox.Focus();
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ageNumericUpDown.Focus();
            }
        }

        private void ageNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addPersonButton.Focus();
            }
        }
    }
}
