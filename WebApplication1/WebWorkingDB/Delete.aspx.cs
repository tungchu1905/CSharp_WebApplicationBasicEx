﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWorkingDB.DAO;

namespace WebWorkingDB
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           

            DataTable da = Database.getOrderDetail(Request.Params["pid"]);
            //if (da.Rows.Count > 0)
            //{

            //}
            //else
            //{
            //Database.DeleteOrderDetail(Request.Params["pid"]);
            Database.DeleteProduct(Request.Params["pid"]);
            //}

            Response.Redirect("Index.aspx");

        }
    }
}