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
using Dapper;

namespace Recipe_Organizer
{
    public partial class frmShowAdvancedRecipes : Form
    {
        private int selectedCategoryId;
        private List<AdvancedRecipe> AdvancedRecipes;

        public frmShowAdvancedRecipes(int categoryId)
        {
            InitializeComponent();
            selectedCategoryId = categoryId;
            LoadRecipesByCategory();
        }
        public frmShowAdvancedRecipes()
        {
            InitializeComponent();
            LoadAllRecipes();
        }
        private void LoadRecipesByCategory()
        {
            string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT name, instructions, prepTime, difficultyScore, chefTips FROM AdvancedRecipe WHERE categoryId = @CategoryId";

                // Use Dapper to retrieve data from the database
                List<AdvancedRecipe> AdvancedRecipes = con.Query<AdvancedRecipe>(selectQuery, new { CategoryId = selectedCategoryId }).ToList();

                AdvancedRecipes = con.Query<AdvancedRecipe>(selectQuery, new { CategoryId = selectedCategoryId }).ToList();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = AdvancedRecipes;
            }
        }
        private void LoadAllRecipes()
        {

            string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT name, instructions, prepTime, difficultyScore, chefTips FROM AdvancedRecipe";

                // Use Dapper to retrieve data from the database
                List<AdvancedRecipe> AdvancedRecipes = con.Query<AdvancedRecipe>(selectQuery).ToList();
                AdvancedRecipes = con.Query<AdvancedRecipe>(selectQuery).ToList();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = AdvancedRecipes;

            }

        }

        private void frmShowAdvancedRecipes_Load(object sender, EventArgs e)
        {

        }

        private void navHome_Click(object sender, EventArgs e)
        {
            new frmHomePage().ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddAdvancedRecipe frm = new frmAddAdvancedRecipe() { newAdvancedRecipe = new AdvancedRecipe()})
            {
                if(frm.ShowDialog()== DialogResult.OK)
                {
                    advancedRecipeBindingSource.Add(frm.newAdvancedRecipe);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the current data-bound item
                AdvancedRecipe selectedRecipe = selectedRow.DataBoundItem as AdvancedRecipe;

                if (selectedRecipe != null)
                {
                    // Remove the item from the BindingSource
                    advancedRecipeBindingSource.Remove(selectedRecipe);

                    // Delete the row from the database
                    DeleteRecipeFromDatabase(selectedRecipe.Name);

                    // Delete the row from the AdvancedRecipes list
                    DeleteRecipeFromList(selectedRecipe.Name);
                }
                else
                {
                    MessageBox.Show("Selected row does not contain valid data for deletion.");
                }

                // Show the updated data in the frmShowAdvancedRecipes form
                new frmShowAdvancedRecipes().ShowDialog();
            }
        }
        private void DeleteRecipeFromDatabase(string recipeName)
        {
            // Delete the row from the database using the provided recipeName
            string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string deleteQuery = "DELETE FROM AdvancedRecipe WHERE name = @RecipeName";
                con.Execute(deleteQuery, new { RecipeName = recipeName });
            }
        }

        private void DeleteRecipeFromList(string recipeName)
        {
            // Delete the row from the AdvancedRecipes list using LINQ
            AdvancedRecipes?.RemoveAll(recipe => recipe.Name == recipeName);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the data from the selected row
                AdvancedRecipe selectedRecipe = new AdvancedRecipe
                {
                    Name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(),
                    Instructions = selectedRow.Cells["instructionsDataGridViewTextBoxColumn"].Value.ToString(),
                    PrepTime = Convert.ToInt32(selectedRow.Cells["prepTimeDataGridViewTextBoxColumn"].Value),
                    DifficultyScore = Convert.ToInt32(selectedRow.Cells["difficultyScoreDataGridViewTextBoxColumn"].Value),
                    ChefTips = selectedRow.Cells["chefTipsDataGridViewTextBoxColumn"].Value.ToString()
                };

                // Open the frmAddAdvancedRecipe form for editing
                using (frmAddAdvancedRecipe frm = new frmAddAdvancedRecipe(AdvancedRecipes, selectedRecipe))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the DataGridView with the edited data
                        LoadRecipesByCategory(); // or LoadAllRecipes() based on your requirement
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
    }
 }