namespace Recipe_Organizer
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navShowRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.standardRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.navAddRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.standardRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnMainDish = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(492, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(378, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakfast.Location = new System.Drawing.Point(74, 241);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(347, 61);
            this.btnBreakfast.TabIndex = 5;
            this.btnBreakfast.TabStop = false;
            this.btnBreakfast.Text = "Breakfast";
            this.btnBreakfast.UseVisualStyleBackColor = true;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunch.Location = new System.Drawing.Point(492, 241);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(378, 61);
            this.btnLunch.TabIndex = 6;
            this.btnLunch.TabStop = false;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinner.Location = new System.Drawing.Point(936, 241);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(370, 61);
            this.btnDinner.TabIndex = 7;
            this.btnDinner.TabStop = false;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = true;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navShowRecipes,
            this.navAddRecipe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1398, 62);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // navShowRecipes
            // 
            this.navShowRecipes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardRecipeToolStripMenuItem1,
            this.advancedRecipeToolStripMenuItem1});
            this.navShowRecipes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navShowRecipes.Name = "navShowRecipes";
            this.navShowRecipes.Size = new System.Drawing.Size(210, 42);
            this.navShowRecipes.Text = "Show Recipes";
            this.navShowRecipes.Click += new System.EventHandler(this.navShowRecipes_Click);
            this.navShowRecipes.MouseEnter += new System.EventHandler(this.navShowRecipes_MouseEnter);
            this.navShowRecipes.MouseHover += new System.EventHandler(this.navShowRecipes_MouseHover);
            // 
            // standardRecipeToolStripMenuItem1
            // 
            this.standardRecipeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardRecipeToolStripMenuItem1.Name = "standardRecipeToolStripMenuItem1";
            this.standardRecipeToolStripMenuItem1.Size = new System.Drawing.Size(307, 40);
            this.standardRecipeToolStripMenuItem1.Text = "standard recipe";
            this.standardRecipeToolStripMenuItem1.Click += new System.EventHandler(this.standardRecipeToolStripMenuItem1_Click);
            // 
            // advancedRecipeToolStripMenuItem1
            // 
            this.advancedRecipeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedRecipeToolStripMenuItem1.Name = "advancedRecipeToolStripMenuItem1";
            this.advancedRecipeToolStripMenuItem1.Size = new System.Drawing.Size(307, 40);
            this.advancedRecipeToolStripMenuItem1.Text = "advanced recipe";
            this.advancedRecipeToolStripMenuItem1.Click += new System.EventHandler(this.advancedRecipeToolStripMenuItem1_Click);
            // 
            // navAddRecipe
            // 
            this.navAddRecipe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardRecipeToolStripMenuItem,
            this.advancedRecipeToolStripMenuItem});
            this.navAddRecipe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navAddRecipe.Name = "navAddRecipe";
            this.navAddRecipe.Size = new System.Drawing.Size(180, 42);
            this.navAddRecipe.Text = "Add Recipe";
            this.navAddRecipe.Click += new System.EventHandler(this.navAddRecipe_Click);
            // 
            // standardRecipeToolStripMenuItem
            // 
            this.standardRecipeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardRecipeToolStripMenuItem.Name = "standardRecipeToolStripMenuItem";
            this.standardRecipeToolStripMenuItem.Size = new System.Drawing.Size(307, 40);
            this.standardRecipeToolStripMenuItem.Text = "standard recipe";
            this.standardRecipeToolStripMenuItem.Click += new System.EventHandler(this.standardRecipeToolStripMenuItem_Click);
            // 
            // advancedRecipeToolStripMenuItem
            // 
            this.advancedRecipeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedRecipeToolStripMenuItem.Name = "advancedRecipeToolStripMenuItem";
            this.advancedRecipeToolStripMenuItem.Size = new System.Drawing.Size(307, 40);
            this.advancedRecipeToolStripMenuItem.Text = "advanced recipe";
            this.advancedRecipeToolStripMenuItem.Click += new System.EventHandler(this.advancedRecipeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Standard Recipes: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Advanced Recipes: ";
            // 
            // btnDessert
            // 
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.Location = new System.Drawing.Point(936, 670);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(370, 55);
            this.btnDessert.TabIndex = 15;
            this.btnDessert.TabStop = false;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnMainDish
            // 
            this.btnMainDish.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDish.Location = new System.Drawing.Point(492, 670);
            this.btnMainDish.Name = "btnMainDish";
            this.btnMainDish.Size = new System.Drawing.Size(378, 55);
            this.btnMainDish.TabIndex = 14;
            this.btnMainDish.TabStop = false;
            this.btnMainDish.Text = "Main Dish";
            this.btnMainDish.UseVisualStyleBackColor = true;
            this.btnMainDish.Click += new System.EventHandler(this.btnMainDish_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.Location = new System.Drawing.Point(65, 670);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Size = new System.Drawing.Size(356, 55);
            this.btnAppetizer.TabIndex = 13;
            this.btnAppetizer.TabStop = false;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.UseVisualStyleBackColor = true;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(65, 731);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(356, 246);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(936, 731);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(370, 246);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(492, 731);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(378, 246);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 1110);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnMainDish);
            this.Controls.Add(this.btnAppetizer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnBreakfast);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.MouseEnter += new System.EventHandler(this.frmHomePage_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navShowRecipes;
        private System.Windows.Forms.ToolStripMenuItem navAddRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnMainDish;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem standardRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardRecipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem advancedRecipeToolStripMenuItem1;
    }
}

