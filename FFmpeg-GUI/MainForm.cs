namespace FFmpeg_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Dictionary<string, IMedia<string>> mediaExtentions = new Dictionary<string, IMedia<string>>();
        string command;
        IMedia<string> outputType;
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadExtentions();
            DisableControls();
        }

        private void DisableControls()
        {
            grpCommand.Enabled = false;
            grpVideo.Enabled = false;
            grpDisplay.Enabled = false;
            grpAudio.Enabled = false;
        }

        private void LoadExtentions()
        {
            List<IMedia<string>> mediaTypes = new List<IMedia<string>>
            {
                Video.Instance,
                Audio.Instance,
                Display.Instance
            };

            foreach (IMedia<string> mediaType in mediaTypes)
            {
                List<string> exts = mediaType.Extentions;

                foreach (string ext in exts)
                {
                    mediaExtentions.Add(ext, mediaType);
                }
            }

            foreach (string extention in mediaExtentions.Keys)
            {
                ddlOutputFormat.Items.Add(extention);
            }
        }
        // File Input/Output
        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName == "")
                return;

            string file = ofd.FileName;

            txtInput.Text = file;
            CommandBuilder.Instance.InputName = file;
            string ext = Path.GetExtension(file).ToUpper().Replace(".", "");

            if (mediaExtentions.ContainsKey(ext))
            {
                outputType = mediaExtentions[ext];
                grpCommand.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select compatible file format.");
                DisableControls();
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName == "")
                return;

            string file = ofd.FileName;

            txtOutput.Text = file;
            CommandBuilder.Instance.OutputName = file;

            string ext = Path.GetExtension(file).ToUpper().Replace(".", "");
        }

        private void ddlOutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string outputFormat = ddlOutputFormat.SelectedItem.ToString();

            if (outputFormat != null)
            {
                switch (mediaExtentions[outputFormat])
                {
                    case Video:
                        grpVideo.Enabled = true;
                        grpDisplay.Enabled = true;
                        grpAudio.Enabled = true;
                        outputType = Video.Instance;
                        break;
                    case Audio:
                        grpVideo.Enabled = false;
                        grpDisplay.Enabled = false;
                        grpAudio.Enabled = true;
                        outputType = Audio.Instance;
                        break;
                    case Display:
                        grpVideo.Enabled = false;
                        grpDisplay.Enabled = true;
                        grpAudio.Enabled = false;
                        outputType = Display.Instance;
                        break;
                    default:
                        grpVideo.Enabled = false;
                        grpDisplay.Enabled = false;
                        grpAudio.Enabled = false;
                        outputType = null;
                        break;
                }
            }
        }

        // Video Settings
        private void txtVideoStart_TextChanged(object sender, EventArgs e)
        {
            Video.Instance.StartTime = txtVideoStart.Text;
        }
        private void txtVideoEnd_TextChanged(object sender, EventArgs e)
        {
            Video.Instance.EndTime = txtVideoEnd.Text;
        }
        private void ddlFPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Video.Instance.Fps = Convert.ToInt32(ddlFPS.SelectedItem);
        }

        // Display Settings
        private void ddlResolution_SelectedIndexChanged(object sender, EventArgs e)
        {

            string resolution = ddlResolution.SelectedItem.ToString();
            int width = Convert.ToInt32(resolution.Split('x')[0]);
            int height = Convert.ToInt32(resolution.Split('x')[1]);

            Display.Instance.Width = width;
            Display.Instance.Height = height;
        }

        // Audio Settings
        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVolume.Text = tbVolume.Value.ToString();
            Audio.Instance.Volume = Convert.ToDouble(tbVolume.Value);
        }

        // Command Settings
        private void btnMakeCMD_Click(object sender, EventArgs e)
        {
            command = CommandBuilder.Instance.MakeCommand(outputType, isPreview: false);
            txtCMD.Text = command;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            command = CommandBuilder.Instance.MakeCommand(outputType, isPreview: true);
            System.Diagnostics.Process.Start("CMD.exe", "/c" + command);
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            command = CommandBuilder.Instance.MakeCommand(outputType, isPreview: false);
            System.Diagnostics.Process.Start("CMD.exe", "/c" + command);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCMD.Text = "";
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCMD.Text);
        }
    }
}
