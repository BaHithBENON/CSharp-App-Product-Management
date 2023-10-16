/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 04:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RestaurantManagement.models
{
	/// <summary>
	/// Description of Payment.
	/// </summary>

	public class Payment {
	    public int Id { get; set; }
	    public DateTime PaymentDate { get; set; }
	    public string PaymentReference { get; set; }
	    public double Remainder { get; set; }
	    public double PayrollAmount { get; set; }
	    public int OrderId { get; set; } // ID de la commande associée
    	public string OrderReference { get; set; } // Référence de la commande associée

	
	    // Constructeur par défaut
	    public Payment() {
	        // Initialisez les propriétés par défaut ici si nécessaire
	        // Par exemple, vous pouvez initialiser PaymentDate à la date actuelle
	        PaymentDate = DateTime.Now;
	    }
	
	    // Constructeur avec des paramètres pour initialiser toutes les propriétés
	    public Payment(int id, DateTime paymentDate, string paymentReference, double remainder, double payrollAmount, int orderId, string orderReference) {
	        Id = id;
	        PaymentDate = paymentDate;
	        PaymentReference = paymentReference;
	        Remainder = remainder;
	        PayrollAmount = payrollAmount;
	        OrderId = orderId;
	        OrderReference = orderReference;
	    }
	    
	    // Constructeur avec des paramètres pour initialiser toutes les propriétés
	    public Payment(DateTime paymentDate, string paymentReference, double remainder, double payrollAmount, int orderId, string orderReference) {
	        Id = -1;
	        PaymentDate = paymentDate;
	        PaymentReference = paymentReference;
	        Remainder = remainder;
	        PayrollAmount = payrollAmount;
	        OrderId = orderId;
	        OrderReference = orderReference;
	    }
	}

}
