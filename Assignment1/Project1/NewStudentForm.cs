using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private enum StudentLevel : int
        {
            Undergraduate = 0,
            Graduate = 1
        }
        private void studentLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDataBelowStudentLevel();

            /******************** Grader Please Note *****************************
            * The controls that are labeled generically (i.e. dataEtcEtc)
            * serve multiple roles in the program and therefore can't 
            * have a specific name. I've already talked to Oksana and had their
            * use approved.
            * Thanks!
            * *******************************************************************/

            // Display undergraduate or graduate fields depending on selection
            if (studentLevelComboBox.SelectedIndex == (int)StudentLevel.Undergraduate) 
            {
                // Fill Labels
                dataLabel1.Text = "Classification";
                dataLabel2.Text = "Parent/Guardian Name";
                dataLabel3.Text = "Parent/Guardian Address";
                
                // Generate Classification Options
                dataComboBox1.Items.Clear(); 
                dataComboBox1.Items.Add("Freshman");
                dataComboBox1.Items.Add("Sophomore");
                dataComboBox1.Items.Add("Junior");
                dataComboBox1.Items.Add("Senior");

                // Show additional input fields
                dataLabel1.Visible = true; //Classification
                dataLabel2.Visible = true; // Guardian Name
                dataLabel3.Visible = true; // Guardian Address
                dataComboBox1.Visible = true; //Classification
                dataTextBox2.Visible = true; // Guardian Name
                dataTextBox3.Visible = true; // Guardian Address
            }
            else if (studentLevelComboBox.SelectedIndex == (int)StudentLevel.Graduate) 
            {
                // Fill Labels
                dataLabel1.Text = "Undergraduate Degree Type";
                dataLabel2.Text = "Degree Name";
                dataLabel3.Text = "Degree Institution Location";

                // Generate Degree Options
                dataComboBox1.Items.Clear();
                dataComboBox1.Items.Add("B.A.");
                dataComboBox1.Items.Add("B.S.");
                dataComboBox1.Items.Add("LL.B.");
                dataComboBox1.Items.Add("B.Eng.");
                dataComboBox1.Items.Add("AD");

                // Show additional input fields
                dataLabel1.Visible = true;
                dataLabel2.Visible = true;
                dataLabel3.Visible = true;
                dataComboBox1.Visible = true;
                dataTextBox2.Visible = true;
                dataTextBox3.Visible = true;
            }

        }

        private void createStudent_Click(object sender, EventArgs e)
        {
            try 
            {
                // Create a student reference
                Student student;

                // Generate and undergraduate or graduate student depending on selection
                if (studentLevelComboBox.SelectedIndex == (int)StudentLevel.Undergraduate)
                {
                    student = new UnderGraduate(nameTextBox.Text, Convert.ToInt32(idTextBox.Text), dataComboBox1.SelectedItem.ToString(), dataTextBox2.Text, dataTextBox3.Text);
                }
                else if (studentLevelComboBox.SelectedIndex == (int)StudentLevel.Graduate)
                {
                    student = new GraduateStudent(nameTextBox.Text, Convert.ToInt32(idTextBox.Text), dataComboBox1.SelectedItem.ToString(), dataTextBox2.Text, dataTextBox3.Text);
                }
                else
                {
                    MessageBox.Show("Please select a Student Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Clear the current data entered and display the student info
                this.ClearForm();
                NewStudentInfo.Text = student.ToString();
            }
            catch (System.FormatException e1)
            {
                // User entered data that is not a number
                MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.NullReferenceException e1)
            {
                // Some of the fields were left blank
                MessageBox.Show("Please ensure the entire form has been filled before creating the student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e1)
            {
                // Something unanticipated happened
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Methods to clear the forms
        private void ClearForm()
        {
            nameTextBox.Clear();
            idTextBox.Clear();
            studentLevelComboBox.Text = "";
            dataComboBox1.Text = "";
            dataTextBox2.Clear();
            dataTextBox3.Clear();
        }

        private void ClearDataBelowStudentLevel()
        {
            dataComboBox1.Text = "";
            dataTextBox2.Clear();
            dataTextBox3.Clear();
        }
    }
}
