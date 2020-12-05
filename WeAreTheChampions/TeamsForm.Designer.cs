
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblColorFirst = new System.Windows.Forms.Label();
            this.lblColorSecond = new System.Windows.Forms.Label();
            this.colorDialogFirst = new System.Windows.Forms.ColorDialog();
            this.colorDialogSecond = new System.Windows.Forms.ColorDialog();
            this.lblBg = new System.Windows.Forms.Label();
            this.lblBg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 42);
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
            this.txtTeamName.Size = new System.Drawing.Size(161, 22);
            this.txtTeamName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(261, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colors";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete🚮";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(30, 143);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(474, 37);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "List Players📜";
            this.btnList.UseVisualStyleBackColor = true;
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
            this.btnAdd.Location = new System.Drawing.Point(418, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ➕";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblColorFirst
            // 
            this.lblColorFirst.AutoSize = true;
            this.lblColorFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblColorFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorFirst.Location = new System.Drawing.Point(261, 84);
            this.lblColorFirst.Name = "lblColorFirst";
            this.lblColorFirst.Size = new System.Drawing.Size(121, 18);
            this.lblColorFirst.TabIndex = 11;
            this.lblColorFirst.Text = "☝ Choose first color";
            this.lblColorFirst.Click += new System.EventHandler(this.lblColorFirst_Click);
            // 
            // lblColorSecond
            // 
            this.lblColorSecond.AutoSize = true;
            this.lblColorSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblColorSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorSecond.Location = new System.Drawing.Point(261, 108);
            this.lblColorSecond.Name = "lblColorSecond";
            this.lblColorSecond.Size = new System.Drawing.Size(146, 18);
            this.lblColorSecond.TabIndex = 12;
            this.lblColorSecond.Text = "☝ Choose second color";
            this.lblColorSecond.Click += new System.EventHandler(this.lblColorSecond_Click);
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
            // lblBg
            // 
            this.lblBg.BackColor = System.Drawing.Color.Transparent;
            this.lblBg.Location = new System.Drawing.Point(1, 1);
            this.lblBg.Name = "lblBg";
            this.lblBg.Size = new System.Drawing.Size(534, 13);
            this.lblBg.TabIndex = 13;
            // 
            // lblBg2
            // 
            this.lblBg2.BackColor = System.Drawing.Color.Transparent;
            this.lblBg2.Location = new System.Drawing.Point(1, 14);
            this.lblBg2.Name = "lblBg2";
            this.lblBg2.Size = new System.Drawing.Size(534, 13);
            this.lblBg2.TabIndex = 14;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 554);
            this.Controls.Add(this.lblBg2);
            this.Controls.Add(this.lblBg);
            this.Controls.Add(this.lblColorSecond);
            this.Controls.Add(this.lblColorFirst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblColorFirst;
        private System.Windows.Forms.Label lblColorSecond;
        private System.Windows.Forms.ColorDialog colorDialogFirst;
        private System.Windows.Forms.ColorDialog colorDialogSecond;
        private System.Windows.Forms.Label lblBg;
        private System.Windows.Forms.Label lblBg2;
    }
}