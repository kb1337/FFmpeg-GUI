using System.Text;

namespace FFmpeg_GUI
{
    internal class Video : IMedia<string>, IDisplay, IAudio
    {
        public Video() { }
        private static Video? _instance = null;
        public static Video Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Video();

                }
                return _instance;
            }
        }

        public List<string> Extentions { get; } = new List<string>()
        {
                "MP4",
                "AVI",
                "MOV"
        };

        public string Name { get; set; }
        public string Size { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Fps { get; set; } = -1;
        public int Width
        {
            get { return Display.Instance.Width; }
            set { Display.Instance.Width = value; }
        }
        public int Height
        {
            get { return Display.Instance.Height; }
            set { Display.Instance.Height = value; }
        }
        public double Volume
        {
            get { return Audio.Instance.Volume; }
            set { Audio.Instance.Volume = value; }
        }

        public string MakeCommandString()
        {
            StringBuilder command = new StringBuilder();

            if (StartTime != null)
                command.Append($" -ss {StartTime} ");
            if (EndTime != null)
                command.Append($" -to {EndTime} ");
            if (Fps != -1)
                command.Append($" -filter:v fps={Fps} ");

            string cmdAudio = Audio.Instance.MakeCommandString();
            string cmdDisplay = Display.Instance.MakeCommandString();

            command.Append(cmdAudio);
            command.Append(cmdDisplay);

            return command.ToString();
        }
    }
}
