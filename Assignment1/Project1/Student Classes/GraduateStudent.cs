using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class GraduateStudent : Student
    {
        // Constructor
        public GraduateStudent(string name, int id, string degreeType, string degreeName, string institutionLocation) : base(name, id)
        {
            DegreeType = degreeType;
            DegreeName = degreeName;
            InstitutionLocation = institutionLocation;
        }

        // Properties
        public string DegreeType { get; set; }

        public string DegreeName { get; set; }

        public string InstitutionLocation { get; set; }
        
        // Methods
        public override string ToString()
        {
            return String.Format("Name: {0:0}\n" +
                        "ID: {1:0}\n" +
                        "Student Level: Graduate\n" +
                        "Degree: {2,0} {3,0}\n" +
                        "Institution Location: {4,0}",
                        this.Name, this.ID, this.DegreeType, this.DegreeName, this.InstitutionLocation);
        }
    }
}
