/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 22/08/2023
 * Time: 00:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class OrderValidatorUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelTotalPrice;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelTotalPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(28, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 33);
			this.label2.TabIndex = 35;
			this.label2.Text = "Votre commande";
			// 
			// flowLayoutPanelProducts
			// 
			this.flowLayoutPanelProducts.AutoScroll = true;
			this.flowLayoutPanelProducts.Location = new System.Drawing.Point(28, 72);
			this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
			this.flowLayoutPanelProducts.Size = new System.Drawing.Size(504, 646);
			this.flowLayoutPanelProducts.TabIndex = 36;
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.buttonSubmit.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSubmit.ForeColor = System.Drawing.Color.White;
			this.buttonSubmit.Location = new System.Drawing.Point(28, 724);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(168, 54);
			this.buttonSubmit.TabIndex = 38;
			this.buttonSubmit.Text = "Confirmer";
			this.buttonSubmit.UseVisualStyleBackColor = false;
			this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmitClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(207, 721);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 33);
			this.label1.TabIndex = 39;
			this.label1.Text = "Prix total";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTotalPrice
			// 
			this.labelTotalPrice.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalPrice.ForeColor = System.Drawing.Color.Black;
			this.labelTotalPrice.Location = new System.Drawing.Point(207, 748);
			this.labelTotalPrice.Name = "labelTotalPrice";
			this.labelTotalPrice.Size = new System.Drawing.Size(325, 33);
			this.labelTotalPrice.TabIndex = 40;
			this.labelTotalPrice.Text = "...";
			this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OrderValidatorUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 790);
			this.Controls.Add(this.labelTotalPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.flowLayoutPanelProducts);
			this.Controls.Add(this.label2);
			this.Name = "OrderValidatorUI";
			this.Text = "OrderValidatorUI";
			this.ResumeLayout(false);

		}
	}
}
