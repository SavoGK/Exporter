using Exporter.Domain.Interfaces;
using Exporter.Domain.Models;
using Exporter.Infrastructure.Interfaces;

namespace Exporter.Infrastructure
{
    public class PlaylistRepository : IPlaylistRepository
    {
        public PlaylistRepository(ISpotifyApiClient spotifyApiClient) 
        {
            this.SpotifyApiClient = spotifyApiClient;
        }
        public List<Playlist> GetPlaylistsForUser(string userId)
        {
            return SpotifyApiClient.GetPlaylistsForUser(userId);
        }

        public List<Track>? GetTracksForPlaylist(string playlistId)
        {
            return SpotifyApiClient.GetTracksForPlaylist(playlistId);
        }

        public ISpotifyApiClient SpotifyApiClient;
    }
}
