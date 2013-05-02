namespace RestClient
{
	partial class Client
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
			this.HttpMethodLabel = new System.Windows.Forms.Label();
			this.HttpMethodComboBox = new System.Windows.Forms.ComboBox();
			this.ServiceURLLabel = new System.Windows.Forms.Label();
			this.ServiceURLTextbox = new System.Windows.Forms.TextBox();
			this.BasicAuthLabel = new System.Windows.Forms.Label();
			this.BasicAuthCheckBox = new System.Windows.Forms.CheckBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameTextbox = new System.Windows.Forms.TextBox();
			this.PasswordTextbox = new System.Windows.Forms.TextBox();
			this.MimeTextbox = new System.Windows.Forms.TextBox();
			this.MimeLabel = new System.Windows.Forms.Label();
			this.RequestBodyLabel = new System.Windows.Forms.Label();
			this.RequestBodyTextbox = new System.Windows.Forms.TextBox();
			this.ResponseBodyLabel = new System.Windows.Forms.Label();
			this.ResponseBodyTextbox = new System.Windows.Forms.TextBox();
			this.ExecuteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HttpMethodLabel
			// 
			this.HttpMethodLabel.AutoSize = true;
			this.HttpMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HttpMethodLabel.Location = new System.Drawing.Point(13, 13);
			this.HttpMethodLabel.Name = "HttpMethodLabel";
			this.HttpMethodLabel.Size = new System.Drawing.Size(107, 20);
			this.HttpMethodLabel.TabIndex = 0;
			this.HttpMethodLabel.Text = "HTTP Method";
			// 
			// HttpMethodComboBox
			// 
			this.HttpMethodComboBox.FormattingEnabled = true;
			this.HttpMethodComboBox.Location = new System.Drawing.Point(127, 11);
			this.HttpMethodComboBox.Name = "HttpMethodComboBox";
			this.HttpMethodComboBox.Size = new System.Drawing.Size(121, 21);
			this.HttpMethodComboBox.TabIndex = 1;
			this.HttpMethodComboBox.Text = "Select ...";
			// 
			// ServiceURLLabel
			// 
			this.ServiceURLLabel.AutoSize = true;
			this.ServiceURLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServiceURLLabel.Location = new System.Drawing.Point(13, 53);
			this.ServiceURLLabel.Name = "ServiceURLLabel";
			this.ServiceURLLabel.Size = new System.Drawing.Size(98, 20);
			this.ServiceURLLabel.TabIndex = 2;
			this.ServiceURLLabel.Text = "Service URL";
			// 
			// ServiceURLTextbox
			// 
			this.ServiceURLTextbox.Location = new System.Drawing.Point(127, 53);
			this.ServiceURLTextbox.Name = "ServiceURLTextbox";
			this.ServiceURLTextbox.Size = new System.Drawing.Size(334, 20);
			this.ServiceURLTextbox.TabIndex = 3;
			// 
			// BasicAuthLabel
			// 
			this.BasicAuthLabel.AutoSize = true;
			this.BasicAuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BasicAuthLabel.Location = new System.Drawing.Point(13, 90);
			this.BasicAuthLabel.Name = "BasicAuthLabel";
			this.BasicAuthLabel.Size = new System.Drawing.Size(86, 20);
			this.BasicAuthLabel.TabIndex = 4;
			this.BasicAuthLabel.Text = "Basic Auth";
			// 
			// BasicAuthCheckBox
			// 
			this.BasicAuthCheckBox.AutoSize = true;
			this.BasicAuthCheckBox.Location = new System.Drawing.Point(127, 91);
			this.BasicAuthCheckBox.Name = "BasicAuthCheckBox";
			this.BasicAuthCheckBox.Size = new System.Drawing.Size(15, 14);
			this.BasicAuthCheckBox.TabIndex = 5;
			this.BasicAuthCheckBox.UseVisualStyleBackColor = true;
			this.BasicAuthCheckBox.CheckedChanged += new System.EventHandler(this.BasicAuthCheckBox_CheckedChanged);
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameLabel.Location = new System.Drawing.Point(165, 91);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
			this.UsernameLabel.TabIndex = 6;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLabel.Location = new System.Drawing.Point(165, 126);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
			this.PasswordLabel.TabIndex = 7;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameTextbox
			// 
			this.UsernameTextbox.Enabled = false;
			this.UsernameTextbox.Location = new System.Drawing.Point(255, 90);
			this.UsernameTextbox.Name = "UsernameTextbox";
			this.UsernameTextbox.Size = new System.Drawing.Size(206, 20);
			this.UsernameTextbox.TabIndex = 8;
			// 
			// PasswordTextbox
			// 
			this.PasswordTextbox.Enabled = false;
			this.PasswordTextbox.Location = new System.Drawing.Point(255, 126);
			this.PasswordTextbox.Name = "PasswordTextbox";
			this.PasswordTextbox.PasswordChar = '*';
			this.PasswordTextbox.Size = new System.Drawing.Size(206, 20);
			this.PasswordTextbox.TabIndex = 9;
			// 
			// MimeTextbox
			// 
			this.MimeTextbox.Location = new System.Drawing.Point(183, 167);
			this.MimeTextbox.Name = "MimeTextbox";
			this.MimeTextbox.Size = new System.Drawing.Size(278, 20);
			this.MimeTextbox.TabIndex = 10;
			this.MimeTextbox.Text = "application/json";
			// 
			// MimeLabel
			// 
			this.MimeLabel.AutoSize = true;
			this.MimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MimeLabel.Location = new System.Drawing.Point(12, 167);
			this.MimeLabel.Name = "MimeLabel";
			this.MimeLabel.Size = new System.Drawing.Size(160, 20);
			this.MimeLabel.TabIndex = 11;
			this.MimeLabel.Text = "MIME (Content Type)";
			// 
			// RequestBodyLabel
			// 
			this.RequestBodyLabel.AutoSize = true;
			this.RequestBodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RequestBodyLabel.Location = new System.Drawing.Point(13, 209);
			this.RequestBodyLabel.Name = "RequestBodyLabel";
			this.RequestBodyLabel.Size = new System.Drawing.Size(219, 20);
			this.RequestBodyLabel.TabIndex = 12;
			this.RequestBodyLabel.Text = "Request Body (Pre-serialized)";
			// 
			// RequestBodyTextbox
			// 
			this.RequestBodyTextbox.Location = new System.Drawing.Point(16, 243);
			this.RequestBodyTextbox.Multiline = true;
			this.RequestBodyTextbox.Name = "RequestBodyTextbox";
			this.RequestBodyTextbox.Size = new System.Drawing.Size(640, 131);
			this.RequestBodyTextbox.TabIndex = 13;
			// 
			// ResponseBodyLabel
			// 
			this.ResponseBodyLabel.AutoSize = true;
			this.ResponseBodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResponseBodyLabel.Location = new System.Drawing.Point(13, 393);
			this.ResponseBodyLabel.Name = "ResponseBodyLabel";
			this.ResponseBodyLabel.Size = new System.Drawing.Size(122, 20);
			this.ResponseBodyLabel.TabIndex = 14;
			this.ResponseBodyLabel.Text = "Response Body";
			// 
			// ResponseBodyTextbox
			// 
			this.ResponseBodyTextbox.Location = new System.Drawing.Point(17, 416);
			this.ResponseBodyTextbox.Multiline = true;
			this.ResponseBodyTextbox.Name = "ResponseBodyTextbox";
			this.ResponseBodyTextbox.Size = new System.Drawing.Size(640, 131);
			this.ResponseBodyTextbox.TabIndex = 15;
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.Location = new System.Drawing.Point(499, 163);
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
			this.ExecuteButton.TabIndex = 16;
			this.ExecuteButton.Text = "Execute";
			this.ExecuteButton.UseVisualStyleBackColor = true;
			this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 563);
			this.Controls.Add(this.ExecuteButton);
			this.Controls.Add(this.ResponseBodyTextbox);
			this.Controls.Add(this.ResponseBodyLabel);
			this.Controls.Add(this.RequestBodyTextbox);
			this.Controls.Add(this.RequestBodyLabel);
			this.Controls.Add(this.MimeLabel);
			this.Controls.Add(this.MimeTextbox);
			this.Controls.Add(this.PasswordTextbox);
			this.Controls.Add(this.UsernameTextbox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.BasicAuthCheckBox);
			this.Controls.Add(this.BasicAuthLabel);
			this.Controls.Add(this.ServiceURLTextbox);
			this.Controls.Add(this.ServiceURLLabel);
			this.Controls.Add(this.HttpMethodComboBox);
			this.Controls.Add(this.HttpMethodLabel);
			this.Name = "Client";
			this.Text = "REST Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HttpMethodLabel;
		private System.Windows.Forms.ComboBox HttpMethodComboBox;
		private System.Windows.Forms.Label ServiceURLLabel;
		private System.Windows.Forms.TextBox ServiceURLTextbox;
		private System.Windows.Forms.Label BasicAuthLabel;
		private System.Windows.Forms.CheckBox BasicAuthCheckBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox UsernameTextbox;
		private System.Windows.Forms.TextBox PasswordTextbox;
		private System.Windows.Forms.TextBox MimeTextbox;
		private System.Windows.Forms.Label MimeLabel;
		private System.Windows.Forms.Label RequestBodyLabel;
		private System.Windows.Forms.TextBox RequestBodyTextbox;
		private System.Windows.Forms.Label ResponseBodyLabel;
		private System.Windows.Forms.TextBox ResponseBodyTextbox;
		private System.Windows.Forms.Button ExecuteButton;
	}
}

