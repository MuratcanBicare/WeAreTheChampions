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
    public partial class PlayersForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        private int teamId;
        public PlayersForm(WeAreTheChampionsContext db, int teamId)
        {
            this.db = db;
            this.teamId = teamId;
            InitializeComponent();
            ListPlayersTeam();
            ListTeams();
        }

        private void ListPlayersTeam()
        {
            var teams = db.Teams.ToList()
                .Where(x => !x.TeamName.Contains("Closed"))
                .ToList();
            teams.Insert(0, new Team { TeamName = "Select Team" });
            teams.Insert(1, new Team { TeamName = "Free Agency" });
            cboPlayersTeam.DataSource = teams;
        }

        private void ListTeams()
        {
            var teams = db.Teams.ToList()
                .Where(x=> !x.TeamName.Contains("Closed"))
                .ToList();
            teams.Insert(0, new Team { TeamName = "All" });
            teams.Insert(1, new Team { TeamName = "Free Agency" });
            cboTeams.DataSource = teams;
        }

        private void ListPlayers()
        {
            if (teamId != 0)
            {
                var team = db.Teams.ToList().Find(x=> x.Id == teamId);
                cboTeams.SelectedItem = team;
                teamId = 0;
            }
            var selectedTeam = (Team)cboTeams.SelectedItem;
            var selectedTeamId = selectedTeam.Id;
            if (cboTeams.SelectedIndex == 0)
                lstPlayers.DataSource = db.Players.ToList();
            else if (cboTeams.SelectedIndex == 1)
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == null);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
            else
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == selectedTeamId);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListPlayers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim().UpperCaseFirst();

            if (cboPlayersTeam.SelectedIndex == 0 || playerName == "")
            {
                MessageBox.Show("You have to choose team.");
                return;
            }
            if (btnAdd.Text == "💾 Save")
            {
                var selectedPlayer = (Player)lstPlayers.SelectedItem;
                selectedPlayer.PlayerName = playerName;
                var teamEdit = (Team)cboPlayersTeam.SelectedItem;
                selectedPlayer.Team = cboPlayersTeam.SelectedIndex == 1 ? null : teamEdit;
                db.SaveChanges();
                ListPlayers();
                ResetForm();
                //WhenMakeChange(EventArgs.Empty);
                return;
            }
           

            var team = (Team)cboPlayersTeam.SelectedItem;
            db.Players.Add(new Player()
            {
                PlayerName = playerName,
                Team = cboPlayersTeam.SelectedIndex == 1 ? null : team
            });
            db.SaveChanges();
            ListPlayers();
            ResetForm();
        }

        private void ResetForm()
        {
            lstPlayers.Enabled = true;
            btnAdd.Text = "Add ➕";
            txtPlayerName.Clear();
            cboPlayersTeam.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
                return;
            var selectedPlayer = (Player)lstPlayers.SelectedItem;
            db.Players.Remove(selectedPlayer);
            db.SaveChanges();
            ListPlayers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Edit Mode Activated
            if (lstPlayers.SelectedIndex < 0)
                return;

            lstPlayers.Enabled = false;
            var selectedPlayer = (Player)lstPlayers.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtPlayerName.Text = selectedPlayer.PlayerName;
            cboPlayersTeam.SelectedItem = selectedPlayer.Team;
        }
    }
}
