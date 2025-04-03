using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Il2CppDumper_GUI
{
    public partial class Main : Form
    {
        // Import necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private string AssemblyPath { get; set; } = "";
        private string MetadataPath { get; set; } = "";
        private readonly string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "output");
        private readonly string dumpedDir = Path.Combine(Directory.GetCurrentDirectory(), "dumped");
        private readonly string logsDir = Path.Combine(Directory.GetCurrentDirectory(), "logs");
        private string DataDir { get; set; } = "";

        public Main()
        {
            InitializeComponent();
            TopBar.MouseDown += TopBar_MouseDown;
            CloseButton.MouseHover += pictureBox1_MouseHover;
            CloseButton.MouseLeave += pictureBox1_MouseLeave;
        }


        private void TopBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if output folder exists
            if (Directory.Exists(outputDir))
            {
                OpenOutput.Enabled = true;
            }

            // Check if the logs folder exists
            if (Directory.Exists(logsDir))
            {
                OpenLogsFolder.Enabled = true;
            }
        }

        private void SelectGameFolder_Click(object sender, EventArgs e)
        {
            // Open the folder browser dialog
            if (GameDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {

                // Find the first folder that ends with "_Data" in the selected directory
                // This is the data directory
                string[] dirs = Directory.GetDirectories(GameDirectoryBrowser.SelectedPath);
                foreach (string dir in dirs)
                {
                    if (dir.EndsWith("_Data"))
                    {
                        DataDir = dir;
                        break;
                    }
                }

                if (String.IsNullOrEmpty(DataDir))
                {
                    string message = "Invalid or unsupported game directory. Please select a valid game directory.";
                    MessageBox.Show(message, "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AssemblyPath = Path.Combine(GameDirectoryBrowser.SelectedPath, "GameAssembly.dll");
                if (!File.Exists(AssemblyPath))
                {
                    string message = $"GameAssembly.dll could not be automatically detected in {GameDirectoryBrowser.SelectedPath}. Please select the DLL file manually.";
                    MessageBox.Show(message, "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenDllBrowser.InitialDirectory = GameDirectoryBrowser.SelectedPath;
                    OpenDllBrowser.Filter = "DLL files (*.dll)|*.dll";
                    OpenDllBrowser.ShowDialog();
                }

                MetadataPath = Path.Combine(DataDir, "il2cpp_data", "Metadata", "global-metadata.dat");
                if (!File.Exists(MetadataPath))
                {
                    string message = $"global-metadata.dat could not be automatically detected in {GameDirectoryBrowser.SelectedPath}. Please select the metadata file manually.";
                    MessageBox.Show(message, "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenMetaDataBrowser.InitialDirectory = GameDirectoryBrowser.SelectedPath;
                    OpenMetaDataBrowser.Filter = "Metadata files (*.dat)|*.dat";
                    OpenMetaDataBrowser.ShowDialog();
                }

                GameDirText.Text = GameDirectoryBrowser.SelectedPath;
            }
        }

        // Manually specify the path to the DLL
        private void OpenDllBrowser_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (OpenDllBrowser.ShowDialog() == DialogResult.OK)
            {
                AssemblyPath = OpenDllBrowser.FileName;
            }
        }

        // Manually specify the path to the metadata file
        private void OpenMetaDataBrowser_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (OpenMetaDataBrowser.ShowDialog() == DialogResult.OK)
            {
                MetadataPath = OpenMetaDataBrowser.FileName;
            }
        }

        private void GameDirectoryBrowser_HelpRequest(object sender, EventArgs e)
        {

        }

        private async void dump_Click(object sender, EventArgs e)
        {
            dump.Enabled = false;
            LogOutputTextBox.Text = "";

            // Clear dumped directory
            if (Directory.Exists(dumpedDir))
            {
                Directory.Delete(dumpedDir, true);
            }

            // Check for required paths
            if (string.IsNullOrEmpty(MetadataPath) || string.IsNullOrEmpty(AssemblyPath))
            {
                dump.Enabled = true;
                MessageBox.Show("Please select the game directory, GameAssembly.dll, and global-metadata.dat file.",
                                "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dumperPath = Path.Combine(Directory.GetCurrentDirectory(), "binaries",
                                Environment.Is64BitOperatingSystem ? "Il2CppDumper.exe" : "Il2CppDumper-x86.exe");

            if (!File.Exists(dumperPath))
            {
                dump.Enabled = true;
                MessageBox.Show("Il2CppDumper not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for config.json
            string configPath = Path.Combine(Directory.GetCurrentDirectory(), "binaries", "config.json");
            if (!File.Exists(configPath))
            {
                dump.Enabled = true;
                MessageBox.Show("config.json not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create dump output directory if it doesn't exist
            Directory.CreateDirectory(dumpedDir);

            string dumpArguments = $"\"{AssemblyPath}\" \"{MetadataPath}\" \"{dumpedDir}\"";

            ProcessStartInfo startInfo = new()
            {
                FileName = dumperPath,
                Arguments = dumpArguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = new() { StartInfo = startInfo };
            process.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    LogOutputTextBox.Invoke((MethodInvoker)(() =>
                    {
                        LogOutputTextBox.AppendText(e.Data + Environment.NewLine);
                        LogOutputTextBox.SelectionStart = LogOutputTextBox.Text.Length;
                        LogOutputTextBox.ScrollToCaret(); // Ensure scrolling happens
                    }));
                }
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    LogOutputTextBox.Invoke((MethodInvoker)(() =>
                    {
                        LogOutputTextBox.AppendText("[ERROR] " + e.Data + Environment.NewLine);
                        LogOutputTextBox.SelectionStart = LogOutputTextBox.Text.Length;
                        LogOutputTextBox.ScrollToCaret(); // Ensure scrolling happens
                    }));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync(); // Asynchronous waiting to prevent UI freezing

            // Create logs folder if it doesn't exist
            Directory.CreateDirectory(logsDir);

            // Write output to a log file
            string logPath = Path.Combine(logsDir, $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.log");

            await File.WriteAllTextAsync(logPath, LogOutputTextBox.Text);

            // Unhollow the dumped DLLs

            // Create output directory if it doesn't exist
            Directory.CreateDirectory(outputDir);
            string dummyDllDir = Path.Combine(dumpedDir, "DummyDll");
            string msCoreLibPath = Path.Combine(dummyDllDir, "mscorlib.dll");

            // Check if dummy DLL directory exists
            if (!Directory.Exists(dummyDllDir))
            {
                dump.Enabled = true;
                MessageBox.Show("DummyDll directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if mscorlib.dll exists
            if (!File.Exists(msCoreLibPath))
            {
                dump.Enabled = true;
                MessageBox.Show("mscorlib.dll not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the last directory of the DataDir
            string gameDir = $"{DataDir.Split(Path.DirectorySeparatorChar).Last().Replace("_Data", "")}_Unhollowed";
            string UnhollowerOutputDir = Path.Combine(outputDir, gameDir);
            // Delete the output directory if it exists
            if (Directory.Exists(UnhollowerOutputDir))
            {
                Directory.Delete(UnhollowerOutputDir, true);
            }

            // Create the output directory
            Directory.CreateDirectory(UnhollowerOutputDir);

            string UnhollowerArguments = $"--input=\"{dummyDllDir}\" --output=\"{UnhollowerOutputDir}\" --mscorlib=\"{msCoreLibPath}\"";
            if (VerboseCheckbox.Checked)
            {
                UnhollowerArguments += " --verbose";
            }
            // Check if Unhollower exists
            if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "binaries", "AssemblyUnhollower.exe")))
            {
                dump.Enabled = true;
                MessageBox.Show("AssemblyUnhollower not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo UnhollowerStartInfo = new()
            {
                FileName = Path.Combine(Directory.GetCurrentDirectory(), "binaries", "AssemblyUnhollower.exe"),
                Arguments = UnhollowerArguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process UnhollowerProcess = new() { StartInfo = UnhollowerStartInfo };
            UnhollowerProcess.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    LogOutputTextBox.Invoke((MethodInvoker)(() =>
                    {
                        LogOutputTextBox.AppendText(e.Data + Environment.NewLine);
                        LogOutputTextBox.SelectionStart = LogOutputTextBox.Text.Length;
                        LogOutputTextBox.ScrollToCaret(); // Ensure scrolling happens
                    }));
                }
            };

            UnhollowerProcess.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    LogOutputTextBox.Invoke((MethodInvoker)(() =>
                    {
                        LogOutputTextBox.AppendText("[ERROR] " + e.Data + Environment.NewLine);
                        LogOutputTextBox.SelectionStart = LogOutputTextBox.Text.Length;
                        LogOutputTextBox.ScrollToCaret(); // Ensure scrolling happens
                    }));
                }
            };

            UnhollowerProcess.Start();
            UnhollowerProcess.BeginOutputReadLine();
            UnhollowerProcess.BeginErrorReadLine();

            await UnhollowerProcess.WaitForExitAsync(); // Asynchronous waiting to prevent UI freezing

            await File.WriteAllTextAsync(logPath, LogOutputTextBox.Text);

            OpenOutput.Enabled = true;
            dump.Enabled = true;
            OpenLogsFolder.Enabled = true;

            if (AutoOpenOutput.Checked)
            {
                if (Directory.Exists(outputDir))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = "explorer.exe",
                        Arguments = $"\"{UnhollowerOutputDir}\"",
                        UseShellExecute = true
                    });
                }
            }
        }
        private void OpenLogsFolder_Click(object sender, EventArgs e)
        {
            // Open the logs folder if it exists
            if (Directory.Exists(logsDir))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments = $"\"{logsDir}\"",
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No logs found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenOutput_Click(object sender, EventArgs e)
        {
            //  Open the output folder if it exists
            if (Directory.Exists(outputDir))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments = $"\"{outputDir}\"",
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No output found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameDirText_Click(object sender, EventArgs e)
        {

        }
    }
}
