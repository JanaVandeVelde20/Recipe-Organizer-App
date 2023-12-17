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
    public partial class frmAddAdvancedRecipe : Form
    {
        private List<AdvancedRecipe> AdvancedRecipes;
        public AdvancedRecipe newAdvancedRecipe { get; set; }

        public frmAddAdvancedRecipe(List<AdvancedRecipe> recipes, AdvancedRecipe existingRecipe)
        {
            InitializeComponent();

            // Set the newAdvancedRecipe property with the existing recipe data
            newAdvancedRecipe = existingRecipe;

            // Set the ID for the existing recipe
            newAdvancedRecipe.advancedRecipeId = existingRecipe.advancedRecipeId;

            // Set the reference to the AdvancedRecipes list
            AdvancedRecipes = recipes;
        }


        public frmAddAdvancedRecipe(int categoryId)
        {
            InitializeComponent();
        }

        public frmAddAdvancedRecipe()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newAdvancedRecipe != null)
            {
                string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    // Delete the old record based on the name
                    string deleteQuery = "DELETE FROM AdvancedRecipe WHERE name = @Name";
                    con.Execute(deleteQuery, new { Name = newAdvancedRecipe?.Name });

                    // Insert the updated record
                    var updatedRecipe = new AdvancedRecipe
                    {
                        Name = txtName.Text,
                        CategoryID = GetCategoryIdFromComboBox(),
                        PrepTime = Convert.ToInt32(txtPrepTime.Text),
                        DifficultyScore = Convert.ToInt32(nrDifficultyScore.Text),
                        Instructions = txtInstructions.Text,
                        ChefTips = txtChefTips.Text
                    };

                    string insertQuery = "INSERT INTO AdvancedRecipe(name, prepTime, categoryId, difficultyScore, instructions, chefTips) " +
                                         "VALUES (@Name, @PrepTime, @CategoryID, @DifficultyScore, @Instructions, @ChefTips)";

                    con.Execute(insertQuery, updatedRecipe);

                    // Delete the old record from the list based on the name
                    AdvancedRecipes?.RemoveAll(recipe => recipe?.Name == newAdvancedRecipe?.Name);

                    // Insert the updated record into the list
                    AdvancedRecipes?.Add(updatedRecipe);

                    // Close the current form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                // Show the updated data in the frmShowAdvancedRecipes form
                new frmShowAdvancedRecipes().ShowDialog();
            }
        }


        // Method to get the selected category ID from ComboBox
        private int GetCategoryIdFromComboBox()
        {
            // Get the selected category from the ComboBox
            string selectedCategory = cmbCategory.SelectedItem as string;

            // Map the selected category to the corresponding foreign key ID
            switch (selectedCategory)
            {
                case "Appetizer":
                    return 4;
                case "Main Dish":
                    return 5;
                case "Dessert":
                    return 6;
                default:
                    return 0; // Handle other cases or return a default value
            }

        }

        private void navHome_Click(object sender, EventArgs e)
        {
            new frmHomePage().ShowDialog();
        }

        private void NewRecipe_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddAdvancedRecipe_Load(object sender, EventArgs e)
        {
            if (newAdvancedRecipe != null)
            {
                txtName.Text = newAdvancedRecipe.Name;
                txtInstructions.Text = newAdvancedRecipe.Instructions;
                txtChefTips.Text = newAdvancedRecipe.ChefTips;

                // Set the selected item based on CategoryID
                SetSelectedCategory(newAdvancedRecipe.CategoryID);

                txtPrepTime.Text = newAdvancedRecipe.PrepTime.ToString();
                nrDifficultyScore.Value = newAdvancedRecipe.DifficultyScore;
            }
        }
        // Method to set the selected item in cmbCategory based on CategoryID
        private void SetSelectedCategory(int categoryId)
        {
            // Your logic to map category ID to category name
            string selectedCategory = GetCategoryNameFromId(categoryId);

            // Set the selected item in cmbCategory
            cmbCategory.SelectedItem = selectedCategory;
        }

        // Method to get the category name from the category ID
        private string GetCategoryNameFromId(int categoryId)
        {
            switch (categoryId)
            {
                case 4:
                    return "Appetizer";
                case 5:
                    return "Main Dish";
                case 6:
                    return "Dessert";
                default:
                    return ""; // Handle other cases or return a default value
            }
        }


        }
}
