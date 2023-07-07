using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENYSchedular_new
{
    class CommFun
    {
        Sql sqlClass = new Sql();
        public DataSet GetEmptyEyData()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlClass.Sql_GetEmptyEyData("USP_UWSARAL_RISK_ENYDATA_GET_DEQC_CR_30554", ref ds,2);
                //sqlClass.Sql_GetEmptyEyData("Usp_EYScoreSchedulare_FeatchData", ref ds,1);
                return ds;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

            }
            return ds;
        }
        public DataSet Featch_SMARTAPIENYFLAG_Details(string Appno)
        {
            DataSet Dt = new DataSet();
            SqlParameter[] sqlparams = new SqlParameter[1];
            try
            {
                sqlparams[0] = new SqlParameter("@AppNo", Appno);
                Dt = sqlClass.RetrieveDataset("USP_SMARTAPIENYRISKFLAG_SCORE_GET_TEMP_Schedular", sqlparams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Dt;
        }
        public int Insert_EnyFlag_Details(string appNo, string ENYValue, string Actions)
        {
            SqlParameter[] sqlparams = new SqlParameter[4];
            try
            {
                sqlparams[0] = new SqlParameter("@AppNo", appNo);
                sqlparams[1] = new SqlParameter("@score", ENYValue);
                sqlparams[2] = new SqlParameter("@early_claim_risk_level", Actions);
                sqlparams[3] = new SqlParameter("@source", "API-localSchedular");
                int i = sqlClass.Insertrecord("USP_INSERT_EnyFlagScore_UWSaral", sqlparams);
                return i;
            }
            catch (Exception ex)
            {
                return 0;

            }
        }
        public int Insert_Logs_RiskAndEY(string ApplicationNo, string Msg, string Source, string APIDetails, string StatusLog)
        {
            SqlParameter[] sqlparams = new SqlParameter[5];
            try
            {
                sqlparams[0] = new SqlParameter("@AppNo", ApplicationNo);
                sqlparams[1] = new SqlParameter("@Msg", Msg);
                sqlparams[2] = new SqlParameter("@Source", Source);
                sqlparams[3] = new SqlParameter("@ApiDetails", APIDetails);
                sqlparams[4] = new SqlParameter("@StatusLog", StatusLog);
                int i = sqlClass.Insertrecord("Sp_Insert_EnyAndRiskScore", sqlparams);
                return i;
            }
            catch (Exception ex)
            {
                return 0;

            }
        }

    }
}
