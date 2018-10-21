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
using CrystalDecisions.Enterprise;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ReportConnection;
using IOM.ECCMS.ECCDB; 

namespace ECC_App
{
    public partial class _PECC_Decision : ECC.BaseController.BaseController 
    {
        ReportDocument rep = new ReportDocument();
        ReportCon _Rept = new ReportCon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _FillComboData();
                showData();
            }
        }



        #region Functions
        private void _FillComboData()
        {
            ECCMS db = new ECCMS();

            try
            {
                DataTable dtProvince = db.lkpProvinceCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpProvince, dtProvince, "ProvNameEng", "ProvId", true);
            }
            finally
            {
                db.Dispose();
                db.Close();
            }
        }

        private void showData()
        {
            DataTable dt = GetGridData(Convert.ToInt32(drpProvince.SelectedValue ));
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    _gvList.Visible = false;
                }
                else
                {
                    SetCurrentPageIndex(ref _gvList, dt);
                    _gvList.Visible = true;
                }
            }
            else
            {
                _gvList.Visible = false;
            }
        }

        private DataTable GetGridData(int ProvID)
        {
            DataTable dt = new DataTable();
            try
            {
                Complain _objList = new Complain();
                        dt = _objList.get_PECCRpt (ProvID );
                if (dt.Rows.Count == 0)
                    lblNoDataMsg.Text = ECCCommon.objCached.NoRecordExists;
                else
                    lblNoDataMsg.Text = "";
                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {

            }
            return dt;
        }

        #endregion

        private void SetCurrentPageIndex(ref GridView _gvList, DataTable dt)
        {
            if (_gvList.SelectedIndex == _gvList.PageCount - 1 && (dt.Rows.Count % _gvList.PageSize) < 1 && _gvList.SelectedIndex != 0)
            {
                _gvList.SelectedIndex = _gvList.SelectedIndex - 1;
            }
        }

        protected void _gvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void _gvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = GetGridData(Convert.ToInt32(drpProvince.SelectedValue ));
            ECCCommon.CustomPaging(ref _gvList, e, dt);
        }

        protected void _gvList_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = GetGridData(Convert.ToInt32(drpProvince.SelectedValue));
            ECCCommon.CustomSorting(ref _gvList, e, dt);
        }



        protected void lnkPDF_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    rep.Load(Server.MapPath("~\\Reports\\_PECC_DecisionRPT.rpt"));
                    rep.SetDatabaseLogon(_Rept.DatabaseUserName, _Rept.DatabasePassword);
                    rep.SetParameterValue(0, drpProvince.SelectedValue);
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
                    rep.Load(Server.MapPath("~\\Reports\\_PECC_DecisionRPT.rpt"));
                    rep.SetDatabaseLogon(_Rept.DatabaseUserName, _Rept.DatabasePassword);
                    rep.SetParameterValue(0, drpProvince.SelectedValue);
                    rep.ExportToHttpResponse(ExportFormatType.Excel, Response, true, "");
                }
            }
            catch
            {

            }
        }

        protected void drpProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }
    }
}
