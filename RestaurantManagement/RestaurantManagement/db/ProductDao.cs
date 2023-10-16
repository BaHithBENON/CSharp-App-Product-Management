/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 00:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RestaurantManagement.models;

namespace RestaurantManagement.db {
    public sealed class ProductDao {
        private static ProductDao instance = new ProductDao();

        public static ProductDao Instance {
            get { return instance; }
        }

        private ProductDao() { }

        public bool AddProduct(Product product, List<ProductImage> images) {
            const string query = "INSERT INTO products (name, price, description, quantity, category) " +
                                 "VALUES (@name, @price, @description, @quantity, @category)";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = connection.CreateCommand();

            try {
                connection.Open();
				command = new MySqlCommand(query, connection);
	            command.Parameters.AddWithValue("@name", product.Name);
	            command.Parameters.AddWithValue("@price", product.Price);
	            command.Parameters.AddWithValue("@description", product.Description);
	            command.Parameters.AddWithValue("@quantity", product.Quantity);
	            command.Parameters.AddWithValue("@category", product.Category);
                command.ExecuteNonQuery();
                
                // Récupérer l'ID de la commande insérée
		        int productId = (int)command.LastInsertedId;
                
                foreach(ProductImage image in images) {
                	string insertImagesProductQuery = "INSERT INTO product_images (product_id, file_name, image_data) " +
		                                             "VALUES (@productId, @fileName, @imageData)";
                	image.ProductId = productId;
		            command = new MySqlCommand(insertImagesProductQuery, connection);
		            command.Parameters.Clear();
                	command.Parameters.AddWithValue("@productId", productId);
                	command.Parameters.AddWithValue("@fileName", image.FileName);
                	command.Parameters.AddWithValue("@imageData", image.ImageData);
                	command.ExecuteNonQuery();
                }
                
                
                return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur d'enregistrement : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        public Product GetProductById(int id) {
            const string selectQuery = "SELECT * FROM products WHERE id = @id";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@id", id);

            try {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int productId = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        double price = reader.GetDouble("price");
                        string description = reader.GetString("description");
                        int quantity = reader.GetInt32("quantity");
                        string category = reader.GetString("category");

                        Product product = new Product(productId, name, price, description, quantity, category);
                        
                        // Récupérez les images associées au produit
                        product.Images = GetProductImages(product.Id, false);

                        return product;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la recherche du produit : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return null; // Aucun produit trouvé avec cet Id
        }

        public List<Product> ListProducts() {
            List<Product> productList = new List<Product>();
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                const string selectQuery = "SELECT * FROM products";
                command = new MySqlCommand(selectQuery, connection);
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        double price = reader.GetDouble("price");
                        string description = reader.GetString("description");
                        int quantity = reader.GetInt32("quantity");
                        string category = reader.GetString("category");

                        Product product = new Product(id, name, price, description, quantity, category);
                        // Récupérez les images associées au produit
                        product.Images = GetProductImages(product.Id, false);
                        productList.Add(product);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de la récupération des produits : " + e.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return productList;
        }

        public bool UpdateProduct(Product product, List<ProductImage> images) {
            const string updateQuery = "UPDATE products SET name = @name, price = @price, " +
                "description = @description, quantity = @quantity, category = @category WHERE id = @id";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = connection.CreateCommand();

            try {
                connection.Open();

                command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@quantity", product.Quantity);
                command.Parameters.AddWithValue("@category", product.Category);

                command.ExecuteNonQuery();
                
                // Supprimer les anciennes images
                foreach(ProductImage image in images) {
                	DeleteProductImage(image.Id, false);
                }
                
                foreach(ProductImage image in images) {
                	string insertImagesProductQuery = "INSERT INTO product_images (product_id, file_name, image_data) " +
		                                             "VALUES (@productId, @fileName, @imageData)";
                	image.ProductId = product.Id;
		            command = new MySqlCommand(insertImagesProductQuery, connection);
		            command.Parameters.Clear();
                	command.Parameters.AddWithValue("@productId", image.ProductId);
                	command.Parameters.AddWithValue("@fileName", image.FileName);
                	command.Parameters.AddWithValue("@imageData", image.ImageData);
                	command.ExecuteNonQuery();
                }
                
                    return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la mise à jour : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        public bool DeleteProduct(int id, List<ProductImage> images) {
            const string deleteQuery = "DELETE FROM products WHERE id = @id";
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();
                
                // Supprimer les anciennes images
                if(images.Count > 0)
	                foreach(ProductImage image in images) {
	                	DeleteProductImage(image.Id, false);
	                }
                
                command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", id);

                int result = command.ExecuteNonQuery();
                if (result == 1) return true;
            } catch (Exception ex) {
            	Console.WriteLine("Erreur lors de la suppression : " + ex.ToString());
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }
        
        public bool AddProductImage(int productId, ProductImage productImage, bool withEnd) {
            const string query = "INSERT INTO product_images (product_id, image_data, file_name) VALUES (@productId, @imageData, @fileName)";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@imageData", productImage.ImageData);
            command.Parameters.AddWithValue("@fileName", productImage.FileName);

            try {
            	if(withEnd) {
            		connection.Open();
            	}

                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de l'ajout de l'image : " + ex.Message);
            } finally {
            	if(withEnd) {
            		if (connection != null && connection.State == System.Data.ConnectionState.Open) {
	                    connection.Close();
	                }
            	}
            }

            return false;
        }
        
        public List<ProductImage> GetProductImages(int productId, bool withEnd) {
            List<ProductImage> productImages = new List<ProductImage>();
            const string selectQuery = "SELECT * FROM product_images WHERE product_id = @productId";

            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@productId", productId);

            try {
                if(withEnd) {
            		connection.Open();
            	}

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        int imageId = reader.GetInt32("id");
                        byte[] imageData = (byte[])reader["image_data"];
                        string fileName = reader.GetString("file_name");
                        ProductImage productImage = new ProductImage 
                        	{ 
                        		Id = imageId, ImageData = imageData,
                        		FileName = fileName, ProductId = productId
                        	};
                        productImages.Add(productImage);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la récupération des images du produit : " + ex.Message);
            } finally {
                if(withEnd) {
            		if (connection != null && connection.State == System.Data.ConnectionState.Open) {
	                    connection.Close();
	                }
            	}
            }

            return productImages;
        }
        
        
        public bool DeleteProductImage(int imageId, bool withEnd) {
            const string deleteQuery = "DELETE FROM product_images WHERE id = @id";
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);

            command.Parameters.AddWithValue("@id", imageId);

            try {
            	if(withEnd) {
                	connection.Open();
            	}

                int result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la suppression de l'image : " + ex.Message);
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

