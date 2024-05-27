using Exporter.Domain.Interfaces;
using Exporter.Domain.Models;
using Exporter.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Infrastructure
{
    internal class PlaylistRepository : IPlaylistRepository
    {
        public List<Playlist> GetPlaylistsForUser(string userId)
        {
            return SpotifyApiClient.GetPlaylistsForUser(userId);
        }

        public List<Track>? GetTracksForPlaylist(string playlistId)
        {
            return SpotifyApiClient.GetTracksForPlaylist(playlistId);
        }


        public required ISpotifyApiClient SpotifyApiClient { get; set; } 
    }
}
