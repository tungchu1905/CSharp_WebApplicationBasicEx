using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        // Event handle: Page
        protected void Page_Load(object sender, EventArgs e)
        {
            lbMessage.Text += "2-5. Su kien LOAD trang, khi co request tu client voi IsPostBack == True.<br/>";
            if (!Page.IsPostBack)
            lbMessage.Text += "3. Su kien LOAD trang, khi co request tu client voi IsPostBack == False.<br/>";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lbMessage.Text += "1. Su kien INIT xuat hien khi trang khoi tao<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            lbMessage.Text += "4-7. Su kien PRERENDER xuat hien khi  <br/><br/>";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            lbMessage.Text += "6. su kien sinh ra khi click vao Button <br/>";
        }
    }
}