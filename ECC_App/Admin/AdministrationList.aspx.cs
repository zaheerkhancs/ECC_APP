using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ECC_App
{
    public partial class AdministrationList : ECC.BaseController.BaseController 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.User.IsInRole("Administrator"))
            {
                Session["ErrorMsg"] = "You are not authorized to view this page";
                Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
            }
        }

        protected void lnkManageUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Admin\\ManageUsers.aspx");
        }

        protected void lnkChangeStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Admin\\ManageLocked.aspx");
        }

        protected void lnkCase_Proirity_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Lookups\\Case_Priorty.aspx");
        }

        
    }
}
