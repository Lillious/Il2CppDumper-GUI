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
            dump = new Button();
            SelectGameFolder = new Button();
            SelectGameLabel = new Label();
            GameDirectoryTextBox = new TextBox();
            GameDirectoryBrowser = new FolderBrowserDialog();
            OpenDllBrowser = new OpenFileDialog();
            OpenMetaDataBrowser = new OpenFileDialog();
            LogOutputTextBox = new RichTextBox();
            OpenLogsFolder = new Button();
            AutoOpenOutput = new CheckBox();
            OpenOutput = new Button();
            SuspendLayout();
            // 
            // dump
            // 
            dump.Location = new Point(364, 389);
            dump.Name = "dump";
            dump.Size = new Size(75, 23);
            dump.TabIndex = 7;
            dump.Text = "Dump";
            dump.UseVisualStyleBackColor = true;
            dump.Click += dump_Click;
            // 
            // SelectGameFolder
            // 
            SelectGameFolder.Location = new Point(12, 39);
            SelectGameFolder.Name = "SelectGameFolder";
            SelectGameFolder.Size = new Size(75, 23);
            SelectGameFolder.TabIndex = 8;
            SelectGameFolder.TabStop = false;
            SelectGameFolder.Text = "Select";
            SelectGameFolder.UseVisualStyleBackColor = true;
            SelectGameFolder.Click += SelectGameFolder_Click;
            // 
            // SelectGameLabel
            // 
            SelectGameLabel.AutoSize = true;
            SelectGameLabel.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectGameLabel.Location = new Point(10, 9);
            SelectGameLabel.Name = "SelectGameLabel";
            SelectGameLabel.Size = new Size(127, 20);
            SelectGameLabel.TabIndex = 9;
            SelectGameLabel.Text = "Game Directory";
            // 
            // GameDirectoryTextBox
            // 
            GameDirectoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            GameDirectoryTextBox.Enabled = false;
            GameDirectoryTextBox.Location = new Point(93, 39);
            GameDirectoryTextBox.Name = "GameDirectoryTextBox";
            GameDirectoryTextBox.ReadOnly = true;
            GameDirectoryTextBox.Size = new Size(346, 23);
            GameDirectoryTextBox.TabIndex = 10;
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
            LogOutputTextBox.BackColor = SystemColors.Control;
            LogOutputTextBox.BorderStyle = BorderStyle.FixedSingle;
            LogOutputTextBox.Location = new Point(12, 87);
            LogOutputTextBox.Name = "LogOutputTextBox";
            LogOutputTextBox.ReadOnly = true;
            LogOutputTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            LogOutputTextBox.Size = new Size(427, 296);
            LogOutputTextBox.TabIndex = 11;
            LogOutputTextBox.Text = "";
            // 
            // OpenLogsFolder
            // 
            OpenLogsFolder.Enabled = false;
            OpenLogsFolder.Location = new Point(12, 389);
            OpenLogsFolder.Name = "OpenLogsFolder";
            OpenLogsFolder.Size = new Size(75, 23);
            OpenLogsFolder.TabIndex = 13;
            OpenLogsFolder.Text = "View Logs";
            OpenLogsFolder.UseVisualStyleBackColor = true;
            OpenLogsFolder.Click += OpenLogsFolder_Click;
            // 
            // AutoOpenOutput
            // 
            AutoOpenOutput.AutoSize = true;
            AutoOpenOutput.Checked = true;
            AutoOpenOutput.CheckState = CheckState.Checked;
            AutoOpenOutput.FlatStyle = FlatStyle.Flat;
            AutoOpenOutput.Location = new Point(142, 392);
            AutoOpenOutput.Name = "AutoOpenOutput";
            AutoOpenOutput.Size = new Size(135, 19);
            AutoOpenOutput.TabIndex = 14;
            AutoOpenOutput.Text = "Open when finished";
            AutoOpenOutput.UseVisualStyleBackColor = true;
            // 
            // OpenOutput
            // 
            OpenOutput.Enabled = false;
            OpenOutput.Location = new Point(283, 389);
            OpenOutput.Name = "OpenOutput";
            OpenOutput.Size = new Size(75, 23);
            OpenOutput.TabIndex = 15;
            OpenOutput.Text = "Open";
            OpenOutput.UseVisualStyleBackColor = true;
            OpenOutput.Click += OpenOutput_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(451, 419);
            Controls.Add(OpenOutput);
            Controls.Add(AutoOpenOutput);
            Controls.Add(OpenLogsFolder);
            Controls.Add(LogOutputTextBox);
            Controls.Add(GameDirectoryTextBox);
            Controls.Add(SelectGameLabel);
            Controls.Add(SelectGameFolder);
            Controls.Add(dump);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "Il2CppDumper";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button dump;
        private Button SelectGameFolder;
        private Label SelectGameLabel;
        private TextBox GameDirectoryTextBox;
        private FolderBrowserDialog GameDirectoryBrowser;
        private OpenFileDialog OpenDllBrowser;
        private OpenFileDialog OpenMetaDataBrowser;
        private RichTextBox LogOutputTextBox;
        private Button OpenLogsFolder;
        private CheckBox AutoOpenOutput;
        private Button OpenOutput;
    }
}
