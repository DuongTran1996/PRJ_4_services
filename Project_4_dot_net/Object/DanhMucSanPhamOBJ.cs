using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class DanhMucSanPhamOBJ
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ten_Danh_Muc { get; set; }
        [DataMember]
        public int Danh_Muc_Cha { get; set; }

    }
}