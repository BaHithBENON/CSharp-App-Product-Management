/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 03:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class ProductDetailsUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
		
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(40, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 31);
			this.label4.TabIndex = 23;
			this.label4.Text = "Produit";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 31);
			this.label1.TabIndex = 22;
			this.label1.Text = "Details";
			// 
			// labelName
			// 
			this.labelName.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(24, 109);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(454, 31);
			this.labelName.TabIndex = 21;
			this.labelName.Text = "Nom";
			// 
			// labelPrice
			// 
			this.labelPrice.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(24, 175);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(454, 31);
			this.labelPrice.TabIndex = 24;
			this.labelPrice.Text = "Prix";
			// 
			// labelCategory
			// 
			this.labelCategory.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCategory.Location = new System.Drawing.Point(24, 233);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(454, 31);
			this.labelCategory.TabIndex = 25;
			this.labelCategory.Text = "Catégorie";
			// 
			// labelQuantity
			// 
			this.labelQuantity.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantity.Location = new System.Drawing.Point(24, 301);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(454, 31);
			this.labelQuantity.TabIndex = 26;
			this.labelQuantity.Text = "Quantité";
			// 
			// labelDescription
			// 
			this.labelDescription.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(24, 376);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(454, 154);
			this.labelDescription.TabIndex = 27;
			this.labelDescription.Text = "Description";
			// 
			// flowLayoutPanelImages
			// 
			this.flowLayoutPanelImages.AutoScroll = true;
			this.flowLayoutPanelImages.Location = new System.Drawing.Point(563, 109);
			this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
			this.flowLayoutPanelImages.Size = new System.Drawing.Size(426, 536);
			this.flowLayoutPanelImages.TabIndex = 28;
			// 
			// ProductDetailsUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 706);
			this.Controls.Add(this.flowLayoutPanelImages);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelQuantity);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelName);
			this.Name = "ProductDetailsUI";
			this.Text = "ProductDetailsUI";
			this.ResumeLayout(false);

		}
	}
}
