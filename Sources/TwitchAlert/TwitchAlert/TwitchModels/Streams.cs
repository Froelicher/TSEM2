using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAlert.TwitchModels
{
    [DataContract]
    class Streams
    {
        [DataMember]
        public Dictionary<string, string> _links { get; set; }

        [DataMember]
        public string self { get; set; }

        [DataMember]
        public string channel { get; set; }

        [DataMember]
        public Stream stream { get; set; }
    }
}
