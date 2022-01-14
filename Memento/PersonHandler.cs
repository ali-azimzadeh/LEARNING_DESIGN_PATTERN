using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Memento
{
    public class PersonHandler : Object, IOriginator
    {
        public PersonHandler() : base()
        {
        }

        private List<Person> _people = null;
        public List<Person> People
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

        public Memento CreateMemnto()
        {
            Memento memento = new Memento();

            memento.People = People;

            return (memento);
        }

        public void SetMemnto(Memento memnto)
        {
            foreach(Person person in memnto.People)
            {
                People.Add(person);
            }
        }
    }
}
