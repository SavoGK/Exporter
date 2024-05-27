using Exporter.Domain.Interfaces;
using Exporter.Domain.Models;
using Exporter.Infrastructure;
using System.Text;

SimulatedSpotifyApiClient simulatedSpotifyApiClient = new SimulatedSpotifyApiClient();
IPlaylistRepository playlistRepository = new PlaylistRepository(simulatedSpotifyApiClient);

User user = new("1", "spotify_user");
StringBuilder stringBuilder = new StringBuilder();

List<Playlist> playlistList = playlistRepository.GetPlaylistsForUser(user.Id);

foreach(var playlist in playlistList)
{
    List<Track>? tracks = playlistRepository.GetTracksForPlaylist(playlist.Id);
    if (tracks != null)
    {
        foreach(var track in tracks)
        {
            stringBuilder.Append(playlist.Folder).Append(',');
            stringBuilder.Append(playlist.Name).Append(',');
            stringBuilder.Append(track.Album).Append(',');
            stringBuilder.Append(track.Name).Append(',');
            stringBuilder.Append(track.Artist);
            stringBuilder.AppendLine();
        }
    }
}
Console.WriteLine(stringBuilder.ToString());

