/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 00:11
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
	/// Description of OrderValidatorUI.
	/// </summary>
	public partial class OrderValidatorUI : Form {
		
		private List<Product> productsList = new List<Product>();
		private List<Product> productsListInOrder = new List<Product>();
		
		public void setProducts(List<Product> products) {
			this.productsList = products;
			this.productsListInOrder = products;
			InitList();
		}
		
		public OrderValidatorUI() {
			InitializeComponent();
			
			InitList();
			labelTotalPrice.Text = "XOF " +  CalculateGlobalPrice();
		}
		
		private void InitList() {
			foreach (Product product in productsList) {
			    // Créez un Panel pour chaque produit
			    Panel productPanel = new Panel();
			    productPanel.Width = flowLayoutPanelProducts.ClientSize.Width; // Assurez-vous qu'il occupe toute la largeur disponible
			    
			    // Créez un TableLayoutPanel pour chaque produit
			    TableLayoutPanel productTableLayoutPanel = new TableLayoutPanel();
			    productTableLayoutPanel.Dock = DockStyle.Top;
			    productTableLayoutPanel.Width = flowLayoutPanelProducts.ClientSize.Width;
			
			    // Créez un Label pour afficher l'id et le nom du produit
			    Label nameLabel = new Label();
			    nameLabel.Text = "ID: " + product.Id + ", Name: " + product.Name;
			    nameLabel.AutoSize = true;
			    nameLabel.Font = new Font("Space Mono", 10, FontStyle.Bold); // Personnalisez la police et le poids de la police
			    nameLabel.Dock = DockStyle.Fill;
			
			    // Créez un NumericUpDown personnalisé pour la quantité
			    NumericUpDown quantityNumericUpDown = new NumericUpDown();
			    quantityNumericUpDown.Name = product.Name;
			    quantityNumericUpDown.Maximum = product.Quantity; // Définissez la quantité maximale sur la quantité du produit
			    quantityNumericUpDown.Minimum = 0;
			    quantityNumericUpDown.Width = 60; // Personnalisez la largeur selon vos besoins
			    quantityNumericUpDown.Value = 0; // Initialisez la quantité à zéro par défaut
			    quantityNumericUpDown.Dock = DockStyle.Fill;
			    quantityNumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
			
			    // Ajoutez le Label et le NumericUpDown au Panel
			    productTableLayoutPanel.Controls.Add(nameLabel);
			    productTableLayoutPanel.Controls.Add(quantityNumericUpDown);
			
			    // Ajoutez le Panel au FlowLayoutPanel vertical
			    flowLayoutPanelProducts.Controls.Add(productTableLayoutPanel);
			}
		}
		
		// Méthode pour calculer le prix total pour chaque produit
		private double CalculateTotalPrice(Product product, int quantity) {
		    return product.Price * quantity;
		}
		// Définissez le gestionnaire d'événement pour tous les NumericUpDown
		private void NumericUpDown_ValueChanged(object sender, EventArgs e) {
		    // Recalculez le prix global
		    double globalPrice = CalculateGlobalPrice();
		
		    // Mettez à jour la valeur du labelTotalPrice
		    labelTotalPrice.Text = "XOF " + globalPrice.ToString();
		    labelTotalPrice.Refresh();
		}
		
		// Méthode pour calculer le prix global de tous les produits
		private double CalculateGlobalPrice() {
		    double globalPrice = 0;
		    foreach (Control control in flowLayoutPanelProducts.Controls) {
		    	foreach(Control con in control.Controls) {
		    		if (con is NumericUpDown) {
			    		NumericUpDown numericUpDown = (NumericUpDown)con;
			            // Trouvez le produit correspondant en fonction du nom du contrôle
			            string controlId = numericUpDown.Name;
			            //int productId = int.Parse(controlId.Substring("numericUpDown_".Length));
			            Product product = productsList.Find(p => p.Name == controlId);
			
			            // Obtenez la quantité du NumericUpDown
			            int quantity = (int)numericUpDown.Value;
			
			            // Calculez le prix total pour ce produit
			            double totalPrice = CalculateTotalPrice(product, quantity);
			            
			            foreach(Product p in productsListInOrder) {
			            	if(p.Name == product.Name) {
			            		p.Quantity = quantity;
			            	}
			            }
			
			            // Ajoutez le prix total au prix global
			            globalPrice += totalPrice;
			        }
		    	}
		    }
		    return globalPrice;
		}
		
		void ButtonSubmitClick(object sender, EventArgs e) {
			Order order = new Order();
			order.TotalPrice = CalculateGlobalPrice();
			order.Products = productsListInOrder;
			
			DateTime maDate = DateTime.Now; // Remplacez par votre objet DateTime
			order.OrderDate = maDate;
			order.OrderReference = "#CMD@" + maDate.ToString("yyyy-MM-dd HH:mm:ss")
					.Replace("-", "").Replace(":", "").Replace(" ", "");
			
			OrderDao orderDao = OrderDao.Instance;
			if(orderDao.CreateOrder(order, productsListInOrder)) {
				MessageBox.Show("La commande a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				AddOrderUI.TriggerProductsTableUpdated();
				this.Close();
			} else {
				MessageBox.Show("Échec de l'ajout de commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
