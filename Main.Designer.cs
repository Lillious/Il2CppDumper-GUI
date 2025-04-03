namespace Il2CppDumper_GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            dump = new Button();
            SelectGameFolder = new Button();
            SelectGameLabel = new Label();
            GameDirectoryBrowser = new FolderBrowserDialog();
            OpenDllBrowser = new OpenFileDialog();
            OpenMetaDataBrowser = new OpenFileDialog();
            LogOutputTextBox = new RichTextBox();
            OpenLogsFolder = new Button();
            AutoOpenOutput = new CheckBox();
            OpenOutput = new Button();
            TopBar = new Panel();
            label1 = new Label();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            GameDirText = new Button();
            VerboseCheckbox = new CheckBox();
            panel1 = new Panel();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dump
            // 
            dump.BackColor = Color.Transparent;
            dump.CausesValidation = false;
            dump.Cursor = Cursors.Hand;
            dump.FlatAppearance.BorderColor = Color.FromArgb(68, 147, 248);
            dump.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 27, 35);
            dump.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 27, 35);
            dump.FlatStyle = FlatStyle.Flat;
            dump.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dump.ForeColor = Color.FromArgb(68, 147, 248);
            dump.Location = new Point(384, 384);
            dump.Name = "dump";
            dump.Size = new Size(75, 32);
            dump.TabIndex = 7;
            dump.Text = "Dump";
            dump.UseVisualStyleBackColor = false;
            dump.Click += dump_Click;
            // 
            // SelectGameFolder
            // 
            SelectGameFolder.BackColor = Color.Transparent;
            SelectGameFolder.Cursor = Cursors.Hand;
            SelectGameFolder.FlatAppearance.BorderColor = Color.FromArgb(68, 147, 248);
            SelectGameFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 27, 35);
            SelectGameFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 27, 35);
            SelectGameFolder.FlatStyle = FlatStyle.Flat;
            SelectGameFolder.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectGameFolder.ForeColor = Color.FromArgb(68, 147, 248);
            SelectGameFolder.Location = new Point(12, 78);
            SelectGameFolder.Name = "SelectGameFolder";
            SelectGameFolder.Size = new Size(75, 32);
            SelectGameFolder.TabIndex = 8;
            SelectGameFolder.TabStop = false;
            SelectGameFolder.Text = "Select";
            SelectGameFolder.UseVisualStyleBackColor = false;
            SelectGameFolder.Click += SelectGameFolder_Click;
            // 
            // SelectGameLabel
            // 
            SelectGameLabel.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectGameLabel.Location = new Point(4, 31);
            SelectGameLabel.Name = "SelectGameLabel";
            SelectGameLabel.Size = new Size(145, 44);
            SelectGameLabel.TabIndex = 9;
            SelectGameLabel.Text = "Game Directory";
            SelectGameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameDirectoryBrowser
            // 
            GameDirectoryBrowser.RootFolder = Environment.SpecialFolder.Recent;
            GameDirectoryBrowser.ShowNewFolderButton = false;
            GameDirectoryBrowser.ShowPinnedPlaces = false;
            GameDirectoryBrowser.HelpRequest += GameDirectoryBrowser_HelpRequest;
            // 
            // OpenDllBrowser
            // 
            OpenDllBrowser.FileName = "OpenDllBrowser";
            OpenDllBrowser.FileOk += OpenDllBrowser_FileOk;
            // 
            // OpenMetaDataBrowser
            // 
            OpenMetaDataBrowser.FileName = "OpenMetaDataBrowser";
            OpenMetaDataBrowser.FileOk += OpenMetaDataBrowser_FileOk;
            // 
            // LogOutputTextBox
            // 
            LogOutputTextBox.BackColor = Color.FromArgb(13, 17, 23);
            LogOutputTextBox.BorderStyle = BorderStyle.None;
            LogOutputTextBox.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutputTextBox.ForeColor = Color.FromArgb(145, 152, 161);
            LogOutputTextBox.Location = new Point(15, 132);
            LogOutputTextBox.Name = "LogOutputTextBox";
            LogOutputTextBox.ReadOnly = true;
            LogOutputTextBox.ScrollBars = RichTextBoxScrollBars.None;
            LogOutputTextBox.Size = new Size(443, 214);
            LogOutputTextBox.TabIndex = 11;
            LogOutputTextBox.Text = "";
            // 
            // OpenLogsFolder
            // 
            OpenLogsFolder.AutoSize = true;
            OpenLogsFolder.BackColor = Color.Transparent;
            OpenLogsFolder.Cursor = Cursors.Hand;
            OpenLogsFolder.Enabled = false;
            OpenLogsFolder.FlatAppearance.BorderColor = Color.FromArgb(68, 147, 248);
            OpenLogsFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 27, 35);
            OpenLogsFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 27, 35);
            OpenLogsFolder.FlatStyle = FlatStyle.Flat;
            OpenLogsFolder.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenLogsFolder.ForeColor = Color.FromArgb(68, 147, 248);
            OpenLogsFolder.Location = new Point(12, 384);
            OpenLogsFolder.Name = "OpenLogsFolder";
            OpenLogsFolder.Size = new Size(103, 32);
            OpenLogsFolder.TabIndex = 13;
            OpenLogsFolder.Text = "View Logs";
            OpenLogsFolder.UseVisualStyleBackColor = false;
            OpenLogsFolder.Click += OpenLogsFolder_Click;
            // 
            // AutoOpenOutput
            // 
            AutoOpenOutput.BackColor = Color.FromArgb(13, 17, 23);
            AutoOpenOutput.Checked = true;
            AutoOpenOutput.CheckState = CheckState.Checked;
            AutoOpenOutput.Cursor = Cursors.Hand;
            AutoOpenOutput.FlatAppearance.CheckedBackColor = Color.FromArgb(68, 147, 248);
            AutoOpenOutput.FlatStyle = FlatStyle.Flat;
            AutoOpenOutput.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoOpenOutput.Location = new Point(283, 354);
            AutoOpenOutput.Name = "AutoOpenOutput";
            AutoOpenOutput.RightToLeft = RightToLeft.Yes;
            AutoOpenOutput.Size = new Size(176, 24);
            AutoOpenOutput.TabIndex = 14;
            AutoOpenOutput.Text = "Open when finished";
            AutoOpenOutput.UseVisualStyleBackColor = false;
            // 
            // OpenOutput
            // 
            OpenOutput.BackColor = Color.Transparent;
            OpenOutput.Cursor = Cursors.Hand;
            OpenOutput.Enabled = false;
            OpenOutput.FlatAppearance.BorderColor = Color.FromArgb(68, 147, 248);
            OpenOutput.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 27, 35);
            OpenOutput.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 27, 35);
            OpenOutput.FlatStyle = FlatStyle.Flat;
            OpenOutput.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenOutput.ForeColor = Color.FromArgb(68, 147, 248);
            OpenOutput.Location = new Point(297, 384);
            OpenOutput.Name = "OpenOutput";
            OpenOutput.Size = new Size(75, 32);
            OpenOutput.TabIndex = 15;
            OpenOutput.Text = "Open";
            OpenOutput.UseVisualStyleBackColor = false;
            OpenOutput.Click += OpenOutput_Click;
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.FromArgb(1, 4, 9);
            TopBar.BorderStyle = BorderStyle.FixedSingle;
            TopBar.Controls.Add(label1);
            TopBar.Controls.Add(MinimizeButton);
            TopBar.Controls.Add(CloseButton);
            TopBar.Cursor = Cursors.SizeAll;
            TopBar.Location = new Point(0, 1);
            TopBar.Margin = new Padding(0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(473, 31);
            TopBar.TabIndex = 16;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 19;
            label1.Text = "Il2CppDumper";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
            MinimizeButton.Location = new Point(409, -1);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(32, 32);
            MinimizeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeButton.TabIndex = 18;
            MinimizeButton.TabStop = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(440, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 32);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseButton.TabIndex = 17;
            CloseButton.TabStop = false;
            CloseButton.Click += pictureBox1_Click;
            // 
            // GameDirText
            // 
            GameDirText.FlatAppearance.BorderColor = Color.FromArgb(68, 147, 248);
            GameDirText.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GameDirText.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GameDirText.FlatStyle = FlatStyle.Flat;
            GameDirText.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameDirText.ForeColor = Color.FromArgb(68, 147, 248);
            GameDirText.Location = new Point(103, 78);
            GameDirText.Name = "GameDirText";
            GameDirText.Size = new Size(358, 32);
            GameDirText.TabIndex = 17;
            GameDirText.TextAlign = ContentAlignment.MiddleLeft;
            GameDirText.UseVisualStyleBackColor = true;
            GameDirText.Click += GameDirText_Click;
            // 
            // VerboseCheckbox
            // 
            VerboseCheckbox.BackColor = Color.FromArgb(13, 17, 23);
            VerboseCheckbox.Cursor = Cursors.Hand;
            VerboseCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(68, 147, 248);
            VerboseCheckbox.FlatStyle = FlatStyle.Flat;
            VerboseCheckbox.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VerboseCheckbox.Location = new Point(12, 354);
            VerboseCheckbox.Name = "VerboseCheckbox";
            VerboseCheckbox.Size = new Size(103, 24);
            VerboseCheckbox.TabIndex = 18;
            VerboseCheckbox.Text = "Verbose";
            VerboseCheckbox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LogOutputTextBox);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 431);
            panel1.TabIndex = 19;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(473, 432);
            Controls.Add(VerboseCheckbox);
            Controls.Add(GameDirText);
            Controls.Add(TopBar);
            Controls.Add(OpenOutput);
            Controls.Add(AutoOpenOutput);
            Controls.Add(OpenLogsFolder);
            Controls.Add(SelectGameLabel);
            Controls.Add(SelectGameFolder);
            Controls.Add(dump);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(240, 246, 252);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Main";
            Text = "Il2CppDumper";
            Load += Form1_Load;
            TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button dump;
        private Button SelectGameFolder;
        private Label SelectGameLabel;
        private FolderBrowserDialog GameDirectoryBrowser;
        private OpenFileDialog OpenDllBrowser;
        private OpenFileDialog OpenMetaDataBrowser;
        private RichTextBox LogOutputTextBox;
        private Button OpenLogsFolder;
        private CheckBox AutoOpenOutput;
        private Button OpenOutput;
        private Panel TopBar;
        private PictureBox CloseButton;
        private PictureBox MinimizeButton;
        private Label label1;
        private Button GameDirText;
        private CheckBox VerboseCheckbox;
        private Panel panel1;
    }
}
