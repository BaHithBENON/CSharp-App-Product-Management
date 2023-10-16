/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 18:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RestaurantManagement.models
{
	/// <summary>
	/// Description of ProductImage.
	/// </summary>
	public class ProductImage {
	    public int Id { get; set; } // L'identifiant de l'image
	    public int ProductId { get; set; } // L'identifiant du produit auquel l'image est associée
	    public string FileName { get; set; } // Le nom de fichier de l'image
	    public byte[] ImageData { get; set; } // Les données binaires de l'image
	
	    // Constructeur par défaut
	    public ProductImage() { }
	
	    // Constructeur avec toutes les propriétés
	    public ProductImage(int id, int productId, string fileName, byte[] imageData) {
	        Id = id;
	        ProductId = productId;
	        FileName = fileName;
	        ImageData = imageData;
	    }
	    
	    public ProductImage(int productId, string fileName, byte[] imageData) {
	        Id = -1;
	        ProductId = productId;
	        FileName = fileName;
	        ImageData = imageData;
	    }
	}

}
