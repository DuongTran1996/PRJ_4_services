using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class LichSuDatHangOBJ
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Id_User { get; set; }
        [DataMember]
        public int Id_SanPham { get; set; }
    }
}