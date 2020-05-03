namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            this.loadExistingTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(275, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tournament Dashboard";
            // 
            // loadExistingTeamMemberDropDown
            // 
            this.loadExistingTeamMemberDropDown.FormattingEnabled = true;
            this.loadExistingTeamMemberDropDown.Location = new System.Drawing.Point(259, 217);
            this.loadExistingTeamMemberDropDown.Name = "loadExistingTeamMemberDropDown";
            this.loadExistingTeamMemberDropDown.Size = new System.Drawing.Size(283, 21);
            this.loadExistingTeamMemberDropDown.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(266, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loud Existing Team Member";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(297, 244);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(226, 40);
            this.loadTournamentButton.TabIndex = 25;
            this.loadTournamentButton.Text = "Load Tournamet";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(297, 321);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(226, 77);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadExistingTeamMemberDropDown);
            this.Controls.Add(this.label1);
            this.Name = "TournamentDashBoardForm";
            this.Text = "TournamentDashBoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox loadExistingTeamMemberDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}