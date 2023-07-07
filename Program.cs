using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENYSchedular_new
{
    class Program
    {
        static void Main(string[] args)
        {
            helper help = new helper();
            try
            {
                DataSet dt = help.GetEmptyEyData();
                //help.GenerateEyScore(dt);
                help.GenerateEyScore_Deqc(dt);
            }
            catch (Exception ex)
            {
                new CommFun().Insert_Logs_RiskAndEY("", ex.Message, "API-localSchedular", "", "Fail");
            }
            //this.Close();
        }
    }
}
