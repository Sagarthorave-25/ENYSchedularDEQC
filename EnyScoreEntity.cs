using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENYSchedular_new
{
    class EnyScoreEntity
    {

    }
    public class EYRiskScoreRequest
    {
        public RequestSource RequestSource { get; set; }
        public Requestbody1 Requestbody { get; set; }
    }
    public class RequestSource
    {
        [MaxLength(20)]
        public string DataKeyName { get; set; }
        [MaxLength(20)]
        public string DataKeyValue { get; set; }
        [MaxLength(500)]
        public string APIDetails { get; set; }
        [MaxLength(20)]
        public string Source { get; set; }
        [MaxLength(1000)]
        public string ErrorMessage { get; set; }
    }
    public class Requestbody1
    {
        public string PolicyID { get; set; }
        public string AppNo2 { get; set; }
        public string Channel { get; set; }
        public string Login_Date { get; set; }
        public string APE { get; set; }
        public string SumAssured { get; set; }
        public string PolicyTerm { get; set; }
        public string Agntnum { get; set; }
        public string Address_proof { get; set; }
        public string LA_name { get; set; }
        public string LA_DOB { get; set; }
        public string LA_Annual_Income { get; set; }
        public string LA_Education { get; set; }
        public string LA_Occupation { get; set; }
        public string LA_Occupation_Desc { get; set; }
        [MaxLength(20)]
        public string LA_State { get; set; }
        public string LA_PCODE { get; set; }
        public string Product_Code { get; set; }
        public string Sales_manager_id { get; set; }
        public string video_plvc_flag { get; set; }
        public string relation_nominee_la { get; set; }
        public string flag_la_not_equal_proposer { get; set; }
        public string distance_between_insurer_and_branch { get; set; }
        public string issue_date { get; set; }
        public string policy_decline_or_postponsed { get; set; }
        public string covid_check { get; set; }
        public string date_of_intimation { get; set; }
        public string date_of_death { get; set; }
    }
    public class EnyScoreResponse1
    {
        public ResponseResult1 ResponseResult { get; set; }
        public List<ResponseBody1> ResponseBody { get; set; }
    }
    public class ResponseBody1
    {
        public string Sales_manager_id { get; set; }
        public string LA_Occupation { get; set; }
        public string Address_proof { get; set; }
        public string PinCode { get; set; }
        public string LA_State { get; set; }
        public string agntnum { get; set; }
        public string AgeBucket_Combined { get; set; }

        public string policy_id { get; set; }
        public string appno2 { get; set; }
        public string Channel { get; set; }
        public string Login_Date { get; set; }
        public string APE { get; set; }
        public string SumAssured { get; set; }
        public string PolicyTerm { get; set; }

        public string LANAME { get; set; }
        public string LADOB { get; set; }
        public string LA_Annual_Income { get; set; }

        public string LA_Education { get; set; }

        public string LA_Occupation_Desc { get; set; }

        public string LA_PCODE { get; set; }
        public string Product_Code { get; set; }
        public string video_plvc_flag__y_n_ { get; set; }
        public string relationship_between_nominee_and_la { get; set; }

        public string flag_for_la_not_equal_to_proposer { get; set; }
        public string distance_between_insured_pincode_and_branch_pincode { get; set; }

        public string issue_date { get; set; }
        public string policy_declined_or_postponed__y_n_ { get; set; }
        public string covid_check { get; set; }
        public string date_of_stringimation { get; set; }
        public string date_of_death { get; set; }
        public string data_id { get; set; }
        public string la_age_at_app { get; set; }
        public string occupation { get; set; }
        public string product_name { get; set; }

        public string product_type { get; set; }
        public string product_par_nonpar { get; set; }

        public string product_category { get; set; }
        public string education { get; set; }
        public string sa_prem { get; set; }
        public string educationOther;
        public string la_proposer_flg { get; set; }
        public string flag_AU { get; set; }

        public string Productnonpar { get; set; }
        public string ape_age { get; set; }

        public string sumassured_age { get; set; }
        public string agebucket1 { get; set; }
        public string agebucket2 { get; set; }
        public string agebucket3 { get; set; }
        public string agebucket4 { get; set; }
        public string agebucket5 { get; set; }
        public string agebucket6 { get; set; }
        public string agebucket7 { get; set; }
        public string agebucket8 { get; set; }
        public string mean_inc { get; set; }

        public string income_age { get; set; }
        public string income_sa { get; set; }
        public string income_prem { get; set; }
        public string last_name { get; set; }
        public string risky_name { get; set; }
        public string flag_distance_0_100 { get; set; }

        public string flag_PIVC { get; set; }
        public string flag_PLVC { get; set; }
        public string close_relation_nominee_la { get; set; }
        public string bday_flag { get; set; }
        public string risky_agent { get; set; }
        public string dec_agent { get; set; }
        public string dec_state { get; set; }
        public string risky_pincode { get; set; }

        public string risky_add { get; set; }
        public string risky_occ { get; set; }
        public string risky_SM { get; set; }

        public string score { get; set; }
        public string Early_claim_risk_level { get; set; }
    }
    public class ResponseResult1
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public string responseDescription { get; set; }
    }
}
