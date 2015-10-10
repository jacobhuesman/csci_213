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
    public partial class DetailsView : Form
    {
        // Create references for Personnel Database model and the EmployeeTable form.
        private PersonnelDB.PersonnelEntities dbcontext = null;
        private System.Windows.Forms.Form employeeTable = null;

        // Initialize DetailsView form and assign reference of the calling form
        // EmployeeTable to an instance variable.
        public DetailsView(System.Windows.Forms.Form employeeTable)
        {
            this.employeeTable = employeeTable;
            InitializeComponent();
        }

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

        // Refresh DetailsView on Load.
        private void DetailsView_Load(object sender, EventArgs e)
        {
            RefreshDB();
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

        // When the DetailsView form is closed display the EmployeeTable form.
        private void DetailsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeTable.Show();
        }
    }
}
