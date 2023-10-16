/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 03:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of RestaurateurUI.
	/// </summary>
	public partial class RestaurateurUI : Form {
		
		public RestaurateurUI() {
			InitializeComponent();
		}
		
		void ButtonAddOrderClick(object sender, EventArgs e) {
			AddOrderUI form = new AddOrderUI();
            form.Show();
		}
		
		void ButtonListOrdersClick(object sender, EventArgs e) {
			OrdersList form = new OrdersList();
			form.Show();
		}
		
		void ButtonListPaymentsClick(object sender, EventArgs e) {
			PaymentsUI form = new PaymentsUI();
			form.Show();
		}
		
		void ButtonRecipesClick(object sender, EventArgs e) {
			RecipesUI form = new RecipesUI();
			form.Show();
		}
		
		void ButtonLogoutClick(object sender, EventArgs e) {
			this.Close();
			AuthUI.TriggerAuthUIUpdated();
		}
		
	}
}
