/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 20/08/2023
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManagement.db {    
	/// <summary>
	/// Description of SingletonDBAccess.
	/// </summary>
	public sealed class SingletonDBAccess {
		private MySqlConnection connection;
	    private MySqlCommand command;
	    private string server = "localhost";
	    private string database = "csharp_resto_db";
	    private string uid = "root";
	    private string password = "";
    
		private static SingletonDBAccess instance = new SingletonDBAccess();
		
		public static SingletonDBAccess Instance {
			get { 
				if(instance == null) {
					instance = new SingletonDBAccess();
				}
				return instance; 
			}
		}
		
		// Propriété publique pour accéder à la connexion
	    public MySqlConnection Connection {
	        get { return connection; }
	        // Vous pouvez également ajouter un setter si nécessaire
	    }
	
	    // Propriété publique pour accéder à la commande
	    public MySqlCommand Command {
	        get { return command; }
	        // Vous pouvez également ajouter un setter si nécessaire
	    }
		
		private SingletonDBAccess() {
			InitializeDatabaseConnection();
		}
		
		private void InitializeDatabaseConnection() {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL.
            // string connectionString = "Server=localhost;Database=csharpdb;Uid=root;Pwd=";
            
            string connectionString = "SERVER=" + server + ";DATABASE=" + database +";UID="+uid+";PASSWORD="+password+";";
            // Requête SQL pour créer la table Etudiants

            try {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                
				InitializeDatabase();
                // Connexion réussie, vous pouvez maintenant exécuter des requêtes SQL ici
                // MessageBox.Show("Connexion réussie à la base de données MySQL.");
            } catch (Exception ex) {
                // En cas d'erreur lors de la connexion
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
            } finally {
                // Fermez la connexion après utilisation
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
        }
	    
	    private void InitializeDatabase() {
            CreateUsersTable();
            CreateProductsTable();
            CreateOrdersTable();
            CreateOrderProductsTable();
            CreatePaymentsTable();
            CreateProductImagesTable();
        }
	    
	    public void CreateUsersTable() {
		    const string createTableQuery = "CREATE TABLE IF NOT EXISTS users (" +
		                                     "id INT AUTO_INCREMENT PRIMARY KEY," +
		                                     "lastname VARCHAR(100) NOT NULL," +
		                                     "firstname VARCHAR(100) NOT NULL," +
		                                     "username VARCHAR(100) NOT NULL," +
		                                     "password VARCHAR(100) NOT NULL," +
		                                     "role VARCHAR(50) NOT NULL" +
		                                     ")";
		    //connection = Instance.Connection;
		    command = new MySqlCommand(createTableQuery, connection);
		    try {
		        // connection.Open();
		
		        int result = command.ExecuteNonQuery();
		        if (result == 0) {
		            // MessageBox.Show("La table des utilisateurs existe déjà.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		        } else {
		            // MessageBox.Show("La table des utilisateurs a été créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
		        }
		    } catch (Exception ex) {
		        // MessageBox.Show("Erreur lors de la création de la table des utilisateurs : " + ex.Message, 
		    	//                 "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
		    	Console.Write("" + ex.ToString());
		    } 
		    /*
		    finally {
		    	
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		    */
		}

		public void CreateProductsTable() {
		    const string createTableQuery = "CREATE TABLE IF NOT EXISTS products (" +
		                                     "id INT AUTO_INCREMENT PRIMARY KEY," +
		                                     "name VARCHAR(255) NOT NULL," +
		                                     "price DECIMAL(10, 2) NOT NULL," +
		                                     "description TEXT," +
		                                     "quantity INT NOT NULL," +
		                                     "category VARCHAR(255) NOT NULL" +
		                                     ")";
		    //MySqlConnection connection = SingletonDBAccess.Instance.Connection;
		    command = new MySqlCommand(createTableQuery, connection);
		    
		    try {
		        // connection.Open();
		
		        int result = command.ExecuteNonQuery();
		        if (result == 0) {
		            // La table des produits existe déjà.
		        } else {
		            // La table des produits a été créée avec succès.
		        }
		    } catch (Exception ex) {
		    	MessageBox.Show("Erreur lors de la création de la table des produits : " + ex.Message,
		    		"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
		        Console.WriteLine("Erreur lors de la création de la table des produits : " + ex.Message);
		    } 
		    /*
 			finally {
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		    */
		}

	    public void CreateOrdersTable() {
	    	const string createTableQuery = "CREATE TABLE IF NOT EXISTS orders (" +
                                             "id INT AUTO_INCREMENT PRIMARY KEY," +
                                             "totalPrice DECIMAL(10, 2) NOT NULL," +
                                             "orderReference VARCHAR(100) NOT NULL," +
                                             "orderDate DATETIME NOT NULL" +
                                             ")";

            //command.CommandText = createTableQuery;
            command = new MySqlCommand(createTableQuery, connection);
            try {
            	// connection.Open();

                int result = command.ExecuteNonQuery();
                if (result == 0) {
                    // La table des commandes existe déjà.
                    Console.WriteLine("La table des commandes existe déjà.");
                } else  {
                    // La table des commandes a été créée avec succès.
                    Console.WriteLine("La table des commandes a été créée avec succès.");
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la création de la table des commandes : " + ex.Message);
                MessageBox.Show("Erreur lors de la création de la table des commandes : " + ex.Message,
		    		"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            /*
 			finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
            */
	    }
	    
	    public void CreateOrderProductsTable() {
	    	const string createTableQuery = "CREATE TABLE IF NOT EXISTS order_products (" +
                                             "order_id INT NOT NULL," +
                                             "product_id INT NOT NULL," +
		                                     "quantity INT NOT NULL," +
                                             "PRIMARY KEY(order_id, product_id)," +
                                             "FOREIGN KEY (order_id) REFERENCES orders(id)," +
                                             "FOREIGN KEY (product_id) REFERENCES products(id)" +
                                             ")";

            // command.CommandText = createTableQuery;
            command = new MySqlCommand(createTableQuery, connection);
	    	try {
	    		// connection.Open();

                int result = command.ExecuteNonQuery();
                if (result == 0) {
                    // La table de liaison entre commandes et produits existe déjà.
                    Console.WriteLine("La table de liaison entre commandes et produits existe déjà.");
                } else {
                    // La table de liaison entre commandes et produits a été créée avec succès.
                    Console.WriteLine("La table de liaison entre commandes et produits a été créée avec succès.");
	    			MessageBox.Show("Erreur lors de la création de la table des order_produits",
		    			"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
	    	} catch (Exception ex) {
                Console.WriteLine("Erreur lors de la création de la table de liaison entre commandes et produits : " + ex.Message);
            } 
            /*
            finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
            */
	    }
	    
	    
	    public void CreatePaymentsTable() {
		    const string createTableQuery = "CREATE TABLE IF NOT EXISTS payments (" +
		                                     "id INT AUTO_INCREMENT PRIMARY KEY," +
		                                     "payment_date DATE NOT NULL," +
		                                     "payment_reference VARCHAR(100) NOT NULL," +
		                                     "remainder DOUBLE NOT NULL," +
		                                     "payroll_amount DOUBLE NOT NULL," +
		                                     "order_id INT NOT NULL," +
		                                     "order_reference VARCHAR(100) NOT NULL," +
		                                     "FOREIGN KEY (order_id) REFERENCES orders(id)" +
		                                     ")";
		
		    // command.CommandText = createTableQuery;
		    command = new MySqlCommand(createTableQuery, connection);
		    try {
		        // connection.Open();
		
		        int result = command.ExecuteNonQuery();
		        if (result == 0) {
		            // La table des paiements existe déjà.
		            Console.WriteLine("La table des paiements existe déjà.");
		        } else {
		            // La table des paiements a été créée avec succès.
		            Console.WriteLine("La table des paiements a été créée avec succès.");
		            MessageBox.Show("La table des paiements a été créée avec succès.",
		                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
		        }
		    } catch (Exception ex) {
		        Console.WriteLine("Erreur lors de la création de la table des paiements : " + ex.Message);
		    } 
		    /*
		    finally {
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		    */
		}
	    
	    public void CreateProductImagesTable() {
		    const string createTableQuery = "CREATE TABLE IF NOT EXISTS product_images (" +
		                                     "id INT NOT NULL AUTO_INCREMENT," +
		                                     "product_id INT NOT NULL," +
		                                     "file_name VARCHAR(255) NOT NULL," +
		                                     "image_data LONGBLOB NOT NULL," +
		                                     "PRIMARY KEY (id)," +
		                                     "FOREIGN KEY (product_id) REFERENCES products(id)" +
		                                     ")";
		
		    command = new MySqlCommand(createTableQuery, connection);
		
		    try {
		        // connection.Open();
		
		        int result = command.ExecuteNonQuery();
		        if (result == 0) {
		            // La table des images de produit existe déjà.
		            Console.WriteLine("La table des images de produit existe déjà.");
		        } else {
		            // La table des images de produit a été créée avec succès.
		            Console.WriteLine("La table des images de produit a été créée avec succès.");
		        }
		    } catch (Exception ex) {
		        Console.WriteLine("Erreur lors de la création de la table des images de produit : " + ex.Message);
		    } 
		    /*
		    finally {
		        if (connection != null && connection.State == System.Data.ConnectionState.Open) {
		            connection.Close();
		        }
		    }
		    */
		}

	    
	}
}
