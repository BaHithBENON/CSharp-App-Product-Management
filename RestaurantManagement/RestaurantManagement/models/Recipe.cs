/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RestaurantManagement.models {
	/// <summary>
	/// Description of Recipe.
	/// </summary>
	public class Recipe {
		public string Id { get; set; }
	    public string Period { get; set; }
	    public double RecipeAmount { get; set; }
	    
		public Recipe() {
	    	Id = "#";
		}
	}
}
