using DataLibrary.Models;
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
    public partial class from_FavoritePlayersForm : Form
    {

        public static List<Player> AllPlayers;
        public static List<Player> FavoritePlayers;

        public from_FavoritePlayersForm()
        {
            InitializeComponent();

        }

        private void flp_AllPlayers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
