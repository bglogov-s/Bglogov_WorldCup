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

        public custom_PlayerControl()
        {
            InitializeComponent();
        }

        public void SetPlayerData(Player player, bool isFavorite)
        {
            lblName.Text = player.Name;
            lblNumber.Text = $"#{player.ShirtNumber}";
            lblPosition.Text = player.Position;
            lblCaptain.Text = player.Captain ? "<CAP>" : "";
            lblFavorite.Text = isFavorite ? "★" : "";
            Tag = player;
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

        
    }
}
