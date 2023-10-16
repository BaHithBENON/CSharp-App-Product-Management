/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 01:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class EditProductUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
		private System.Windows.Forms.Button buttonChoiceImages;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
		private System.Windows.Forms.Button buttonDeleteImage;
		
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
			this.submitButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
			this.buttonChoiceImages = new System.Windows.Forms.Button();
			this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonDeleteImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.submitButton.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.ForeColor = System.Drawing.Color.White;
			this.submitButton.Location = new System.Drawing.Point(23, 581);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(187, 51);
			this.submitButton.TabIndex = 17;
			this.submitButton.Text = "Valider";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 31);
			this.label3.TabIndex = 16;
			this.label3.Text = "Prix";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 31);
			this.label2.TabIndex = 15;
			this.label2.Text = "Nom";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(23, 215);
			this.textBoxPrice.Multiline = true;
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(451, 34);
			this.textBoxPrice.TabIndex = 14;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(23, 131);
			this.textBoxName.Multiline = true;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(451, 35);
			this.textBoxName.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(39, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 31);
			this.label4.TabIndex = 20;
			this.label4.Text = "Produit";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 31);
			this.label1.TabIndex = 19;
			this.label1.Text = "Editer";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(225, 31);
			this.label5.TabIndex = 22;
			this.label5.Text = "Description";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(23, 298);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(451, 83);
			this.textBoxDescription.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(23, 397);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(225, 31);
			this.label7.TabIndex = 26;
			this.label7.Text = "Quantité";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(23, 470);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(225, 31);
			this.label8.TabIndex = 28;
			this.label8.Text = "Catégorie";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Items.AddRange(new object[] {
			"Pizzas",
			"Pâtes",
			"Grillades",
			"Fruits de mer",
			"Plats végétariens",
			"Desserts",
			"Boissons",
			"Menus pour enfants",
			"Entrées",
			"Plats principaux"});
			this.comboBoxCategory.Location = new System.Drawing.Point(23, 504);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(451, 24);
			this.comboBoxCategory.TabIndex = 29;
			// 
			// numericUpDownQuantity
			// 
			this.numericUpDownQuantity.Location = new System.Drawing.Point(23, 431);
			this.numericUpDownQuantity.Name = "numericUpDownQuantity";
			this.numericUpDownQuantity.Size = new System.Drawing.Size(451, 22);
			this.numericUpDownQuantity.TabIndex = 30;
			// 
			// buttonChoiceImages
			// 
			this.buttonChoiceImages.BackColor = System.Drawing.Color.Blue;
			this.buttonChoiceImages.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChoiceImages.ForeColor = System.Drawing.Color.White;
			this.buttonChoiceImages.Location = new System.Drawing.Point(526, 12);
			this.buttonChoiceImages.Name = "buttonChoiceImages";
			this.buttonChoiceImages.Size = new System.Drawing.Size(188, 46);
			this.buttonChoiceImages.TabIndex = 31;
			this.buttonChoiceImages.Text = "Choisir Images";
			this.buttonChoiceImages.UseVisualStyleBackColor = false;
			this.buttonChoiceImages.Click += new System.EventHandler(this.ButtonChoiceImagesClick);
			// 
			// flowLayoutPanelImages
			// 
			this.flowLayoutPanelImages.AutoScroll = true;
			this.flowLayoutPanelImages.Location = new System.Drawing.Point(526, 78);
			this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
			this.flowLayoutPanelImages.Size = new System.Drawing.Size(439, 536);
			this.flowLayoutPanelImages.TabIndex = 32;
			// 
			// buttonDeleteImage
			// 
			this.buttonDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteImage.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteImage.ForeColor = System.Drawing.Color.White;
			this.buttonDeleteImage.Location = new System.Drawing.Point(771, 12);
			this.buttonDeleteImage.Name = "buttonDeleteImage";
			this.buttonDeleteImage.Size = new System.Drawing.Size(194, 46);
			this.buttonDeleteImage.TabIndex = 33;
			this.buttonDeleteImage.Text = "Effacer Images";
			this.buttonDeleteImage.UseVisualStyleBackColor = false;
			this.buttonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteImageClick);
			// 
			// EditProductUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 657);
			this.Controls.Add(this.buttonDeleteImage);
			this.Controls.Add(this.flowLayoutPanelImages);
			this.Controls.Add(this.buttonChoiceImages);
			this.Controls.Add(this.numericUpDownQuantity);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Name = "EditProductUI";
			this.Text = "EditProductUI";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
