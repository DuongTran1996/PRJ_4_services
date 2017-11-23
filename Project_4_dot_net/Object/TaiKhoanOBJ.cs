using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class TaiKhoanOBJ
    {
        [DataMember]
        public int idtaikhoan { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int Loai { get; set; }
        [DataMember]
        public string Link_FB { get; set; }
        [DataMember]
        public string SDT { get; set; }
        [DataMember]
        public string DiaChi { get; set; }
    }
}