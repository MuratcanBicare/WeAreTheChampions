
namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnListPlayers = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colorDialogFirst = new System.Windows.Forms.ColorDialog();
            this.colorDialogSecond = new System.Windows.Forms.ColorDialog();
            this.cboFirstColor = new System.Windows.Forms.ComboBox();
            this.cboSecondColor = new System.Windows.Forms.ComboBox();
            this.lblFirstColor = new System.Windows.Forms.Label();
            this.lblSecondColor = new System.Windows.Forms.Label();
            this.lblBg = new System.Windows.Forms.Label();
            this.lblBg2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team Name:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(30, 87);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(180, 22);
            this.txtTeamName.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(368, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete🚮";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 505);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 37);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit ✏";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.BackColor = System.Drawing.Color.Gold;
            this.btnListPlayers.ForeColor = System.Drawing.Color.White;
            this.btnListPlayers.Location = new System.Drawing.Point(30, 149);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(474, 31);
            this.btnListPlayers.TabIndex = 6;
            this.btnListPlayers.Text = "List Players📜";
            this.btnListPlayers.UseVisualStyleBackColor = false;
            this.btnListPlayers.Click += new System.EventHandler(this.btnListPlayers_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 16;
            this.lstTeams.Location = new System.Drawing.Point(30, 187);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(474, 308);
            this.lstTeams.TabIndex = 9;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(474, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ➕";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // colorDialogFirst
            // 
            this.colorDialogFirst.AnyColor = true;
            this.colorDialogFirst.Color = System.Drawing.Color.DimGray;
            this.colorDialogFirst.FullOpen = true;
            this.colorDialogFirst.SolidColorOnly = true;
            // 
            // colorDialogSecond
            // 
            this.colorDialogSecond.AnyColor = true;
            this.colorDialogSecond.Color = System.Drawing.Color.DimGray;
            this.colorDialogSecond.FullOpen = true;
            this.colorDialogSecond.SolidColorOnly = true;
            // 
            // cboFirstColor
            // 
            this.cboFirstColor.DisplayMember = "ColorName";
            this.cboFirstColor.FormattingEnabled = true;
            this.cboFirstColor.Location = new System.Drawing.Point(315, 60);
            this.cboFirstColor.Name = "cboFirstColor";
            this.cboFirstColor.Size = new System.Drawing.Size(147, 24);
            this.cboFirstColor.TabIndex = 15;
            this.cboFirstColor.SelectedIndexChanged += new System.EventHandler(this.cboFirstColor_SelectedIndexChanged);
            // 
            // cboSecondColor
            // 
            this.cboSecondColor.DisplayMember = "ColorName";
            this.cboSecondColor.FormattingEnabled = true;
            this.cboSecondColor.Location = new System.Drawing.Point(315, 87);
            this.cboSecondColor.Name = "cboSecondColor";
            this.cboSecondColor.Size = new System.Drawing.Size(147, 24);
            this.cboSecondColor.TabIndex = 16;
            this.cboSecondColor.SelectedIndexChanged += new System.EventHandler(this.cboSecondColor_SelectedIndexChanged);
            // 
            // lblFirstColor
            // 
            this.lblFirstColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstColor.Location = new System.Drawing.Point(468, 60);
            this.lblFirstColor.Name = "lblFirstColor";
            this.lblFirstColor.Size = new System.Drawing.Size(35, 24);
            this.lblFirstColor.TabIndex = 17;
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondColor.Location = new System.Drawing.Point(468, 89);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(36, 24);
            this.lblSecondColor.TabIndex = 18;
            // 
            // lblBg
            // 
            this.lblBg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg.Location = new System.Drawing.Point(0, 0);
            this.lblBg.Name = "lblBg";
            this.lblBg.Size = new System.Drawing.Size(535, 17);
            this.lblBg.TabIndex = 19;
            // 
            // lblBg2
            // 
            this.lblBg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg2.Location = new System.Drawing.Point(0, 17);
            this.lblBg2.Name = "lblBg2";
            this.lblBg2.Size = new System.Drawing.Size(535, 17);
            this.lblBg2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "First Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Second Color:";
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBg2);
            this.Controls.Add(this.lblBg);
            this.Controls.Add(this.lblSecondColor);
            this.Controls.Add(this.lblFirstColor);
            this.Controls.Add(this.cboSecondColor);
            this.Controls.Add(this.cboFirstColor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnListPlayers;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColorDialog colorDialogFirst;
        private System.Windows.Forms.ColorDialog colorDialogSecond;
        private System.Windows.Forms.ComboBox cboFirstColor;
        private System.Windows.Forms.ComboBox cboSecondColor;
        private System.Windows.Forms.Label lblFirstColor;
        private System.Windows.Forms.Label lblSecondColor;
        private System.Windows.Forms.Label lblBg;
        private System.Windows.Forms.Label lblBg2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}