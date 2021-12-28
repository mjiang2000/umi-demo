using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Microsoft.Azure.Services.AppAuthentication;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MIPOC
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnGetToken_Click(object sender, EventArgs e)
        {
         
            try
            {
                var umiClientId = "bcee34af-98ac-4199-90e7-27fe9ff2579e";
                var azureServiceTokenProvider = new AzureServiceTokenProvider($"RunAs=App;AppId={umiClientId}");
                string accessToken = azureServiceTokenProvider.GetAccessTokenAsync("api://47bc37bb-860b-4133-9e76-77e76dee9d5d").GetAwaiter().GetResult();
                this.txtToken.Text = accessToken;
            }
            catch (Exception ex)
            {
                string errorText = String.Format("{0} \n\n{1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : "Acquire token failed");
                MessageBox.Show(errorText);
            }

        }

        private async void btnCallApi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.txtToken.Text))
                {
                    var httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.txtToken.Text);
                    var response = await httpClient.GetAsync("https://vj-webapp-01.azurewebsites.net/api/TestApi");
                    this.txtAPIResult.Text = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                this.txtAPIResult.Text = ex.Message;
            }
        }

        private async void btnCallApiWithoutToken_Click(object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("https://vj-webapp-01.azurewebsites.net/api/TestApi");
                this.txtAPIError.Text = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                this.txtAPIError.Text = ex.Message;
            }
        }
    }
}
