/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using RestaurantManagement.ui;

namespace RestaurantManagement {
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program {
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AuthUI());
		}
		
	}
}
