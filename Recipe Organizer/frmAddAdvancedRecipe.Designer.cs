namespace Recipe_Organizer
{
    partial class frmAddAdvancedRecipe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAdvancedRecipe));
            this.NewRecipe = new System.Windows.Forms.GroupBox();
            this.txtChefTips = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nrDifficultyScore = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.advancedRecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrepTime = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navHome = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDifficultyScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedRecipeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRecipe
            // 
            this.NewRecipe.Controls.Add(this.txtChefTips);
            this.NewRecipe.Controls.Add(this.label6);
            this.NewRecipe.Controls.Add(this.label4);
            this.NewRecipe.Controls.Add(this.nrDifficultyScore);
            this.NewRecipe.Controls.Add(this.pictureBox1);
            this.NewRecipe.Controls.Add(this.label2);
            this.NewRecipe.Controls.Add(this.btnSave);
            this.NewRecipe.Controls.Add(this.txtName);
            this.NewRecipe.Controls.Add(this.txtInstructions);
            this.NewRecipe.Controls.Add(this.label5);
            this.NewRecipe.Controls.Add(this.label1);
            this.NewRecipe.Controls.Add(this.cmbCategory);
            this.NewRecipe.Controls.Add(this.label3);
            this.NewRecipe.Controls.Add(this.txtPrepTime);
            this.NewRecipe.Location = new System.Drawing.Point(12, 86);
            this.NewRecipe.Name = "NewRecipe";
            this.NewRecipe.Size = new System.Drawing.Size(1721, 941);
            this.NewRecipe.TabIndex = 14;
            this.NewRecipe.TabStop = false;
            this.NewRecipe.Text = "New Recipe";
            this.NewRecipe.Enter += new System.EventHandler(this.NewRecipe_Enter);
            // 
            // txtChefTips
            // 
            this.txtChefTips.Location = new System.Drawing.Point(403, 537);
            this.txtChefTips.Name = "txtChefTips";
            this.txtChefTips.Size = new System.Drawing.Size(614, 117);
            this.txtChefTips.TabIndex = 15;
            this.txtChefTips.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chef\'s tips:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Difficulty score:";
            // 
            // nrDifficultyScore
            // 
            this.nrDifficultyScore.Location = new System.Drawing.Point(410, 201);
            this.nrDifficultyScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrDifficultyScore.Name = "nrDifficultyScore";
            this.nrDifficultyScore.Size = new System.Drawing.Size(136, 26);
            this.nrDifficultyScore.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(846, 695);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 65);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(403, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(403, 258);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(614, 254);
            this.txtInstructions.TabIndex = 8;
            this.txtInstructions.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Instructions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Appetizer",
            "Main Dish",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(407, 100);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(139, 28);
            this.cmbCategory.TabIndex = 5;
            // 
            // advancedRecipeBindingSource
            // 
            this.advancedRecipeBindingSource.DataSource = typeof(Recipe_Organizer.AdvancedRecipe);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prep time:";
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(410, 150);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(136, 26);
            this.txtPrepTime.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1839, 62);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navHome
            // 
            this.navHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navHome.Name = "navHome";
            this.navHome.Size = new System.Drawing.Size(112, 42);
            this.navHome.Text = "Home";
            this.navHome.Click += new System.EventHandler(this.navHome_Click);
            // 
            // frmAddAdvancedRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 1010);
            this.Controls.Add(this.NewRecipe);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAddAdvancedRecipe";
            this.Text = "frmAddAdvancedRecipe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddAdvancedRecipe_Load);
            this.NewRecipe.ResumeLayout(false);
            this.NewRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDifficultyScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedRecipeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NewRecipe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.TextBox txtPrepTime;
        public System.Windows.Forms.NumericUpDown nrDifficultyScore;
        public System.Windows.Forms.RichTextBox txtInstructions;
        public System.Windows.Forms.RichTextBox txtChefTips;
        private System.Windows.Forms.BindingSource advancedRecipeBindingSource;
    }
}