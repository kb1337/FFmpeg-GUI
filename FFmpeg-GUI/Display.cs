using System.Text;

namespace FFmpeg_GUI
{
    class Display : IMedia<string>, IDisplay
    {
        private Display() { }
        private static Display? _instance = null;
        public static Display Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Display();

                }
                return _instance;
            }
        }

        public List<string> Extentions { get; } = new List<string>()
        {
            "GIF",
            "PNG",
            "JPG",
            "JPEG"
        };
        public string Name { get; set; }
        public string Size { get; set; }
        public int Width { get; set; } = -1;
        public int Height { get; set; } = -1;

        public string MakeCommandString()
        {
            StringBuilder command = new StringBuilder();

            if (Width > 0 && Height > 0)
                command.Append($" -vf scale={Width}:{Height} ");

            return command.ToString();
        }
    }
}
