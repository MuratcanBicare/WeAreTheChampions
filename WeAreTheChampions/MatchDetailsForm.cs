using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Model;

namespace WeAreTheChampions
{
    public partial class MatchDetailsForm : Form
    {
        public event EventHandler HasBeenChanged;
        private readonly WeAreTheChampionsContext db;
        private readonly int selectedIdMainForm;
        bool isEditIdShow;
        public MatchDetailsForm(WeAreTheChampionsContext db, int selectedIdMainForm)
        {
            this.selectedIdMainForm = selectedIdMainForm;
            this.db = db;
            InitializeComponent();
            isEditIdShow = true;
            ListTeamsNewMatch();
            ListTeamsEditMatch();
        }

        private void ListTeamsEditMatch()
        {

            var matches = MatchListCreate();
            var matchesplus = matches.OrderByDescending(x => x.MatchTime).Select(x =>
                            x.Id + " - " + x.Team1.TeamName + "-" + x.Team2.TeamName + " || "
                             + x.MatchTime?.ToShortDateString())
                .ToList();
            cboMatches.DataSource = matchesplus;
            if (isEditIdShow == true)
            {
                cboMatches.SelectedIndex = -1;
            }
        }

        private List<Match> MatchListCreate()
        {
            var matches = db.Matches.ToList().OrderBy(x => x.MatchTime).ToList();

            return matches;
        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void ListTeamsNewMatch()
        {
            var teams1 = db.Teams.ToList();
            teams1.Insert(0, new Team { TeamName = "Select Team" });
            var teams2 = db.Teams.ToList();
            teams2.Insert(0, new Team { TeamName = "Select Team" });
            cboNewTeam1.DataSource = teams1;
            cboNewTeam2.DataSource = teams2;
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (cboNewTeam1.SelectedIndex == 0 || cboNewTeam2.SelectedIndex == 0 || (Team)cboNewTeam1.SelectedItem == (Team)cboNewTeam2.SelectedItem)
            {
                MessageBox.Show("Please select team correctly!");
                return;
            }
            var team1 = (Team)cboNewTeam1.SelectedItem;
            var team2 = (Team)cboNewTeam2.SelectedItem;
            DateTime? matchDate = dtpNewDate.Value;
            if (team1.Team1Matches.ToList().Any(x => x.MatchTime.Value.ToShortDateString() == matchDate.Value.ToShortDateString()) || team1.Team2Matches.ToList().Any(x => x.MatchTime.Value.ToShortDateString() == matchDate.Value.ToShortDateString()))
            {
                MessageBox.Show($"{team1.TeamName} have a match on selected date");
                return;
            }
            if (team2.Team1Matches.ToList().Any(x => x.MatchTime.Value.ToShortDateString() == matchDate.Value.ToShortDateString()) || team2.Team2Matches.ToList().Any(x => x.MatchTime.Value.ToShortDateString() == matchDate.Value.ToShortDateString()))
            {
                MessageBox.Show($"{team2.TeamName} have  a match on selected date");
                return;
            }
            db.Matches.Add(new Match()
            {
                Team1 = team1,
                Team2 = team2,
                MatchTime = matchDate
            });
            db.SaveChanges();
            ListTeamsEditMatch();
            WhenMakeChange(EventArgs.Empty);
            ResetForm();
        }

        private void ResetForm()
        {
            cboNewTeam1.SelectedIndex = 0;
            cboNewTeam2.SelectedIndex = 0;
            dtpNewDate.Value = DateTime.Now;
        }

        private void cboMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedIdMainForm > 0 && isEditIdShow == true)
            {
                var mac = db.Matches.ToList().Find(x => x.Id == selectedIdMainForm);
                string mactext = mac.Id + " - " + mac.Team1.TeamName + "-" + mac.Team2.TeamName + " || " + mac.MatchTime?.ToShortDateString();
                cboMatches.SelectedItem = mactext;
                isEditIdShow = false;

            }

            if (cboMatches.SelectedIndex == -1)
            {
                cboEditTeam1.Enabled = cboEditTeam2.Enabled
                    = nudScore1.Enabled = nudScore2.Enabled
                    = dtpEditDate.Enabled = false;
                return;
            }

            cboEditTeam1.Enabled = cboEditTeam2.Enabled = true;
            nudScore1.Enabled = nudScore2.Enabled = dtpEditDate.Enabled = true;
            cboEditTeam1.DataSource = db.Teams.ToList();
            cboEditTeam2.DataSource = db.Teams.ToList();
            var selectedMatch = FindSelectedMatch();
            cboEditTeam1.SelectedItem = selectedMatch.Team1;
            cboEditTeam2.SelectedItem = selectedMatch.Team2;
            if (selectedMatch.MatchTime > DateTime.Now)
            {
                nudScore1.Enabled = false;
                nudScore2.Enabled = false;
            }
            nudScore1.Value = selectedMatch.Score1;
            nudScore2.Value = selectedMatch.Score2;
            dtpEditDate.Value = selectedMatch.MatchTime == null ? DateTime.Now : selectedMatch.MatchTime.Value;

            var color1 = selectedMatch.Team1.TeamColors.ToList();
            var color2 = selectedMatch.Team2.TeamColors.ToList();
            if (color1.Count == 0)
                return;
            else if (color1.Count == 1)
                lblHTeamC1.BackColor = System.Drawing.Color.FromArgb(color1[0].Red, color1[0].Green, color1[0].Blue);
            else if (color1.Count == 2)
            {
                lblHTeamC1.BackColor = System.Drawing.Color.FromArgb(color1[0].Red, color1[0].Green, color1[0].Blue);
                lblHTeamC2.BackColor = System.Drawing.Color.FromArgb(color1[1].Red, color1[1].Green, color1[1].Blue);
            }
            if (color2.Count == 0)
                return;
            else if (color2.Count == 1)
                lblATeamC1.BackColor = System.Drawing.Color.FromArgb(color2[0].Red, color2[0].Green, color2[0].Blue);
            else if (color2.Count == 2)
            {
                lblATeamC1.BackColor = System.Drawing.Color.FromArgb(color2[0].Red, color2[0].Green, color2[0].Blue);
                lblATeamC2.BackColor = System.Drawing.Color.FromArgb(color2[1].Red, color2[1].Green, color2[1].Blue);
            }

        }

        private Match FindSelectedMatch()
        {
            var matches = MatchListCreate();
            Match selectedMatch = matches.Find(x =>
                            x.Id + " - " + x.Team1.TeamName + "-" + x.Team2.TeamName + " || "
                            + x.MatchTime?.ToShortDateString() == (string)cboMatches.SelectedItem);
            return selectedMatch;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboMatches.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the match you want to edit.");
                return;
            }
            if ((Team)cboEditTeam1.SelectedItem == (Team)cboEditTeam2.SelectedItem)
            {
                MessageBox.Show("Please select team correctly!");
                return;
            }
            var selectedMatch = FindSelectedMatch();
            selectedMatch.Team1 = (Team)cboEditTeam1.SelectedItem;
            selectedMatch.Team2 = (Team)cboEditTeam2.SelectedItem;
            selectedMatch.MatchTime = dtpEditDate.Value;

            selectedMatch.Score1 = (int)nudScore1.Value;
            selectedMatch.Score2 = (int)nudScore2.Value;
            db.SaveChanges();
            WhenMakeChange(EventArgs.Empty);
            MessageBox.Show("All changes has been saved.");
            if (selectedIdMainForm > 0)
                Close();

            ListTeamsEditMatch();
        }

    }
}