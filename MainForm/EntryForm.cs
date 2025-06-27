using DataLibrary.Enums;
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

namespace MainForm
{
    public partial class EntryForm : Form
    {
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
            else if  (rbFemale.Checked)
            {
                gender = GenderCategory.Female;
            }
        
            
        }

        
    }
}
