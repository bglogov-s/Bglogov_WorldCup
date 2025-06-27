using MainForm;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainClass
{
    public partial class form_FavoriteTeamForm : Form
    {
        public form_FavoriteTeamForm()
        {


            InitializeComponent();
        }

        private void form_FavoriteTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void cbFavoriteTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public async Task<T?> FetchFromApiAsync<T>(string endpoint, RestResponse response)
        {
            var request = new RestRequest(endpoint, Method.Get);

            try
            {
                RestResponse restResponse = await DataLibrary.Config.Endpoints._restClient.ExecuteAsync(request);
               

                if (!response.IsSuccessful)
                {
                    MessageBox.Show($"API Error: {response.StatusCode} - {response.ErrorMessage}");
                    return default;
                }

                return JsonSerializer.Deserialize<T>(restResponse.Content ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return default;
            }
        }

    }
}
