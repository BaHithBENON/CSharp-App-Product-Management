/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 00:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace RestaurantManagement.models {
	/// <summary>
	/// Description of Product.
	/// </summary>
	public class Product {
	    // Propriétés
	    public int Id { get; set; }
	    public string Name { get; set; }
	    public double Price { get; set; }
	    public string Description { get; set; }
	    public int Quantity { get; set; }
	    public string Category { get; set; }
	    public List<ProductImage> Images { get; set; }
	
	    // Constructeur par défaut
	    public Product() {
	        Images = new List<ProductImage>();
	        // Par défaut, l'Id est -1 pour indiquer qu'il n'est pas encore défini.
	        Id = -1;
	    }
	
	    // Constructeur avec Id
	    public Product(int id, string name, double price, string description, int quantity, string category) {
	        Id = id;
	        Name = name;
	        Price = price;
	        Description = description;
	        Quantity = quantity;
	        Category = category;
	    }
	    
	    // Constructeur avec Id
	    public Product(string name, double price, string description, int quantity, string category) {
	        Id = -1;
	        Name = name;
	        Price = price;
	        Description = description;
	        Quantity = quantity;
	        Category = category;
	    }
	
	    // Méthode de comparaison basée sur l'Id
	    public bool EqualsById(Product otherProduct) {
	        if (otherProduct == null)
	        {
	            return false;
	        }
	        return Id == otherProduct.Id;
	    }
	}

}
