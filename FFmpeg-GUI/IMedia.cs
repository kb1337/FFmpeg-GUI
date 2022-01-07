namespace FFmpeg_GUI
{
    interface IMedia<T>
    {
        List<string> Extentions { get; }

        string Name { get; set; }
        string Size { get; set; }
        string MakeCommandString();
    }
}
