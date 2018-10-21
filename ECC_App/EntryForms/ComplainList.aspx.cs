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

namespace ECC_App
{
    public partial class ComplainList : ECC.BaseController.BaseController 
    {

        #region Properties
        private Int32 Prov_ID
        {
            get
            {
                if (Request.QueryString["Prov_ID"] != null) 
                    return Convert.ToInt32(ECCCommon.DecryptQueryString(Request.QueryString["Prov_ID"].ToString()));
                return 0;
            }
        }
        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty;
            }
        }
        #endregion 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.User.IsInRole("SuperUser"))
                {
                    Session["ErrorMsg"] = "You are not authorized to view this page";
                    Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
                }
                //if (!this.User.IsInRole("Administrator"))
                //{
                //    pnlSearch.Visible = false;
                //}

                if (Prov_ID != 0)
                    showData(Prov_ID);
                else
                {
                    _FillComboData();
                    showData(Convert.ToInt32(drpProvince.SelectedValue));
                }
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

        private void showData(int Prov_ID)
        {
            DataTable dt = GetGridData(Prov_ID);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    _gvList.Visible = false;
                }
                else
                {
                    SetCurrentPageIndex(ref _gvList , dt);
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
                Complain _objList = new Complain ();
                string userRight;
                userRight = Session["Role"].ToString();
                if (userRight == "Administrator")
                {
                    if (ProvID == 35 || ProvID == 0)
                        dt = _objList.getComplainList();

                    else
                        dt = _objList.getComplainListByProv(ProvID);
                }
                else
                {
                    if (ProvID == 35 || ProvID == 0)
                        dt = _objList.getComplainListbyUser (UserId);

                    else
                        dt = _objList.getComplainListByUser_rov(ProvID,UserId );
                }
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

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("ManageComplain.aspx?CaseID=" + ECCCommon.EncryptQueryString(e.CommandArgument.ToString()) + "");     
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            ECCMS _objDb = new ECCMS();
            try
            {
                Complain _objRow = new Complain();
                _objRow._Complain_DeleteLogically(e.CommandArgument.ToString());

                showData(Prov_ID );
            }
            finally 
            {
                _objDb.Dispose();
            }

        }

        protected void imgDetail_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("ComplainDetail.aspx?CaseID=" + ECCCommon.EncryptQueryString(e.CommandArgument.ToString()) + "");     

        }

        protected void drpProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData(Convert.ToInt32(drpProvince.SelectedValue));
        }

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
            DataTable dt = GetGridData(Convert.ToInt32( drpProvince.SelectedValue) );
            ECCCommon.CustomPaging(ref _gvList, e, dt);
        }

        protected void _gvList_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = GetGridData(Convert.ToInt32(drpProvince.SelectedValue ));
            ECCCommon.CustomSorting(ref _gvList, e, dt);
        }
    }
}
