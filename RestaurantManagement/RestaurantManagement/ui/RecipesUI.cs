/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using RestaurantManagement.models;
using RestaurantManagement.db;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of RecipesUI.
	/// </summary>
	public partial class RecipesUI : Form {
		
		private List<Product> productsList = new List<Product>();
		private List<Payment> paymentsList = new List<Payment>();
		private List<Recipe> recipesList = new List<Recipe>();
		
		public RecipesUI() {
			InitializeComponent();
			
			
			
			InitProducts();
			InitPayments();
			
	        comboBoxFrequency.SelectedIndex = 0;
	        comboBoxProducts.SelectedIndex = 0;
	        FilterAndGroupByDay();
	        
			InitRecipesTableGridView();
			
			// Abonnez-vous aux événements ComboBox.
	        comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
	        comboBoxFrequency.SelectedIndexChanged += comboBoxFrequency_SelectedIndexChanged;

		}
		
		private void InitProducts() {
			productsList = ProductDao.Instance.ListProducts();
			// Assurez-vous que comboBoxProducts est vidé avant d'ajouter de nouveaux éléments.
			comboBoxProducts.Items.Clear();
			// Parcourez la liste des produits et ajoutez-les au ComboBox.
			comboBoxProducts.Items.Add("Tous");
			foreach (Product product in productsList) {
			    // Vous pouvez spécifier ce que vous voulez afficher dans le ComboBox en utilisant la propriété DisplayMember.
			    // Par exemple, si vous voulez afficher le nom du produit, utilisez product.Name.
			    comboBoxProducts.Items.Add(product.Name);
			}
			
		}
		
		private void InitPayments() {
			paymentsList = PaymentDao.Instance.ListPayments();
			
		}
		
		private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e) {
			comboBoxFrequency_SelectedIndexChanged(sender, e);
	    }
	
	    private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e) {
	        // Récupérez la valeur sélectionnée du ComboBox
    		string selectedValue = comboBoxFrequency.SelectedItem.ToString();
    		if(selectedValue == "Journalière") {
    			FilterAndGroupByDay();
    		} else if(selectedValue == "Hebdomadaire") {
    			FilterAndGroupByWeek();
    		} else {
    			FilterAndGroupByMonth();
    		}
	    }
		
		private void InitRecipesTableGridView() {
			// Obtenez les valeurs sélectionnées dans les ComboBox.
	        //string selectedProduct = comboBoxProducts.SelectedItem.ToString();
	        //string selectedFrequency = comboBoxFrequency.SelectedItem.ToString();
	        
	        // Filtrer les paiements en fonction du produit sélectionné.
        	// var filteredPayments = paymentsList.Where(payment => payment.ProductName == selectedProduct);
        	
			dataGridViewRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        	dataGridViewRecipes.DataSource = null;
        	dataGridViewRecipes.DataSource = recipesList;

			
		}
		
		private void FilterAndGroupByDay() {
			recipesList.Clear();
			foreach (Payment payment in paymentsList) {
				// Récupérez la valeur sélectionnée du ComboBox
    			string productSelectedValue = comboBoxProducts.SelectedItem.ToString();
    			double soldeByProduct = 0;
    			if(productSelectedValue != "Tous") {
    				// Recupérer la commande
					Order order = OrderDao.Instance.GetOrderById(payment.OrderId);
					List<Product> list = new List<Product>();
					if(order != null) {
						list = OrderDao.Instance.GetProductsByOrderId(order.Id, true);
					}
					
	    			foreach(Product p in list) {
	    				if(p.Name == productSelectedValue) {
							soldeByProduct += (p.Price * p.Quantity);
	    				}
	    			}
    			}
    			
				// On récupère la période
				String paymentPeriod = CalculatePeriod(payment.PaymentDate.ToString());
				// Recup de la période
				Recipe recipe = recipesList.Find((r) => r.Period.Equals(paymentPeriod));
				// Si la periode existe déjà
				if(recipe != null) {
					// On cumule les payes
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount += (payment.PayrollAmount - payment.Remainder);
					}
				} else {
					recipe = new Recipe();
					// Si la periode n'exite pas
					recipe.Period = paymentPeriod;
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount = (payment.PayrollAmount - payment.Remainder);
					}
					recipesList.Add(recipe);
				}
			}
			
			InitRecipesTableGridView();
		}
		
		private void FilterAndGroupByWeek() {
			recipesList.Clear();
			foreach (Payment payment in paymentsList) {
				DateTime paymentDate = GetDateFromString(payment.PaymentDate.ToString());
				DateTime startOfWeek = paymentDate.AddDays(-(int)paymentDate.DayOfWeek + (int)DayOfWeek.Monday);
				int weekNumber = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(paymentDate, 
				        CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
				DateTime endOfWeek = startOfWeek.AddDays(6);
				
				// Récupérez la valeur sélectionnée du ComboBox
    			string productSelectedValue = comboBoxProducts.SelectedItem.ToString();
    			double soldeByProduct = 0;
    			if(productSelectedValue != "Tous") {
    				// Recupérer la commande
					Order order = OrderDao.Instance.GetOrderById(payment.OrderId);
					List<Product> list = new List<Product>();
					if(order != null) {
						list = OrderDao.Instance.GetProductsByOrderId(order.Id, true);
					}
					
	    			foreach(Product p in list) {
	    				if(p.Name == productSelectedValue) {
							soldeByProduct += (p.Price * p.Quantity);
	    				}
	    			}
    			}
    			
				
				String paymentPeriod = startOfWeek.ToString("dd/MM/yyyy") + " - " + endOfWeek.ToString("dd/MM/yyyy");
				// Recup de la période
				Recipe recipe = recipesList.Find((r) => r.Period.Equals(paymentPeriod));
				// Si la periode existe déjà
				if(recipe != null) {
					// On cumule les payes
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount += (payment.PayrollAmount - payment.Remainder);
					}
				} else {
					recipe = new Recipe();
					// Si la periode n'exite pas
					recipe.Period = paymentPeriod;
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount = (payment.PayrollAmount - payment.Remainder);
					}
					recipesList.Add(recipe);
				}
			}
			InitRecipesTableGridView();
		}
		
		private void FilterAndGroupByMonth() {
			recipesList.Clear();
			foreach (Payment payment in paymentsList) {
				DateTime paymentDate = GetDateFromString(payment.PaymentDate.ToString());
				DateTime firstOfMonth = new DateTime(paymentDate.Year, paymentDate.Month, 1);
				// Obtenir l'année et le mois sous forme de chaîne au format "yyyy-MM"
				string yearMonth = paymentDate.ToString("yyyy-MM");
				
				// Récupérez la valeur sélectionnée du ComboBox
    			string productSelectedValue = comboBoxProducts.SelectedItem.ToString();
    			double soldeByProduct = 0;
    			if(productSelectedValue != "Tous") {
    				// Recupérer la commande
					Order order = OrderDao.Instance.GetOrderById(payment.OrderId);
					List<Product> list = new List<Product>();
					if(order != null) {
						list = OrderDao.Instance.GetProductsByOrderId(order.Id, true);
					}
					
	    			foreach(Product p in list) {
	    				if(p.Name == productSelectedValue) {
							soldeByProduct += (p.Price * p.Quantity);
	    				}
	    			}
    			}
    			
				String paymentPeriod = yearMonth;
				// Recup de la période
				Recipe recipe = recipesList.Find((r) => r.Period.Equals(paymentPeriod));
				// Si la periode existe déjà
				if(recipe != null) {
					// On cumule les payes
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount += (payment.PayrollAmount - payment.Remainder);
					}
				} else {
					recipe = new Recipe();
					// Si la periode n'exite pas
					recipe.Period = paymentPeriod;
					if(productSelectedValue != "Tous") {
						recipe.RecipeAmount += soldeByProduct;
					} else {
						recipe.RecipeAmount = (payment.PayrollAmount - payment.Remainder);
					}
					recipesList.Add(recipe);
				}
				
			}
			InitRecipesTableGridView();
		}
	
		public string CalculatePeriod(string dateString) {
		    // Définissez le format de date attendu.
		    string dateFormat = "dd/MM/yyyy HH:mm:ss";
		
		    try {
		        // Utilisez DateTime.ParseExact pour convertir la chaîne en objet DateTime en spécifiant le format.
		        DateTime date = DateTime.ParseExact(dateString, dateFormat, System.Globalization.CultureInfo.InvariantCulture);
		
		        // Implémentez votre logique de calcul de période ici.
		        int day = date.Day;
		        int month = date.Month;
		        int year = date.Year;
		
		        // Exemple de logique de calcul de période pour afficher le mois et l'année.
		        return string.Format("{0:D2}/{1:D2}/{2}", day, month, year);
		    } catch (FormatException) {
		        // En cas d'erreur de format de date.
		        return "Date invalide";
		    }
		}
		
		public DateTime GetDateFromString(string dateString) {
		    // Définissez le format de date attendu
		    string dateFormat = "dd/MM/yyyy HH:mm:ss";
		
		    // Utilisez DateTime.TryParseExact pour convertir la chaîne en objet DateTime en spécifiant le format
		    DateTime result;
		    if (DateTime.TryParseExact(dateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out result)) {
		        return result.Date; // Récupérez seulement la partie de la date sans l'heure
		    } else {
		        throw new FormatException("Format de date invalide");
		    }
		}

	}
}
