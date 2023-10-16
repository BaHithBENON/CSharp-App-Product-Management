/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button continueButton;
		
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
			this.continueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(116, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 108);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gestion de restaurant";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// continueButton
			// 
			this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.continueButton.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.continueButton.ForeColor = System.Drawing.Color.White;
			this.continueButton.Location = new System.Drawing.Point(162, 277);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(187, 38);
			this.continueButton.TabIndex = 5;
			this.continueButton.Text = "Continuer";
			this.continueButton.UseVisualStyleBackColor = false;
			this.continueButton.Click += new System.EventHandler(this.ContinueButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 391);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "RestaurantManagement";
			this.ResumeLayout(false);

		}
	}
}
