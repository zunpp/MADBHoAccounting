using MADBHoAccounting.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.StoredProcedures
{
    public class DepartmentDAL
    {
        //string connectionString = "Server=localhost; DataBase=MADBHoAccounting_Online; User id=madbadmin; Password=@dmin123; trusted_connection=true;encrypt=false; MultipleActiveResultSets=true";

        // Get All Financial Year List
        public IEnumerable<TbDepartment> GetAllDepartment(string connectionString)
        {
            List<TbDepartment> Dept = new List<TbDepartment>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Department_Select", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TbDepartment dept = new TbDepartment();

                    dept.DepartmentPkid = Convert.ToInt32(dr["DepartmentPkid"].ToString());
                    dept.DepartmentCode = dr["DepartmentCode"].ToString();
                    dept.Department = dr["Department"].ToString();
                    

                    Dept.Add(dept);
                }
                con.Close();
            }
            return Dept;
        }
    }
}
