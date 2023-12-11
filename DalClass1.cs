using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;
using System.Data.SqlClient;

namespace Dal
{
    public class DalClass1
    {

        public DataTable GetStatesByCountry(int countryID)
        {
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=First_Ex;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand("GetStatesByCountry", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CountryID", countryID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable GetCityByStates(int stateID)
        {
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=First_Ex;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand("GetCItyByStates", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StateID", stateID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

    }
}
