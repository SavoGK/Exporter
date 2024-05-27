using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Domain.Models
{
    public class User(string id, string name)
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
