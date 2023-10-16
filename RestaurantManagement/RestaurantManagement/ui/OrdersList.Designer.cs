/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 03:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class OrdersList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewOrders;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderReference;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button buttonOrderPaiment;
		private System.Windows.Forms.Button buttonDeleteOrder;
		
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
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonOrderPaiment = new System.Windows.Forms.Button();
			this.buttonDeleteOrder = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.AllowUserToAddRows = false;
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.totalPrice,
			this.orderReference,
			this.orderDate});
			this.dataGridViewOrders.Location = new System.Drawing.Point(22, 113);
			this.dataGridViewOrders.MultiSelect = false;
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.ReadOnly = true;
			this.dataGridViewOrders.RowTemplate.Height = 24;
			this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOrders.Size = new System.Drawing.Size(718, 580);
			this.dataGridViewOrders.TabIndex = 32;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(22, 65);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(718, 33);
			this.textBoxSearch.TabIndex = 31;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(22, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 33);
			this.label1.TabIndex = 30;
			this.label1.Text = "Liste des commandes";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(764, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 33);
			this.label2.TabIndex = 36;
			this.label2.Text = "Les produits";
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5});
			this.dataGridViewProducts.Location = new System.Drawing.Point(764, 65);
			this.dataGridViewProducts.MultiSelect = false;
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.ReadOnly = true;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProducts.Size = new System.Drawing.Size(717, 628);
			this.dataGridViewProducts.TabIndex = 35;
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
			// buttonOrderPaiment
			// 
			this.buttonOrderPaiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonOrderPaiment.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOrderPaiment.ForeColor = System.Drawing.Color.White;
			this.buttonOrderPaiment.Location = new System.Drawing.Point(1319, 713);
			this.buttonOrderPaiment.Name = "buttonOrderPaiment";
			this.buttonOrderPaiment.Size = new System.Drawing.Size(162, 46);
			this.buttonOrderPaiment.TabIndex = 37;
			this.buttonOrderPaiment.Text = "Paiement";
			this.buttonOrderPaiment.UseVisualStyleBackColor = false;
			this.buttonOrderPaiment.Click += new System.EventHandler(this.ButtonOrderPaimentClick);
			// 
			// buttonDeleteOrder
			// 
			this.buttonDeleteOrder.BackColor = System.Drawing.Color.Red;
			this.buttonDeleteOrder.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteOrder.ForeColor = System.Drawing.Color.White;
			this.buttonDeleteOrder.Location = new System.Drawing.Point(764, 713);
			this.buttonDeleteOrder.Name = "buttonDeleteOrder";
			this.buttonDeleteOrder.Size = new System.Drawing.Size(162, 46);
			this.buttonDeleteOrder.TabIndex = 38;
			this.buttonDeleteOrder.Text = "Supprimer";
			this.buttonDeleteOrder.UseVisualStyleBackColor = false;
			this.buttonDeleteOrder.Click += new System.EventHandler(this.ButtonDeleteOrderClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// totalPrice
			// 
			this.totalPrice.DataPropertyName = "totalPrice";
			this.totalPrice.HeaderText = "Solde";
			this.totalPrice.Name = "totalPrice";
			this.totalPrice.ReadOnly = true;
			// 
			// orderReference
			// 
			this.orderReference.DataPropertyName = "orderReference";
			this.orderReference.HeaderText = "Reference";
			this.orderReference.Name = "orderReference";
			this.orderReference.ReadOnly = true;
			// 
			// orderDate
			// 
			this.orderDate.DataPropertyName = "orderDate";
			this.orderDate.HeaderText = "Date";
			this.orderDate.Name = "orderDate";
			this.orderDate.ReadOnly = true;
			// 
			// OrdersList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1523, 784);
			this.Controls.Add(this.buttonDeleteOrder);
			this.Controls.Add(this.buttonOrderPaiment);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Name = "OrdersList";
			this.Text = "OrdersList";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
