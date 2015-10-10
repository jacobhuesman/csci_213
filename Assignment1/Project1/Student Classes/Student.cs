using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Student
    {
        // Constructor
        public Student( string name, int id )
        {
            Name = name;
            ID = id;
        }

        // Properties
        public string Name { get; set; }

        public int ID { get; set; }

        // Methods
        public override string ToString()
        {
            return String.Format("Name: {0:0}\n" +
                                "ID: {1:0}" +
                                this.Name, this.ID);
        }
    }
}
