
using MADBHoAccounting.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class UserLoginDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        // Get All Financial Year List
        public IEnumerable<TbUserLogin> GetAllUser(string connectionString)
        {
            List<TbUserLogin> user = new List<TbUserLogin>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_UserLogin_SelectByUsername", con);
                cmd.Parameters.AddWithValue("@userName", "admin");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TbUserLogin userLogin = new TbUserLogin();

                    userLogin.UserPkid = Convert.ToInt32(dr["UserPkid"].ToString());
                    userLogin.UsernameOrEmail = dr["UsernameOrEmail"].ToString();
                    userLogin.Password = dr["Password"].ToString();
                    userLogin.AccountType = dr["AccountType"].ToString();
                    userLogin.Department = dr["Department"].ToString();
                    userLogin.Status = dr["Status"].ToString();
                    //userLogin.LoginDate = Convert.ToDateTime(dr["LoginDate"].ToString());
                    //userLogin.LogoutDate = Convert.ToDateTime(dr["LogoutDate"].ToString());
                    //userLogin.PCName = dr["PCName"].ToString();
                    userLogin.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"].ToString());
                    userLogin.CreatedBy = dr["CreatedBy"].ToString();
                    userLogin.CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString());                
                    

                    user.Add(userLogin);
                }
                con.Close();
            }
            return user;
        }
    }
}
