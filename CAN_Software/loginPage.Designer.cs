
namespace CAN_Software
{
	partial class loginPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.newUsernameLabel = new System.Windows.Forms.Label();
			this.newPasswordLabel = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.newUsernameBox = new System.Windows.Forms.TextBox();
			this.newPasswordBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.newLoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(50, 19);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(63, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "User Name:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(57, 72);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password:";
			// 
			// newUsernameLabel
			// 
			this.newUsernameLabel.AutoSize = true;
			this.newUsernameLabel.Location = new System.Drawing.Point(25, 134);
			this.newUsernameLabel.Name = "newUsernameLabel";
			this.newUsernameLabel.Size = new System.Drawing.Size(88, 13);
			this.newUsernameLabel.TabIndex = 2;
			this.newUsernameLabel.Text = "New User Name:";
			this.newUsernameLabel.Click += new System.EventHandler(this.p_Click);
			// 
			// newPasswordLabel
			// 
			this.newPasswordLabel.AutoSize = true;
			this.newPasswordLabel.Location = new System.Drawing.Point(32, 195);
			this.newPasswordLabel.Name = "newPasswordLabel";
			this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
			this.newPasswordLabel.TabIndex = 3;
			this.newPasswordLabel.Text = "New Password:";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(119, 16);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(165, 20);
			this.usernameBox.TabIndex = 4;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(118, 69);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '●';
			this.passwordBox.Size = new System.Drawing.Size(165, 20);
			this.passwordBox.TabIndex = 5;
			// 
			// newUsernameBox
			// 
			this.newUsernameBox.Location = new System.Drawing.Point(119, 131);
			this.newUsernameBox.Name = "newUsernameBox";
			this.newUsernameBox.Size = new System.Drawing.Size(164, 20);
			this.newUsernameBox.TabIndex = 6;
			// 
			// newPasswordBox
			// 
			this.newPasswordBox.Location = new System.Drawing.Point(119, 192);
			this.newPasswordBox.Name = "newPasswordBox";
			this.newPasswordBox.PasswordChar = '●';
			this.newPasswordBox.Size = new System.Drawing.Size(164, 20);
			this.newPasswordBox.TabIndex = 7;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(118, 227);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// newLoginButton
			// 
			this.newLoginButton.Location = new System.Drawing.Point(209, 227);
			this.newLoginButton.Name = "newLoginButton";
			this.newLoginButton.Size = new System.Drawing.Size(75, 23);
			this.newLoginButton.TabIndex = 9;
			this.newLoginButton.Text = "newLogin";
			this.newLoginButton.UseVisualStyleBackColor = true;
			this.newLoginButton.Click += new System.EventHandler(this.newLoginButton_Click);
			// 
			// loginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 262);
			this.Controls.Add(this.newLoginButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.newPasswordBox);
			this.Controls.Add(this.newUsernameBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.newPasswordLabel);
			this.Controls.Add(this.newUsernameLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Name = "loginPage";
			this.Text = "loginPage";
			this.Load += new System.EventHandler(this.loginPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label newUsernameLabel;
		private System.Windows.Forms.Label newPasswordLabel;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox newUsernameBox;
		private System.Windows.Forms.TextBox newPasswordBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button newLoginButton;
	}
}