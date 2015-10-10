using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class UnderGraduate : Student 
    {
        // Constructor
        public UnderGraduate(string name, int id, string classification, string guardianName, string guardianAddress) 
            : base(name, id)
        {
            Classification = classification;
            GuardianName = guardianName;
            GuardianAddress = guardianAddress;
        }

        // Properties
        public string Classification { get; set; }

        public string GuardianName { get; set; }

        public string GuardianAddress { get; set; }

        // Methods
        public override string ToString()
        {
            return String.Format("Name: {0:0}\n" +
                        "ID: {1:0}\n" +
                        "Student Level: UnderGraduate\n" +
                        "Classification: {2,0}\n" +
                        "Parent/Guardian Name: {3,0}\n" +
                        "Parent/Guardian Address: {4,0}",
                        this.Name, this.ID, this.Classification, this.GuardianName, this.GuardianAddress);
        }
    }
}
