using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENYSchedular_new
{
    class Sql
    {
        static string TrnxCommRisk = ConfigurationManager.AppSettings["TrnxCommRisk"].ToString().Trim();
        static string TrnxComm = ConfigurationManager.AppSettings["TrnxComm"].ToString().Trim();
        public void Sql_GetEmptyEyData(String spName, ref DataSet _dt,int db)
        {
            string finalConn = string.Empty;
            if (db == 1)
            {
                finalConn = TrnxComm;
            }
            else {
                finalConn = TrnxCommRisk;
            }
            try
            {
                SqlConnection connection = new SqlConnection(finalConn);

                SqlCommand cmd = new SqlCommand(spName, connection);
                cmd.CommandTimeout = Convert.ToInt32(ConfigurationManager.AppSettings["SqlCommandTimeOut"]);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(_dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        public DataSet RetrieveDataset(string spName, SqlParameter[] sqlParam)
        {
            DataSet _ds;
            _ds = SqlHelper.ExecuteDataset(TrnxComm, CommandType.StoredProcedure, spName, sqlParam);
            return _ds;
        }


        public int Insertrecord(string spName, SqlParameter[] sqlParam)
        {
            int result;
            result = SqlHelper.ExecuteNonQuery(TrnxComm, CommandType.StoredProcedure, spName, sqlParam);
            return result;
        }

    }
}
