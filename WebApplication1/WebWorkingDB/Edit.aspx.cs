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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int pId = Convert.ToInt32(Request["pid"].ToString());
                lblId.Text = pId.ToString();
                //lblId.Text = Request.Params["pid"];
                //txtName.Text = Request.Params["name"];
                string pName = Request["name"];
                txtName.Text = pName;
                // lay du lieu tu pid
                txtPrice.Text = Database.getProductById(pId.ToString()).Rows[0]["UnitPrice"].ToString();


                ddlDanhMuc.DataSource = Database.getAllcategories();
                ddlDanhMuc.DataTextField = "CategoryName";
                ddlDanhMuc.DataValueField = "CategoryID";
                ddlDanhMuc.DataBind();
                ddlDanhMuc.SelectedValue = Database.getProductById(pId.ToString()).Rows[0]["CategoryID"].ToString();
                bool status = Convert.ToBoolean(Database.getProductById(pId.ToString()).Rows[0]["Discontinued"].ToString());
                if (status)
                {
                    cbconhang.Checked = true;
                }
                else
                {
                    cbconhang.Checked = false;
                }
                Label1.Text = check().ToString() + " " + txtName.Text + " " + txtPrice.Text + " " + ddlDanhMuc.SelectedValue + " " + lblId.Text;
            }
        }
        public bool check()
        {
            if (cbconhang.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Database.Edit(txtName.Text, lblId.Text);
            Database.Edit(txtName.Text, txtPrice.Text, ddlDanhMuc.SelectedValue.ToString(), check().ToString(), lblId.Text);
            Response.Redirect("Index.aspx");

        }
    }
}