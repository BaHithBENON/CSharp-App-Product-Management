/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 02:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using RestaurantManagement.models;
using RestaurantManagement.db;
using System.Linq;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of ChefDashboardUI.
	/// </summary>
	public partial class ChefDashboardUI : Form {
		private List<Product> productsList;
		
		private Product product = null;
		
		public static int updateListCounter { 
			get;
			set;
		}
		
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action ChefUIUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerChefUIUpdated() {
	        ChefUIUpdated.Invoke();
	    }
		
		public ChefDashboardUI() {
			InitializeComponent();
			InitProductsList();
			dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
			ChefDashboardUI.ChefUIUpdated += InitProductsList;
		}
		
		private void InitProductsList() {
			productsList = ProductDao.Instance.ListProducts();
			
			dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.DataSource = productsList;
		}
		
		void ButtonDetailsClick(object sender, EventArgs e) {
			ProductDetailsUI form = new ProductDetailsUI();
			form.populateProduct(product);
            form.Show();
		}
		
		void ButtonAddClick(object sender, EventArgs e) {
			EditProductUI form = new EditProductUI();
            form.Show();
		}
		
		void ButtonUpdateClick(object sender, EventArgs e) {
			if(product != null) {
				EditProductUI form = new EditProductUI();
				form.populateProduct(product);
            	form.Show();
			} else {
				MessageBox.Show("Sélectionnez un product.");
			}
		}
		
		void ButtonDeleteClick(object sender, EventArgs e) {
			if(product != null) {
    			product.Images = ProductDao.Instance.GetProductImages(product.Id, true);
				ProductDao productDao = ProductDao.Instance;
				//MessageBox.Show(product.Id + "");
				if(productDao.DeleteProduct(product.Id, product.Images)) {
					MessageBox.Show("Le produit a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    	InitProductsList();
			    } else {
			        MessageBox.Show("Échec de la suppression du produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
			} else {
				MessageBox.Show("Sélectionnez un produit.");
			}
		}
		
		void DataGridViewProducts_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewProducts.SelectedRows.Count > 0) {
				// dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				// int rowIndex = dataGridViewUsers.SelectedRows[0];
				product = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
			}
		}
		
		void ButtonLogoutClick(object sender, EventArgs e) {
			this.Close();
			AuthUI.TriggerAuthUIUpdated();
		}
    	
		void TextBoxSearchTextChanged(object sender, EventArgs e) {
			// Vérifier si la TextBox de recherche n'est pas vide
		    if (!string.IsNullOrEmpty(textBoxSearch.Text)) {
		    	// Filtrer les étudiants dont une des colonnes (par exemple, le nom ou le prénom) contient le texte de recherche
		        List<Product> resultatsRecherche = productsList
		        	.Where(p => p.Name.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Category.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Id.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Price.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Quantity.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
		            .ToList();
		
		        // Afficher les résultats de la recherche dans le DataGridView
		        dataGridViewProducts.DataSource = resultatsRecherche;
		    } else {
		        // Si la TextBox de recherche est vide, afficher tous les étudiants dans le DataGridView
		        dataGridViewProducts.DataSource = productsList;
		    }
		}
	}
}
