namespace Exporter.Domain.Models
{
    public class Track(string trackId, string name, string album, string artist)
    {
        public string TrackId { get; set; } = trackId;
        public string Name { get; set; } = name;
        public string Album { get; set; } = album;
        public string Artist { get; set; } = artist;
    }
}
