namespace MainForm
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
            gbDataPull = new GroupBox();
            rbJsonPull = new RadioButton();
            rbApiPull = new RadioButton();
            gbGenderChoice = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            gbLanguage = new GroupBox();
            rbEnglish = new RadioButton();
            rbCroatian = new RadioButton();
            btnSave = new Button();
            gbDataPull.SuspendLayout();
            gbGenderChoice.SuspendLayout();
            gbLanguage.SuspendLayout();
            SuspendLayout();
            // 
            // gbDataPull
            // 
            gbDataPull.Controls.Add(rbJsonPull);
            gbDataPull.Controls.Add(rbApiPull);
            gbDataPull.Location = new Point(250, 30);
            gbDataPull.Name = "gbDataPull";
            gbDataPull.Size = new Size(280, 80);
            gbDataPull.TabIndex = 0;
            gbDataPull.TabStop = false;
            gbDataPull.Text = "Data pull";
            gbDataPull.Enter += gbDataPull_Enter;
            // 
            // rbJsonPull
            // 
            rbJsonPull.AutoSize = true;
            rbJsonPull.Location = new Point(176, 36);
            rbJsonPull.Name = "rbJsonPull";
            rbJsonPull.Size = new Size(53, 19);
            rbJsonPull.TabIndex = 1;
            rbJsonPull.Text = "JSON";
            rbJsonPull.UseVisualStyleBackColor = true;
            rbJsonPull.CheckedChanged += rbJsonPull_CheckedChanged;
            // 
            // rbApiPull
            // 
            rbApiPull.AutoSize = true;
            rbApiPull.Checked = true;
            rbApiPull.Location = new Point(38, 36);
            rbApiPull.Name = "rbApiPull";
            rbApiPull.Size = new Size(43, 19);
            rbApiPull.TabIndex = 0;
            rbApiPull.TabStop = true;
            rbApiPull.Text = "API";
            rbApiPull.UseVisualStyleBackColor = true;
            rbApiPull.CheckedChanged += rbApiPull_CheckedChanged;
            // 
            // gbGenderChoice
            // 
            gbGenderChoice.Controls.Add(rbFemale);
            gbGenderChoice.Controls.Add(rbMale);
            gbGenderChoice.Location = new Point(250, 150);
            gbGenderChoice.Name = "gbGenderChoice";
            gbGenderChoice.Size = new Size(280, 80);
            gbGenderChoice.TabIndex = 1;
            gbGenderChoice.TabStop = false;
            gbGenderChoice.Text = "Gender";
            gbGenderChoice.Enter += gbGenderChoice_Enter;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(176, 36);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(38, 36);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // gbLanguage
            // 
            gbLanguage.Controls.Add(rbEnglish);
            gbLanguage.Controls.Add(rbCroatian);
            gbLanguage.Location = new Point(250, 280);
            gbLanguage.Name = "gbLanguage";
            gbLanguage.Size = new Size(280, 80);
            gbLanguage.TabIndex = 2;
            gbLanguage.TabStop = false;
            gbLanguage.Text = "Language";
            gbLanguage.Enter += gbLanguage_Enter;
            // 
            // rbEnglish
            // 
            rbEnglish.AutoSize = true;
            rbEnglish.Checked = true;
            rbEnglish.Location = new Point(176, 36);
            rbEnglish.Name = "rbEnglish";
            rbEnglish.Size = new Size(63, 19);
            rbEnglish.TabIndex = 1;
            rbEnglish.TabStop = true;
            rbEnglish.Text = "English";
            rbEnglish.UseVisualStyleBackColor = true;
            rbEnglish.CheckedChanged += rbEnglish_CheckedChanged;
            // 
            // rbCroatian
            // 
            rbCroatian.AutoSize = true;
            rbCroatian.Location = new Point(38, 36);
            rbCroatian.Name = "rbCroatian";
            rbCroatian.Size = new Size(70, 19);
            rbCroatian.TabIndex = 0;
            rbCroatian.Text = "Croatian";
            rbCroatian.UseVisualStyleBackColor = true;
            rbCroatian.CheckedChanged += rbCroatian_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(678, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(gbLanguage);
            Controls.Add(gbGenderChoice);
            Controls.Add(gbDataPull);
            Name = "EntryForm";
            Text = "Settings";
            Load += EntryForm_Load;
            gbDataPull.ResumeLayout(false);
            gbDataPull.PerformLayout();
            gbGenderChoice.ResumeLayout(false);
            gbGenderChoice.PerformLayout();
            gbLanguage.ResumeLayout(false);
            gbLanguage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDataPull;
        private RadioButton rbJsonPull;
        private RadioButton rbApiPull;
        private GroupBox gbGenderChoice;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private GroupBox gbLanguage;
        private RadioButton rbEnglish;
        private RadioButton rbCroatian;
        private Button btnSave;
    }
}