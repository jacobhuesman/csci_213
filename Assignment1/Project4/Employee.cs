using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Employee
    {
        // Constructors
        public Employee(string name, string number, decimal payRate, decimal hoursWorked)
        {
            Name = name;
            Number = number;

            // Ensure valid data for payRate and hoursWorked. If valid calculate and store total pay.
            if (payRate < 0)
                throw new System.FormatException("Pay rate cannot be below 0");
            else if (hoursWorked < 0)
                throw new System.FormatException("Hours worked cannot be less than 0");
            else if (hoursWorked <= 40) // First 40 at standard pay rate
                TotalPay = hoursWorked * payRate;
            else // First 40 + time and a half
                TotalPay = 40 * payRate + (hoursWorked - 40) * payRate * 1.5m;
        }

        public Employee(string CSVEmployeeData)
        {
            try
            {
                string[] values = CSVEmployeeData.Split(',');
                Name = values[0];
                Number = values[1];
                TotalPay = Convert.ToDecimal(values[2]);
            }
            catch (Exception innerException)
            {
                throw new FormatException("CSVEmployeeData was not the correct format", innerException);
            }
        }

        // Methods
        public override string ToString()
        {
            return String.Format("Name: {0:0}, Total Pay: {1:c}", Name, TotalPay);
        }

        public string ToCSV()
        {
            return String.Format("{0},{1},{2}\r\n", Name, Number, TotalPay);
        }

        // Properties
        public string Name { get; set; }

        public string Number { get; set; }

        public decimal TotalPay { get; set; }
    }
}
