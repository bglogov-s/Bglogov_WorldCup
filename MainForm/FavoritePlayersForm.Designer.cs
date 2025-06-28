namespace MainClass
{
    partial class from_FavoritePlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(from_FavoritePlayersForm));
            flp_AllPlayers = new FlowLayoutPanel();
            flp_FavoritePlayer = new FlowLayoutPanel();
            btnMoveToFavorite = new Button();
            btnMoveToAllPlayers = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // flp_AllPlayers
            // 
            resources.ApplyResources(flp_AllPlayers, "flp_AllPlayers");
            flp_AllPlayers.Name = "flp_AllPlayers";
            flp_AllPlayers.Paint += flp_AllPlayers_Paint;
            // 
            // flp_FavoritePlayer
            // 
            resources.ApplyResources(flp_FavoritePlayer, "flp_FavoritePlayer");
            flp_FavoritePlayer.Name = "flp_FavoritePlayer";
            // 
            // btnMoveToFavorite
            // 
            resources.ApplyResources(btnMoveToFavorite, "btnMoveToFavorite");
            btnMoveToFavorite.Name = "btnMoveToFavorite";
            btnMoveToFavorite.UseVisualStyleBackColor = true;
            // 
            // btnMoveToAllPlayers
            // 
            resources.ApplyResources(btnMoveToAllPlayers, "btnMoveToAllPlayers");
            btnMoveToAllPlayers.Name = "btnMoveToAllPlayers";
            btnMoveToAllPlayers.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // from_FavoritePlayersForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConfirm);
            Controls.Add(btnMoveToAllPlayers);
            Controls.Add(btnMoveToFavorite);
            Controls.Add(flp_FavoritePlayer);
            Controls.Add(flp_AllPlayers);
            Name = "from_FavoritePlayersForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_AllPlayers;
        private FlowLayoutPanel flp_FavoritePlayer;
        private Button btnMoveToFavorite;
        private Button btnMoveToAllPlayers;
        private Button btnConfirm;
    }
}