using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Memento
{
    /// <summary>
    /// What is serialize in C#?
    ///     Serialization in C# is the process of converting an object into a 
    ///     stream of bytes to store the object to memory, a database, or a file. 
    ///     Its main purpose is to save the state of an object in order to be able
    ///     to recreate it when needed. The reverse process is called deserialization
    ///     
    /// سریال سازی در سی شارپ چیست؟
    /// سریال سازی در سی شارپ فرآیند تبدیل یک شی به جریانی از بایت ها
    /// برای ذخیره شی در حافظه، پایگاه داده یا فایل است
    ///  هدف اصلی آن این است که وضعیت یک شی را ذخیره کند تا بتوان در صورت نیازآن را بازیابی کرد
    ///  نامیده می شود deserialization  فرآیند معکوس  
    /// </summary>

    [Serializable]
    public class Memento : Object
    {
        public Memento() : base()
        {
        }

        public List<Person> People { get; set; }

    }
}
