/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantManagement.db;
using RestaurantManagement.models;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of AuthUI.
	/// </summary>
	public partial class AuthUI : Form {
		
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action AuthUIUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerAuthUIUpdated() {
	        AuthUIUpdated.Invoke();
	    }
		
		public AuthUI() {
			InitializeComponent();
			AuthUI.AuthUIUpdated += CloseAuthUI;
		}
    	
    	private void CloseAuthUI() {
    		this.Show();
    	}
    	
		
		private User AuthenticateUser() {
		    string username = textBoxUsername.Text;
		    string password = textBoxPassword.Text;
		
		    // Vérifiez si les champs sont vides
		    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
		        MessageBox.Show("Veuillez remplir tous les champs.", "Erreur d'authentification", 
		    	                MessageBoxButtons.OK, MessageBoxIcon.Error);
		        return null; // Ou lancez une exception si vous préférez
		    }
		
		    // Utilisez le UserDao pour obtenir l'utilisateur correspondant
		    User user = UserDao.Instance.GetUserByUsernameAndPassword(username, password);
		
		    if (user == null) {
		        MessageBox.Show("Nom d'utilisateur incorrect.", "Erreur d'authentification", 
		    	                MessageBoxButtons.OK, MessageBoxIcon.Error);
		        return null;
		    }
		
		    // Vérifiez le mot de passe
		    if (user.Password != password) {
		        MessageBox.Show("Mot de passe incorrect.", "Erreur d'authentification", 
		    	                MessageBoxButtons.OK, MessageBoxIcon.Error);
		        return null;
		    }
		
		    // Authentification réussie, retournez l'utilisateur
		    return user;
		}
    	
    	private void Erase() {
    		textBoxUsername.Text = "";
    		textBoxPassword.Text = "";
    	}

		
		void SubmitButtonClick(object sender, EventArgs e) {
			User user = AuthenticateUser();
			if(user != null) {
				switch (user.Role) {
					case "Administrateur":
						AdminDashboard adminUI = new AdminDashboard();
						adminUI.Show();
						this.Hide();
						break;
					case "Chef":
						ChefDashboardUI chefUI = new ChefDashboardUI();
						chefUI.Show();
						this.Hide();
						break;
					case "Restaurateur":
						RestaurateurUI restoUI = new RestaurateurUI();
						restoUI.Show();
						this.Hide();
						break;
					default:
			            // Gérer d'autres rôles ou afficher un message d'erreur si nécessaire
			            MessageBox.Show("Rôle non reconnu.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
			            break;
				}
    
			} else {
				
			}
			Erase();
		}
	}
}
