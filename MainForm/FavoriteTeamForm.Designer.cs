namespace MainClass
{
    partial class form_FavoriteTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_FavoriteTeamForm));
            cbFavoriteTeam = new ComboBox();
            SuspendLayout();
            // 
            // cbFavoriteTeam
            // 
            resources.ApplyResources(cbFavoriteTeam, "cbFavoriteTeam");
            cbFavoriteTeam.FormattingEnabled = true;
            cbFavoriteTeam.Name = "cbFavoriteTeam";
            cbFavoriteTeam.SelectedIndexChanged += cbFavoriteTeam_SelectedIndexChanged;
            // 
            // form_FavoriteTeamForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.team_favoriteTeamForm;
            Controls.Add(cbFavoriteTeam);
            Name = "form_FavoriteTeamForm";
            Load += form_FavoriteTeamForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbFavoriteTeam;
    }
}