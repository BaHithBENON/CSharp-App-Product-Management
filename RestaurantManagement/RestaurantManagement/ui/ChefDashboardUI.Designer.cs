/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 02:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class ChefDashboardUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn category;
		
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDetails = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(29, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "Liste des produits";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(29, 73);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(947, 33);
			this.textBoxSearch.TabIndex = 8;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
			// 
			// quantity
			// 
			this.quantity.DataPropertyName = "quantity";
			this.quantity.HeaderText = "Quantité";
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.HeaderText = "Prix";
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// category
			// 
			this.category.DataPropertyName = "category";
			this.category.HeaderText = "Categorie";
			this.category.Name = "category";
			this.category.ReadOnly = true;
			// 
			// name
			// 
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Nom";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.name,
			this.category,
			this.price,
			this.quantity});
			this.dataGridViewProducts.Location = new System.Drawing.Point(29, 121);
			this.dataGridViewProducts.MultiSelect = false;
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.ReadOnly = true;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProducts.Size = new System.Drawing.Size(947, 502);
			this.dataGridViewProducts.TabIndex = 9;
			// 
			// buttonLogout
			// 
			this.buttonLogout.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.Location = new System.Drawing.Point(747, 27);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(229, 40);
			this.buttonLogout.TabIndex = 10;
			this.buttonLogout.Text = "Quitter";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.ButtonLogoutClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Red;
			this.buttonDelete.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.Color.White;
			this.buttonDelete.Location = new System.Drawing.Point(809, 648);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(167, 43);
			this.buttonDelete.TabIndex = 11;
			this.buttonDelete.Text = "Supprimer";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.Location = new System.Drawing.Point(593, 648);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(146, 43);
			this.buttonUpdate.TabIndex = 12;
			this.buttonUpdate.Text = "Modifier";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(327, 648);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(195, 43);
			this.buttonAdd.TabIndex = 13;
			this.buttonAdd.Text = "Ajouter";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// buttonDetails
			// 
			this.buttonDetails.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDetails.Location = new System.Drawing.Point(100, 648);
			this.buttonDetails.Name = "buttonDetails";
			this.buttonDetails.Size = new System.Drawing.Size(195, 43);
			this.buttonDetails.TabIndex = 14;
			this.buttonDetails.Text = "Details";
			this.buttonDetails.UseVisualStyleBackColor = true;
			this.buttonDetails.Click += new System.EventHandler(this.ButtonDetailsClick);
			// 
			// ChefDashboardUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1011, 718);
			this.Controls.Add(this.buttonDetails);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Name = "ChefDashboardUI";
			this.Text = "ChefDashboardUI";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
