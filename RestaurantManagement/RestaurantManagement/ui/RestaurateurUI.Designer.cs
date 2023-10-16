/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 03:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class RestaurateurUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonAddOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonValidOrder;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonListOrders;
		private System.Windows.Forms.Button buttonListPayments;
		private System.Windows.Forms.Button buttonRecipes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonLogout;
		
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
			this.buttonAddOrder = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonValidOrder = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonListOrders = new System.Windows.Forms.Button();
			this.buttonListPayments = new System.Windows.Forms.Button();
			this.buttonRecipes = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddOrder
			// 
			this.buttonAddOrder.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddOrder.Location = new System.Drawing.Point(40, 168);
			this.buttonAddOrder.Name = "buttonAddOrder";
			this.buttonAddOrder.Size = new System.Drawing.Size(419, 43);
			this.buttonAddOrder.TabIndex = 22;
			this.buttonAddOrder.Text = "Ajouter Commande";
			this.buttonAddOrder.UseVisualStyleBackColor = true;
			this.buttonAddOrder.Click += new System.EventHandler(this.ButtonAddOrderClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(40, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 33);
			this.label1.TabIndex = 15;
			this.label1.Text = "Restaurateur";
			// 
			// buttonValidOrder
			// 
			this.buttonValidOrder.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonValidOrder.Location = new System.Drawing.Point(881, 646);
			this.buttonValidOrder.Name = "buttonValidOrder";
			this.buttonValidOrder.Size = new System.Drawing.Size(231, 43);
			this.buttonValidOrder.TabIndex = 24;
			this.buttonValidOrder.Text = "Valider";
			this.buttonValidOrder.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(1139, 646);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(231, 43);
			this.buttonDelete.TabIndex = 26;
			this.buttonDelete.Text = "Retirer";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonListOrders
			// 
			this.buttonListOrders.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonListOrders.Location = new System.Drawing.Point(40, 245);
			this.buttonListOrders.Name = "buttonListOrders";
			this.buttonListOrders.Size = new System.Drawing.Size(419, 43);
			this.buttonListOrders.TabIndex = 27;
			this.buttonListOrders.Text = "Liste Commandes";
			this.buttonListOrders.UseVisualStyleBackColor = true;
			this.buttonListOrders.Click += new System.EventHandler(this.ButtonListOrdersClick);
			// 
			// buttonListPayments
			// 
			this.buttonListPayments.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonListPayments.Location = new System.Drawing.Point(40, 324);
			this.buttonListPayments.Name = "buttonListPayments";
			this.buttonListPayments.Size = new System.Drawing.Size(419, 43);
			this.buttonListPayments.TabIndex = 29;
			this.buttonListPayments.Text = "Liste Paiements";
			this.buttonListPayments.UseVisualStyleBackColor = true;
			this.buttonListPayments.Click += new System.EventHandler(this.ButtonListPaymentsClick);
			// 
			// buttonRecipes
			// 
			this.buttonRecipes.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRecipes.Location = new System.Drawing.Point(40, 402);
			this.buttonRecipes.Name = "buttonRecipes";
			this.buttonRecipes.Size = new System.Drawing.Size(419, 43);
			this.buttonRecipes.TabIndex = 30;
			this.buttonRecipes.Text = "Recettes";
			this.buttonRecipes.UseVisualStyleBackColor = true;
			this.buttonRecipes.Click += new System.EventHandler(this.ButtonRecipesClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(60, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 33);
			this.label2.TabIndex = 31;
			this.label2.Text = "Tableau de bord";
			// 
			// buttonLogout
			// 
			this.buttonLogout.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.Location = new System.Drawing.Point(295, 27);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(178, 40);
			this.buttonLogout.TabIndex = 32;
			this.buttonLogout.Text = "Déconnexion";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.ButtonLogoutClick);
			// 
			// RestaurateurUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 531);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonRecipes);
			this.Controls.Add(this.buttonListPayments);
			this.Controls.Add(this.buttonListOrders);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonValidOrder);
			this.Controls.Add(this.buttonAddOrder);
			this.Controls.Add(this.label1);
			this.Name = "RestaurateurUI";
			this.Text = "RestaurateurUI";
			this.ResumeLayout(false);

		}
	}
}
