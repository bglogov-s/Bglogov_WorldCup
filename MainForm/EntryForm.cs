using DataLibrary.Config;
using DataLibrary.Enums;
using DataLibrary.Models;
using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class EntryForm : Form
    {
        private string _selectedLanguage = "en";
        public EntryForm()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            PullCategory pull;
            GenderCategory gender;

            //Pull choice
            if (rbApiPull.Checked)
            {
                pull = PullCategory.API;
            }
            else if (rbJsonPull.Checked)
            {
                pull = PullCategory.JSON;
            }

            //Gender choice
            if (rbMale.Checked)
            {
                gender = GenderCategory.Male;
            }
            else if (rbFemale.Checked)
            {
                gender = GenderCategory.Female;
            }

            var settings = new UserSettings
            {
                SelectedLanguage = _selectedLanguage,
                UseApiPull = rbApiPull.Checked,
                UseJsonPull = rbJsonPull.Checked,
                IsMale = rbMale.Checked,
                IsFemale = rbFemale.Checked

            };

            SettingsManager.SaveSettings(settings);            
            form_FavoriteTeamForm teamForm = new form_FavoriteTeamForm();
            this.Hide();
            teamForm.Show();
            
        }

        private void SetCulture(string CultureName)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureName);

            UpdateUI();
        }

        private void UpdateUI()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnCroatian_Click(object sender, EventArgs e)
        {
            _selectedLanguage = "hr";
            SetCulture("hr");
            
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            _selectedLanguage = "en";
            SetCulture("en");
        }
    }
}
