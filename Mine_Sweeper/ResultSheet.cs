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
    public partial class ResultSheet : Form
    {
        Properties.Settings details = new Properties.Settings();
        string gameType;
        bool highscore = false;

        public ResultSheet()
        {
            InitializeComponent();
            loadDetails();
            NameEasyText.Select();
        }

        private void loadDetails()
        {
            NameEasyText.Text = details.NameEasy;
            NameMediumText.Text = details.NameMedium;
            NameHardText.Text = details.NameHard;

            TimeEasyLabel.Text = details.TimeEasy.ToString();
            TimeMediumLabel.Text = details.TimeMedium.ToString();
            TimeHardLabel.Text = details.TimeHard.ToString();
        }

        public void setDetails(string gameType, TimeSpan time)
        {
            this.gameType = gameType;
            switch (gameType)
            {
                case "Easy":
                    if (details.TimeEasy == TimeSpan.FromSeconds(0) || time < details.TimeEasy)
                    {
                        NameEasyText.Text = "";
                        NameEasyText.ReadOnly = false;
                        TimeEasyLabel.Text = time.ToString();
                        details.TimeEasy = time;
                        highscore = true;
                    }
                    NameEasyText.Select();
                    break;

                case "Medium":
                    if (details.TimeMedium == TimeSpan.FromSeconds(0) || time < details.TimeMedium)
                    {
                        NameMediumText.Text = "";
                        NameMediumText.ReadOnly = false;
                        TimeMediumLabel.Text = time.ToString();
                        details.TimeMedium = time;
                        highscore = true;
                    }
                    NameMediumText.Select();
                    break;

                case "Hard":
                    if (details.TimeHard == TimeSpan.FromSeconds(0) || time < details.TimeHard)
                    {
                        NameHardText.Text = "";
                        NameHardText.ReadOnly = false;
                        TimeHardLabel.Text = time.ToString();
                        details.TimeHard = time;
                        highscore = true;
                    }
                    NameHardText.Select();
                    break;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (highscore)
            {
                switch (gameType)
                {
                    case "Easy":
                        details.NameEasy = NameEasyText.Text;
                        break;

                    case "Medium":
                        details.NameMedium = NameMediumText.Text;
                        break;

                    case "Hard":
                        details.NameHard = NameHardText.Text;
                        break;
                }
            }

            details.Save();
            Close();
        }

        private void pressEnter(char theKey)
        {
            if (theKey == (char)System.ConsoleKey.Enter)
            {
                OKButton_Click(null, null);
            }
        }

        private void NameEasyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            pressEnter(e.KeyChar);
        }

        private void NameMediumText_KeyPress(object sender, KeyPressEventArgs e)
        {
            pressEnter(e.KeyChar);
        }

        private void NameHardText_KeyPress(object sender, KeyPressEventArgs e)
        {
            pressEnter(e.KeyChar);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure\ndo you want to reset Results?",
                "Reset Results", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == System.Windows.Forms.DialogResult.Yes)
            {
                ResetResults();
            }
        }

        private void ResetResults()
        {
            details.Reset();
            details.Save();
            setDetails(null, TimeSpan.FromSeconds(0));
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
