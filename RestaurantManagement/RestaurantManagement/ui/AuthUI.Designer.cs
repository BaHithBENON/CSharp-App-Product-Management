/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class AuthUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label label1;
		
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
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.submitButton.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.ForeColor = System.Drawing.Color.White;
			this.submitButton.Location = new System.Drawing.Point(30, 379);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(187, 38);
			this.submitButton.TabIndex = 11;
			this.submitButton.Text = "Continuer";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 31);
			this.label3.TabIndex = 10;
			this.label3.Text = "Mot de passe";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 31);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nom d\'utilisateur";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(30, 284);
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(451, 34);
			this.textBoxPassword.TabIndex = 8;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(30, 175);
			this.textBoxUsername.Multiline = true;
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(451, 35);
			this.textBoxUsername.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(30, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Connexion";
			// 
			// AuthUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 501);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.label1);
			this.Name = "AuthUI";
			this.Text = "AuthUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
