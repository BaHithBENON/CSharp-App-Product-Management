/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class PaymentsUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewPayments;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn paymentDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn paymentReference;
		private System.Windows.Forms.DataGridViewTextBoxColumn remainder;
		private System.Windows.Forms.DataGridViewTextBoxColumn payrollAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderReference;
		private System.Windows.Forms.Button buttonDeletePayment;
		private System.Windows.Forms.Button buttonUpdatePayment;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payrollAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDeletePayment = new System.Windows.Forms.Button();
			this.buttonUpdatePayment = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPayments
			// 
			this.dataGridViewPayments.AllowUserToAddRows = false;
			this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.paymentDate,
			this.paymentReference,
			this.orderId,
			this.orderReference,
			this.remainder,
			this.payrollAmount});
			this.dataGridViewPayments.Location = new System.Drawing.Point(28, 128);
			this.dataGridViewPayments.MultiSelect = false;
			this.dataGridViewPayments.Name = "dataGridViewPayments";
			this.dataGridViewPayments.ReadOnly = true;
			this.dataGridViewPayments.RowTemplate.Height = 24;
			this.dataGridViewPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPayments.Size = new System.Drawing.Size(988, 501);
			this.dataGridViewPayments.TabIndex = 32;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// paymentDate
			// 
			this.paymentDate.DataPropertyName = "paymentDate";
			this.paymentDate.HeaderText = "Date";
			this.paymentDate.Name = "paymentDate";
			this.paymentDate.ReadOnly = true;
			// 
			// paymentReference
			// 
			this.paymentReference.DataPropertyName = "paymentReference";
			this.paymentReference.HeaderText = "Reference";
			this.paymentReference.Name = "paymentReference";
			this.paymentReference.ReadOnly = true;
			// 
			// orderId
			// 
			this.orderId.DataPropertyName = "orderId";
			this.orderId.HeaderText = "Id Commande";
			this.orderId.Name = "orderId";
			this.orderId.ReadOnly = true;
			// 
			// orderReference
			// 
			this.orderReference.DataPropertyName = "orderReference";
			this.orderReference.HeaderText = "Ref. Commande";
			this.orderReference.Name = "orderReference";
			this.orderReference.ReadOnly = true;
			// 
			// remainder
			// 
			this.remainder.DataPropertyName = "remainder";
			this.remainder.HeaderText = "Relicat";
			this.remainder.Name = "remainder";
			this.remainder.ReadOnly = true;
			// 
			// payrollAmount
			// 
			this.payrollAmount.DataPropertyName = "payrollAmount";
			this.payrollAmount.HeaderText = "Montant Payé";
			this.payrollAmount.Name = "payrollAmount";
			this.payrollAmount.ReadOnly = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(28, 77);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(988, 33);
			this.textBoxSearch.TabIndex = 31;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(28, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 33);
			this.label1.TabIndex = 30;
			this.label1.Text = "Liste des paiements";
			// 
			// buttonDeletePayment
			// 
			this.buttonDeletePayment.BackColor = System.Drawing.Color.Red;
			this.buttonDeletePayment.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeletePayment.ForeColor = System.Drawing.Color.White;
			this.buttonDeletePayment.Location = new System.Drawing.Point(869, 648);
			this.buttonDeletePayment.Name = "buttonDeletePayment";
			this.buttonDeletePayment.Size = new System.Drawing.Size(147, 43);
			this.buttonDeletePayment.TabIndex = 36;
			this.buttonDeletePayment.Text = "Supprimer";
			this.buttonDeletePayment.UseVisualStyleBackColor = false;
			this.buttonDeletePayment.Click += new System.EventHandler(this.ButtonDeletePaymentClick);
			// 
			// buttonUpdatePayment
			// 
			this.buttonUpdatePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonUpdatePayment.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdatePayment.ForeColor = System.Drawing.Color.White;
			this.buttonUpdatePayment.Location = new System.Drawing.Point(606, 648);
			this.buttonUpdatePayment.Name = "buttonUpdatePayment";
			this.buttonUpdatePayment.Size = new System.Drawing.Size(210, 43);
			this.buttonUpdatePayment.TabIndex = 37;
			this.buttonUpdatePayment.Text = "Mise à jour";
			this.buttonUpdatePayment.UseVisualStyleBackColor = false;
			this.buttonUpdatePayment.Click += new System.EventHandler(this.ButtonUpdatePaymentClick);
			// 
			// PaymentsUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 703);
			this.Controls.Add(this.buttonUpdatePayment);
			this.Controls.Add(this.buttonDeletePayment);
			this.Controls.Add(this.dataGridViewPayments);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Name = "PaymentsUI";
			this.Text = "PaymentsUI";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
