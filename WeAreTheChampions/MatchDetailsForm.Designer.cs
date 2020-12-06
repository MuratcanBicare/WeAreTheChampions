
namespace WeAreTheChampions
{
    partial class MatchDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNewTeam1 = new System.Windows.Forms.ComboBox();
            this.cboNewTeam2 = new System.Windows.Forms.ComboBox();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMatches = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEditTeam1 = new System.Windows.Forms.ComboBox();
            this.cboEditTeam2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHTeamC1 = new System.Windows.Forms.Label();
            this.lblHTeamC2 = new System.Windows.Forms.Label();
            this.lblATeamC2 = new System.Windows.Forms.Label();
            this.lblATeamC1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "MMMMdd.yyyy | hh:mm";
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(536, 66);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(154, 20);
            this.dtpNewDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Away Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Match Date";
            // 
            // cboNewTeam1
            // 
            this.cboNewTeam1.DisplayMember = "TeamName";
            this.cboNewTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam1.FormattingEnabled = true;
            this.cboNewTeam1.Location = new System.Drawing.Point(17, 65);
            this.cboNewTeam1.Name = "cboNewTeam1";
            this.cboNewTeam1.Size = new System.Drawing.Size(230, 21);
            this.cboNewTeam1.TabIndex = 5;
            // 
            // cboNewTeam2
            // 
            this.cboNewTeam2.DisplayMember = "TeamName";
            this.cboNewTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam2.FormattingEnabled = true;
            this.cboNewTeam2.Location = new System.Drawing.Point(286, 66);
            this.cboNewTeam2.Name = "cboNewTeam2";
            this.cboNewTeam2.Size = new System.Drawing.Size(223, 21);
            this.cboNewTeam2.TabIndex = 6;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(716, 60);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(45, 34);
            this.btnAddMatch.TabIndex = 7;
            this.btnAddMatch.Text = "➕";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edit Match";
            // 
            // cboMatches
            // 
            this.cboMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatches.FormattingEnabled = true;
            this.cboMatches.Location = new System.Drawing.Point(17, 200);
            this.cboMatches.Name = "cboMatches";
            this.cboMatches.Size = new System.Drawing.Size(744, 21);
            this.cboMatches.TabIndex = 9;
            this.cboMatches.SelectedIndexChanged += new System.EventHandler(this.cboMatches_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Match";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Match Date";
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.CustomFormat = "MMMMdd.yyyy | hh:mm";
            this.dtpEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDate.Location = new System.Drawing.Point(286, 269);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(154, 20);
            this.dtpEditDate.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Home Team";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Away Team";
            // 
            // cboEditTeam1
            // 
            this.cboEditTeam1.DisplayMember = "TeamName";
            this.cboEditTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam1.FormattingEnabled = true;
            this.cboEditTeam1.Location = new System.Drawing.Point(20, 383);
            this.cboEditTeam1.Name = "cboEditTeam1";
            this.cboEditTeam1.Size = new System.Drawing.Size(230, 21);
            this.cboEditTeam1.TabIndex = 15;
            // 
            // cboEditTeam2
            // 
            this.cboEditTeam2.DisplayMember = "TeamName";
            this.cboEditTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam2.FormattingEnabled = true;
            this.cboEditTeam2.Location = new System.Drawing.Point(489, 383);
            this.cboEditTeam2.Name = "cboEditTeam2";
            this.cboEditTeam2.Size = new System.Drawing.Size(223, 21);
            this.cboEditTeam2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Score";
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(286, 383);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(33, 20);
            this.nudScore1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "➖";
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(407, 384);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(33, 20);
            this.nudScore2.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(741, 45);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHTeamC1
            // 
            this.lblHTeamC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHTeamC1.Location = new System.Drawing.Point(20, 301);
            this.lblHTeamC1.Name = "lblHTeamC1";
            this.lblHTeamC1.Size = new System.Drawing.Size(36, 36);
            this.lblHTeamC1.TabIndex = 22;
            // 
            // lblHTeamC2
            // 
            this.lblHTeamC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHTeamC2.Location = new System.Drawing.Point(62, 301);
            this.lblHTeamC2.Name = "lblHTeamC2";
            this.lblHTeamC2.Size = new System.Drawing.Size(36, 36);
            this.lblHTeamC2.TabIndex = 23;
            // 
            // lblATeamC2
            // 
            this.lblATeamC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblATeamC2.Location = new System.Drawing.Point(531, 301);
            this.lblATeamC2.Name = "lblATeamC2";
            this.lblATeamC2.Size = new System.Drawing.Size(36, 36);
            this.lblATeamC2.TabIndex = 25;
            // 
            // lblATeamC1
            // 
            this.lblATeamC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblATeamC1.Location = new System.Drawing.Point(489, 301);
            this.lblATeamC1.Name = "lblATeamC1";
            this.lblATeamC1.Size = new System.Drawing.Size(36, 36);
            this.lblATeamC1.TabIndex = 24;
            // 
            // MatchDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.lblATeamC2);
            this.Controls.Add(this.lblATeamC1);
            this.Controls.Add(this.lblHTeamC2);
            this.Controls.Add(this.lblHTeamC1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudScore2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudScore1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboEditTeam2);
            this.Controls.Add(this.cboEditTeam1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEditDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMatches);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.cboNewTeam2);
            this.Controls.Add(this.cboNewTeam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNewDate);
            this.Name = "MatchDetailsForm";
            this.Text = "MatchDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNewTeam1;
        private System.Windows.Forms.ComboBox cboNewTeam2;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMatches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEditTeam1;
        private System.Windows.Forms.ComboBox cboEditTeam2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHTeamC1;
        private System.Windows.Forms.Label lblHTeamC2;
        private System.Windows.Forms.Label lblATeamC2;
        private System.Windows.Forms.Label lblATeamC1;
    }
}