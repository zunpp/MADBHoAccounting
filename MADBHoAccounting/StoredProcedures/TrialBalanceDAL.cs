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
                    tb.Debit = Convert.ToDecimal(dr["Debit"].ToString());
                    tb.Credit = Convert.ToDecimal(dr["Credit"].ToString());

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
                    tb.Debit = Convert.ToDecimal(dr["Debit"].ToString());
                    tb.Credit = Convert.ToDecimal(dr["Credit"].ToString());

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

        public IEnumerable<IncomeProgressive> GetIncomeProgressiveList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<IncomeProgressive> accNameList = new List<IncomeProgressive>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_IncomeProgressive_Select", con);
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
                    IncomeProgressive tb = new IncomeProgressive();

                    tb.DivisionCode = dr["DivisionCode"].ToString();
                    tb.DiviSionName = dr["DiviSionName"].ToString();
                    tb.TownOrderCode = dr["TownOrderCode"].ToString();
                    tb.TownName = dr["TownName"].ToString();
                    tb.Int_SLC = Convert.ToDecimal(dr["Int_SLC"].ToString());
                    tb.Int_STL = Convert.ToDecimal(dr["Int_STL"].ToString());
                    tb.Int_LTL = Convert.ToDecimal(dr["Int_LTL"].ToString());
                    tb.Int_Overdraft = Convert.ToDecimal(dr["Int_Overdraft"].ToString());
                    tb.Int_LSL = Convert.ToDecimal(dr["Int_LSL"].ToString());
                    tb.Int_LTRS = Convert.ToDecimal(dr["Int_LTRS"].ToString());
                    tb.Int_LRS_LTL_JICA = Convert.ToDecimal(dr["Int_LRS_LTL_JICA"].ToString());
                    tb.Int_LRS_STL_JICA = Convert.ToDecimal(dr["Int_LRS_STL_JICA"].ToString());
                    tb.Int_MEB_LTL = Convert.ToDecimal(dr["Int_MEB_LTL"].ToString());
                    tb.Int_MEB_STL = Convert.ToDecimal(dr["Int_MEB_STL"].ToString());
                    tb.PenInt_SLC = Convert.ToDecimal(dr["PenInt_SLC"].ToString());
                    tb.PenInt_ST = Convert.ToDecimal(dr["PenInt_ST"].ToString());
                    tb.PenInt_LT = Convert.ToDecimal(dr["PenInt_LT"].ToString());
                    tb.PenInt_LS = Convert.ToDecimal(dr["PenInt_LS"].ToString());
                    tb.PenIntLTRS = Convert.ToDecimal(dr["PenIntLTRS"].ToString());
                    tb.PenInt_LRS_LTL_JICA = Convert.ToDecimal(dr["PenInt_LRS_LTL_JICA"].ToString());
                    tb.PenInt_LRS_STL_JICA = Convert.ToDecimal(dr["PenInt_LRS_STL_JICA"].ToString());
                    tb.PenInt_LRS_LTL_MEB = Convert.ToDecimal(dr["PenInt_LRS_LTL_MEB"].ToString());
                    tb.PenInt_LRS_STL_MEB = Convert.ToDecimal(dr["PenInt_LRS_STL_MEB"].ToString());
                    tb.Misc = Convert.ToDecimal(dr["Misc"].ToString());
                    tb.FeeAndCommission = Convert.ToDecimal(dr["FeeAndCommission"].ToString());
                    tb.Int_Covid19 = Convert.ToDecimal(dr["Int_Covid19"].ToString());
                    tb.PenInt_Covid19 = Convert.ToDecimal(dr["PenInt_Covid19"].ToString());



                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<ExpenditureProgressive> GetExpenditureProgressiveList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<ExpenditureProgressive> accNameList = new List<ExpenditureProgressive>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ExpenditureProgressive_Select", con);
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
                    ExpenditureProgressive tb = new ExpenditureProgressive();

                    tb.DivisionCode = dr["DivisionCode"].ToString();
                    tb.DiviSionName = dr["DiviSionName"].ToString();
                    tb.TownOrderCode = dr["TownOrderCode"].ToString();
                    tb.TownName = dr["TownName"].ToString();
                    tb.PayAllwance = Convert.ToDecimal(dr["PayAllwance"].ToString());
                    tb.Wages = Convert.ToDecimal(dr["Wages"].ToString());
                    tb.A_Cleaning = Convert.ToDecimal(dr["A_Cleaning"].ToString());
                    tb.B_DWOffice = Convert.ToDecimal(dr["B_DWOffice"].ToString());
                    tb.C_Wages1Persentage = Convert.ToDecimal(dr["C_Wages1Persentage"].ToString());
                    tb.D_Other = Convert.ToDecimal(dr["D_Other"].ToString());
                    tb.Pension = Convert.ToDecimal(dr["Pension"].ToString());
                    tb.TA = Convert.ToDecimal(dr["TA"].ToString());
                    tb.Entertainment = Convert.ToDecimal(dr["Entertainment"].ToString());
                    tb.PTT = Convert.ToDecimal(dr["PTT"].ToString());
                    tb.LightingPower = Convert.ToDecimal(dr["LightingPower"].ToString());
                    tb.RBC = Convert.ToDecimal(dr["RBC"].ToString());
                    tb.RBCMEB = Convert.ToDecimal(dr["RBCMEB"].ToString());
                    tb.RBCJICA = Convert.ToDecimal(dr["RBCJICA"].ToString());
                    tb.Newspaper = Convert.ToDecimal(dr["Newspaper"].ToString());
                    tb.UniformAllwance = Convert.ToDecimal(dr["UniformAllwance"].ToString());
                    tb.T_and_H = Convert.ToDecimal(dr["T_and_H"].ToString());
                    tb.T_and_H_MEB = Convert.ToDecimal(dr["T_and_H_MEB"].ToString());
                    tb.T_and_H_Jica = Convert.ToDecimal(dr["T_and_H_Jica"].ToString());
                    tb.VehicleRExpense = Convert.ToDecimal(dr["VehicleRExpense"].ToString());
                    tb.VRE_JICA = Convert.ToDecimal(dr["VRE_JICA"].ToString());
                    tb.OfficeSupplies = Convert.ToDecimal(dr["OfficeSupplies"].ToString());
                    tb.OfficeSuppliesMEB = Convert.ToDecimal(dr["OfficeSuppliesMEB"].ToString());
                    tb.OfficeSuppliesJICA = Convert.ToDecimal(dr["OfficeSuppliesJICA"].ToString());
                    tb.P_S = Convert.ToDecimal(dr["P_S"].ToString());
                    tb.P_S_MEB = Convert.ToDecimal(dr["P_S_MEB"].ToString());
                    tb.P_S_Jica = Convert.ToDecimal(dr["P_S_Jica"].ToString());
                    tb.PatrolOilLubri = Convert.ToDecimal(dr["PatrolOilLubri"].ToString());
                    tb.Rent = Convert.ToDecimal(dr["Rent"].ToString());
                    tb.RateTaxs = Convert.ToDecimal(dr["RateTaxs"].ToString());
                    tb.TrainingExpense = Convert.ToDecimal(dr["TrainingExpense"].ToString());
                    tb.TrainingMEB = Convert.ToDecimal(dr["TrainingMEB"].ToString());
                    tb.TrainingJICA = Convert.ToDecimal(dr["TrainingJICA"].ToString());
                    tb.IntOnMEB = Convert.ToDecimal(dr["IntOnMEB"].ToString());
                    tb.IntOnMEB_JICA = Convert.ToDecimal(dr["IntOnMEB_JICA"].ToString());
                    tb.IntOnRSD = Convert.ToDecimal(dr["IntOnRSD"].ToString());
                    tb.IntOnResidentSavingDeposit = Convert.ToDecimal(dr["IntOnResidentSavingDeposit"].ToString());
                    tb.Insurance = Convert.ToDecimal(dr["Insurance"].ToString());
                    tb.ExhibitionExpense = Convert.ToDecimal(dr["ExhibitionExpense"].ToString());
                    tb.ExhibitionMEB = Convert.ToDecimal(dr["ExhibitionMEB"].ToString());
                    tb.ExhibitionJica = Convert.ToDecimal(dr["ExhibitionJica"].ToString());
                    tb.MOfficeBuilding = Convert.ToDecimal(dr["MOfficeBuilding"].ToString());
                    tb.MOfficeVehicle = Convert.ToDecimal(dr["MOfficeVehicle"].ToString());
                    tb.MOfficeEquipment = Convert.ToDecimal(dr["MOfficeEquipment"].ToString());
                    tb.MFurnitureOther = Convert.ToDecimal(dr["MFurnitureOther"].ToString());
                    tb.DEOfficeBuilding = Convert.ToDecimal(dr["DEOfficeBuilding"].ToString());
                    tb.DEOfficeVehicle = Convert.ToDecimal(dr["DEOfficeVehicle"].ToString());
                    tb.DEOfficeEquipment = Convert.ToDecimal(dr["DEOfficeEquipment"].ToString());
                    tb.DEFurEquipment = Convert.ToDecimal(dr["DEFurEquipment"].ToString());
                    tb.OfficeBuildingJICA = Convert.ToDecimal(dr["OfficeBuildingJICA"].ToString());
                    tb.OfficeVehicleJICA = Convert.ToDecimal(dr["OfficeVehicleJICA"].ToString());
                    tb.OfficeEquipmentJICA = Convert.ToDecimal(dr["OfficeEquipmentJICA"].ToString());
                    tb.FurnitureAndOtherJICA = Convert.ToDecimal(dr["FurnitureAndOtherJICA"].ToString());
                    tb.Advertisement = Convert.ToDecimal(dr["Advertisement"].ToString());
                    tb.TA_JICA = Convert.ToDecimal(dr["TA_JICA"].ToString());
                    tb.Advertisement_JICA = Convert.ToDecimal(dr["Advertisement_JICA"].ToString());
                    tb.TA_MEB = Convert.ToDecimal(dr["TA_MEB"].ToString());
                    tb.BankingSoftwareOther = Convert.ToDecimal(dr["BankingSoftwareOther"].ToString());
                    tb.VehicleRentalExpenseMEB = Convert.ToDecimal(dr["VehicleRentalExpenseMEB"].ToString());
                    tb.Fireprevention = Convert.ToDecimal(dr["Fireprevention"].ToString());
                    tb.OtherGeneral = Convert.ToDecimal(dr["OtherGeneral"].ToString());
                    tb.RBC_Covid19 = Convert.ToDecimal(dr["RBC_Covid19"].ToString());
                    tb.MealAllowance = Convert.ToDecimal(dr["MealAllowance"].ToString());
                    tb.TravellingCovid19 = Convert.ToDecimal(dr["TravellingCovid19"].ToString());
                    tb.OfficeSuppliesCovid19 = Convert.ToDecimal(dr["OfficeSuppliesCovid19"].ToString());
                    tb.P_S_Covid19 = Convert.ToDecimal(dr["P_S_Covid19"].ToString());
                    tb.T_and_H_Covid19 = Convert.ToDecimal(dr["T_and_H_Covid19"].ToString());
                    tb.SpecialAllowance = Convert.ToDecimal(dr["SpecialAllowance"].ToString());
                    tb.Accommodation = Convert.ToDecimal(dr["Accommodation"].ToString());
                    tb.RBCSunflower = Convert.ToDecimal(dr["RBCSunflower"].ToString());
                    tb.P_S_Sunflower = Convert.ToDecimal(dr["P_S_Sunflower"].ToString());
                    tb.OfficeSuppliesSunflower = Convert.ToDecimal(dr["OfficeSuppliesSunflower"].ToString());
                    tb.T_and_H_Sunflower = Convert.ToDecimal(dr["T_and_H_Sunflower"].ToString());
                    tb.TASunflower = Convert.ToDecimal(dr["TASunflower"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetMonthReturnList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_MonthReturn_SelectByDate", con);
                
                if (tID == null)
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TownshipCode", tID);
                }
                
                cmd.Parameters.AddWithValue("@EndDate", eDate);
                //cmd.Parameters.AddWithValue("@con", rdVal);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();
                    
                    tb.AccountCode = dr["AccountCode"].ToString();
                    tb.SubsiHead = dr["SubsiHead"].ToString();
                    tb.Debit = Convert.ToDecimal(dr["Debit"].ToString());
                    tb.Credit = Convert.ToDecimal(dr["Credit"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetMainHeadProgressiveList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string mainhead, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_TownAndAccountBalance", con);

                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }

                cmd.Parameters.AddWithValue("@EndDate", eDate);
                cmd.Parameters.AddWithValue("@MainHead", mainhead);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    tb.TownName = dr["TownName"].ToString();
                    tb.Balance = Convert.ToDecimal(dr["Balance"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }

        public IEnumerable<TrialBalance> GetSubsiHeadProgressiveList(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate, string subsiheadname, string connectionString)
        {
            List<TrialBalance> accNameList = new List<TrialBalance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_TownAndAccountSubsiBalance", con);

                if (gpID == null)
                {
                    cmd.Parameters.AddWithValue("@GroupID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupID", gpID);
                }
                if (sdID == null)
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StateDivisionCode", sdID);
                }

                cmd.Parameters.AddWithValue("@EndDate", eDate);
                cmd.Parameters.AddWithValue("@SubsiHead", subsiheadname);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TrialBalance tb = new TrialBalance();

                    tb.TownName = dr["TownName"].ToString();
                    tb.Balance = Convert.ToDecimal(dr["Balance"].ToString());

                    accNameList.Add(tb);
                }
                con.Close();
            }
            return accNameList;
        }
    }
}
