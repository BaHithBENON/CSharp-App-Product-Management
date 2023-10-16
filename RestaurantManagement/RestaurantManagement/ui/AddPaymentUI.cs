/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantManagement.db;
using System.Collections.Generic;
using RestaurantManagement.models;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of AddPaymentUI.
	/// </summary>
	public partial class AddPaymentUI : Form {
		private Order order = null;
		private Payment payment = null;
		
		public bool fromOrderList { get; set; }
		public bool fromPaymentList { get; set; }
		
		public void setOrder(Order order) {
			this.order = order;
		}
		
		public void setPayment(Payment payment) {
			this.payment = payment;
		}
		
		public AddPaymentUI() {
			InitializeComponent();
		}
		
		public void populate(Order order) {
			setOrder(order);
			labelOrderRef.Text += order.OrderReference;
			labelOrderDate.Text += order.OrderDate.ToString();
			labelOrderAmount.Text += order.TotalPrice.ToString();
			
			// Pour le payment
			if(payment == null) {
				payment = PaymentDao.Instance.GetPaymentByOrder(order);
			}
			
			if(payment != null) {
				labelPaymentDate.Text += payment.PaymentDate.ToString();
				labelPaymentRef.Text += payment.PaymentReference;
				
				textBoxAmountPayroll.Text = payment.PayrollAmount.ToString();
				textBoxRemaider.Text = payment.Remainder.ToString();
			}
			
		}
		
		private bool ValidatePaymentFields() {
		    // Vérifiez si les champs requis sont vides
		    if (string.IsNullOrWhiteSpace(textBoxAmountPayroll.Text) || 
		        string.IsNullOrWhiteSpace(textBoxRemaider.Text)) {
		        // Affichez des messages d'alerte pour les champs vides
		        MessageBox.Show("Veuillez remplir tous les champs pour ajouter un produit.", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return false;
		    }
		    double a, b;
		    // Vérifiez si le prix est un nombre valide
		    if (!double.TryParse(textBoxAmountPayroll.Text, out a) ||
		       	!double.TryParse(textBoxRemaider.Text, out b)) {
		        MessageBox.Show("Le champ des montant doit être un nombre valide.", "Format invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return false;
		    }
		
		    return true;
		}
		
		void ButtonValidPaymentClick(object sender, EventArgs e) {
			if(ValidatePaymentFields()) {
				
				if(double.Parse(textBoxAmountPayroll.Text) < order.TotalPrice) {
					MessageBox.Show("Le champ des montant payé est inférieur à la somme totale.", "Montant invalide", 
					                MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					Payment pay = new Payment();
					pay.OrderId = order.Id;
					pay.OrderReference = order.OrderReference;
					DateTime maDate = DateTime.Now;
					pay.PaymentDate = maDate;
					pay.PaymentReference = "#PAY@" + maDate.ToString("yyyy-MM-dd HH:mm:ss")
							.Replace("-", "").Replace(":", "").Replace(" ", "");
					pay.PayrollAmount = double.Parse(textBoxAmountPayroll.Text);
					pay.Remainder = double.Parse(textBoxRemaider.Text);
					
					// Pour l'ajout (le payement n'existe pas encore)
					if(payment == null) {
						if(PaymentDao.Instance.CreatePayment(pay)) {
							MessageBox.Show("La paiement a été effectué avec succès.", 
							                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Close();
						} else {
							MessageBox.Show("Échec du paiement de commande.", 
							                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					} else {
						// Pour la mise à jour
						pay.Id = payment.Id;
						if(PaymentDao.Instance.UpdatePayment(pay)) {
							MessageBox.Show("La paiement a été modifié avec succès.", 
							                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
							if(fromOrderList) {
								OrdersList.TriggerOrdersTableUpdated();
							}
							
							if(fromPaymentList) {
								PaymentsUI.TriggerPaymentsTableUpdated();
							}
							
							this.Close();
						} else {
							MessageBox.Show("Échec du paiement de commande.", 
							                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}
		
		void ButtonDeletePaymentClick(object sender, EventArgs e) {
			if(PaymentDao.Instance.DeletePayment(payment.Id)) {
				MessageBox.Show("La paiement a été supprimé avec succès.", 
				                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PaymentsUI.TriggerPaymentsTableUpdated();
				this.Close();
			} else {
				MessageBox.Show("Échec du paiement de commande.", 
				                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
	}
}
