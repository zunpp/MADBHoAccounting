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
    public class TrialBalanceDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";
        
        public IEnumerable<TrialBalance> GetTriBalanceList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_TriBalance_SelectByDate", con);
                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                //cmd.Parameters.AddWithValue("@GroupID", gpID);
                if(tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                //cmd.Parameters.AddWithValue("@TownshipCode", tID);
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }
               
                //cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                cmd.Parameters.AddWithValue("@StartDate", sDate);
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    //tb.AccountPkid = Convert.ToInt32(dr["AccountID"].ToString());
                    //tb.AccountMainTitleCode = dr["AccountCode"].ToString();
                    tb.MainHead = dr["MainHead"].ToString();
                    tb.DebitAmount = Convert.ToDecimal(dr["Debit"].ToString());
                    tb.CreditAmount = Convert.ToDecimal(dr["Credit"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetDayBookList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DayBook_SelectByDate", con);
                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                //cmd.Parameters.AddWithValue("@GroupID", gpID);
                if (tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                //cmd.Parameters.AddWithValue("@TownshipCode", tID);
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }
                //cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                cmd.Parameters.AddWithValue("@StartDate", sDate);
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    //tb.AccountPkid = Convert.ToInt32(dr["AccountID"].ToString());
                    //tb.AccountMainTitleCode = dr["AccountCode"].ToString();
                    tb.MainHead = dr["MainHead"].ToString();
                    tb.DebitAmount = Convert.ToDecimal(dr["Debit"].ToString());
                    tb.CreditAmount = Convert.ToDecimal(dr["Credit"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetIncomeList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Income_SelectByDate", con);
                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                //cmd.Parameters.AddWithValue("@GroupID", gpID);
                if (tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                //cmd.Parameters.AddWithValue("@TownshipCode", tID);
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }
                //cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                //cmd.Parameters.AddWithValue("@StartDate", sDate);
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                //cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    //tb.AccountPkid = Convert.ToInt32(dr["AccountID"].ToString());
                    //tb.AccountMainTitleCode = dr["AccountCode"].ToString();
                    tb.SubsiHead = dr["SubsiHead"].ToString();
                    tb.DuringMonth = Convert.ToDecimal(dr["DuringMonth"].ToString());
                    tb.EndOfMonth = Convert.ToDecimal(dr["EndOfMonth"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetExpenditureList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Expendicture_SelectByDate", con);
                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                //cmd.Parameters.AddWithValue("@GroupID", gpID);
                if (tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                //cmd.Parameters.AddWithValue("@TownshipCode", tID);
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }
                //cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                //cmd.Parameters.AddWithValue("@StartDate", sDate);
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                //cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    //tb.AccountPkid = Convert.ToInt32(dr["AccountID"].ToString());
                    //tb.AccountMainTitleCode = dr["AccountCode"].ToString();
                    tb.SubsiHead = dr["SubsiHead"].ToString();
                    tb.DuringMonth = Convert.ToDecimal(dr["DuringMonth"].ToString());
                    tb.EndOfMonth = Convert.ToDecimal(dr["EndOfMonth"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetIncomeProgressiveList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Expendicture_SelectByDate", con);
                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                //cmd.Parameters.AddWithValue("@GroupID", gpID);
                if (tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                //cmd.Parameters.AddWithValue("@TownshipCode", tID);
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }
                //cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                //cmd.Parameters.AddWithValue("@StartDate", sDate);
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                //cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    //tb.AccountPkid = Convert.ToInt32(dr["AccountID"].ToString());
                    //tb.AccountMainTitleCode = dr["AccountCode"].ToString();
                    tb.SubsiHead = dr["SubsiHead"].ToString();
                    tb.DuringMonth = Convert.ToDecimal(dr["DuringMonth"].ToString());
                    tb.EndOfMonth = Convert.ToDecimal(dr["EndOfMonth"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }
    }
}
