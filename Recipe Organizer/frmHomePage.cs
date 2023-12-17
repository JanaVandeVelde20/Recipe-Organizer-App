using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Organizer
{
    public partial class frmHomePage : Form
    {

        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnShowRecipes_Click(object sender, EventArgs e)
        {
            new frmShowRecipes().ShowDialog();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            OpenShowRecipesForm(1);
        }

        private void OpenShowRecipesForm(int categoryId)
        {
            // Open the Show Recipes form and pass the selected category ID
            frmShowRecipes showRecipesForm = new frmShowRecipes(categoryId);
            showRecipesForm.Show();
        }

        private void OpenShowAdvancedRecipesForm(int categoryId)
        {
            // Open the Show Recipes form and pass the selected category ID
            frmShowAdvancedRecipes showAdvancedRecipesForm = new frmShowAdvancedRecipes(categoryId);
            showAdvancedRecipesForm.Show();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            OpenShowRecipesForm(2);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            OpenShowRecipesForm(3);
        }

        private void navShowRecipes_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void navAddRecipe_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void frmHomePage_MouseEnter(object sender, EventArgs e)
        {

        }

        private void navShowRecipes_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void navShowRecipes_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void standardRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddRecipe().ShowDialog();
        }

        private void advancedRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddAdvancedRecipe().ShowDialog();
        }

        private void standardRecipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmShowRecipes().ShowDialog();
        }

        private void advancedRecipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmShowAdvancedRecipes().ShowDialog();
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            OpenShowAdvancedRecipesForm(4);
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            OpenShowAdvancedRecipesForm(5);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            OpenShowAdvancedRecipesForm(6);
        }
    }
}
