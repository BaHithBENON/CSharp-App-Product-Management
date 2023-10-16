/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 03:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantManagement.db;
using System.Collections.Generic;
using RestaurantManagement.models;
using System.Linq;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of OrdersList.
	/// </summary>
	public partial class OrdersList : Form {
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action OrdersTableUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerOrdersTableUpdated() {
	        OrdersTableUpdated.Invoke();
	    }
    	
		private List<Order> ordersList = new List<Order>();
		private List<Product> productsList = new List<Product>();
		Order orderSelected = null;
		
		public OrdersList() {
			InitializeComponent();
			InitOrdersList();
			dataGridViewOrders.SelectionChanged += DataGridViewOrderProducts_SelectionChanged;
			OrdersList.OrdersTableUpdated += InitOrdersList;
		}
		
		private void InitOrdersList() {
			ordersList = OrderDao.Instance.ListOrders();
			dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewOrders.DataSource = ordersList;
		}
		
		private void DataGridViewOrderProducts_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewOrders.SelectedRows.Count > 0) {
				orderSelected = dataGridViewOrders.SelectedRows[0].DataBoundItem as Order;
				InitProductsList();
			}
		}
		
		private void InitProductsList() {
			// MessageBox.Show(orderSelected.Products.Count.ToString());
			productsList = OrderDao.Instance.GetProductsByOrderId(orderSelected.Id, true);
			dataGridViewProducts.DataSource = null;
			dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewProducts.DataSource = productsList;
		}
		
		void ButtonOrderPaimentClick(object sender, EventArgs e) {
			if(orderSelected != null) {
				AddPaymentUI form = new AddPaymentUI();
				form.populate(orderSelected);
				form.fromOrderList = true;
				form.Show();
			} else {
				MessageBox.Show("Sélectionnez une commande d'abord.");
			}
		}
		
		void ButtonDeleteOrderClick(object sender, EventArgs e) {
			if(orderSelected != null) {
				if(OrderDao.Instance.DeleteOrder(orderSelected.Id)) {
					MessageBox.Show("La commande a été supprimée avec succès.", "Succès", 
					                MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					InitOrdersList();
				} else {
					MessageBox.Show("Échec de la suppression de commande.", "Erreur", 
					                MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Sélectionnez une commande d'abord.");
			}
		}
		
		void TextBoxSearchTextChanged(object sender, EventArgs e) {
			// Vérifier si la TextBox de recherche n'est pas vide
		    if (!string.IsNullOrEmpty(textBoxSearch.Text)) {
		    	// Filtrer les étudiants dont une des colonnes (par exemple, le nom ou le prénom) contient le texte de recherche
		        List<Order> resultatsRecherche = ordersList
		        	.Where(o => o.OrderReference.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       o.OrderDate.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       o.Id.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       o.TotalPrice.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
		            .ToList();
		
		        // Afficher les résultats de la recherche dans le DataGridView
		        dataGridViewOrders.DataSource = resultatsRecherche;
		    } else {
		        // Si la TextBox de recherche est vide, afficher tous les étudiants dans le DataGridView
		        dataGridViewOrders.DataSource = ordersList;
		    }
		}
	}
}
