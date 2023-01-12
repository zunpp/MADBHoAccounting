using MADBHoAccounting.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class AccountSubTitleSelectDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        public AccountTitle GetAllAccTitle(string subTile, string connectionString)
        {
            //List<AccountTitle> accSubList = new List<AccountTitle>();
            AccountTitle accSubList = new AccountTitle();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AccountTitle_Select", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccSubTitle", subTile);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //AccountTitle at = new AccountTitle();

                    accSubList.AccountMainTitleCode = dr["AccountMainTitleCode"].ToString();
                    accSubList.AccountSubItemPkid = Convert.ToInt32(dr["AccountSubItemPkid"].ToString());
                    accSubList.AccountSubTitleCode = dr["AccountSubTitleCode"].ToString();
                    accSubList.AccountMainTitleInEnglish = dr["AccountMainTitleInEnglish"].ToString();                    
                    accSubList.AccountSubTitleInEnglish = dr["AccountSubTitleInEnglish"].ToString();
                    //accSubList.AccountMainTitleInMyanmar = dr["AccountMainTitleInMyanmar"].ToString();
                    accSubList.AccountSubTitleInMyanmar = dr["AccountSubTitleInMyanmar"].ToString();
                    //accSubList.AccountNature = dr["AccountNature"].ToString();
                    //accSubList.TownshipId = dr["TownshipId"].ToString();
                    //accSubList.StateDivisionId = dr["StateDivisionId"].ToString();
                    //accSubList.IsUsable = Convert.ToBoolean(dr["IsUsable"].ToString());
                    //accSubList.MainTitleDeleted = Convert.ToBoolean(dr["MainTitleDeleted"].ToString());
                    //accSubList.MainIsUploaded = Convert.ToBoolean(dr["MainIsUploaded"].ToString());
                    //accSubList.SubTitleDeleted = Convert.ToBoolean(dr["SubTitleDeleted"].ToString());
                    //accSubList.SubTitleUploaded = Convert.ToBoolean(dr["SubTitleUploaded"].ToString());
                    //accSubList.CreatedBy = 1;
                    //accSubList.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
                }
                con.Close();
            }
            return accSubList;
        }

    }
}
