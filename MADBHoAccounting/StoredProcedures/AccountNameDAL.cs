using MADBHoAccounting.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class AccountNameDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        //Get All Account Name List
        public IEnumerable<TbAccountName> GetAllAccountName(string connectionString)
        {
            List<TbAccountName> accNameList = new List<TbAccountName>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountName_Select", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TbAccountName an = new TbAccountName();

                    an.AccountId = Convert.ToInt32(dr["AccountID"].ToString());
                    an.AccountCode = dr["AccountCode"].ToString();
                    an.SubsiHeadName = dr["SubsiHeadName"].ToString();
                    an.MainHeadName = dr["MainHeadName"].ToString();
                    an.AccountNature = dr["AccountNature"].ToString();
                    an.OrderCode = dr["OrderCode"].ToString();
                    an.IsDeleted = Convert.ToBoolean(dr["IsDeleted"].ToString());
                    an.CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString());
                    an.CreatedBy = dr["CreatedBy"].ToString();
                    an.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"].ToString());

                    accNameList.Add(an);
                }
                con.Close();
            }
            return accNameList;
        }

        //Create New Account Name
        public void AddAccountMainTitle(TbAccountName an, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountName_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", 0);
                cmd.Parameters.AddWithValue("@AccountCode", an.AccountCode);
                cmd.Parameters.AddWithValue("@SubsiHeadName", an.SubsiHeadName);
                cmd.Parameters.AddWithValue("@MainHeadName", an.MainHeadName);
                cmd.Parameters.AddWithValue("@AccountNature", an.AccountNature);                
                cmd.Parameters.AddWithValue("@OrderCode", an.OrderCode);
                cmd.Parameters.AddWithValue("@IsDeleted", 0);
                //cmd.Parameters.AddWithValue("@CreatedDate", an.CreatedDate);
                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                //cmd.Parameters.AddWithValue("@ModifiedDate", "");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Update Account Name
        public void UpdateAccountMainTitle(TbAccountName an, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountName_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", an.AccountId);
                cmd.Parameters.AddWithValue("@AccountCode", an.AccountCode);
                cmd.Parameters.AddWithValue("@SubsiHeadName", an.SubsiHeadName);
                cmd.Parameters.AddWithValue("@MainHeadName", an.MainHeadName);
                cmd.Parameters.AddWithValue("@AccountNature", an.AccountNature);
                cmd.Parameters.AddWithValue("@OrderCode", an.OrderCode);
                cmd.Parameters.AddWithValue("@IsDeleted", 0);
                //cmd.Parameters.AddWithValue("@CreatedDate", an.CreatedDate);
                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                //cmd.Parameters.AddWithValue("@ModifiedDate", an.ModifiedDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Delete Account Name
        public void DeleteAccountMainTitle(int id, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountName_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
