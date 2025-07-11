﻿namespace MainForm
{
    partial class EntryForm
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
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            gbDataPull = new GroupBox();
            rbJsonPull = new RadioButton();
            rbApiPull = new RadioButton();
            gbGenderChoice = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            btnSave = new Button();
            btnCroatian = new Button();
            btnEnglish = new Button();
            gbDataPull.SuspendLayout();
            gbGenderChoice.SuspendLayout();
            SuspendLayout();
            // 
            // gbDataPull
            // 
            resources.ApplyResources(gbDataPull, "gbDataPull");
            gbDataPull.Controls.Add(rbJsonPull);
            gbDataPull.Controls.Add(rbApiPull);
            gbDataPull.Name = "gbDataPull";
            gbDataPull.TabStop = false;
            // 
            // rbJsonPull
            // 
            resources.ApplyResources(rbJsonPull, "rbJsonPull");
            rbJsonPull.Name = "rbJsonPull";
            rbJsonPull.UseVisualStyleBackColor = true;
            // 
            // rbApiPull
            // 
            resources.ApplyResources(rbApiPull, "rbApiPull");
            rbApiPull.Checked = true;
            rbApiPull.Name = "rbApiPull";
            rbApiPull.TabStop = true;
            rbApiPull.UseVisualStyleBackColor = true;
            // 
            // gbGenderChoice
            // 
            resources.ApplyResources(gbGenderChoice, "gbGenderChoice");
            gbGenderChoice.Controls.Add(rbFemale);
            gbGenderChoice.Controls.Add(rbMale);
            gbGenderChoice.Name = "gbGenderChoice";
            gbGenderChoice.TabStop = false;
            // 
            // rbFemale
            // 
            resources.ApplyResources(rbFemale, "rbFemale");
            rbFemale.Name = "rbFemale";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            resources.ApplyResources(rbMale, "rbMale");
            rbMale.Checked = true;
            rbMale.Name = "rbMale";
            rbMale.TabStop = true;
            rbMale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCroatian
            // 
            resources.ApplyResources(btnCroatian, "btnCroatian");
            btnCroatian.Name = "btnCroatian";
            btnCroatian.UseVisualStyleBackColor = true;
            btnCroatian.Click += btnCroatian_Click;
            // 
            // btnEnglish
            // 
            resources.ApplyResources(btnEnglish, "btnEnglish");
            btnEnglish.Name = "btnEnglish";
            btnEnglish.UseVisualStyleBackColor = true;
            btnEnglish.Click += btnEnglish_Click;
            // 
            // EntryForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MainClass.Properties.Resources.goal_entryForm;
            Controls.Add(btnEnglish);
            Controls.Add(btnCroatian);
            Controls.Add(btnSave);
            Controls.Add(gbGenderChoice);
            Controls.Add(gbDataPull);
            Name = "EntryForm";
            gbDataPull.ResumeLayout(false);
            gbDataPull.PerformLayout();
            gbGenderChoice.ResumeLayout(false);
            gbGenderChoice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDataPull;
        private RadioButton rbJsonPull;
        private RadioButton rbApiPull;
        private GroupBox gbGenderChoice;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Button btnSave;
        private Button btnCroatian;
        private Button btnEnglish;
    }
}