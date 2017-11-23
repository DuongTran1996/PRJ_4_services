using Project_4_dot_net.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project_4_dot_net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
         List<TaiKhoanOBJ> Select_all_User();
        [OperationContract]
        List<CoSoDoiTacOBJ> Select_all_CoSoDoiTac();
        [OperationContract]
        string Select_all_user_string();
    }
}
