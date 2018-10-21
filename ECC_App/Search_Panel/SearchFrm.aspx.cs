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
    public partial class SearchFrm : ECC.BaseController.BaseController 
    {
        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                _FillCombo();
        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~//EntryForms//ManageComplain.aspx?CaseID=" + ECCCommon.EncryptQueryString(e.CommandArgument.ToString()) + "");
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            ECCMS _objDb = new ECCMS();
            try
            {
                Complain _objRow = new Complain();
                _objRow._Complain_DeleteLogically(e.CommandArgument.ToString());

                showData();
            }
            finally
            {
                _objDb.Dispose();
            }

        }

        protected void imgDetail_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~//EntryForms//ComplainDetail.aspx?CaseID=" + ECCCommon.EncryptQueryString(e.CommandArgument.ToString()) + "");

        }

        protected void _gvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = GetGridData();
            ECCCommon.CustomPaging(ref _gvList, e, dt);
        }

        protected void _gvList_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = GetGridData();
            ECCCommon.CustomSorting(ref _gvList, e, dt);
        }

        private void _FillCombo()
        {
            ECCMS db = new ECCMS();

            try
            {
                DataTable dtProvince = db.lkpProvinceCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpProvince, dtProvince, "ProvNameEng", "ProvId", true);

                DataTable dtBit = db.lkpBitCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpKuchi, dtBit, "BitName", "BitID", true);

                DataTable dtCompType = db.lkpComplainanttypeCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpComplaintType, dtCompType, "Comp_Name", "Comp_TypeID", true);

                DataTable dtRespType = db.lkpRespondanttypeCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpRespondantType, dtRespType, "RespType_Name", "RespType_ID", true);

                DataTable dtRespOffice = db.lkpResponsibleOfficeCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpResponOffice, dtRespOffice, "Resp_OfficeName", "Resp_OfficeID", true);

                DataTable dtSanc = db.lkpSanctionCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpSanctTypr, dtSanc, "SacntionName", "SacntionID", true);

                DataTable dtPro = db.lkpCasepriorityCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpCasePro, dtPro, "caseProName", "caseProID", true);

                DataTable dtStatus = db.lklStatusCollection.GetAsDataTable("Active=1", "StatusID");
                ECCCommon.FillCombo(ref drpStatus, dtStatus, "StatusName", "StatusID", true);

            }
            finally
            {
                db.Dispose();
                db.Close();
            }
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
                    SetCurrentPageIndex(ref _gvList, dt);
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
            ECCMS _objDB = new ECCMS();
            try
            {
                Complain _objList = new Complain();
                string userRight;
                string caseNo,BitName,caseProName,ProvNameEng,Resp_OfficeName,Resp_TypeName,SanctionName,StatusName,Comp_Name;
                userRight = Session["Role"].ToString();

                if (txtCaseNo.Text.Length == 7)
                    txtCaseNo.Text  = "A-10-" + txtCaseNo.Text.ToString().Trim();



                if (txtCaseNo.Text.Trim() != "")
                    caseNo =  txtCaseNo.Text.Trim();
                else
                    caseNo = DBNull.Value.ToString();

                if (drpCasePro.SelectedValue.ToString() != "0")
                    caseProName = drpCasePro.SelectedItem.Text.Trim();
                else
                    caseProName = DBNull.Value.ToString();

                if (drpComplaintType.SelectedValue.ToString() != "0")
                    Comp_Name = drpComplaintType.SelectedItem.Text;
                else
                    Comp_Name = DBNull.Value.ToString();

                if (drpKuchi.SelectedValue.ToString() != "0")
                    BitName = drpKuchi.SelectedItem.Text;
                else
                    BitName = DBNull.Value.ToString();

                if (drpProvince.SelectedValue.ToString() != "0")
                    ProvNameEng = drpProvince.SelectedItem.Text;
                else
                    ProvNameEng = DBNull.Value.ToString();

                if (drpRespondantType.SelectedValue.ToString() != "0")
                    Resp_TypeName = drpRespondantType.SelectedItem.Text;
                else
                    Resp_TypeName = DBNull.Value.ToString();

                if (drpResponOffice.SelectedValue.ToString() != "0")
                    Resp_OfficeName = drpResponOffice.SelectedItem.Text;
                else
                    Resp_OfficeName = DBNull.Value.ToString();

                if (drpSanctTypr.SelectedValue.ToString() != "0")
                    SanctionName = drpSanctTypr.SelectedItem.Text;
                else
                    SanctionName = DBNull.Value.ToString();

                if (drpStatus.SelectedValue.ToString() != "0")
                    StatusName = drpStatus.SelectedItem.Text;
                else
                    StatusName = DBNull.Value.ToString();

                if (userRight == "Administrator")
                {
                    dt = _objList.getAdmin_Search(caseNo, BitName, caseProName, ProvNameEng, Resp_OfficeName, Resp_TypeName, SanctionName, StatusName, Comp_Name);
                }
                else
                {
                    dt = _objList.getUser_Search(caseNo, BitName, caseProName, ProvNameEng, Resp_OfficeName, Resp_TypeName, SanctionName, StatusName, Comp_Name,UserId );
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
                _objDB.Dispose();
            }
            return dt;
        }
        private void SetCurrentPageIndex(ref GridView _gvList, DataTable dt)
        {
            if (_gvList.SelectedIndex == _gvList.PageCount - 1 && (dt.Rows.Count % _gvList.PageSize) < 1 && _gvList.SelectedIndex != 0)
            {
                _gvList.SelectedIndex = _gvList.SelectedIndex - 1;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            showData();
        }

    }
}
