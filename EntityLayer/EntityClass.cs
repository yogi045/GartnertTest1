using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityClass
    {
        public string Tags { get; set; }
        public string Name { get; set; }
        public string Twitter { get; set; }

      public EntityClass(string tags, string names, string twitter)
        {
            Tags = tags;
            Name = names;
            Twitter = twitter;
        }

    }
}
