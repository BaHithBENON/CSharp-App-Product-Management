/*
 * Created by SharpDevelop.
 * User: asist
 * Date: 14/08/2023
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RestaurantManagement.ui
{
	partial class AdminDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
		private System.Windows.Forms.DataGridViewTextBoxColumn username;
		private System.Windows.Forms.DataGridViewTextBoxColumn role;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAdd;
		
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(23, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Liste des utilisateurs";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Space Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(23, 59);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(947, 33);
			this.textBoxSearch.TabIndex = 1;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.AllowUserToAddRows = false;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.lastname,
			this.firstname,
			this.username,
			this.role});
			this.dataGridViewUsers.Location = new System.Drawing.Point(23, 107);
			this.dataGridViewUsers.MultiSelect = false;
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.RowTemplate.Height = 24;
			this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUsers.Size = new System.Drawing.Size(947, 502);
			this.dataGridViewUsers.TabIndex = 2;
			this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsersCellContentClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// lastname
			// 
			this.lastname.DataPropertyName = "lastname";
			this.lastname.HeaderText = "Nom";
			this.lastname.Name = "lastname";
			this.lastname.ReadOnly = true;
			// 
			// firstname
			// 
			this.firstname.DataPropertyName = "firstname";
			this.firstname.HeaderText = "Prénom";
			this.firstname.Name = "firstname";
			this.firstname.ReadOnly = true;
			// 
			// username
			// 
			this.username.DataPropertyName = "username";
			this.username.HeaderText = "Nom d\'utilisateur";
			this.username.Name = "username";
			this.username.ReadOnly = true;
			// 
			// role
			// 
			this.role.DataPropertyName = "role";
			this.role.HeaderText = "Rôle";
			this.role.Name = "role";
			this.role.ReadOnly = true;
			// 
			// buttonLogout
			// 
			this.buttonLogout.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.Location = new System.Drawing.Point(741, 13);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(229, 40);
			this.buttonLogout.TabIndex = 3;
			this.buttonLogout.Text = "Déconnexion";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.ButtonLogoutClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Red;
			this.buttonDelete.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.Color.White;
			this.buttonDelete.Location = new System.Drawing.Point(803, 634);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(167, 43);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Supprimer";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.Location = new System.Drawing.Point(587, 634);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(146, 43);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Text = "Modifier";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Space Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(321, 634);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(195, 43);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Ajouter";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// AdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 689);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.dataGridViewUsers);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Name = "AdminDashboard";
			this.Text = "AdminDashboard";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
