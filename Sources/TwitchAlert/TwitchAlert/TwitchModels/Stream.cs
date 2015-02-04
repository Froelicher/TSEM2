using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAlert.TwitchModels
{
    [DataContract]
    class Stream
    {
        [DataMember]
        public long _id { get; set; }

        [DataMember]
        public string game { get; set; }

        [DataMember]
        public int viewers { get; set; }

        [DataMember]
        public string created_at { get; set; }

        [DataMember]
        public string self { get; set; }

        [DataMember]
        public Preview preview { get; set; }

        [DataMember]
        public Channel channel { get; set; }
    }
}
