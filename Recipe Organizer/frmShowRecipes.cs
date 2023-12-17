using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace Recipe_Organizer
{
    public partial class frmShowRecipes : Form
    {
        private int selectedCategoryId;

        public frmShowRecipes(int categoryId)
        {
            InitializeComponent();
            selectedCategoryId = categoryId;
            LoadRecipesByCategory();
        }

        public frmShowRecipes()
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

                string selectQuery = "SELECT name, instructions, prepTime FROM Recipe WHERE categoryId = @CategoryId";

                // Use Dapper to retrieve data from the database
                List<Recipe> recipes = con.Query<Recipe>(selectQuery, new { CategoryId = selectedCategoryId }).ToList();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = recipes;

                // Enable text wrapping for the 'instructions' column
                dataGridView1.Columns["Instructions"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Hide the 'categoryId' column
                dataGridView1.Columns["CategoryId"].Visible = false;
            }
        }
        private void LoadAllRecipes()
        {

            string connectionString = "Data Source=C:\\_DATA\\Thomas More\\2023-2024\\semester 1\\DevOps & Security\\Case Study\\Recipe Organizer\\Recipe.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT name, instructions, prepTime FROM Recipe";

                // Use Dapper to retrieve data from the database
                List<Recipe> recipes = con.Query<Recipe>(selectQuery).ToList();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = recipes;

                // Enable text wrapping for the 'instructions' column
                dataGridView1.Columns["instructions"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Hide the 'categoryId' column
                dataGridView1.Columns["CategoryId"].Visible = false;

            }

        }

        private void frmShowRecipes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navHome_Click(object sender, EventArgs e)
        {
            new frmHomePage().ShowDialog();
        }

        private void navAddRecipe_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
