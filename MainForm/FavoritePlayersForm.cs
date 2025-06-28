using DataLibrary.Config;
using DataLibrary.Models;
using DataLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMatch = DataLibrary.Models.Match;
using MainClass.CustomControls;
using System.Text.Json;

namespace MainClass
{
    public partial class from_FavoritePlayersForm : Form
    {
        public from_FavoritePlayersForm()
        {
            InitializeComponent();
        }

        private void flp_AllPlayers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_FavoritePlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMoveToFavorite_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in flp_AllPlayers.Controls.OfType<custom_PlayerControl>().Where(p => p.IsSelected))
            {
                if (flp_FavoritePlayer.Controls.Count >= 3)
                {
                    MessageBox.Show("Možete imati maksimalno 3 omiljena igrača.");
                    return;
                }

                flp_AllPlayers.Controls.Remove(ctrl);
                flp_FavoritePlayer.Controls.Add(ctrl);
            }
        }

        private void btnMoveToAllPlayers_Click(object sender, EventArgs e)
        {
            var selected = flp_FavoritePlayer.Controls
            .OfType<custom_PlayerControl>()
            .Where(c => c.IsSelected)
            .ToList();

            foreach (var playerControl in selected)
            {
                flp_FavoritePlayer.Controls.Remove(playerControl);
                flp_AllPlayers.Controls.Add(playerControl);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var favoriteIds = flp_FavoritePlayer.Controls
            .OfType<custom_PlayerControl>()
            .Select(ctrl => ctrl.Tag?.ToString())
            .Where(id => !string.IsNullOrWhiteSpace(id))
            .ToList();

            if (favoriteIds.Count != 3)
            {
                MessageBox.Show("Moraš odabrati točno 3 omiljena igrača.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var settings = SettingsManager.LoadSettings() ?? new UserSettings();
            settings.FavoritePlayers = favoriteIds;
            SettingsManager.SaveSettings(settings);

            MessageBox.Show("Omiljeni igrači su uspješno spremljeni!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetPlayerId(Player player) => $"{player.Name}_{player.ShirtNumber}";

        private List<string> LoadFavoriteIds()
        {
            string savePath = "favorite_players.json";
            if (!File.Exists(savePath)) return new();
            return JsonSerializer.Deserialize<List<string>>(File.ReadAllText(savePath)) ?? new();
        }

        private async Task LoadPlayersForFavoriteTeamAsync()
        {

            var settings = DataLibrary.Config.SettingsManager.LoadSettings();

            if (settings == null || string.IsNullOrWhiteSpace(settings.FavoriteTeamFifaCode))
            {
                MessageBox.Show("Nema odabranog omiljenog tima u postavkama.");
                return;
            }

            string gender = settings.IsMale ? "men" : "women";
            string fifaCode = settings.FavoriteTeamFifaCode;


            List<MyMatch>? matches = await FactoryAPI.GetMatchesByCountryAsync(gender, fifaCode);

            if (matches == null || matches.Count == 0)
            {
                MessageBox.Show("Nema pronađenih utakmica za odabrani tim.");
                return;
            }


            var firstMatch = matches.FirstOrDefault(m =>
                (m.HomeTeamStatistics?.StartingEleven?.Count > 0 || m.AwayTeamStatistics?.StartingEleven?.Count > 0));

            if (firstMatch == null)
            {
                MessageBox.Show("Nema dostupnih podataka o igračima u prvoj utakmici.");
                return;
            }


            var isHome = firstMatch.HomeTeam.Code == fifaCode;
            var teamStats = isHome ? firstMatch.HomeTeamStatistics : firstMatch.AwayTeamStatistics;


            var allPlayers = new List<DataLibrary.Models.Player>();
            if (teamStats?.StartingEleven != null)
                allPlayers.AddRange(teamStats.StartingEleven);
            if (teamStats?.Substitutes != null)
                allPlayers.AddRange(teamStats.Substitutes);

            if (allPlayers.Count == 0)
            {
                MessageBox.Show("Nema dostupnih igrača za prikaz.");
                return;
            }

            var savedFavorites = settings.FavoritePlayers ?? new List<string>();


            flp_AllPlayers.Controls.Clear();
            flp_FavoritePlayer.Controls.Clear();

            foreach (var player in allPlayers)
            {
                var playerId = GetPlayerId(player);
                var isFav = savedFavorites.Contains(playerId);
                var pc = new custom_PlayerControl();
                pc.SetPlayerData(player, isFav);
                pc.Tag = playerId;

                if (isFav && flp_FavoritePlayer.Controls.Count < 3)
                    flp_FavoritePlayer.Controls.Add(pc);
                else
                    flp_AllPlayers.Controls.Add(pc);
            }
        }

        private async void from_FavoritePlayersForm_LoadAsync(object sender, EventArgs e)
        {
            await LoadPlayersForFavoriteTeamAsync();
        }

        private void flp_AllPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragging(sender);
        }

        private void flp_AllPlayers_MouseEnter(object sender, EventArgs e)
        {
            // Nije potreban za drag-drop, može se izostaviti
        }

        private void flp_AllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            HandleDragDrop(sender as FlowLayoutPanel, flp_FavoritePlayer, e);
        }

        private void flp_FavoritePlayer_DragDrop(object sender, DragEventArgs e)
        {
            HandleDragDrop(sender as FlowLayoutPanel, flp_AllPlayers, e);
        }

        private void flp_FavoritePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragging(sender);
        }

        private void flp_FavoritePlayer_MouseEnter(object sender, EventArgs e)
        {
            // Nije potreban za drag-drop, može se izostaviti
        }

        private void StartDragging(object sender)
        {
            if (sender is FlowLayoutPanel panel)
            {
                var selectedControls = panel.Controls
                    .OfType<custom_PlayerControl>()
                    .Where(p => p.IsSelected)
                    .ToList();

                if (selectedControls.Any())
                {
                    var data = new DataObject();
                    data.SetData(typeof(List<custom_PlayerControl>), selectedControls);
                    panel.DoDragDrop(data, DragDropEffects.Move);
                }
            }
        }

        private void HandleDragDrop(FlowLayoutPanel targetPanel, FlowLayoutPanel otherPanel, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<custom_PlayerControl>)))
            {
                var players = (List<custom_PlayerControl>)e.Data.GetData(typeof(List<custom_PlayerControl>));

                foreach (var p in players)
                {
                    if (targetPanel == flp_FavoritePlayer && flp_FavoritePlayer.Controls.Count >= 3)
                    {
                        MessageBox.Show("Možete imati maksimalno 3 omiljena igrača.");
                        return;
                    }

                    otherPanel.Controls.Remove(p);
                    targetPanel.Controls.Add(p);
                }
            }
        }

        private void flp_AllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<custom_PlayerControl>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        

        private void flp_FavoritePlayer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<custom_PlayerControl>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
    }
}
