using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class EmployeeData : Form
    {
        private LinkedList<Employee> employees = new LinkedList<Employee>();

        public EmployeeData()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, EventArgs e)
        {
            // Check to see that all fields have been filled before continuing
            if(nameTextBox.Text == "" || numberTextBox.Text == "" || payRateTextBox.Text == "" || hoursWorkedTextBox.Text == ""){
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Add employee to employee list
                employees.AddFirst(new Employee(nameTextBox.Text, numberTextBox.Text, Convert.ToDecimal(payRateTextBox.Text), Convert.ToDecimal(hoursWorkedTextBox.Text)));

                // Append info and display
                contactInfoDisplay.Text = employees.First.Value.ToString() + "\n" + contactInfoDisplay.Text;

                // Return cursor to nameTextBox for additional entries
                nameTextBox.Focus();
            }
            catch (System.FormatException error)
            {
                MessageBox.Show("Please enter numbers in Pay Rate and Hours Worked\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Prompt user to select a file and attempt to save to that location
            try
            {
                // Create a string to be saved in text file
                string employeeCSV = "";
                foreach(Employee employee in employees){
                    employeeCSV += employee.ToCSV();
                }

                // Prompt user to select a file or create a new one
                saveFileDialog.ShowDialog();

                // If the user properly selects a file, write data to file
                if (saveFileDialog.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, employeeCSV);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {   
                // Create list of employees to fill
                LinkedList<Employee> loadedEmployees = new LinkedList<Employee>();
                
                // Prompt user for file to load
                openFileDialog.ShowDialog();

                // Load file contents into a string array
                string[] employeeCSV = System.IO.File.ReadAllLines(openFileDialog.FileName);

                // Convert file contents into an array of EmployeePay objects
                foreach (string employee in employeeCSV)
                {
                    loadedEmployees.AddFirst(new Employee(employee));
                }

                // Display employee name and formatted total pay on a different form
                EmployeePayData form2 = new EmployeePayData();
                RichTextBox employeePayDataDisplay = (RichTextBox)form2.Controls.Find("employeePayDataDisplay", false)[0];

                foreach (Employee employee in loadedEmployees)
                {
                    employeePayDataDisplay.Text = employee.ToString() + "\n" + employeePayDataDisplay.Text;
                }
                
                form2.Show();       
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            // Clear current session
            contactInfoDisplay.Text = "";
            employees.Clear();
            nameTextBox.Text = "";
            numberTextBox.Text = "";
            payRateTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
        }

        // Select all the text in a textbox on entry to allow for easy overwrite/entry
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.SelectAll();
        }

        private void numberTextBox_Enter(object sender, EventArgs e)
        {
            numberTextBox.SelectAll();
        }

        private void payRateTextBox_Enter(object sender, EventArgs e)
        {
            payRateTextBox.SelectAll();
        }

        private void hoursWorkedTextBox_Enter(object sender, EventArgs e)
        {
            hoursWorkedTextBox.SelectAll();
        }

        
    }
}
