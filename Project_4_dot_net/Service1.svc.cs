using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Project_4_dot_net.Object;
using Project_4_dot_net.DataAccess;

namespace Project_4_dot_net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<CoSoDoiTacOBJ> Select_all_CoSoDoiTac()
        {
            List<CoSoDoiTacOBJ> list = new List<CoSoDoiTacOBJ>();
            //list = TaiKhoanDB.LoadAll_User();
            list = CoSoDoiTacDB.LoadAll();
            return list;
        }
        public  List<TaiKhoanOBJ> Select_all_User()
        {
            List<TaiKhoanOBJ> list = new List<TaiKhoanOBJ>();
             list =  TaiKhoanDB.LoadAll_User();
            return list;
        }

        public string Select_all_user_string()
        {
            string str_User = TaiKhoanDB.Load_All_User_Json();
            return str_User;
        }
    }
}
