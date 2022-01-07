namespace FFmpeg_GUI
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
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.ddlOutputFormat = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblCMD = new System.Windows.Forms.Label();
            this.txtCMD = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ddlFPS = new System.Windows.Forms.ComboBox();
            this.lblFPS = new System.Windows.Forms.Label();
            this.ddlResolution = new System.Windows.Forms.ComboBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.ddlColorFilter = new System.Windows.Forms.ComboBox();
            this.lblColorFilter = new System.Windows.Forms.Label();
            this.grpVideo = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtVideoEnd = new System.Windows.Forms.MaskedTextBox();
            this.txtVideoStart = new System.Windows.Forms.MaskedTextBox();
            this.grpAudio = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVolumeTitle = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnMakeCMD = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grpFile.SuspendLayout();
            this.grpDisplay.SuspendLayout();
            this.grpVideo.SuspendLayout();
            this.grpAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.grpCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.lblOutputFormat);
            this.grpFile.Controls.Add(this.ddlOutputFormat);
            this.grpFile.Controls.Add(this.txtOutput);
            this.grpFile.Controls.Add(this.btnOutput);
            this.grpFile.Controls.Add(this.txtInput);
            this.grpFile.Controls.Add(this.btnInput);
            this.grpFile.Location = new System.Drawing.Point(12, 12);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(487, 123);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Input/Output";
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.Location = new System.Drawing.Point(288, 88);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(86, 15);
            this.lblOutputFormat.TabIndex = 10;
            this.lblOutputFormat.Text = "Output Format";
            // 
            // ddlOutputFormat
            // 
            this.ddlOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOutputFormat.FormattingEnabled = true;
            this.ddlOutputFormat.Location = new System.Drawing.Point(380, 80);
            this.ddlOutputFormat.Name = "ddlOutputFormat";
            this.ddlOutputFormat.Size = new System.Drawing.Size(98, 23);
            this.ddlOutputFormat.TabIndex = 9;
            this.ddlOutputFormat.SelectedIndexChanged += new System.EventHandler(this.ddlOutputFormat_SelectedIndexChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(119, 51);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(359, 23);
            this.txtOutput.TabIndex = 8;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(6, 51);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(107, 23);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(119, 22);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(359, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(6, 22);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(107, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(87, 182);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(403, 182);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblCMD
            // 
            this.lblCMD.AutoSize = true;
            this.lblCMD.Location = new System.Drawing.Point(-90, 6);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(64, 15);
            this.lblCMD.TabIndex = 3;
            this.lblCMD.Text = "Command";
            // 
            // txtCMD
            // 
            this.txtCMD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCMD.Location = new System.Drawing.Point(6, 22);
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.Size = new System.Drawing.Size(472, 154);
            this.txtCMD.TabIndex = 2;
            this.txtCMD.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ddlFPS
            // 
            this.ddlFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFPS.FormattingEnabled = true;
            this.ddlFPS.Items.AddRange(new object[] {
            "60",
            "30",
            "24",
            "16"});
            this.ddlFPS.Location = new System.Drawing.Point(321, 45);
            this.ddlFPS.Name = "ddlFPS";
            this.ddlFPS.Size = new System.Drawing.Size(72, 23);
            this.ddlFPS.TabIndex = 3;
            this.ddlFPS.SelectedIndexChanged += new System.EventHandler(this.ddlFPS_SelectedIndexChanged);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(290, 48);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(26, 15);
            this.lblFPS.TabIndex = 2;
            this.lblFPS.Text = "FPS";
            // 
            // ddlResolution
            // 
            this.ddlResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlResolution.FormattingEnabled = true;
            this.ddlResolution.Items.AddRange(new object[] {
            "1920x1080",
            "1280x720",
            "720x480",
            "480x360"});
            this.ddlResolution.Location = new System.Drawing.Point(77, 23);
            this.ddlResolution.Name = "ddlResolution";
            this.ddlResolution.Size = new System.Drawing.Size(105, 23);
            this.ddlResolution.TabIndex = 1;
            this.ddlResolution.SelectedIndexChanged += new System.EventHandler(this.ddlResolution_SelectedIndexChanged);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(6, 31);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(63, 15);
            this.lblResolution.TabIndex = 0;
            this.lblResolution.Text = "Resolution";
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.ddlColorFilter);
            this.grpDisplay.Controls.Add(this.lblColorFilter);
            this.grpDisplay.Controls.Add(this.ddlResolution);
            this.grpDisplay.Controls.Add(this.lblResolution);
            this.grpDisplay.Location = new System.Drawing.Point(12, 243);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(202, 123);
            this.grpDisplay.TabIndex = 2;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Display Settings";
            // 
            // ddlColorFilter
            // 
            this.ddlColorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlColorFilter.FormattingEnabled = true;
            this.ddlColorFilter.Items.AddRange(new object[] {
            "Black/White",
            "Retro"});
            this.ddlColorFilter.Location = new System.Drawing.Point(77, 52);
            this.ddlColorFilter.Name = "ddlColorFilter";
            this.ddlColorFilter.Size = new System.Drawing.Size(105, 23);
            this.ddlColorFilter.TabIndex = 4;
            // 
            // lblColorFilter
            // 
            this.lblColorFilter.AutoSize = true;
            this.lblColorFilter.Location = new System.Drawing.Point(6, 60);
            this.lblColorFilter.Name = "lblColorFilter";
            this.lblColorFilter.Size = new System.Drawing.Size(65, 15);
            this.lblColorFilter.TabIndex = 3;
            this.lblColorFilter.Text = "Color Filter";
            // 
            // grpVideo
            // 
            this.grpVideo.Controls.Add(this.lblEnd);
            this.grpVideo.Controls.Add(this.lblStart);
            this.grpVideo.Controls.Add(this.txtVideoEnd);
            this.grpVideo.Controls.Add(this.txtVideoStart);
            this.grpVideo.Controls.Add(this.ddlFPS);
            this.grpVideo.Controls.Add(this.lblFPS);
            this.grpVideo.Location = new System.Drawing.Point(12, 141);
            this.grpVideo.Name = "grpVideo";
            this.grpVideo.Size = new System.Drawing.Size(486, 96);
            this.grpVideo.TabIndex = 4;
            this.grpVideo.TabStop = false;
            this.grpVideo.Text = "Video Settings";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(139, 27);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(27, 15);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(29, 27);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(31, 15);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start";
            // 
            // txtVideoEnd
            // 
            this.txtVideoEnd.Location = new System.Drawing.Point(139, 45);
            this.txtVideoEnd.Mask = "00:00:00";
            this.txtVideoEnd.Name = "txtVideoEnd";
            this.txtVideoEnd.Size = new System.Drawing.Size(63, 23);
            this.txtVideoEnd.TabIndex = 5;
            this.txtVideoEnd.Text = "000000";
            this.txtVideoEnd.TextChanged += new System.EventHandler(this.txtVideoEnd_TextChanged);
            // 
            // txtVideoStart
            // 
            this.txtVideoStart.Location = new System.Drawing.Point(29, 45);
            this.txtVideoStart.Mask = "00:00:00";
            this.txtVideoStart.Name = "txtVideoStart";
            this.txtVideoStart.Size = new System.Drawing.Size(63, 23);
            this.txtVideoStart.TabIndex = 4;
            this.txtVideoStart.Text = "000000";
            this.txtVideoStart.TextChanged += new System.EventHandler(this.txtVideoStart_TextChanged);
            // 
            // grpAudio
            // 
            this.grpAudio.Controls.Add(this.lblVolume);
            this.grpAudio.Controls.Add(this.lblVolumeTitle);
            this.grpAudio.Controls.Add(this.tbVolume);
            this.grpAudio.Location = new System.Drawing.Point(221, 243);
            this.grpAudio.Name = "grpAudio";
            this.grpAudio.Size = new System.Drawing.Size(278, 123);
            this.grpAudio.TabIndex = 5;
            this.grpAudio.TabStop = false;
            this.grpAudio.Text = "Audio Settings";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(65, 26);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(25, 15);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "100";
            // 
            // lblVolumeTitle
            // 
            this.lblVolumeTitle.AutoSize = true;
            this.lblVolumeTitle.Location = new System.Drawing.Point(6, 26);
            this.lblVolumeTitle.Name = "lblVolumeTitle";
            this.lblVolumeTitle.Size = new System.Drawing.Size(53, 15);
            this.lblVolumeTitle.TabIndex = 4;
            this.lblVolumeTitle.Text = "Volume: ";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(6, 52);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(255, 45);
            this.tbVolume.TabIndex = 0;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.Value = 100;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnMakeCMD);
            this.grpCommand.Controls.Add(this.btnPreview);
            this.grpCommand.Controls.Add(this.btnRun);
            this.grpCommand.Controls.Add(this.txtCMD);
            this.grpCommand.Controls.Add(this.lblCMD);
            this.grpCommand.Controls.Add(this.btnClear);
            this.grpCommand.Controls.Add(this.btnCopy);
            this.grpCommand.Location = new System.Drawing.Point(11, 372);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(487, 216);
            this.grpCommand.TabIndex = 6;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command";
            // 
            // btnMakeCMD
            // 
            this.btnMakeCMD.Location = new System.Drawing.Point(168, 182);
            this.btnMakeCMD.Name = "btnMakeCMD";
            this.btnMakeCMD.Size = new System.Drawing.Size(148, 23);
            this.btnMakeCMD.TabIndex = 8;
            this.btnMakeCMD.Text = "Make Command";
            this.btnMakeCMD.UseVisualStyleBackColor = true;
            this.btnMakeCMD.Click += new System.EventHandler(this.btnMakeCMD_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(322, 183);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 600);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.grpAudio);
            this.Controls.Add(this.grpVideo);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.grpFile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpeg GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpDisplay.ResumeLayout(false);
            this.grpDisplay.PerformLayout();
            this.grpVideo.ResumeLayout(false);
            this.grpVideo.PerformLayout();
            this.grpAudio.ResumeLayout(false);
            this.grpAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpFile;
        private Label lblCMD;
        private RichTextBox txtCMD;
        private TextBox txtInput;
        private Button btnInput;
        private OpenFileDialog openFileDialog;
        private ComboBox ddlResolution;
        private Label lblResolution;
        private TextBox txtOutput;
        private Button btnOutput;
        private Button btnCopy;
        private Button btnClear;
        private Button btnRun;
        private ComboBox ddlFPS;
        private Label lblFPS;
        private Label lblOutputFormat;
        private ComboBox ddlOutputFormat;
        private GroupBox grpDisplay;
        private GroupBox grpVideo;
        private GroupBox grpAudio;
        private TrackBar tbVolume;
        private GroupBox grpCommand;
        private Button btnPreview;
        private Label lblColorFilter;
        private Label lblVolumeTitle;
        private ComboBox ddlColorFilter;
        private Label lblEnd;
        private Label lblStart;
        private MaskedTextBox txtVideoEnd;
        private MaskedTextBox txtVideoStart;
        private Label lblVolume;
        private Button btnMakeCMD;
    }
}