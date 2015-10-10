using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class ContactInfo : Form
    {
        // In order to avoid having carriage returns removed by the RichTextBox (making the string display weird on notepad) all the info is kept in a seperate string.
        private string info = "";

        public ContactInfo()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Check to see that all fields have been filled before continuing
            if(nameTextBox.Text == "" || emailTextBox.Text == "" || phoneTextBox.Text == ""){
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           // Append info and display
            info += String.Format("{0:0},{1:0},{2:0}", nameTextBox.Text, emailTextBox.Text, phoneTextBox.Text) + "\r\n";
            ContactInfoDisplay.Text = ContactInfoDisplay.Text += String.Format("Name: {0:0}, Email: {1:0}, Phone Number: {2:0}\n", nameTextBox.Text, emailTextBox.Text, phoneTextBox.Text);
        
            // Return cursor to NameTextBox
            nameTextBox.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Prompt user to select a file and attempt to save to that location
            try
            {
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, info);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        // Select all text in each text box on entry to make data reuse or overwrite easier
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.SelectAll();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            emailTextBox.SelectAll();
        }

        private void phoneTextBox_Enter(object sender, EventArgs e)
        {
            phoneTextBox.SelectAll();
        }    
    }
}
