using System.Text;

namespace FFmpeg_GUI
{
    internal class CommandBuilder
    {
        private static CommandBuilder _instance = null;

        public static CommandBuilder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CommandBuilder();

                }
                return _instance;
            }
        }

        public string InputName { get; set; }
        public string OutputName { get; set; }

        public string MakeCommand(IMedia<string> media, bool isPreview)
        {
            StringBuilder _command = new StringBuilder();

            if (isPreview)
                _command.Append("ffplay");
            else
                _command.Append("ffmpeg");

            _command.Append($" -i \"{InputName}\" ");

            _command.Append(media.MakeCommandString());

            if (!isPreview)
                _command.Append($" \"{OutputName}\"");

            return _command.ToString();
        }

    }
}
