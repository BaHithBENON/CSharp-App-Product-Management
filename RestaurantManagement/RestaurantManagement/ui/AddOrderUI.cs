/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 04:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using RestaurantManagement.models;
using RestaurantManagement.db;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of AddOrderUI.
	/// </summary>
	public partial class AddOrderUI : Form {
		
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action ProductsTableUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerProductsTableUpdated() {
	        ProductsTableUpdated.Invoke();
	    }
		
		private List<Product> productsList = new List<Product>();
		private List<Product> productsListInOrder= new List<Product>();
		
		private Product productSelected = null;
		private Product orderProductSelected = null;
		
		public AddOrderUI() {
			InitializeComponent();
			InitProductsList();
			dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
			dataGridViewOrder.SelectionChanged += DataGridViewOrderProducts_SelectionChanged;
			AddOrderUI.ProductsTableUpdated += InitProductsList;
		}
		
		void InitProductsList() {
			productsList = ProductDao.Instance.ListProducts();
			
			dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.DataSource = productsList;
		}
		
		void InitOrderProductsList() {
			dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewOrder.DataSource = null;
            dataGridViewOrder.DataSource = productsListInOrder;
            
		}
		
		private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewProducts.SelectedRows.Count > 0) {
				productSelected = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
			}
		}
		
		private void DataGridViewOrderProducts_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewOrder.SelectedRows.Count > 0) {
				orderProductSelected = dataGridViewOrder.SelectedRows[0].DataBoundItem as Product;
			}
		}
		
		void ButtonAddProductClick(object sender, EventArgs e) {
			if(productSelected != null  && !productsListInOrder.Contains(productSelected)) {
				productsListInOrder.Add(productSelected);
				productSelected = null;
				InitOrderProductsList();
			}
		}
		
		void ButtonValidOrderClick(object sender, EventArgs e) {
			OrderValidatorUI form = new OrderValidatorUI();
			form.setProducts(productsListInOrder);
			form.Show();
		}
		
		void ButtonDeleteClick(object sender, EventArgs e) {
			if(orderProductSelected != null) {
				productsListInOrder.Remove(orderProductSelected);
				orderProductSelected = null;
				InitOrderProductsList();
			} else {
				MessageBox.Show("Sélectionnez un produit.");
			}
		}
		
		void ButtonLogoutClick(object sender, EventArgs e) {
			this.Close();
		}
	}
}
