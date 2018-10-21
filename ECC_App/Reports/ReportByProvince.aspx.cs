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
using IOM.ECCMS.ECCDB;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace ECC_App
{
    public partial class ReportByProvince : ECC.BaseController.BaseController
    {
        ReportDocument rep = new ReportDocument();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                showData();
        }

        protected void imgView_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("ComplainList.aspx?Prov_ID=" + ECCCommon.EncryptQueryString(e.CommandArgument.ToString()) + "");     
        }

        private void showData()
        {
            DataTable dt = GetGridData();
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    _gvList.Visible = false;
                }
                else
                {
                    _gvList.DataSource = dt;
                    _gvList.DataBind();
                    _gvList.Visible = true;
                }
            }
            else
            {
                _gvList.Visible = false;
            }
        }

        private DataTable GetGridData()
        {
            DataTable dt = new DataTable();
            try
            {
                Complain _objList = new Complain();
                    dt = _objList.getTotalComplain ();

                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {

            }
            return dt;
        }

        protected void lnkpdf_Click(object sender, EventArgs e)
        {
            try
            {
                rep.Load(Server.MapPath("~//Reports//TotalComplainRpt.rpt"));
                rep.SetDatabaseLogon("sa", "hx3b8");
                rep.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "");
            }
            catch
            {

            }
        }

        protected void lnkExcel_Click(object sender, EventArgs e)
        {
            try
            {
                rep.Load(Server.MapPath("~//Reports//TotalComplainRpt.rpt"));
                rep.SetDatabaseLogon("sa", "hx3b8");
                rep.ExportToHttpResponse(ExportFormatType.Excel , Response, true, "");
            }
            catch
            {

            }
        }
    }
}
