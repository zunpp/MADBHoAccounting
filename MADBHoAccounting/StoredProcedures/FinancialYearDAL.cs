using MADBHoAccounting.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class FinancialYearDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        // Get All Financial Year List
        public IEnumerable<TB_FinancialYear> GetAllFinancialYear(string connectionString)
        {
            List<TB_FinancialYear> financialYear = new List<TB_FinancialYear>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_FinancialYear_Select", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_FinancialYear fy = new TB_FinancialYear();

                    fy.FinancialYearPkid = Convert.ToInt32(dr["FinancialYearPkid"].ToString());
                    fy.FinancialStartDate = Convert.ToDateTime(dr["FinancialStartDate"]).ToString("yyyy-MM-dd");
                    fy.FinancialMiddleDate = Convert.ToDateTime(dr["FinancialMiddleDate"].ToString()).ToString("yyyy-MM-dd");
                    fy.FinancialEndDate = Convert.ToDateTime(dr["FinancialEndDate"].ToString()).ToString("yyyy-MM-dd");
                    fy.FinancialYear = dr["FinancialYear"].ToString();                    
                    fy.IsActiveFinancialYear = Convert.ToBoolean(dr["IsActiveFinancialYear"].ToString());
                    fy.IsAccountClosed = Convert.ToBoolean(dr["IsAccountClosed"].ToString());
                    fy.IsDeleted = Convert.ToBoolean(dr["IsDeleted"].ToString());
                    fy.IsUploaded = Convert.ToBoolean(dr["IsUploaded"].ToString());
                    fy.CreatedBy = 1;
                    fy.CreatedDate =Convert.ToDateTime(dr["CreatedDate"].ToString());

                    financialYear.Add(fy);
                }
                con.Close();
            }
            return financialYear;
        }

        //Create New Financial Year
        public void AddFinancialYear(TB_FinancialYear SP_FinancialYear_Select, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_FinancialYear_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FinancialYearPkid", 0);
                cmd.Parameters.AddWithValue("@FinancialStartDate", "");
                cmd.Parameters.AddWithValue("@FinancialMiddleDate", "");
                cmd.Parameters.AddWithValue("@FinancialEndDate", "");
                cmd.Parameters.AddWithValue("@FinancialYear", "");
                cmd.Parameters.AddWithValue("@IsActiveFinancialYear", "");
                cmd.Parameters.AddWithValue("@IsAccountClosed", "");
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.Parameters.AddWithValue("@IsUploaded", true);
                cmd.Parameters.AddWithValue("@CreatedBy", 1);
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToShortDateString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Update Financial Year
        public void UpdateFinancialYear(TB_FinancialYear sp_FinancialYear_Select, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_FinancialYear_Save", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FinancialYearPkid", sp_FinancialYear_Select.FinancialYearPkid);
                cmd.Parameters.AddWithValue("@FinancialStartDate", sp_FinancialYear_Select.FinancialStartDate);
                cmd.Parameters.AddWithValue("@FinancialMiddleDate", sp_FinancialYear_Select.FinancialMiddleDate);
                cmd.Parameters.AddWithValue("@FinancialEndDate", sp_FinancialYear_Select.FinancialEndDate);
                cmd.Parameters.AddWithValue("@FinancialYear", sp_FinancialYear_Select.FinancialYear);
                cmd.Parameters.AddWithValue("@IsActiveFinancialYear", sp_FinancialYear_Select.IsActiveFinancialYear);
                cmd.Parameters.AddWithValue("@IsAccountClosed", sp_FinancialYear_Select.IsAccountClosed);
                cmd.Parameters.AddWithValue("@IsDeleted", sp_FinancialYear_Select.IsDeleted);
                cmd.Parameters.AddWithValue("@IsUploaded", sp_FinancialYear_Select.IsUploaded);              
                cmd.Parameters.AddWithValue("@CreatedBy", sp_FinancialYear_Select.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToShortDateString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Delete Financial Year
        public void DeleteFinancialYear(int? id, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_FinancialYear_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FinancialYearPkid", id);
                cmd.Parameters.AddWithValue("@IsDeleted", 1);
                cmd.Parameters.AddWithValue("@IsRecordEdited", 1);
                cmd.Parameters.AddWithValue("@CreatedBy", 1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
