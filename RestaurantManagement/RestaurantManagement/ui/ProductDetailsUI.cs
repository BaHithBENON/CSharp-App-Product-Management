/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 03:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RestaurantManagement.models;
using System.Collections.Generic;
using RestaurantManagement.db;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of ProductDetailsUI.
	/// </summary>
	public partial class ProductDetailsUI : Form {
		private List<ProductImage> images = new List<ProductImage>();
		private Product product;
		
		public ProductDetailsUI() {
			InitializeComponent();
		}
		
		public void populateProduct(Product product) {
			this.product = product;
			labelName.Text += " : " + product.Name;
			labelPrice.Text += " : " + product.Price;
			labelCategory.Text += " : " + product.Category;
			labelQuantity.Text += " : " + product.Quantity;
			labelDescription.Text += " : " + product.Description;
			
			AfficherImages();
		}
		
		private void AfficherImages() {
            // Assurez-vous de vider le contenu précédent avant d'ajouter de nouvelles images.
            flowLayoutPanelImages.Controls.Clear();
            images = ProductDao.Instance.GetProductImages(product.Id, true);
            // Parcourez la liste des images et ajoutez-les au FlowLayoutPanel.
            foreach (ProductImage image in images) {
                // Créez un PictureBox pour chaque image.
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 200; // Largeur souhaitée de l'image.
                pictureBox.Height = 200; // Hauteur souhaitée de l'image.
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ajuster l'image pour s'adapter au PictureBox.

                // Chargez l'image depuis les données binaires de ProductImage.ImageData.
                using (MemoryStream ms = new MemoryStream(image.ImageData)) {
                    pictureBox.Image = Image.FromStream(ms);
                }

                // Ajoutez le PictureBox au FlowLayoutPanel.
                flowLayoutPanelImages.Controls.Add(pictureBox);
            }
        }
	}
}
