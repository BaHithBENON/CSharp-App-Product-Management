/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace RestaurantManagement.models {
	/// <summary>
	/// Description of Order.
	/// </summary>
	public class Order {
	    public int Id { get; set; }
	    public double TotalPrice { get; set; }
	    public string OrderReference { get; set; }
	    public DateTime OrderDate { get; set; }
	    public List<Product> Products { get; set; }
	
	    // Constructeur par défaut
	    public Order() {
	        // Initialisez la liste des produits
	        Products = new List<Product>();
	    }
	
	    // Constructeur avec paramètres
	    public Order(int id, double totalPrice, string orderReference, DateTime orderDate) {
	        Id = id;
	        TotalPrice = totalPrice;
	        OrderReference = orderReference;
	        OrderDate = orderDate;
	        Products = new List<Product>();
	    }
	    
	    public Order(double totalPrice, string orderReference, DateTime orderDate) {
	        Id = -1;
	        TotalPrice = totalPrice;
	        OrderReference = orderReference;
	        OrderDate = orderDate;
	        Products = new List<Product>();
	    }
	
	    // Méthode de comparaison basée sur l'ID
	    public bool Equals(Order other) {
	        if (other == null)
	            return false;
	
	        return Id == other.Id && OrderReference == other.OrderReference;
	    }
	}

}
