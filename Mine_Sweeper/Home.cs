using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SetResultValues();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            Game.sideWidth = 10; //Columns Count
            Game.sideHeight = 10; //Rows Count
            Game.bombCount = 10; //Bomb count
            Game.gameType = "Easy";

            StartGame();
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            Game.sideWidth = 20; //Columns Count
            Game.sideHeight = 10; //Rows Count
            Game.bombCount = 20; //Bomb count
            Game.gameType = "Medium";

            StartGame();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            Game.sideWidth = 30; //Columns Count
            Game.sideHeight = 15; //Rows Count
            Game.bombCount = 60; //Bomb count
            Game.gameType = "Hard";

            StartGame();
        }

        private void StartGame()
        {
            Game G = new Game();
            G.Show();
            Hide();
            G.senderForm = this;
        }

        public void SetResultValues()
        {
            Properties.Settings details = new Properties.Settings();

            ResultButton.Text = "Results\n" +
                "   ●Easy\n" +
                "      " + details.TimeEasy.ToString() + "\n" +
                "      " + details.NameEasy + "\n\n";

            ResultButton.Text +=
                "   ●Medium\n" +
                "      " + details.TimeMedium.ToString() + "\n" +
                "      " + details.NameMedium + "\n\n";

            ResultButton.Text +=
                "   ●Hard\n" +
                "      " + details.TimeHard.ToString() + "\n" +
                "      " + details.NameHard + "\n\n";

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            ResultSheet rSheet = new ResultSheet();
            if (rSheet.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                SetResultValues(); //Reload values if reset Result sheet
            }
        }

        private void AboutMeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutMe AbtMe = new AboutMe();
            AbtMe.ShowDialog();
        }
    }
}
