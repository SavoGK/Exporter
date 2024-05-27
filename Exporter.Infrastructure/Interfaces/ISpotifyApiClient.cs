using Exporter.Domain.Models;

namespace Exporter.Infrastructure.Interfaces
{
    public interface ISpotifyApiClient
    {
        public List<Playlist> GetPlaylistsForUser(string userId);
        public List<Track>? GetTracksForPlaylist(string playlistId);
    }
}
