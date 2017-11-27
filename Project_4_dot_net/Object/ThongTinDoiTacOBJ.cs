using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class ThongTinDoiTacOBJ
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IDuser { get; set; }
        [DataMember]
        public string GioiThieu { get; set; }
    }
}