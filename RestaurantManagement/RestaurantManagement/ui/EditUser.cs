/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 20/08/2023
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantManagement.models;
using RestaurantManagement.db;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of EditUser.
	/// </summary>
	public partial class EditUser : Form {
		private User newUser;
		public User User {
			get {return newUser;}
			set {newUser = value; }
		}
		
		public EditUser() {
			InitializeComponent();
		}
		
		public void populateUser(User user) {
			newUser = user;
			textBoxUsername.Text = newUser.Username;
	        textBoxPassword.Text = newUser.Password;
	        textBoxPasswordConfirm.Text = newUser.Password;
	        textBoxFirstname.Text = newUser.FirstName;
	        textBoxLastname.Text = newUser.LastName;
	        comboBoxRole.Text = newUser.Role;
		}
		
		void EraseForm() {
			// Réinitialisez les champs du formulaire si nécessaire
	        textBoxUsername.Text = "";
	        textBoxPassword.Text = "";
	        textBoxPasswordConfirm.Text = "";
	        textBoxFirstname.Text = "";
	        textBoxLastname.Text = "";
	        comboBoxRole.SelectedIndex = -1; // Effacez la sélection du rôle
	        newUser = null;
		}
		
		void SubmitButtonClick(object sender, EventArgs e) {
			// Récupérez les valeurs des champs du formulaire
		    string username = textBoxUsername.Text;
		    string password = textBoxPassword.Text;
		    string passwordConfirm = textBoxPasswordConfirm.Text;
		    string firstname = textBoxFirstname.Text;
		    string lastname = textBoxLastname.Text;
		    string role = comboBoxRole.Text;
		    
		    // Vérifiez que tous les champs sont remplis
		    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
		        string.IsNullOrWhiteSpace(passwordConfirm) || string.IsNullOrWhiteSpace(firstname) ||
		        string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(role)) {
		        MessageBox.Show("Veuillez remplir tous les champs.", "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return; // Arrêtez l'exécution si des champs sont vides
		    }
		
		    // Vérifiez que les mots de passe correspondent
		    if (password != passwordConfirm) {
		        MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return; // Arrêtez l'exécution si les mots de passe ne correspondent pas
		    }
		    
		    // Créez un objet User avec les valeurs des champs
		    User u = new User(lastname, firstname, username, password, role);
		    
		    UserDao userDao = UserDao.Instance;
		    if(newUser == null) {
		    	if (userDao.AddUser(u)) {
			    	MessageBox.Show("L'utilisateur a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    	EraseForm();
			    	AdminDashboard.TriggerAdminUIUpdated();
			    } else {
			        MessageBox.Show("Échec de l'ajout de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
		    } else {
		    	u.Id = newUser.Id;
		    	if (userDao.UpdateUser(u)) {
			    	MessageBox.Show("L'utilisateur a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    	EraseForm();
			    	AdminDashboard.TriggerAdminUIUpdated();
			    } else {
			        MessageBox.Show("Échec de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
		    }
		    // MessageBox.Show(""+ u.Id);
		}
	}
}
