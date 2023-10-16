/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 12:11
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
	/// Description of PaymentsUI.
	/// </summary>
	public partial class PaymentsUI : Form {
		private List<Payment> paymentsList = new List<Payment>();
		private Payment paymentSelected = null;
		
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action PaymentsTableUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerPaymentsTableUpdated() {
	        PaymentsTableUpdated.Invoke();
	    }
		
		public PaymentsUI() {
			InitializeComponent();
			
			InitPaymentsList();
			dataGridViewPayments.SelectionChanged += DataGridViewPayments_SelectionChanged;
			PaymentsUI.PaymentsTableUpdated += InitPaymentsList;
		}
		
		private void InitPaymentsList() {
			paymentsList = PaymentDao.Instance.ListPayments();
			dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewPayments.DataSource = paymentsList;
		}
		
		private void DataGridViewPayments_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewPayments.SelectedRows.Count > 0) {
				paymentSelected = dataGridViewPayments.SelectedRows[0].DataBoundItem as Payment;
			}
		}
		
		void ButtonUpdatePaymentClick(object sender, EventArgs e) {
			if(paymentSelected != null) {
				AddPaymentUI form = new AddPaymentUI();
				Order order = OrderDao.Instance.GetOrderById(paymentSelected.OrderId);
				form.populate(order);
				form.setPayment(paymentSelected);
				form.fromPaymentList = true;
				form.Show();
				
				InitPaymentsList();
			} else {
				MessageBox.Show("Sélectionnez un paiement");
			}
		}
		
		void ButtonDeletePaymentClick(object sender, EventArgs e) {
			if(paymentSelected != null) {
				if(PaymentDao.Instance.DeletePayment(paymentSelected.Id)) {
					MessageBox.Show("La paiement a été supprimé avec succès.", 
					                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
					InitPaymentsList();
				} else {
					MessageBox.Show("Échec du paiement de commande.", 
					                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Sélectionnez un paiement");
			}
		}
    	
		void TextBoxSearchTextChanged(object sender, EventArgs e) {
			// Vérifier si la TextBox de recherche n'est pas vide
		    if (!string.IsNullOrEmpty(textBoxSearch.Text)) {
		    	// Filtrer les étudiants dont une des colonnes (par exemple, le nom ou le prénom) contient le texte de recherche
		        List<Payment> resultatsRecherche = paymentsList
		        	.Where(p => p.OrderReference.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.PaymentDate.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Id.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.PaymentReference.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.PayrollAmount.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       p.Remainder.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper())||
		        	       p.OrderId.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper())
		        	 )
		            .ToList();
		
		        // Afficher les résultats de la recherche dans le DataGridView
		        dataGridViewPayments.DataSource = resultatsRecherche;
		    } else {
		        // Si la TextBox de recherche est vide, afficher tous les étudiants dans le DataGridView
		        dataGridViewPayments.DataSource = paymentsList;
		    }
		}
	}
}
