using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class LienKetMuaHangOBJ
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ma_Khuyen_Mai { get; set; }
        [DataMember]
        public int Id_User { get; set; }
        [DataMember]
        public int Id_DoiTac { get; set; }
        [DataMember]
        public int Id_SanPham { get; set; }

    }
}