using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project_4_dot_net.Connect_Database
{
    public  class KetNoi
    {
        SqlConnection cnn;

        //public void Connect()
        //{
        //    if (cnn == null)

        //        cnn = new SqlConnection(@"Data Source=DESKTOP-N4CK7NN;Initial Catalog=db_WEB_CHUC;Integrated Security=True");

        //    if (cnn.State == ConnectionState.Closed)

        //        cnn.Open();
        //}
        public  DataSet ExecuteDataSet(string procName, params SqlParameter[] procParams)
        {
            SqlConnection conn = null;
            SqlDataAdapter adapter = null;
            DataSet ds = new DataSet();
            SqlCommand cmd = null;
            string paramName = "";
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-N4CK7NN;Initial Catalog=Project_4_Web;Integrated Security=True");
                cmd = new SqlCommand(procName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 300;
                if (procParams != null)
                {
                    for (int i = 0; i < procParams.Length; i++)
                    {
                        cmd.Parameters.Add(procParams[i]);
                        paramName += procParams[i].ParameterName + ":" + procParams[i].Value + "|";
                    }
                }
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                //log.Error("Command:" + cmd.CommandText + ",Command Parameter:" + paramName);
                //log.Error(ex);

                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (adapter != null)
                {
                    adapter.Dispose();

                }
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return ds;
        }
    }
}