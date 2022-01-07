using System.Text;

namespace FFmpeg_GUI
{
    class Audio : IMedia<string>, IAudio
    {
        private Audio() { }
        private static Audio? _instance = null;
        public static Audio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Audio();

                }
                return _instance;
            }
        }

        public List<string> Extentions { get; } = new List<string>()
        {
            "MP3"
        };
        public double Volume { get; set; } = 100;
        public string Name { get; set; }
        public string Size { get; set; }

        public string MakeCommandString()
        {
            StringBuilder command = new StringBuilder();

            string volume = Math.Round((Volume / 100), 1).ToString().Replace(",", ".");

            command.Append($" -filter:a \"volume = {volume}\" ");

            return command.ToString();
        }
    }
}
