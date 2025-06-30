using DataLibrary.Enums;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace MainClass.CustomControls
{
    public partial class custom_PlayerControl : UserControl
    {
        public Player? PlayerData { get; private set; }
        public custom_PlayerControl()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        public void SetPlayerData(Player player, bool isFavorite)
        {
            lblName.Text = player.Name;
            lblNumber.Text = $"#{player.ShirtNumber}";
            lblPosition.Text = player.Position;
            lblCaptain.Text = player.Captain ? "<CAP>" : "";
            lblFavorite.Text = isFavorite ? "★" : "";
            PlayerData = player;
        }
        public bool IsSelected => cbSelect.Checked;
        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = cbSelect.Checked ? Color.LightGreen : SystemColors.Control;
            StartDragDrop();
        }

        private void custom_PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragDrop();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragDrop();
        }

        public void StartDragDrop()
        {
            var parent = this.Parent as FlowLayoutPanel;
            if (parent == null) return;

            var selectedControls = parent.Controls
                .OfType<custom_PlayerControl>()
                .Where(p => p.IsSelected)
                .ToArray();

            if (selectedControls.Length > 0)
            {
                var data = new DataObject();
                data.SetData(typeof(custom_PlayerControl[]), selectedControls);
                parent.DoDragDrop(data, DragDropEffects.Move);
            }
        }

        private void InitializeContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            var tsmiChangeImage = new ToolStripMenuItem("Promijeni sliku");
            tsmiChangeImage.Click += TsmiChangeImage_Click;
            contextMenu.Items.Add(tsmiChangeImage);

            pictureBox1.ContextMenuStrip = contextMenu;
        }

        private void TsmiChangeImage_Click(object? sender, EventArgs e)
        {
            if (PlayerData == null)
            {
                MessageBox.Show("Nema učitanog igrača za ovu kontrolu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Odaberi novu sliku";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image newImage = Image.FromFile(ofd.FileName);
                        pictureBox1.Image = newImage;

                        // Lokacija za spremanje
                        string projectRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MainForm\Resources\PlayerImages");
                        Directory.CreateDirectory(projectRootPath);

                        // Ime datoteke
                        string safeName = string.Join("_", PlayerData.Name.Split(Path.GetInvalidFileNameChars()));
                        string fileName = $"{safeName}_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                        string savePath = Path.GetFullPath(Path.Combine(projectRootPath, fileName));

                        // Spremi sliku
                        newImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                        // Spremljena relativna putanja
                        string relativePath = $@"Resources\PlayerImages\{fileName}";
                        PlayerData.PicturePath = relativePath;

                        MessageBox.Show($"Slika je uspješno spremljena:\n{savePath}", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Greška pri spremanju slike: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
