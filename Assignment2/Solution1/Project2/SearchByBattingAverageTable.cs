using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Library for interacting with Entity Data Model
using System.Data.Entity;

namespace Project2
{
    public partial class SearchByBattingAverageTable : Form
    {
        // Create a Database Entity Model for the Baseball Database.
        private DBBaseball.BaseballEntities dbcontext = new DBBaseball.BaseballEntities();

        // Initialize form.
        public SearchByBattingAverageTable()
        {
            InitializeComponent();
        }

        // Display all Players on reset.
        private void resetButton_Click(object sender, EventArgs e)
        {
            playersBindingSource.DataSource = dbcontext.Players.Local;
        }

        // On search display any players whose batting average are greater than 
        // or equal to the minimum batting average set and less than or equal
        // to the maximum batting average set.
        private void searchButton_Click(object sender, EventArgs e)
        {
            playersBindingSource.DataSource = dbcontext.Players.Local
                .Where(Player => 
                    Player.BattingAverage >= minNumeric.Value 
                    && Player.BattingAverage <= maxNumeric.Value);
        }

        // Fill table with Player information on load.
        private void SearchByBattingAverageTable_Load(object sender, EventArgs e)
        {
            // Load Players into Datebase Model, ordering by their last name.
            dbcontext.Players
                .OrderBy(Player => Player.LastName)
                .Load();

            // Display contents of database in table.
            playersBindingSource.DataSource = dbcontext.Players.Local;

            // Set the max batting average to 1.
            maxNumeric.Value = 1.00M;
        }
    }
}
