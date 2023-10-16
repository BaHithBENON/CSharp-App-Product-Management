/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 05:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RestaurantManagement.models;

namespace RestaurantManagement.db {
    public sealed class PaymentDao {
        private static PaymentDao instance = new PaymentDao();

        public static PaymentDao Instance {
            get { return instance; }
        }

        private PaymentDao() { }

        public bool CreatePayment(Payment payment) {
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = connection.CreateCommand();
            try {
                connection.Open();
                
                string insertPaymentQuery = "INSERT INTO payments (payment_date, payment_reference, remainder, payroll_amount, order_id, order_reference) " +
                                            "VALUES (@paymentDate, @paymentReference, @remainder, @payrollAmount, @orderId, @orderReference)";
                command = new MySqlCommand(insertPaymentQuery, connection);
                command.Parameters.AddWithValue("@paymentDate", payment.PaymentDate);
                command.Parameters.AddWithValue("@paymentReference", payment.PaymentReference);
                command.Parameters.AddWithValue("@remainder", payment.Remainder);
                command.Parameters.AddWithValue("@payrollAmount", payment.PayrollAmount);
                command.Parameters.AddWithValue("@orderId", payment.OrderId);
                command.Parameters.AddWithValue("@orderReference", payment.OrderReference);
                command.ExecuteNonQuery();

                return true;
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la création du paiement : " + ex.Message);
                return false;
            } finally {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public Payment GetPaymentById(int id) {
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            try {
                connection.Open();

                const string selectQuery = "SELECT * FROM payments WHERE id = @id";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int paymentId = reader.GetInt32("id");
                        DateTime paymentDate = reader.GetDateTime("payment_date");
                        string paymentReference = reader.GetString("payment_reference");
                        double remainder = reader.GetDouble("remainder");
                        double payrollAmount = reader.GetDouble("payroll_amount");
                        int orderId = reader.GetInt32("order_id");
                        string orderReference = reader.GetString("order_reference");

                        Payment payment = new Payment(paymentId, paymentDate, paymentReference, remainder, payrollAmount, orderId, orderReference);
                        return payment;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la récupération du paiement : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return null; // Aucun paiement trouvé avec cet Id
        }
        
        public Payment GetPaymentByOrder(Order order) {
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            try {
                connection.Open();

                const string selectQuery = "SELECT * FROM payments WHERE order_id = @id AND order_reference = @orderReference";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@id", order.Id);
                command.Parameters.AddWithValue("@orderReference", order.OrderReference);

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        int paymentId = reader.GetInt32("id");
                        DateTime paymentDate = reader.GetDateTime("payment_date");
                        string paymentReference = reader.GetString("payment_reference");
                        double remainder = reader.GetDouble("remainder");
                        double payrollAmount = reader.GetDouble("payroll_amount");
                        int orderId = reader.GetInt32("order_id");
                        string orderReference = reader.GetString("order_reference");

                        Payment payment = new Payment(paymentId, paymentDate, paymentReference, remainder, payrollAmount, orderId, orderReference);
                        return payment;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la récupération du paiement : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return null; // Aucun paiement trouvé avec cet Id
        }

        public List<Payment> ListPayments() {
            List<Payment> paymentList = new List<Payment>();
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                const string selectQuery = "SELECT * FROM payments";
                command = new MySqlCommand(selectQuery, connection);

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        int paymentId = reader.GetInt32("id");
                        DateTime paymentDate = reader.GetDateTime("payment_date");
                        string paymentReference = reader.GetString("payment_reference");
                        double remainder = reader.GetDouble("remainder");
                        double payrollAmount = reader.GetDouble("payroll_amount");
                        int orderId = reader.GetInt32("order_id");
                        string orderReference = reader.GetString("order_reference");

                        Payment payment = new Payment(paymentId, paymentDate, paymentReference, remainder, payrollAmount, orderId, orderReference);
                        paymentList.Add(payment);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de la récupération des paiements : " + e.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return paymentList;
        }

        public bool UpdatePayment(Payment payment) {
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;

            try {
                connection.Open();

                const string updateQuery = "UPDATE payments SET payment_date = @paymentDate, " +
                    "payment_reference = @paymentReference, remainder = @remainder, payroll_amount = @payrollAmount, " +
                    "order_id = @orderId, order_reference = @orderReference WHERE id = @id";

                command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@id", payment.Id);
                command.Parameters.AddWithValue("@paymentDate", payment.PaymentDate);
                command.Parameters.AddWithValue("@paymentReference", payment.PaymentReference);
                command.Parameters.AddWithValue("@remainder", payment.Remainder);
                command.Parameters.AddWithValue("@payrollAmount", payment.PayrollAmount);
                command.Parameters.AddWithValue("@orderId", payment.OrderId);
                command.Parameters.AddWithValue("@orderReference", payment.OrderReference);

                int result = command.ExecuteNonQuery();
                if (result == 1) {
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la mise à jour du paiement : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }

            return false;
        }

        public bool DeletePayment(int id) {
            MySqlConnection connection = SingletonDBAccess.Instance.Connection;
            MySqlCommand command = null;
            try {
                connection.Open();
                const string deleteQuery = "DELETE FROM payments WHERE id = @id";
                command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", id);

                int result = command.ExecuteNonQuery();
                if (result == 1) {
                    return true;
                }
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de la suppression du paiement : " + ex.Message);
            } finally {
                if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
            }
            return false;
        }
    }
}
