namespace DarknetHaxor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            checkAimBot = new CheckBox();
            checkESPLines = new CheckBox();
            checkEspName = new CheckBox();
            trackAimBotDistance = new TrackBar();
            lblDistance = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackAimBotDistance).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 387);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            lblStatus.UseWaitCursor = true;
            // 
            // checkAimBot
            // 
            checkAimBot.AutoSize = true;
            checkAimBot.Location = new Point(40, 23);
            checkAimBot.Name = "checkAimBot";
            checkAimBot.Size = new Size(104, 19);
            checkAimBot.TabIndex = 5;
            checkAimBot.Text = "Enable Aimbot";
            checkAimBot.UseVisualStyleBackColor = true;
            checkAimBot.CheckedChanged += checkAimBot_CheckedChanged;
            // 
            // checkESPLines
            // 
            checkESPLines.AutoSize = true;
            checkESPLines.Location = new Point(40, 113);
            checkESPLines.Name = "checkESPLines";
            checkESPLines.Size = new Size(70, 19);
            checkESPLines.TabIndex = 6;
            checkESPLines.Text = "ESP Line";
            checkESPLines.UseVisualStyleBackColor = true;
            checkESPLines.CheckedChanged += checkESPLines_CheckedChanged;
            // 
            // checkEspName
            // 
            checkEspName.AutoSize = true;
            checkEspName.Location = new Point(40, 138);
            checkEspName.Name = "checkEspName";
            checkEspName.Size = new Size(68, 19);
            checkEspName.TabIndex = 9;
            checkEspName.Text = "ESP Box";
            checkEspName.UseVisualStyleBackColor = true;
            checkEspName.CheckedChanged += checkEspBox_CheckedChanged;
            // 
            // trackAimBotDistance
            // 
            trackAimBotDistance.Location = new Point(41, 72);
            trackAimBotDistance.Maximum = 2000;
            trackAimBotDistance.Name = "trackAimBotDistance";
            trackAimBotDistance.Size = new Size(174, 45);
            trackAimBotDistance.TabIndex = 18;
            trackAimBotDistance.TickStyle = TickStyle.None;
            trackAimBotDistance.Value = 50;
            trackAimBotDistance.Scroll += trackAimBotDistance_Scroll;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(41, 54);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(65, 15);
            lblDistance.TabIndex = 19;
            lblDistance.Text = "Fov Range:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 163);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "ESP Name";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkEspName_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(324, 411);
            Controls.Add(checkBox1);
            Controls.Add(lblDistance);
            Controls.Add(trackAimBotDistance);
            Controls.Add(checkEspName);
            Controls.Add(checkESPLines);
            Controls.Add(checkAimBot);
            Controls.Add(lblStatus);
            ForeColor = SystemColors.ControlLight;
            MaximizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Darknet Haxor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackAimBotDistance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private CheckBox checkAimBot;
        private CheckBox checkESPLines;
        private CheckBox checkEspName;
        private TrackBar trackAimBotDistance;
        private Label lblDistance;
        private CheckBox checkBox1;
    }
}
