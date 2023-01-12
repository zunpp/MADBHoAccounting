using MADBHoAccounting.Models;
using MADBHoAccounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class AccountDetailEntryDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        //GET Account Detail Entry
        public IEnumerable<TB_AccountDetailEntry> GetAccountDetailEntry(string GroupName,string connectionString)
        {
            List<TB_AccountDetailEntry> accountDetailEntryList = new List<TB_AccountDetailEntry>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountDetailEntry_Select", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GroupName", GroupName);
                //cmd.Parameters.AddWithValue("@TownshipID", "9999");

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_AccountDetailEntry ade = new TB_AccountDetailEntry();

                    ade.AccountID = Convert.ToInt32(dr["AccountID"].ToString());
                    ade.Date = Convert.ToDateTime(dr["Date"].ToString()).ToString("yyyy-MM-dd");
                    ade.TownCode = dr["TownCode"].ToString();
                    ade.TownName = dr["TownName"].ToString();
                    ade.DiviSionName = dr["DiviSionName"].ToString();
                    ade.AccountCode = dr["AccountCode"].ToString();
                    ade.SubsiHeadName = dr["SubsiHeadName"].ToString();                    
                    ade.MiniAccount = dr["MiniAccount"].ToString();
                    ade.MainHeadName = dr["MainHeadName"].ToString();
                    ade.DebitAmount = Convert.ToDecimal(dr["DebitAmount"].ToString());
                    ade.CreditAmount = Convert.ToDecimal(dr["CreditAmount"].ToString());
                    ade.GroupNumber = dr["GroupNumber"].ToString();
                    ade.IsDeleted = Convert.ToBoolean(dr["IsDeleted"].ToString());
                    ade.CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString()).ToString("yyyy-MM-dd");
                    ade.CreatedBy = dr["CreatedBy"].ToString();
                    ade.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"].ToString()).ToString("yyyy-MM-dd");

                    accountDetailEntryList.Add(ade);
                }
                con.Close();
            }
            return accountDetailEntryList;
        }

        //GET Account Detail Entry for Branches
        public IEnumerable<TB_AccountDetailEntry> GetAccountDetailEntryForBranch(string connectionString,string Acctype, string TownCode="", string DivisionCode="", string GroupName="")
        {
            List<TB_AccountDetailEntry> accountDetailEntryList = new List<TB_AccountDetailEntry>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountDetailEntry_SelectAll", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TownshipId", TownCode);
                cmd.Parameters.AddWithValue("@DivisionId", DivisionCode);
                cmd.Parameters.AddWithValue("@GroupName", GroupName);
                cmd.Parameters.AddWithValue("@AccType", Acctype);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_AccountDetailEntry ade = new TB_AccountDetailEntry();

                    ade.AccountID = Convert.ToInt32(dr["AccountID"].ToString());
                    ade.Date = Convert.ToDateTime(dr["Date"].ToString()).ToString("yyyy-MM-dd");
                    ade.TownCode = dr["TownCode"].ToString();
                    ade.TownName = dr["TownName"].ToString();
                    ade.DiviSionName = dr["DiviSionName"].ToString();
                    ade.AccountCode = dr["AccountCode"].ToString();
                    ade.SubsiHeadName = dr["SubsiHeadName"].ToString();
                    ade.MiniAccount = dr["MiniAccount"].ToString();
                    ade.MainHeadName = dr["MainHeadName"].ToString();
                    ade.DebitAmount = Convert.ToDecimal(dr["DebitAmount"].ToString());
                    ade.CreditAmount = Convert.ToDecimal(dr["CreditAmount"].ToString());
                    //ade.GroupNumber = dr["GroupNumber"].ToString();
                    ade.IsDeleted = Convert.ToBoolean(dr["IsDeleted"].ToString());
                    ade.CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString()).ToString("yyyy-MM-dd");
                    ade.CreatedBy = dr["CreatedBy"].ToString();
                    ade.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"].ToString()).ToString("yyyy-MM-dd");

                    accountDetailEntryList.Add(ade);
                }
                con.Close();
            }
            return accountDetailEntryList;
        }

        //Create Account Detail Transaction
        public void AddAccountDetailEntry(TB_AccountDetailEntry ade, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountDetailEntry_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", 0);
                cmd.Parameters.AddWithValue("@Date", ade.Date);
                cmd.Parameters.AddWithValue("@TownCode", ade.TownCode);
                //cmd.Parameters.AddWithValue("@TownName", ade.TownName);
                //cmd.Parameters.AddWithValue("@DiviSionName", ade.DiviSionName);
                cmd.Parameters.AddWithValue("@AccountCode", ade.AccountCode);
                //cmd.Parameters.AddWithValue("@SubsiHeadName", ade.SubsiHeadName);
                cmd.Parameters.AddWithValue("@MiniAccount", "");
                //cmd.Parameters.AddWithValue("@MainHeadName", ade.MainHeadName);
                cmd.Parameters.AddWithValue("@DebitAmount", ade.DebitAmount);
                cmd.Parameters.AddWithValue("@CreditAmount", ade.CreditAmount);                
                cmd.Parameters.AddWithValue("@IsDeleted", 0);                
                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Update Account Detail Transaction
        public void UpdateAccountDetailEntry(TB_AccountDetailEntry ade, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountDetailEntry_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", ade.AccountID);
                cmd.Parameters.AddWithValue("@Date", ade.Date);
                cmd.Parameters.AddWithValue("@TownCode", ade.TownCode);
                //cmd.Parameters.AddWithValue("@TownName", ade.TownName);
                //cmd.Parameters.AddWithValue("@DiviSionName", ade.DiviSionName);
                cmd.Parameters.AddWithValue("@AccountCode", ade.AccountCode);
                cmd.Parameters.AddWithValue("@MiniAccount", "");
                //cmd.Parameters.AddWithValue("@SubsiHeadName", ade.SubsiHeadName);                
                //cmd.Parameters.AddWithValue("@MainHeadName", ade.MainHeadName);
                cmd.Parameters.AddWithValue("@DebitAmount", ade.DebitAmount);
                cmd.Parameters.AddWithValue("@CreditAmount", ade.CreditAmount);
                cmd.Parameters.AddWithValue("@IsDeleted", 0);
                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Delete Account Detail Transaction
        public void DeleteAccountDetailEntry(int? id, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountDetailEntry_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", id);               

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
