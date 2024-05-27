using Exporter.Domain.Models;
using Exporter.Infrastructure.Interfaces;


namespace Exporter.Infrastructure
{
    public class SimulatedSpotifyApiClient: ISpotifyApiClient
    {
        // It is a list of playlists for the example.
        // The Playlist constructor takes as arguments:
        // id (string), name (string), folder (string)
        readonly List<Playlist> playlists =
        [
            new Playlist("1", "Jazz Classics", "English"),
            new Playlist("2", "Funny Strings", "Instrumentals")
        ];


        /// <summary>
        /// This dictionary contains the playlistId as key and a list of tracks
        /// as value. The Track class has a constructor that takes as input
        /// trackId (string), name (string), album (string), artists (string)
        /// </summary>
        readonly Dictionary<string, List<Track>> playlistTracks = new()
            {
                {
                    "1",
                    new List<Track>()
                    {
                        new ("A", "I'm Gonna Sit Right Down And Write Myself A Letter", "Kisses On The Bottom", "Paul McArtney"),
                        new ("B", "Love Me Or Leave Me", "Fly Me To The Moon..", "Rod Stewart"),
                        new ("C", "Sunny Side Of The Street", "Fly Me To The Moon..", "Rod Stewart"),
                        new ("D", "Jump Session", "Here comes... Slim Gaillard", "Gaillard")
                    }
                },
                {
                    "2",
                    new List<Track>()
                    {
                        new ("E", "Les passants", "Zas", "Zas"),
                        new ("F", "Je veux", "Zas", "Zas"),
                        new ("G", "A-Tisket, A-Tasket", "Swing", "The Manhattan Transfer")
                    }
                }
            };
       




        public SimulatedSpotifyApiClient()
        {
        }
 
        /// <summary>
        /// This method returns the playlists for the specified userId.
        /// </summary>
        /// <param name="userId">Please use any fake id.</param>
        /// <returns>A list of Playlist objects.</returns>
        public List<Playlist> GetPlaylistsForUser(string userId)
        {
            return playlists;
        }


        /// <summary>
        /// This method returns the playlist tracks for the specified playlistId.
        /// </summary>
        /// <param name="playlistId">Playlist Id.</param>
        /// <returns></returns>
        public List<Track>? GetTracksForPlaylist(string playlistId)
        {
            playlistTracks.TryGetValue(playlistId, out List<Track>? result);


            return result;
        }
    }
}

