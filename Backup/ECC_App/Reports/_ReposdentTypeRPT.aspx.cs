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
using CrystalDecisions.Enterprise;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ReportConnection;


namespace ECC_App
{
    public partial class _ReposdentTypeRPT : ECC.BaseController.BaseController 
    {
        ReportDocument rep = new ReportDocument();
        ReportCon _Rept = new ReportCon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                showData();
        }



        private void showData()
        {
            DataTable dt = GetGridData();
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    _gvReport.Visible = false;
                }
                else
                {
                    _gvReport.Visible = true;
                }
            }
            else
            {
                _gvReport.Visible = false;
            }
        }

        private DataTable GetGridData()
        {
            DataTable dt = new DataTable();
            try
            {
                Complain _objList = new Complain();
                dt = _objList.getStaticReport_Respond  ();

                if (dt.Rows.Count == 0)
                    lblNoDataMsg.Text = ECCCommon.objCached.NoRecordExists;
                else
                    lblNoDataMsg.Text = "";

                _gvReport.DataSource = dt;
                _gvReport.DataBind();
            }
            finally
            {

            }
            return dt;
        }



        protected void lnkPDF_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    rep.Load(Server.MapPath("~\\Reports\\_RespondentTypeReport.rpt"));
                    rep.SetDatabaseLogon(_Rept.DatabaseUserName, _Rept.DatabasePassword);
                    rep.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "");
                }
            }
            catch
            {

            }
        }

        protected void lnkExcel_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    rep.Load(Server.MapPath("~\\Reports\\_RespondentTypeReport.rpt"));
                    rep.SetDatabaseLogon(_Rept.DatabaseUserName, _Rept.DatabasePassword);
                    rep.ExportToHttpResponse(ExportFormatType.Excel, Response, true, "");
                }
            }
            catch
            {

            }
        }
    }
}
