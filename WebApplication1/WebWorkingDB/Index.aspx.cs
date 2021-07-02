using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWorkingDB.DAO;

namespace WebWorkingDB
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HorizontalAlign right = HorizontalAlign.Right;
            if (!Page.IsPostBack)
            {
                ddlCategory.DataSource = null;
                ddlCategory.DataSource = Database.getAllcategories();
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryID";
                ddlCategory.DataBind();
                //string[] url = { "ProductID" };

                //ddlCategory.Items.Insert(0, new ListItem("-- all --", "0"));
                //
                //Label2.Text = ddlCategory.SelectedValue.ToString();
                // Fill du lieu tu get all

                gvProduct.DataSource = Database.getProductByCateID(ddlCategory.SelectedValue.ToString());
                gvProduct.DataBind();

                // yeu cau bo sung 2 cot edit va delete su dung hyper link field 
                // voi link edit tren tung dong du lieu -> url Edit.aspx?pid=1
                // voi link delete tren tung dung du lieu -> url: Delete.aspx?pid=1 Dieu huong ve Index.aspx

            }

        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            // lay value dang chonj (categoryID) tu ddlCategory
            Label2.Text = ddlCategory.SelectedValue;
            // sau do Fill lai
            gvProduct.DataSource = Database.getProductByCateID(ddlCategory.SelectedValue.ToString());
            gvProduct.DataBind();
        }
    }
}