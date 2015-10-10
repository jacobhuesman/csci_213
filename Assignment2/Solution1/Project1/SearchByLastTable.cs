using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Library for interacting with Entity Data Model.
using System.Data.Entity;

namespace Project1
{
    public partial class SearchByLastTable : Form
    {
        // Create a Database Entity Model for the Baseball Database.
        private DBBaseball.BaseballEntities dbcontext = new DBBaseball.BaseballEntities();
        
        // Initialize form.
        public SearchByLastTable()
        {
            InitializeComponent();
        }

        // On search, display all players whose last name matches the content
        // of the searchBox text.
        private void searchButton_Click(object sender, EventArgs e)
        {
            playersBindingSource.DataSource = dbcontext.Players.Local
                .Where(Player => Player.LastName == searchBox.Text);
        }

        // On reset, display entire contents of Players table.
        private void resetButton_Click(object sender, EventArgs e)
        {
            playersBindingSource.DataSource = dbcontext.Players.Local;
        }

        // On entry of the search box, select all text for ease
        // of data entry.
        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.SelectAll();
        }

        // Fill table with Player information on load.
        private void SearchByLastTable_Load(object sender, EventArgs e)
        {
            // Load Players into Datebase Model, ordering by their last name.
            dbcontext.Players
                .OrderBy(Player => Player.LastName)
                .Load();

            // Display contents of database in table.
            playersBindingSource.DataSource = dbcontext.Players.Local;
        }
    }
}
