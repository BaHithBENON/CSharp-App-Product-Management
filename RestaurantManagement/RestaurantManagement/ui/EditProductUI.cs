/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 21/08/2023
 * Time: 01:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using RestaurantManagement.models;
using RestaurantManagement.db;

namespace RestaurantManagement.ui {
	/// <summary>
	/// Description of EditProductUI.
	/// </summary>
	public partial class EditProductUI : Form {
		private Product newProduct;
		private List<ProductImage> images = new List<ProductImage>();

		public EditProductUI() {
			InitializeComponent();
		}
		
		public void populateProduct(Product product) {
			newProduct = product;
			textBoxName.Text = product.Name;
	        textBoxDescription.Text = product.Description;
	        textBoxPrice.Text = product.Price.ToString();
	        numericUpDownQuantity.Value = product.Quantity;
	        comboBoxCategory.SelectedItem = product.Category;
	        
	        
            images = ProductDao.Instance.GetProductImages(product.Id, true);
	        AfficherImages();
		}
		
		void EraseForm() {
			textBoxName.Text = "";
		    textBoxDescription.Text = "";
		    textBoxPrice.Text = "";
		    numericUpDownQuantity.Value = 0;
		    comboBoxCategory.SelectedIndex = -1; // Effacez la sélection du rôle
	        newProduct = null;
		}
		
		private bool ValidateProductFields() {
		    // Vérifiez si les champs requis sont vides
		    if (string.IsNullOrWhiteSpace(textBoxName.Text) || 
		        string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
		        string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
		        numericUpDownQuantity.Value == 0 ||
		        comboBoxCategory.SelectedIndex == -1) {
		        // Affichez des messages d'alerte pour les champs vides
		        MessageBox.Show("Veuillez remplir tous les champs pour ajouter un produit.", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return false;
		    }
		    double a;
		    // Vérifiez si le prix est un nombre valide
		    if (!double.TryParse(textBoxPrice.Text, out a)) {
		        MessageBox.Show("Le champ Prix doit être un nombre valide.", "Format invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return false;
		    }
		
		    return true;
		}

		void SubmitButtonClick(object sender, EventArgs e) {
			if (ValidateProductFields()) {
				Product product = new Product(
					textBoxName.Text,
					double.Parse(textBoxPrice.Text),
					textBoxDescription.Text,
					(int)numericUpDownQuantity.Value,
					comboBoxCategory.Text
				);
		        // Les champs sont valides, vous pouvez créer un objet Product et l'ajouter via le ProductDao.
				
				ProductDao productDao = ProductDao.Instance;
				if(newProduct == null) {
			    	if (productDao.AddProduct(product, images)) {
				    	MessageBox.Show("Le produit a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				    	EraseForm();
						ChefDashboardUI.TriggerChefUIUpdated();
				    	this.Close();
				    } else {
				        MessageBox.Show("Échec de l'ajout du product.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				    }
			    } else {
			    	product.Id = newProduct.Id;
			    	if (productDao.UpdateProduct(product, images)) {
				    	MessageBox.Show("Le produit a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				    	EraseForm();
						ChefDashboardUI.TriggerChefUIUpdated();
				    	this.Close();
				    } else {
				        MessageBox.Show("Échec de la mise à jour du product.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				    }
			    }
			}
		}
		
		void ButtonChoiceImagesClick(object sender, EventArgs e) {
			images.Clear();
			OpenFileDialog openFileDialog = new OpenFileDialog();
		    openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif"; // Filtrez les fichiers par extension d'image
		    openFileDialog.Multiselect = true; // Permettre la sélection de plusieurs fichiers
		    
		    if (openFileDialog.ShowDialog() == DialogResult.OK) {
		        // L'utilisateur a sélectionné des fichiers, vous pouvez maintenant traiter ces fichiers.
		        string[] selectedFiles = openFileDialog.FileNames;
		        // Faites quelque chose avec les fichiers sélectionnés, par exemple, 
		        // enregistrez-les dans votre base de données ou affichez-les dans votre interface utilisateur.
		        foreach (string filePath in selectedFiles) {
		            // Lisez les données binaires du fichier image
		            byte[] imageData = File.ReadAllBytes(filePath);
		
		            // Obtenez le nom du fichier à partir du chemin complet
		            string fileName = Path.GetFileName(filePath);
		
		            // Créez un objet ProductImage avec les données lues
		            ProductImage productImage = new ProductImage();
		            productImage.FileName = fileName;
		            productImage.ImageData = imageData;
		
		            // Ajoutez l'objet ProductImage à votre liste d'images
		            images.Add(productImage);
		        }

		    }
		    AfficherImages();
		}
		
		private void AfficherImages() {
            // Assurez-vous de vider le contenu précédent avant d'ajouter de nouvelles images.
            flowLayoutPanelImages.Controls.Clear();
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
		
		void ButtonDeleteImageClick(object sender, EventArgs e) {
			images.Clear();
			AfficherImages();
		}
	}
}
