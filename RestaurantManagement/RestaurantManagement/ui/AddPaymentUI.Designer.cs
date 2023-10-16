/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class AddPaymentUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelOrderRef;
		private System.Windows.Forms.Label labelOrderDate;
		private System.Windows.Forms.Label labelOrderAmount;
		private System.Windows.Forms.Label labelPaymentRef;
		private System.Windows.Forms.Label labelPaymentDate;
		private System.Windows.Forms.TextBox textBoxAmountPayroll;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxRemaider;
		private System.Windows.Forms.Button buttonValidPayment;
		private System.Windows.Forms.Button buttonDeletePayment;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelOrderRef = new System.Windows.Forms.Label();
			this.labelOrderDate = new System.Windows.Forms.Label();
			this.labelOrderAmount = new System.Windows.Forms.Label();
			this.labelPaymentRef = new System.Windows.Forms.Label();
			this.labelPaymentDate = new System.Windows.Forms.Label();
			this.textBoxAmountPayroll = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxRemaider = new System.Windows.Forms.TextBox();
			this.buttonValidPayment = new System.Windows.Forms.Button();
			this.buttonDeletePayment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(419, 33);
			this.label1.TabIndex = 16;
			this.label1.Text = "Paiement";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(43, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(419, 33);
			this.label2.TabIndex = 17;
			this.label2.Text = "Editer";
			// 
			// labelOrderRef
			// 
			this.labelOrderRef.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderRef.Location = new System.Drawing.Point(23, 111);
			this.labelOrderRef.Name = "labelOrderRef";
			this.labelOrderRef.Size = new System.Drawing.Size(508, 34);
			this.labelOrderRef.TabIndex = 18;
			this.labelOrderRef.Text = "Reférence commande :";
			// 
			// labelOrderDate
			// 
			this.labelOrderDate.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderDate.Location = new System.Drawing.Point(23, 160);
			this.labelOrderDate.Name = "labelOrderDate";
			this.labelOrderDate.Size = new System.Drawing.Size(508, 34);
			this.labelOrderDate.TabIndex = 19;
			this.labelOrderDate.Text = "Date commande :";
			// 
			// labelOrderAmount
			// 
			this.labelOrderAmount.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderAmount.Location = new System.Drawing.Point(23, 215);
			this.labelOrderAmount.Name = "labelOrderAmount";
			this.labelOrderAmount.Size = new System.Drawing.Size(508, 34);
			this.labelOrderAmount.TabIndex = 20;
			this.labelOrderAmount.Text = "Prix total (XOF) :";
			// 
			// labelPaymentRef
			// 
			this.labelPaymentRef.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPaymentRef.Location = new System.Drawing.Point(23, 476);
			this.labelPaymentRef.Name = "labelPaymentRef";
			this.labelPaymentRef.Size = new System.Drawing.Size(508, 34);
			this.labelPaymentRef.TabIndex = 21;
			this.labelPaymentRef.Text = "Reference Paiement:";
			// 
			// labelPaymentDate
			// 
			this.labelPaymentDate.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPaymentDate.Location = new System.Drawing.Point(23, 530);
			this.labelPaymentDate.Name = "labelPaymentDate";
			this.labelPaymentDate.Size = new System.Drawing.Size(508, 34);
			this.labelPaymentDate.TabIndex = 22;
			this.labelPaymentDate.Text = "Date Paiement:";
			// 
			// textBoxAmountPayroll
			// 
			this.textBoxAmountPayroll.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAmountPayroll.Location = new System.Drawing.Point(23, 312);
			this.textBoxAmountPayroll.Name = "textBoxAmountPayroll";
			this.textBoxAmountPayroll.Size = new System.Drawing.Size(508, 33);
			this.textBoxAmountPayroll.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(23, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(508, 34);
			this.label8.TabIndex = 24;
			this.label8.Text = "Montant payé";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(23, 373);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(508, 34);
			this.label9.TabIndex = 26;
			this.label9.Text = "Montant rendu (relicat)";
			// 
			// textBoxRemaider
			// 
			this.textBoxRemaider.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRemaider.Location = new System.Drawing.Point(23, 410);
			this.textBoxRemaider.Name = "textBoxRemaider";
			this.textBoxRemaider.Size = new System.Drawing.Size(508, 33);
			this.textBoxRemaider.TabIndex = 25;
			// 
			// buttonValidPayment
			// 
			this.buttonValidPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonValidPayment.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonValidPayment.ForeColor = System.Drawing.Color.White;
			this.buttonValidPayment.Location = new System.Drawing.Point(23, 609);
			this.buttonValidPayment.Name = "buttonValidPayment";
			this.buttonValidPayment.Size = new System.Drawing.Size(147, 43);
			this.buttonValidPayment.TabIndex = 34;
			this.buttonValidPayment.Text = "Valider";
			this.buttonValidPayment.UseVisualStyleBackColor = false;
			this.buttonValidPayment.Click += new System.EventHandler(this.ButtonValidPaymentClick);
			// 
			// buttonDeletePayment
			// 
			this.buttonDeletePayment.BackColor = System.Drawing.Color.Red;
			this.buttonDeletePayment.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeletePayment.ForeColor = System.Drawing.Color.White;
			this.buttonDeletePayment.Location = new System.Drawing.Point(217, 609);
			this.buttonDeletePayment.Name = "buttonDeletePayment";
			this.buttonDeletePayment.Size = new System.Drawing.Size(147, 43);
			this.buttonDeletePayment.TabIndex = 35;
			this.buttonDeletePayment.Text = "Supprimer";
			this.buttonDeletePayment.UseVisualStyleBackColor = false;
			this.buttonDeletePayment.Click += new System.EventHandler(this.ButtonDeletePaymentClick);
			// 
			// AddPaymentUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 700);
			this.Controls.Add(this.buttonDeletePayment);
			this.Controls.Add(this.buttonValidPayment);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxRemaider);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxAmountPayroll);
			this.Controls.Add(this.labelPaymentDate);
			this.Controls.Add(this.labelPaymentRef);
			this.Controls.Add(this.labelOrderAmount);
			this.Controls.Add(this.labelOrderDate);
			this.Controls.Add(this.labelOrderRef);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddPaymentUI";
			this.Text = "AddPaymentUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
