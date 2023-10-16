/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 04:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class AddOrderUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonValidOrder;
		private System.Windows.Forms.DataGridView dataGridViewOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button buttonAddProduct;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn category;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonValidOrder = new System.Windows.Forms.Button();
			this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonAddProduct = new System.Windows.Forms.Button();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(1027, 654);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(231, 43);
			this.buttonDelete.TabIndex = 35;
			this.buttonDelete.Text = "Retirer";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(774, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 33);
			this.label2.TabIndex = 34;
			this.label2.Text = "Votre commande";
			// 
			// buttonValidOrder
			// 
			this.buttonValidOrder.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonValidOrder.Location = new System.Drawing.Point(774, 654);
			this.buttonValidOrder.Name = "buttonValidOrder";
			this.buttonValidOrder.Size = new System.Drawing.Size(231, 43);
			this.buttonValidOrder.TabIndex = 33;
			this.buttonValidOrder.Text = "Valider";
			this.buttonValidOrder.UseVisualStyleBackColor = true;
			this.buttonValidOrder.Click += new System.EventHandler(this.ButtonValidOrderClick);
			// 
			// dataGridViewOrder
			// 
			this.dataGridViewOrder.AllowUserToAddRows = false;
			this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5});
			this.dataGridViewOrder.Location = new System.Drawing.Point(774, 81);
			this.dataGridViewOrder.MultiSelect = false;
			this.dataGridViewOrder.Name = "dataGridViewOrder";
			this.dataGridViewOrder.ReadOnly = true;
			this.dataGridViewOrder.RowTemplate.Height = 24;
			this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOrder.Size = new System.Drawing.Size(717, 549);
			this.dataGridViewOrder.TabIndex = 32;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
			this.dataGridViewTextBoxColumn3.HeaderText = "Categorie";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
			this.dataGridViewTextBoxColumn5.HeaderText = "Quantité";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// buttonAddProduct
			// 
			this.buttonAddProduct.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddProduct.Location = new System.Drawing.Point(29, 654);
			this.buttonAddProduct.Name = "buttonAddProduct";
			this.buttonAddProduct.Size = new System.Drawing.Size(231, 43);
			this.buttonAddProduct.TabIndex = 31;
			this.buttonAddProduct.Text = "Commander";
			this.buttonAddProduct.UseVisualStyleBackColor = true;
			this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProductClick);
			// 
			// buttonLogout
			// 
			this.buttonLogout.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.Location = new System.Drawing.Point(1262, 29);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(229, 40);
			this.buttonLogout.TabIndex = 30;
			this.buttonLogout.Text = "Quitter";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.ButtonLogoutClick);
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
			this.dataGridViewProducts.Location = new System.Drawing.Point(29, 129);
			this.dataGridViewProducts.MultiSelect = false;
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.ReadOnly = true;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProducts.Size = new System.Drawing.Size(718, 501);
			this.dataGridViewProducts.TabIndex = 29;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// name
			// 
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Nom";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// category
			// 
			this.category.DataPropertyName = "category";
			this.category.HeaderText = "Categorie";
			this.category.Name = "category";
			this.category.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.HeaderText = "Prix";
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// quantity
			// 
			this.quantity.DataPropertyName = "quantity";
			this.quantity.HeaderText = "Quantité";
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(29, 81);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(718, 33);
			this.textBoxSearch.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(29, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 33);
			this.label1.TabIndex = 27;
			this.label1.Text = "Liste des produits";
			// 
			// AddOrderUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1597, 729);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonValidOrder);
			this.Controls.Add(this.dataGridViewOrder);
			this.Controls.Add(this.buttonAddProduct);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Name = "AddOrderUI";
			this.Text = "AddOrderUI";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
