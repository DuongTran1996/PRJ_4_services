using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class ImagesLinkOBJ
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int IDBaiViet { get; set; }
        [DataMember]
        public string Images { get; set; }
    }
}