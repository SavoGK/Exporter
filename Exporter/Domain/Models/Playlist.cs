using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Domain.Models
{
    public class Playlist(string id, string name, string folder)
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Folder { get; set; } = folder;

    }
}
