﻿using DataLibrary.Config;
using DataLibrary.Models;
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

        private async void form_FavoriteTeamForm_Load(object sender, EventArgs e)
        {
            try
            {
                var settings = DataLibrary.Config.SettingsManager.LoadSettings();

                string gender = settings.IsMale ? "men" : "women";
                List<DataLibrary.Models.Team>? teams = null;

                if (settings.UseApiPull)
                {
                    teams = await DataLibrary.Services.FactoryAPI.GetTeamsAsync(gender);
                }
                else if (settings.UseJsonPull)
                {
                    string folder = settings.IsMale ? "jsonMen" : "jsonWomen";
                    string fileName = $"{gender}_teams.json";
                    string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folder, fileName);


                    if (File.Exists(jsonPath))
                    {
                        string json = await File.ReadAllTextAsync(jsonPath);
                        teams = System.Text.Json.JsonSerializer.Deserialize<List<Team>>(json);
                    }
                    else
                    {
                        MessageBox.Show($"JSON file not found. Check if files really exist: {jsonPath}");
                        return;
                    }
                }

                if (teams != null)
                {
                    cbFavoriteTeam.DataSource = teams;
                }
                else
                {
                    MessageBox.Show("Data is not avaiable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFavoriteTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChoice_Click(object sender, EventArgs e)
        {
            if (cbFavoriteTeam.SelectedItem is Team selectedTeam)
            {
                var settings = SettingsManager.LoadSettings();
                settings.FavoriteTeamFifaCode = selectedTeam.FifaCode;
                SettingsManager.SaveSettings(settings);

                MessageBox.Show($"You have selected team:  '{selectedTeam.Country}' ({selectedTeam.FifaCode}) ");

                this.Hide();
                from_FavoritePlayersForm from_FavoritePlayersForm = new from_FavoritePlayersForm();
                from_FavoritePlayersForm.Show();
            }
        }

        public async Task<T?> FetchFromApiAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);

            try
            {
                RestResponse restResponse = await DataLibrary.Config.Endpoints._restClient.ExecuteAsync(request);

                if (!restResponse.IsSuccessful)
                {
                    MessageBox.Show($"API Error: {restResponse.StatusCode} - {restResponse.ErrorMessage}");
                    return default;
                }

                return JsonConvert.DeserializeObject<T>(restResponse.Content ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return default;
            }
        }


    }
}
