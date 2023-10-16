/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 20/08/2023
 * Time: 15:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using RestaurantManagement.models;

namespace RestaurantManagement.db
{
	/// <summary>
	/// Description of UserDao.
	/// </summary>
	public sealed class UserDao {
		private static UserDao instance = new UserDao();
		
		public static UserDao Instance {
			get { return instance; }
		}
		
		private UserDao() { }
		
		public bool AddUser(User user) {
		    const string query = "INSERT INTO users (lastname, firstname, username, password, role) " +
		                         "VALUES (@lastname, @firstname, @username, @password, @role)";
		
		    MySqlConnection connection = SingletonDBAccess.Instance.Connection;
		    //MessageBox.Show("" + connection);
		    MySqlCommand command = new MySqlCommand(query, connection);
		    
		    command.Parameters.AddWithValue("@lastname", user.LastName);
		    command.Parameters.AddWithValue("@firstname", user.FirstName);
		    command.Parameters.AddWithValue("@username", user.Username);
		    command.Parameters.AddWithValue("@password", user.Password);
		    command.Parameters.AddWithValue("@role", user.Role);
		    
		    try {
		        SingletonDBAccess.Instance.Connection.Open();
		
		        int result = command.ExecuteNonQuery();
		        if (result == 1)
		            return true;
		    } catch (Exception ex) {
		        // En cas d'erreur lors de la connexion
		        MessageBox.Show("Erreur d'enregistrement : " + ex.ToString());
		    } finally {
		        // Fermez la connexion après utilisation
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		
		    return false;
		}
		
		public User GetUserByUsernameAndPassword(string username, string password) {
		    const string selectQuery = "SELECT * FROM users WHERE username = @username AND password = @password";
		
		    MySqlConnection connection = SingletonDBAccess.Instance.Connection;
		    MySqlCommand command = new MySqlCommand(selectQuery, connection);
		
		    command.Parameters.AddWithValue("@username", username);
		    command.Parameters.AddWithValue("@password", password);
		
		    try {
		        connection.Open();
		
		        using (MySqlDataReader reader = command.ExecuteReader()) {
		            if (reader.Read()) {
		                int id = reader.GetInt32("id");
		                string lastName = reader.GetString("lastname");
		                string firstName = reader.GetString("firstname");
		                string role = reader.GetString("role");
		
		                // Créez un nouvel objet User avec les données de la base de données
		                User user = new User(id, lastName, firstName, username, password, role);
		
		                return user;
		            }
		        }
		    } catch (Exception ex) {
		        MessageBox.Show("Erreur lors de la recherche de l'utilisateur : " + ex.Message);
		    } finally {
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		
		    return null; // Aucun utilisateur trouvé avec ces identifiants
		}

	
		public List<User> ListUsers() {
            List<User> userList = new List<User>();
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            
            try {
            	connection.Open();

                // Requête SQL pour sélectionner tous les enregistrements de la table users
                const string selectQuery = "SELECT * FROM users";
                command = new MySqlCommand(selectQuery, connection);
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    // Parcours des enregistrements et ajout à la liste des utilisateurs
                    while (reader.Read()) {
                        int id = reader.GetInt32("id");
                        string lastName = reader.GetString("lastname");
                        string firstName = reader.GetString("firstname");
                        string username = reader.GetString("username");
                        string password = reader.GetString("password");
                        string role = reader.GetString("role");

                        User user = new User(id, lastName, firstName, username, password, role);
                        userList.Add(user);
                    }
                }
            } catch (Exception e) {
                MessageBox.Show("Erreur lors de la récupération des données : " + e.Message);
            } finally {
                // Fermez la connexion après utilisation
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return userList;
		}
		
		public bool UpdateUser(User user) {
            const string updateQuery = "UPDATE users SET lastname = @lastname, firstname = @firstname, " +
                "username = @username, password = @password, role = @role WHERE id = @id";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            
            try {
            	connection.Open();

                command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@lastname", user.LastName);
                command.Parameters.AddWithValue("@firstname", user.FirstName);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role);

                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            } catch (Exception ex) {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
            } finally {
                // Fermez la connexion après utilisation
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
		}
		
		public bool DeleteUser(int id) {
		    const string deleteQuery = "DELETE FROM users WHERE Id = @id";
			MySqlConnection connection = SingletonDBAccess.Instance.Connection;
			MySqlCommand command = null;
	        try {
	            connection.Open();
	            command = new MySqlCommand(deleteQuery, connection);
	            command.Parameters.AddWithValue("@id", id);
	
                int result = command.ExecuteNonQuery();
                if (result == 1) return true;
	        } catch (Exception ex) {
	            MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
	        } finally {
                // Fermez la connexion après utilisation
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
		    return false;
		}
	}
}
