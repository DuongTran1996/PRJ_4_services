using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Project_4_dot_net.Object
{
    [DataContract]
    public class SanPhamOBJ
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ten_San_Pham { get; set; }
        [DataMember]
        public int Loai_San_Pham { get; set; }
        [DataMember]
        public int Id_Doi_Tac { get; set; }
        [DataMember]
        public int Trang_Thai { get; set; }
        [DataMember]
        public string Tieu_De { get; set; }
        [DataMember]
        public string Noi_Dung { get; set; }
        [DataMember]
        public string Link_Image { get; set; }
        [DataMember]
        public DateTime Ngay_Het_Han { get; set; }
        [DataMember]
        public int So_Nguoi_Da_Dat { get; set; }
        [DataMember]
        public string Dia_Chi { get; set; }
        [DataMember]
        public int Ma_Danh_Muc { get; set; }
        [DataMember]
        public string Thanh_Pho { get; set; }
        [DataMember]
        public string Loai_Khuyen_Mai { get; set; }
    }
}