using Exporter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Domain.Interfaces
{
    internal interface IPlaylistRepository
    {
        public List<Playlist> GetPlaylistsForUser(string userId);
        public List<Track>? GetTracksForPlaylist(string playlistId);
    }
}
