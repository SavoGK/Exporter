using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Domain.Models
{
    public class Track(string trackId, string name, string album, string artists)
    {
        public string TrackId { get; set; } = trackId;
        public string Name { get; set; } = name;
        public string Album { get; set; } = album;
        public string Artists { get; set; } = artists;
    }
}
