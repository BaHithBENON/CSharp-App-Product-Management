/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class RecipesUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFrequency;
		private System.Windows.Forms.ComboBox comboBoxProducts;
		private System.Windows.Forms.DataGridView dataGridViewRecipes;
		private System.Windows.Forms.DataGridViewTextBoxColumn period;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipe;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxProducts = new System.Windows.Forms.ComboBox();
			this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
			this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(28, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(419, 33);
			this.label1.TabIndex = 17;
			this.label1.Text = "Recettes";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(28, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(255, 34);
			this.label8.TabIndex = 25;
			this.label8.Text = "Fréquence de tri";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(300, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 34);
			this.label2.TabIndex = 26;
			this.label2.Text = "Produits";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxProducts
			// 
			this.comboBoxProducts.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxProducts.FormattingEnabled = true;
			this.comboBoxProducts.Location = new System.Drawing.Point(300, 109);
			this.comboBoxProducts.Name = "comboBoxProducts";
			this.comboBoxProducts.Size = new System.Drawing.Size(255, 33);
			this.comboBoxProducts.TabIndex = 28;
			// 
			// comboBoxFrequency
			// 
			this.comboBoxFrequency.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxFrequency.FormattingEnabled = true;
			this.comboBoxFrequency.Items.AddRange(new object[] {
			"Journalière",
			"Hebdomadaire",
			"Mensuelle"});
			this.comboBoxFrequency.Location = new System.Drawing.Point(28, 109);
			this.comboBoxFrequency.Name = "comboBoxFrequency";
			this.comboBoxFrequency.Size = new System.Drawing.Size(255, 33);
			this.comboBoxFrequency.TabIndex = 29;
			//this.comboBoxFrequency.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrequencySelectedIndexChanged);
			// 
			// dataGridViewRecipes
			// 
			this.dataGridViewRecipes.AllowUserToAddRows = false;
			this.dataGridViewRecipes.AllowUserToDeleteRows = false;
			this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.period,
			this.recipe});
			this.dataGridViewRecipes.Location = new System.Drawing.Point(28, 176);
			this.dataGridViewRecipes.Name = "dataGridViewRecipes";
			this.dataGridViewRecipes.ReadOnly = true;
			this.dataGridViewRecipes.RowTemplate.Height = 24;
			this.dataGridViewRecipes.Size = new System.Drawing.Size(527, 534);
			this.dataGridViewRecipes.TabIndex = 30;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// period
			// 
			this.period.DataPropertyName = "period";
			this.period.HeaderText = "Periode";
			this.period.Name = "period";
			this.period.ReadOnly = true;
			// 
			// recipe
			// 
			this.recipe.DataPropertyName = "RecipeAmount";
			this.recipe.HeaderText = "Recette";
			this.recipe.Name = "recipe";
			this.recipe.ReadOnly = true;
			// 
			// RecipesUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 734);
			this.Controls.Add(this.dataGridViewRecipes);
			this.Controls.Add(this.comboBoxFrequency);
			this.Controls.Add(this.comboBoxProducts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Name = "RecipesUI";
			this.Text = "RecipesUI";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
