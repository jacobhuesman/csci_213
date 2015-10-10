using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class SignUpSheet : Form
    {
        public SignUpSheet()
        {
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            // Make sure a name is entered
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Get checkboxes
            var checkBoxes = equipmentGroupBox.Controls.OfType<CheckBox>();
            
            // Start equipment list
            string equipmentList = String.Format("Name: {0,0}\n" +
                                                "Equipment: ", 
                                                nameTextBox.Text);
            
            // Append any checked items to equipment list
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    equipmentList += checkBox.Text.ToString() + ", ";
                }
            }

            // Remove trailing whitespace and comma. Then display equipment list in equipment info
            equipmentInfo.Text += equipmentList.Trim().TrimEnd(',') + "\n\n";

            // Return cursor to Name and clear checkboxes
            nameTextBox.Focus();
            ClearCheckBoxes();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear Name
            nameTextBox.Text = "";
            
            // Get checkboxes
            var checkBoxes = equipmentGroupBox.Controls.OfType<CheckBox>();

            this.ClearCheckBoxes();

            // Clear equipment info
            equipmentInfo.Text = "";
        }

        // Exit the application when exit is clicked
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Uncheck all checkboxes
        private void ClearCheckBoxes()
        {
            var checkBoxes = equipmentGroupBox.Controls.OfType<CheckBox>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }
        }

        // Select all the text in a textbox on entry to allow for easy overwrite/entry
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.SelectAll();
        }
    }
}
