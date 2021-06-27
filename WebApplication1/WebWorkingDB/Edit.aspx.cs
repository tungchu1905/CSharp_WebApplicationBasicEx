using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWorkingDB.DAO;

namespace WebWorkingDB
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblId.Text =  Request.Params["pid"]; 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!(txtName.Text.Equals("") || txtPrice.Text.Equals("")))
            {
                Database.Edit(txtName.Text, txtPrice.Text, lblId.Text);
                Response.Redirect("Index.aspx");
            }
            


        }
    }
}