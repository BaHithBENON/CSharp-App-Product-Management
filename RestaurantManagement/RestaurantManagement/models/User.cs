/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 20/08/2023
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RestaurantManagement.models
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User {
	    // Propriétés
	    public int Id { get; set; }
	    public string LastName { get; set; }
	    public string FirstName { get; set; }
	    public string Username { get; set; }
	    public string Password { get; set; }
	    public string Role { get; set; }
	
	    // Constructeur par défaut
	    public User() {}
	
	    // Constructeur avec initialisation
	    public User(int id, string lastName, string firstName, string username, string password, string role) {
	        Id = id;
	        LastName = lastName;
	        FirstName = firstName;
	        Username = username;
	        Password = password;
	        Role = role;
	    }
	    
	    // Constructeur avec initialisation
	    public User(string lastName, string firstName, string username, string password, string role) {
	    	Id = -1;
	        LastName = lastName;
	        FirstName = firstName;
	        Username = username;
	        Password = password;
	        Role = role;
	    }
	
	    // Méthode pour comparer deux utilisateurs par Id, Password et Username
	    public bool Equals(User otherUser) {
	        if (otherUser == null)
	            return false;
	
	        return Id == otherUser.Id &&
	               Password == otherUser.Password &&
	               Username == otherUser.Username;
	    }
	}

}
