/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 20/08/2023
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class EditUser
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxPasswordConfirm;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxLastname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxFirstname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxRole;
		
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxLastname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxFirstname = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxRole = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.submitButton.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.ForeColor = System.Drawing.Color.White;
			this.submitButton.Location = new System.Drawing.Point(34, 657);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(187, 38);
			this.submitButton.TabIndex = 17;
			this.submitButton.Text = "Valider";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 31);
			this.label3.TabIndex = 16;
			this.label3.Text = "Mot de passe";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 31);
			this.label2.TabIndex = 15;
			this.label2.Text = "Nom d\'utilisateur";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(34, 232);
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(451, 34);
			this.textBoxPassword.TabIndex = 14;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(34, 151);
			this.textBoxUsername.Multiline = true;
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(451, 35);
			this.textBoxUsername.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(34, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 31);
			this.label1.TabIndex = 12;
			this.label1.Text = "Editer";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Space Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(50, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 31);
			this.label4.TabIndex = 18;
			this.label4.Text = "Utilisateur";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(321, 31);
			this.label5.TabIndex = 20;
			this.label5.Text = "Mot de passe (Repeter)";
			// 
			// textBoxPasswordConfirm
			// 
			this.textBoxPasswordConfirm.Location = new System.Drawing.Point(34, 320);
			this.textBoxPasswordConfirm.Multiline = true;
			this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
			this.textBoxPasswordConfirm.PasswordChar = '*';
			this.textBoxPasswordConfirm.Size = new System.Drawing.Size(451, 34);
			this.textBoxPasswordConfirm.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(34, 366);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(225, 31);
			this.label6.TabIndex = 22;
			this.label6.Text = "Nom";
			// 
			// textBoxLastname
			// 
			this.textBoxLastname.Location = new System.Drawing.Point(34, 400);
			this.textBoxLastname.Multiline = true;
			this.textBoxLastname.Name = "textBoxLastname";
			this.textBoxLastname.Size = new System.Drawing.Size(451, 34);
			this.textBoxLastname.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 445);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(225, 31);
			this.label7.TabIndex = 24;
			this.label7.Text = "Prénom";
			// 
			// textBoxFirstname
			// 
			this.textBoxFirstname.Location = new System.Drawing.Point(34, 479);
			this.textBoxFirstname.Multiline = true;
			this.textBoxFirstname.Name = "textBoxFirstname";
			this.textBoxFirstname.Size = new System.Drawing.Size(451, 34);
			this.textBoxFirstname.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(34, 530);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(225, 31);
			this.label8.TabIndex = 26;
			this.label8.Text = "Rôle";
			// 
			// comboBoxRole
			// 
			this.comboBoxRole.FormattingEnabled = true;
			this.comboBoxRole.Items.AddRange(new object[] {
			"Super Administrateur",
			"Administrateur",
			"Chef",
			"Restaurateur"});
			this.comboBoxRole.Location = new System.Drawing.Point(34, 564);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(451, 24);
			this.comboBoxRole.TabIndex = 28;
			// 
			// EditUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 743);
			this.Controls.Add(this.comboBoxRole);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxFirstname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxLastname);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxPasswordConfirm);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.label1);
			this.Name = "EditUser";
			this.Text = "EditUser";
			//this.Load += new System.EventHandler(this.EditUserLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
