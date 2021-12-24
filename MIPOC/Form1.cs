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
                var azureServiceTokenProvider = new AzureServiceTokenProvider();
                string accessToken = azureServiceTokenProvider.GetAccessTokenAsync("api://47bc37bb-860b-4133-9e76-77e76dee9d5d").GetAwaiter().GetResult();
                this.txtToken.Text = accessToken;
            }
            catch (Exception ex)
            {
                string errorText = String.Format("{0} \n\n{1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : "Acquire token failed");
                MessageBox.Show(errorText);
            }

        }
    }
}
