using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Modal;
using Bal;
using System.Data.SqlClient;

namespace DropdownBindData
{
    public partial class DropDownForm : System.Web.UI.Page
    {
        ModalClass1 modal = new ModalClass1();
        BalClass1 bal = new BalClass1();

       protected void Page_Load(object sender, EventArgs e)
        {
        

            if(!IsPostBack)
            {
                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;
                //Bind Country
                string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=First_Ex;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand("SPCountry", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                DataTable dt = new DataTable();

                da.Fill(ds);
                dt = ds.Tables[0];
                
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "CountryID";
                DropDownList1.DataTextField = "CountryName";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "Select");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bind State
            DropDownList2.Enabled = true;

            int countryID = Convert.ToInt32(DropDownList1.SelectedValue);
            DataTable dt = new DataTable();
            dt = bal.GetStatesByCountry(countryID);

            DropDownList2.DataSource = dt;
            DropDownList2.DataValueField = "StateID";
            DropDownList2.DataTextField = "StateName";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "Select");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int statesID = Convert.ToInt32(DropDownList2.SelectedValue);
            DataTable dt = new DataTable();
            dt = bal.GetCityByStates(statesID);

            DropDownList3.Enabled = true;
            DropDownList3.DataSource = dt;
            DropDownList3.DataValueField = "CityID";
            DropDownList3.DataTextField = "CityName";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "Select");
        }
          

    }


}
