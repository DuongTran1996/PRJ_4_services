using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class CoSoDoiTacOBJ
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int ID_DoiTac { get; set; }
        [DataMember]
        public string TenCoSo { get; set; }
        [DataMember]
        public string DiaChi { get; set; }
        [DataMember]
        public string ThanhPho { get; set; }
        [DataMember]
        public string SDT { get; set; }
    }
}