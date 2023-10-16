/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantManagement.models;

namespace RestaurantManagement.db {
	
    public sealed class OrderDao {
        private static OrderDao instance = new OrderDao();

        public static OrderDao Instance {
            get { return instance; }
        }

        private OrderDao() { }
        
        public bool CreateOrder(Order order, List<Product> products) {
		    MySqlConnection connection = SingletonDBAccess.Instance.Connection;
		    MySqlCommand command = connection.CreateCommand();
		    MySqlTransaction transaction = null;
		
		    try {
		        connection.Open();
		        //transaction = connection.BeginTransaction();
		
		        // Insérer la commande dans la table "orders"
		        string insertOrderQuery = "INSERT INTO orders (totalPrice, orderReference, orderDate) " +
		                                  "VALUES (@totalPrice, @orderReference, @orderDate)";
		        //command.CommandText = insertOrderQuery;
		        command = new MySqlCommand(insertOrderQuery, connection);
		        command.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
		        command.Parameters.AddWithValue("@orderReference", order.OrderReference);
		        command.Parameters.AddWithValue("@orderDate", order.OrderDate);
		        command.ExecuteNonQuery();
		
		        // Récupérer l'ID de la commande insérée
		        int orderId = (int)command.LastInsertedId;
		
		        // Mettre à jour la quantité des produits et insérer dans la table "order_products"
		        foreach (Product product in products) {
		            string updateProductQuantityQuery = "UPDATE products SET quantity = quantity - @quantity WHERE id = @productId";
		            //command.CommandText = updateProductQuantityQuery;
		            command = new MySqlCommand(updateProductQuantityQuery, connection);
		            command.Parameters.Clear();
		            command.Parameters.AddWithValue("@quantity", product.Quantity);
		            command.Parameters.AddWithValue("@productId", product.Id);
		            command.ExecuteNonQuery();
		
		            string insertOrderProductQuery = "INSERT INTO order_products (order_id, product_id, quantity) " +
		                                             "VALUES (@orderId, @productId, @quantity)";
		            //command.CommandText = insertOrderProductQuery;
		            command = new MySqlCommand(insertOrderProductQuery, connection);
		            command.Parameters.Clear();
		            command.Parameters.AddWithValue("@orderId", orderId);
		            command.Parameters.AddWithValue("@productId", product.Id);
		            command.Parameters.AddWithValue("@quantity", product.Quantity);
		            command.ExecuteNonQuery();
		        }
		
		        //transaction.Commit();
		        return true;
		    } catch (Exception ex) {
		        if (transaction != null) {
		            transaction.Rollback();
		        }
		    	MessageBox.Show(ex.ToString());
		        Console.WriteLine("Erreur lors de la création de la commande : " + ex.Message);
		        return false;
		    } finally {
		        if (connection.State == System.Data.ConnectionState.Open)
		            connection.Close();
		    }
		}


        public bool AddOrder(Order order) {
            const string query = "INSERT INTO orders (totalPrice, orderReference, orderDate) " +
                                 "VALUES (@totalPrice, @orderReference, @orderDate)";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
            command.Parameters.AddWithValue("@orderReference", order.OrderReference);
            command.Parameters.AddWithValue("@orderDate", order.OrderDate);

            try {
                SingletonDBAccess.Instance.Connection.Open();

                int result = command.ExecuteNonQuery();
                if (result == 1) {
                    // Maintenant, ajoutez les produits associés à cette commande
                    foreach (Product product in order.Products) {
                        AddProductToOrder(order, product);
                    }

                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur d'enregistrement de la commande : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        public Order GetOrderById(int id) {
            const string selectQuery = "SELECT * FROM orders WHERE id = @id";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@id", id);

            try {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int orderId = reader.GetInt32("id");
                        double totalPrice = reader.GetDouble("totalPrice");
                        string orderReference = reader.GetString("orderReference");
                        DateTime orderDate = reader.GetDateTime("orderDate");

                        // Créez un nouvel objet Order avec les données de la base de données
                        Order order = new Order(orderId, totalPrice, orderReference, orderDate);

                        // Récupérez les produits associés à cette commande
                        List<Product> products = GetProductsByOrderId(orderId, true);
                        order.Products = products;

                        return order;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la recherche de la commande : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return null; // Aucune commande trouvée avec cet Id
        }

        public List<Order> ListOrders() {
            List<Order> orderList = new List<Order>();
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                const string selectQuery = "SELECT * FROM orders";
                command = new MySqlCommand(selectQuery, connection);
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        int id = reader.GetInt32("id");
                        double totalPrice = reader.GetDouble("totalPrice");
                        string orderReference = reader.GetString("orderReference");
                        DateTime orderDate = reader.GetDateTime("orderDate");

                        // Créez un nouvel objet Order avec les données de la base de données
                        Order order = new Order(id, totalPrice, orderReference, orderDate);

                        // Récupérez les produits associés à cette commande
                        List<Product> products = GetProductsByOrderId(id, false);
                        order.Products = products;

                        orderList.Add(order);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de la récupération des commandes : " + e.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return orderList;
        }

        public bool UpdateOrder(Order order) {
            const string updateQuery = "UPDATE orders SET totalPrice = @totalPrice, " +
                "orderReference = @orderReference, orderDate = @orderDate WHERE id = @id";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", order.Id);
                command.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
                command.Parameters.AddWithValue("@orderReference", order.OrderReference);
                command.Parameters.AddWithValue("@orderDate", order.OrderDate);

                int result = command.ExecuteNonQuery();
                if (result == 1) {
                    // Mettez à jour les produits associés à cette commande
                    UpdateProductsInOrder(order);
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la mise à jour de la commande : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        public bool DeleteOrder(int id) {
            const string deleteQuery = "DELETE FROM orders WHERE id = @id";
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            try {
            	connection.Open();
            	// Supprimez également les produits associés à cette commande
            	if(DeleteProductsInOrder(id, false)) {
            		command = new MySqlCommand(deleteQuery, connection);
            		command.Parameters.AddWithValue("@id", id);
            		int result = command.ExecuteNonQuery();
	            	if (result == 1) {
	            		// Supprimez également les produits associés à cette commande
	            		DeleteProductsInOrder(id, false);
	            		return true;
	            	}
            	}
            } catch (Exception ex) {
            	Console.WriteLine("Erreur lors de la suppression de la commande : " + ex.Message);
            } finally {
            	if (connection != null && connection.State == System.Data.ConnectionState.Open) {
            		connection.Close();
                }
            }
            return false;
        }

        // Méthode pour ajouter un produit à une commande
        public bool AddProductToOrder(Order order, Product product) {
            const string query = "INSERT INTO order_products (order_id, product_id) " +
                                 "VALUES (@orderId, @productId)";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@orderId", order.Id);
            command.Parameters.AddWithValue("@productId", product.Id);

            try {
                SingletonDBAccess.Instance.Connection.Open();
                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de l'ajout de produit à la commande : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        // Méthode pour récupérer la liste des produits associés à une commande
        public List<Product> GetProductsByOrderId(int orderId, bool withEnd) {
            List<Product> productList = new List<Product>();
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                const string selectQuery = "SELECT products.*, order_products.quantity AS order_quantity " +
                                           "FROM order_products " +
                                           "INNER JOIN products ON order_products.product_id = products.id " +
                                           "WHERE order_products.order_id = @orderId";

                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@orderId", orderId);

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        double price = reader.GetDouble("price");
                        string description = reader.GetString("description");
                        int quantity = reader.GetInt32("order_quantity");
                        string category = reader.GetString("category");

                        Product product = new Product(id, name, price, description, quantity, category);
                        productList.Add(product);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de la récupération des produits de la commande : " + e.Message);
            } finally {
            	if(withEnd){
            		if (connection != null && connection.State == System.Data.ConnectionState.Open) {
	                    connection.Close();
	                }
            	}
            }

            return productList;
        }

        // Méthode pour mettre à jour les produits associés à une commande
        public bool UpdateProductsInOrder(Order order) {
            // Supprimez d'abord tous les produits associés à cette commande
            DeleteProductsInOrder(order.Id, false);

            // Ensuite, ajoutez les produits actuels à la commande
            foreach (Product product in order.Products) {
                AddProductToOrder(order, product);
            }

            return true;
        }

        // Méthode pour supprimer les produits associés à une commande
        public bool DeleteProductsInOrder(int orderId, bool withEnd) {
            const string deleteQuery = "DELETE FROM order_products WHERE order_id = @orderId";
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            // MessageBox.Show("Yep");
            try {
        		if(withEnd) {
            		connection.Open();	
        		}
                command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@orderId", orderId);

                int result = command.ExecuteNonQuery();
                if (result >= 0)
                    return true;
            } catch (Exception ex) {
            	// MessageBox.Show(ex.ToString());
                Console.WriteLine("Erreur lors de la suppression des produits de la commande : " + ex.Message);
            } finally {
            	if(withEnd) {
            		if (connection != null && connection.State == System.Data.ConnectionState.Open) {
	                    connection.Close();
	                }
            	}
            }

            return false;
        }
    }
}

