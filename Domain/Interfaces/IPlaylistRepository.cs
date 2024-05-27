using Exporter.Domain.Models;

namespace Exporter.Domain.Interfaces
{
    public interface IPlaylistRepository
    {
        public List<Playlist> GetPlaylistsForUser(string userId);
        public List<Track>? GetTracksForPlaylist(string playlistId);
    }
}
