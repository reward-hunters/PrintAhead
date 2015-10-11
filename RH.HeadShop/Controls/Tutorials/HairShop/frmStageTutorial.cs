﻿using System.Diagnostics;
using System.Windows.Forms;
using RH.HeadShop.Helpers;
using RH.HeadShop.IO;

namespace RH.HeadShop.Controls.Tutorials.HairShop
{
    public partial class frmStageTutorial : FormEx
    {
        public frmStageTutorial()
        {
            InitializeComponent();
            linkLabel1.Text = UserConfig.ByName("Tutorials")["Links", "Stage", "https://www.youtube.com/watch?v=AjG09RGgHvw"];
        }

        private void frmStageTutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;            // this cancels the close event.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = UserConfig.ByName("Tutorials")["Links", "Stage", "https://www.youtube.com/watch?v=AjG09RGgHvw"];
            Process.Start(link);
        }

        private void cbShow_CheckedChanged(object sender, System.EventArgs e)
        {
            UserConfig.ByName("Options")["Tutorials", "Stage"] = cbShow.Checked ? "0" : "1";
        }
    }
}
