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
    public partial class TeamsForm : Form
    {
        public event EventHandler HasBeenChanged;
        private readonly WeAreTheChampionsContext db;
        public TeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListTeams();
            ListColors();
            cboFirstColor.SelectedIndex = cboSecondColor.SelectedIndex = -1;
        }

        private void ListColors()
        {
            cboFirstColor.DataSource = db.Colors.ToList();
            cboSecondColor.DataSource = db.Colors.ToList();
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var color1 = (Model.Color)cboFirstColor.SelectedItem;
            var color2 = (Model.Color)cboSecondColor.SelectedItem;
            if (color1 == null || color2 == null)
            {
                MessageBox.Show("Have to choose two colors.");
                return;
            }
            List<Model.Color> colors = new List<Model.Color>();
            colors.Add(color1);
            colors.Add(color2);

            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                selectedTeam.TeamName = txtTeamName.Text;
                selectedTeam.TeamColors = colors;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            db.Teams.Add(new Team() { TeamName = txtTeamName.Text, TeamColors = colors });
            db.SaveChanges();
            ListTeams();
            ResetForm();
            WhenMakeChange(EventArgs.Empty);
        }



        private void ResetForm()
        {
            txtTeamName.Clear();
            lstTeams.Enabled = true;
            btnAdd.Text = "Add ➕";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstTeams.SelectedIndex < 0) return;

            var selectedTeam = (Team)lstTeams.SelectedItem;
            if (selectedTeam.TeamName.Contains("(Closed)"))
            {
                MessageBox.Show("Selected team has already been closed.");
                return;
            }
            if (selectedTeam.Players.Count != 0 || selectedTeam.Team1Matches.Count != 0 || selectedTeam.Team2Matches.Count != 0)
            {
                selectedTeam.TeamName = selectedTeam.TeamName + "(Closed)";
                if (selectedTeam.Players.Count != 0)
                {
                    var players = selectedTeam.Players.ToList();
                    players.ForEach(x => x.TeamId = null);
                }
                db.SaveChanges();
                WhenMakeChange(EventArgs.Empty);
                ListTeams();
                return;
            }
            db.Teams.Remove(selectedTeam);
            db.SaveChanges();
            WhenMakeChange(EventArgs.Empty);
            ListTeams();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0) return;
            //Edit Mode Activated
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;

        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void cboFirstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFirstColor.SelectedIndex == -1)
            {
                lblFirstColor.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Model.Color)cboFirstColor.SelectedItem;
            lblFirstColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void cboSecondColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondColor.SelectedIndex == -1)
            {
                lblSecondColor.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Model.Color)cboSecondColor.SelectedItem;
            lblSecondColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = (Team)lstTeams.SelectedItem;
            List<Model.Color> colors = team.TeamColors.ToList();
            if (colors.Count == 0 || colors == null)
            {
                lblBg.BackColor = System.Drawing.Color.Transparent;
                lblBg2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (colors.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.FromArgb(colors[1].Red, colors[1].Green, colors[1].Blue);
            }
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            var team = (Team)lstTeams.SelectedItem;
            var teamId = team.Id;
            var frmPlayersForm = new PlayersForm(db, teamId);
            frmPlayersForm.ShowDialog();
        }
    }
}
