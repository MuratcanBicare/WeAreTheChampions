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
        }

        private void ShowTeamColor()
        {
            var team = (Team)lstTeams.SelectedItem;
            List<Model.Color> colors = team.TeamColors.ToList();
            if (colors.Count == 0)
            {
                lblBg.BackColor = lblBg2.BackColor = System.Drawing.Color.Transparent;
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

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var color1 = CreateColor(lblColorFirst);
            var color2 = CreateColor(lblColorSecond);
            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                List<Model.Color> colorEdit = new List<Model.Color>();
                colorEdit.Add(color1);
                colorEdit.Add(color2);
                selectedTeam.TeamColors = colorEdit;
                selectedTeam.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            List<Model.Color> colors = new List<Model.Color>();
            colors.Add(color1);
            colors.Add(color2);
            db.Teams.Add(new Team() { TeamName = txtTeamName.Text, TeamColors = colors });
            db.SaveChanges();
            ListTeams();
            ResetForm();
            WhenMakeChange(EventArgs.Empty);
        }

        private Model.Color CreateColor(Label lbl)
        {
            System.Drawing.Color firstLblColor = lbl.BackColor;
            byte r = firstLblColor.R;
            byte g = firstLblColor.G;
            byte b = firstLblColor.B;
            var renk = new Model.Color() { Red = r, Green = g, Blue = b };
            return renk;
        }

        private void ResetForm()
        {
            txtTeamName.Clear();
            lblColorFirst.BackColor = System.Drawing.Color.Transparent;
            lblColorSecond.BackColor = System.Drawing.Color.Transparent;
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
            List<Model.Color> colors = selectedTeam.TeamColors.ToList();
            lblColorFirst.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
            lblColorSecond.BackColor = System.Drawing.Color.FromArgb(colors[1].Red, colors[1].Green, colors[1].Blue);
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;

        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void lblColorFirst_Click(object sender, EventArgs e)
        {
            if (colorDialogFirst.ShowDialog() == DialogResult.OK)
                lblColorFirst.BackColor = colorDialogFirst.Color;

        }

        private void lblColorSecond_Click(object sender, EventArgs e)
        {
            if (colorDialogSecond.ShowDialog() == DialogResult.OK)
                lblColorSecond.BackColor = colorDialogSecond.Color;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTeamColor();
        }
    }
}
