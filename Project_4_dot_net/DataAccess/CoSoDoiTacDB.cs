using Project_4_dot_net.Connect_Database;
using Project_4_dot_net.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Project_4_dot_net.DataAccess
{
    public class CoSoDoiTacDB
    {
        public static KetNoi kn = new KetNoi();
        public static DataTable dt = new DataTable();

        public static string Load_All_CoSoDoiTac_Json()
        {
            string _json;
            List<CoSoDoiTacOBJ> list = new List<CoSoDoiTacOBJ>();
            try
            {
                dt = kn.ExecuteDataSet("usp_PMCC_tblCoSoDoiTac_Select_All", new SqlParameter[0]).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        CoSoDoiTacOBJ tk = new CoSoDoiTacOBJ
                        {
                            id = int.Parse(dr["Id"].ToString()),
                            ID_DoiTac = int.Parse(dr["ID_DoiTac"].ToString()),
                            TenCoSo = dr["TenCoSo"].ToString(),
                            DiaChi = dr["Dia_Chi"].ToString(),
                            ThanhPho = dr["Thanh_Pho"].ToString(),
                            SDT = dr["SDT"].ToString()
                            //idtaikhoan = int.Parse(dr["Id"].ToString()),
                            //UserName = dr["UserName"].ToString(),
                            //Password = dr["Pass"].ToString(),
                            //Loai = int.Parse(dr["Loai"].ToString()),
                            //SDT = dr["Link_Facebook"].ToString(),
                            //DiaChi = dr["SDT"].ToString(),
                            //Link_FB = dr["DiaChi"].ToString()
                        };
                        list.Add(tk);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var json = new JavaScriptSerializer().Serialize(list);
            _json = json;
            return _json;
        }


        public static List<CoSoDoiTacOBJ> LoadAll()
        {
            List<CoSoDoiTacOBJ> list = new List<CoSoDoiTacOBJ>();
            try
            {
                dt = kn.ExecuteDataSet("usp_PMCC_tblCoSoDoiTac_Select_All", new SqlParameter[0]).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        CoSoDoiTacOBJ tk = new CoSoDoiTacOBJ
                        {
                            id = int.Parse(dr["Id"].ToString()),
                            ID_DoiTac = int.Parse(dr["ID_DoiTac"].ToString()),
                            TenCoSo = dr["TenCoSo"].ToString(),
                            DiaChi = dr["Dia_Chi"].ToString(),
                            ThanhPho = dr["Thanh_Pho"].ToString(),
                            SDT = dr["SDT"].ToString()
                            //idtaikhoan = int.Parse(dr["Id"].ToString()),
                            //UserName = dr["UserName"].ToString(),
                            //Password = dr["Pass"].ToString(),
                            //Loai = int.Parse(dr["Loai"].ToString()),
                            //SDT = dr["Link_Facebook"].ToString(),
                            //DiaChi = dr["SDT"].ToString(),
                            //Link_FB = dr["DiaChi"].ToString()
                        };
                        list.Add(tk);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}