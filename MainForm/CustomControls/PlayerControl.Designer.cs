namespace MainClass.CustomControls
{
    partial class custom_PlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custom_PlayerControl));
            lblName = new Label();
            lblNumber = new Label();
            lblPosition = new Label();
            lblCaptain = new Label();
            lblFavorite = new Label();
            cbSelect = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // lblNumber
            // 
            resources.ApplyResources(lblNumber, "lblNumber");
            lblNumber.Name = "lblNumber";
            // 
            // lblPosition
            // 
            resources.ApplyResources(lblPosition, "lblPosition");
            lblPosition.Name = "lblPosition";
            // 
            // lblCaptain
            // 
            resources.ApplyResources(lblCaptain, "lblCaptain");
            lblCaptain.Name = "lblCaptain";
            // 
            // lblFavorite
            // 
            resources.ApplyResources(lblFavorite, "lblFavorite");
            lblFavorite.Name = "lblFavorite";
            // 
            // cbSelect
            // 
            resources.ApplyResources(cbSelect, "cbSelect");
            cbSelect.Name = "cbSelect";
            cbSelect.UseVisualStyleBackColor = true;
            cbSelect.CheckedChanged += cbSelect_CheckedChanged;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackgroundImage = Properties.Resources.png_PlayerControl;
            pictureBox1.Image = Properties.Resources.png_PlayerControl;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // custom_PlayerControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox1);
            Controls.Add(cbSelect);
            Controls.Add(lblFavorite);
            Controls.Add(lblCaptain);
            Controls.Add(lblPosition);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Name = "custom_PlayerControl";
            MouseDown += custom_PlayerControl_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNumber;
        private Label lblPosition;
        private Label lblCaptain;
        private Label lblFavorite;
        private CheckBox cbSelect;
        private PictureBox pictureBox1;
    }
}