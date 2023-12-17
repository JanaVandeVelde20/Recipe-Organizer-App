using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Dapper;

namespace Recipe_Organizer
{
    public partial class frmAddRecipe : Form
    {
        public frmAddRecipe()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save a new recipe to the database
            string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

            SQLiteConnection con = new SQLiteConnection(connectionString);

            var newRecipe = new Recipe
            {
                Name = txtName.Text,
                CategoryID = GetCategoryIdFromComboBox(),
                Instructions = txtInstructions.Text,
                PrepTime = Convert.ToInt32(txtPrepTime.Text)
            };

            string insertQuery = "INSERT INTO Recipe(name, categoryId, instructions, prepTime) VALUES (@Name, @CategoryID, @Instructions, @PrepTime)";
            
            con.Query(insertQuery, newRecipe);

            new frmShowRecipes().ShowDialog();
        }

        // Method to get the selected category ID from ComboBox
        private int GetCategoryIdFromComboBox()
        {
            // Get the selected category from the ComboBox
            string selectedCategory = cmbCategory.SelectedItem as string;

            // Map the selected category to the corresponding foreign key ID
            switch (selectedCategory)
            {
                case "Breakfast":
                    return 1;
                case "Lunch":
                    return 2;
                case "Dinner":
                    return 3;
                default:
                    return 0; // Handle other cases or return a default value
            }

        }

        private void navHome_Click(object sender, EventArgs e)
        {
            new frmHomePage().ShowDialog();
        }

        private void navShowRecipes_Click(object sender, EventArgs e)
        {
            new frmShowRecipes().ShowDialog();
        }
    }
}
