﻿using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RH.HeadShop.Helpers;
using RH.HeadShop.IO;

namespace RH.HeadShop.Controls.Tutorials.HeadShop
{
    public partial class frmCustomHeadsTutorial : FormEx
    {
        public frmCustomHeadsTutorial()
        {
            InitializeComponent();
            linkLabel1.Text = UserConfig.ByName("Tutorials")["Links", "CustomHeads", "http://youtu.be/H9dqNF4HdMQ"];
            Text = ProgramCore.ProgramCaption;

            var directoryPath = Path.Combine(Application.StartupPath, "Tutorials");
            var filePath = Path.Combine(directoryPath, "TutCustomHeads.jpg");
            if (File.Exists(filePath))
                BackgroundImage = Image.FromFile(filePath);
        }

        private void frmCustomHeadsTutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;            // this cancels the close event.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = UserConfig.ByName("Tutorials")["Links", "CustomHeads", "http://youtu.be/H9dqNF4HdMQ"];
            Process.Start(link);
        }

        private void cbShow_CheckedChanged(object sender, System.EventArgs e)
        {
            UserConfig.ByName("Options")["Tutorials", "CustomHeads"] = cbShow.Checked ? "0" : "1";
        }
    }
}
