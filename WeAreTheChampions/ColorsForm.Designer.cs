
namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.hsRed = new System.Windows.Forms.HScrollBar();
            this.hsGreen = new System.Windows.Forms.HScrollBar();
            this.hsBlue = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color Name:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(102, 43);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(344, 22);
            this.txtColorName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(434, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add ➕";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete🚮";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 474);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 37);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit ✏";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstColors
            // 
            this.lstColors.DisplayMember = "ColorName";
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 16;
            this.lstColors.Location = new System.Drawing.Point(12, 254);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(408, 212);
            this.lstColors.TabIndex = 14;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // lblPreview
            // 
            this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPreview.Location = new System.Drawing.Point(431, 251);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(15, 212);
            this.lblPreview.TabIndex = 15;
            // 
            // hsRed
            // 
            this.hsRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsRed.LargeChange = 1;
            this.hsRed.Location = new System.Drawing.Point(102, 68);
            this.hsRed.Maximum = 255;
            this.hsRed.Name = "hsRed";
            this.hsRed.Size = new System.Drawing.Size(344, 17);
            this.hsRed.TabIndex = 16;
            this.hsRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsRed_Scroll);
            // 
            // hsGreen
            // 
            this.hsGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsGreen.LargeChange = 1;
            this.hsGreen.Location = new System.Drawing.Point(102, 108);
            this.hsGreen.Maximum = 255;
            this.hsGreen.Name = "hsGreen";
            this.hsGreen.Size = new System.Drawing.Size(344, 17);
            this.hsGreen.TabIndex = 17;
            this.hsGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsGreen_Scroll);
            // 
            // hsBlue
            // 
            this.hsBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsBlue.LargeChange = 1;
            this.hsBlue.Location = new System.Drawing.Point(102, 144);
            this.hsBlue.Maximum = 255;
            this.hsBlue.Name = "hsBlue";
            this.hsBlue.Size = new System.Drawing.Size(344, 17);
            this.hsBlue.TabIndex = 18;
            this.hsBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsBlue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Blue";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(12, 181);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(434, 26);
            this.lblColor.TabIndex = 22;
            // 
            // lblGreen
            // 
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(60, 108);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(32, 17);
            this.lblGreen.TabIndex = 24;
            this.lblGreen.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(60, 143);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(32, 17);
            this.lblBlue.TabIndex = 25;
            this.lblBlue.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(60, 68);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(32, 17);
            this.lblRed.TabIndex = 23;
            this.lblRed.Text = "0";
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 524);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsBlue);
            this.Controls.Add(this.hsGreen);
            this.Controls.Add(this.hsRed);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.HScrollBar hsRed;
        private System.Windows.Forms.HScrollBar hsGreen;
        private System.Windows.Forms.HScrollBar hsBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
    }
}