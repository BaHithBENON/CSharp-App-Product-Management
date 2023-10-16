/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 12:20
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
	/// Description of AdminDashboard.
	/// </summary>
	public partial class AdminDashboard : Form {
		private List<User> usersList;
		
		private User user = null;
		
		public static int updateListCounter { 
			get;
			set;
		}
		
		public void SetUpdateListCounter(int i) {
			updateListCounter = i;
			InitUsersList();
		}
		
		// Événement statique pour signaler la mise à jour de la table
    	public static event Action AdminUIUpdated;
    	// Méthode statique pour déclencher l'événement
	    public static void TriggerAdminUIUpdated() {
	        AdminUIUpdated.Invoke();
	    }
		
		public AdminDashboard() {
			InitializeComponent();
			InitUsersList();
			dataGridViewUsers.SelectionChanged += DataGridViewUsers_SelectionChanged;
			AdminDashboard.AdminUIUpdated += InitUsersList;
		}
		
		private void InitUsersList() {
			usersList = UserDao.Instance.ListUsers();
			
			dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.DataSource = usersList;
		}
		
		void ButtonLogoutClick(object sender, EventArgs e) {
			this.Close();
			AuthUI.TriggerAuthUIUpdated();
		}
		
		void ButtonAddClick(object sender, EventArgs e) {
			EditUser editUser = new EditUser();
            editUser.Show();
		}
		
		void ButtonDeleteClick(object sender, EventArgs e) {
			if(user != null) {
				UserDao userDao = UserDao.Instance;
				if(userDao.DeleteUser(user.Id)) {
					MessageBox.Show("L'utilisateur a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    	// new AdminDashboard().SetUpdateListCounter(AdminDashboard.updateListCounter++);
			    	InitUsersList();
			    } else {
			        MessageBox.Show("Échec de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
			} else {
				MessageBox.Show("Sélectionnez un utilisateur.");
			}
			
		}
		
		void DataGridViewUsers_SelectionChanged(object sender, EventArgs e) {
			if(dataGridViewUsers.SelectedRows.Count > 0) {
				// dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				// int rowIndex = dataGridViewUsers.SelectedRows[0];
				user = dataGridViewUsers.SelectedRows[0].DataBoundItem as User;
			}
		}
		
		void DataGridViewUsersCellContentClick(object sender, DataGridViewCellEventArgs e) {
			
		}
		
		void ButtonUpdateClick(object sender, EventArgs e) {
			if(user != null) {
				EditUser editUser = new EditUser();
				editUser.populateUser(user);
            	editUser.Show();
			} else {
				MessageBox.Show("Sélectionnez un utilisateur.");
			}
		}
    	
		void TextBoxSearchTextChanged(object sender, EventArgs e) {
			// Vérifier si la TextBox de recherche n'est pas vide
		    if (!string.IsNullOrEmpty(textBoxSearch.Text)) {
		    	// Filtrer les étudiants dont une des colonnes (par exemple, le nom ou le prénom) contient le texte de recherche
		        List<User> resultatsRecherche = usersList
		        	.Where(user => user.LastName.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       user.FirstName.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       user.Id.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
		        	       user.Username.ToUpper().Contains(textBoxSearch.Text.ToUpper()))
		            .ToList();
		
		        // Afficher les résultats de la recherche dans le DataGridView
		        dataGridViewUsers.DataSource = resultatsRecherche;
		    } else {
		        // Si la TextBox de recherche est vide, afficher tous les étudiants dans le DataGridView
		        dataGridViewUsers.DataSource = usersList;
		    }
		}
	}
}
