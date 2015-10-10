using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Additional libraries needed for interacting with Entity Data Model.
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Project3
{
    public partial class EmployeeTable : Form
    {
        // Initialize the form.
        public EmployeeTable()
        {
            InitializeComponent();
        }

        // Create an entity model of the Personnel Database.
        private PersonnelDB.PersonnelEntities dbcontext = new PersonnelDB.PersonnelEntities();

        // Save any additions, modifications and deletions to the database.
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Validate entries and end any edits.
            this.Validate();
            this.employeeBindingSource.EndEdit();

            // Try to save all changes. If any columns are empty display an error message and don't save. 
            // If ID is changed, notify user that this is not a valid operation.
            // If a pay rate is entered greater, than database support then notify user.
            // Display error message if other error occurs.
            try
            {
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show(this, "Columns cannot be empty", "Entity Validation Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show(this, "Cannot modify employee ID.\n"
                              + "Please create a new employee with the desired ID and then delete the old one",
                              "Invalid Operation",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show(this, "Cannot pay an employee this rate.\n"
                              + "The max allowable pay is 999999.99.",
                              "Invalid Operation",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message,
                             "Exception",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Display the latest infomation contained in the Database.
            RefreshDB();

        }

        // Refresh EmployeeTable on Load.
        private void EmployeeTable_Load(object sender, EventArgs e)
        {
            RefreshDB();

        }

        // Display the highest pay rate contained in the database of employees.
        private void maximumButton_Click(object sender, EventArgs e)
        {
            // Find employee with highest pay rate.
            PersonnelDB.Employee highest = dbcontext.Employees          // In db employees table,
                .OrderByDescending(Employee => Employee.HourlyPayRate)  // order the Employees in descending order by payrate,
                .First();                                               // select the first Employee (highest pay rate),

            // Display employee with highest pay rate.
            MessageBox.Show(String.Format("Pay rate: ${0}/hr\n"
                                        + "ID: {1}\n"
                                        + "Name: {2}\n"
                                        + "Position: {3}",
                highest.HourlyPayRate,
                highest.EmployeeID,
                highest.Name,
                highest.Position), 
                "Highest Pay Rate"); // MessageBox title.
        }

        // Display the lowest pay rate contained in the database of employees.
        private void minimumButton_Click(object sender, EventArgs e)
        {
            // Find employee with lowest pay rate.
            PersonnelDB.Employee lowest = dbcontext.Employees           // In db employees table,
                .OrderBy(Employee => Employee.HourlyPayRate)            // order the Employees in ascending order by payrate,
                .First();                                               // select the first Employee (lowest pay rate),

            // Display employee with lowest pay rate.
            MessageBox.Show(String.Format("Pay rate: ${0}/hr\n"
                                        + "ID: {1}\n"
                                        + "Name: {2}\n"
                                        + "Position: {3}",
                lowest.HourlyPayRate,
                lowest.EmployeeID,
                lowest.Name,
                lowest.Position), 
                "Lowest Pay Rate"); // MessageBox title.
        }

        // Display the Employee Table in a Details View.
        private void detailsButton_Click(object sender, EventArgs e)
        {
            // Create new DetailsView form, display it and hide current form.
            DetailsView detailsView = new DetailsView(this);
            detailsView.Show();
            this.Hide();
        }

        // Display most current data contained in Database
        private void RefreshDB()
        {
            // Dispose of old database object if object exists.
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }

            // Create new database model object.
            dbcontext = new PersonnelDB.PersonnelEntities();

            // Load object with content of database.
            dbcontext.Employees.Load();

            // Display fresh content in EmployeeTable form.
            employeeBindingSource.DataSource = dbcontext.Employees.Local;
        }

        // Refresh EmployeeTable on Load.
        private void EmployeeTable_VisibleChanged(object sender, EventArgs e)
        {
            RefreshDB();
        }

        // Catch error if data entered into table is incorrect.
        private void employeeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(this, "Invalid data entry.\n"
                                + "Example of correct format: 1234 John Smith Accountant 30.45",
                              "Invalid Operation",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
