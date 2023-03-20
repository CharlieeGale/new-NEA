
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.newUsernameBox = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.newLoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(49, 23);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(63, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "User Name:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(56, 76);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "New User Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "New Password:";
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
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(119, 192);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(164, 20);
			this.textBox4.TabIndex = 7;
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
			// 
			// loginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 262);
			this.Controls.Add(this.newLoginButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.newUsernameBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox newUsernameBox;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button newLoginButton;
	}
}