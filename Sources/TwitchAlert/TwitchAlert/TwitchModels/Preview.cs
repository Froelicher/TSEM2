using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAlert.TwitchModels
{
    [DataContract]
    class Preview
    {
        [DataMember]
        public string small { get; set; }

        [DataMember]
        public string medium { get; set; }

        [DataMember]
        public string large { get; set; }

        [DataMember]
        public string template { get; set; }
    }
}
