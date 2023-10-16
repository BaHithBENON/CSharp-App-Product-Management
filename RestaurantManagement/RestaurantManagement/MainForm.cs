/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RestaurantManagement.ui;

namespace RestaurantManagement
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ContinueButtonClick(object sender, EventArgs e) {
			AuthUI authUI = new AuthUI();
			authUI.Show();
			
			this.Hide();
		}
	}
}
