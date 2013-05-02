using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace RestClient
{
	/// <summary>
	/// Client.
	/// </summary>
	public partial class Client : Form
	{
		#region Fields

		/// <summary>
		/// The _useBasicAuth.
		/// </summary>
		private bool _useBasicAuth = false;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of <see cref="Client"/> form.
		/// </summary>
		public Client()
		{
			InitializeComponent();

			this.PopoulateHTTPMethods();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Adds HTTP methods to the combo box.
		/// </summary>
		private void PopoulateHTTPMethods()
		{
			this.HttpMethodComboBox.Items.Add("GET");
			this.HttpMethodComboBox.Items.Add("POST");
			this.HttpMethodComboBox.Items.Add("HEAD");
			this.HttpMethodComboBox.Items.Add("DELETE");
			this.HttpMethodComboBox.Items.Add("PUT");
		}

		/// <summary>
		/// Executes a HTTP web request.
		/// </summary>
		private void Execute()
		{
			this.ResponseBodyTextbox.Text = "Executing ...";

			string basicAuthCredentials = string.Empty;

			if (string.IsNullOrEmpty(this.ServiceURLTextbox.Text))
			{
				this.ResponseBodyTextbox.Text = this.ResponseBodyTextbox.Text + Environment.NewLine + "You must enter a service URL.";
			}

			else
			{
				Stream stream;

				// If we're using basic auth (HTTP).
				if (this._useBasicAuth)
				{
					// No username specified.
					if (string.IsNullOrEmpty(this.UsernameTextbox.Text))
					{
						this.ResponseBodyTextbox.Text = this.ResponseBodyTextbox.Text + Environment.NewLine + "BASIC AUTH requires a username";
						
						return;
					}

					// No password specified.
					if (string.IsNullOrEmpty(this.PasswordTextbox.Text))
					{
						this.ResponseBodyTextbox.Text = this.ResponseBodyTextbox.Text + Environment.NewLine + "BASIC AUTH requires a password";
						
						return;
					}

					basicAuthCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.UsernameTextbox.Text + ":" + this.PasswordTextbox.Text));
				}

				// Accept all certificates (SSL).
				System.Net.ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(RemoteCertValidate);

				// Create a HTTP web request to the service URL.
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.ServiceURLTextbox.Text);
				request.Accept = this.MimeTextbox.Text;
				request.ContentType = this.MimeTextbox.Text;
				request.Method = this.HttpMethodComboBox.Text;

				if (this.BasicAuthCheckBox.Checked)
				{
					request.Headers.Add("Authorization", "Basic " + basicAuthCredentials);
				}

				request.Timeout = 60;
				request.UserAgent = "REST Client";
				
				try
				{
					string serverResponse = string.Empty;

					using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
					{
						using (stream = response.GetResponseStream())
						{
							using (StreamReader reader = new StreamReader(stream))
							{
								serverResponse = reader.ReadToEnd();
								this.ResponseBodyTextbox.Text = this.ResponseBodyTextbox.Text + Environment.NewLine + serverResponse;
							}
						}
					}
				}

				catch (WebException ex)
				{
					using (WebResponse response = ex.Response)
					{
						HttpWebResponse httpResponse = (HttpWebResponse)response;

						using (stream = httpResponse.GetResponseStream())
						{
							this.ResponseBodyTextbox.Text = this.ResponseBodyTextbox.Text + Environment.NewLine + new StreamReader(stream).ReadToEnd();
						}
					}
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="cert"></param>
		/// <param name="chain"></param>
		/// <param name="error"></param>
		/// <returns></returns>
		private bool RemoteCertValidate(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
		{
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BasicAuthCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this._useBasicAuth = !this._useBasicAuth;

			this.UsernameTextbox.Enabled = this._useBasicAuth;
			this.PasswordTextbox.Enabled = this._useBasicAuth;
		}

		private void ExecuteButton_Click(object sender, EventArgs e)
		{
			this.Execute();
		}

		#endregion
	}
}