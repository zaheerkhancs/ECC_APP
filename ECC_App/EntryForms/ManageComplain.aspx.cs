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
using System.IO;

namespace ECC_App
{
    public partial class ManageComplain : ECC.BaseController.BaseController 
    {
        string _Case_ID,_CaseNO;
        private String strstatus = "";
        protected System.Web.UI.WebControls.DataGrid DataGrid1;
        private String CaseID
        {
            get
            {
                if (Request.QueryString["CaseID"] != null) 
                    return (ECCCommon.DecryptQueryString(Request.QueryString["CaseID"].ToString()));
                return "";
            }
        }

        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty ;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.User.IsInRole("SuperUser"))
            {
                Session["ErrorMsg"] = "You are not authorized to view this page";
                Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
            }
            if (!IsPostBack)
            {
                _FillCombo();
                if (CaseID  != "")
                {
                    showEditData();
                }
                
                if (Request.UrlReferrer != null)
                {
                    ViewState["URLReferer"] = Request.UrlReferrer.AbsoluteUri;
                }
                
            }
         
            if (Request.QueryString["key"] != null)
            {
                ECCCommon.SetlblMessage(Request.QueryString["key"].ToString(), ref lblMsg);
            }
        }

        private void saveComplain()
        {
            ECCMS _objDb = new ECCMS();
            try
            {
                tblComplainRow _objComplain = new tblComplainRow();
                if (CaseID == "")
                {
                   
                    _objComplain.CaseNo = GetCaseNo(Convert.ToInt32(drpProvince.SelectedValue));
                    txtCaseNo.Text = _objComplain.CaseNo.ToString();
                    _objComplain.Sub_Date = Convert.ToDateTime(txtSubDate.Text.Trim());
                    _objComplain.Kuchi = Convert.ToInt32( drpKuchi.SelectedValue);
                    _objComplain.CaseProID = Convert.ToInt32( drpCasePro.SelectedValue);
                    _objComplain.Tri_Date = Convert.ToDateTime(txtTriDate.Text.Trim());
                    _objComplain.ProvID = Convert.ToInt32(drpProvince.SelectedValue);
                    _objComplain.PolCen_ID = Convert.ToInt32( drpPC.SelectedValue);
                    _objComplain.PS = txtPS.Text.Trim();
                    _objComplain.Comp_GenderID = Convert.ToInt32(drpGender1.SelectedValue);
                    _objComplain.Comp_Cand_ID = Convert.ToInt32(drpCandidate.SelectedValue);
                    _objComplain.Comp_TypeID = Convert.ToInt32(drpComplaintType.SelectedValue);
                    _objComplain.Resp_GenderID = Convert.ToInt32(drpGender2.SelectedValue);
                    _objComplain.Resp_TypeID = Convert.ToInt32(drpRespondantType.SelectedValue);
                    _objComplain.AllagType_ID = Convert.ToInt32(drpAllegationType.SelectedValue);
                    _objComplain.AllegationSummary = txtSummary.Text.Trim();
                    _objComplain.Resp_OfficeID = Convert.ToInt32(drpResponOffice.SelectedValue);
                    _objComplain.StatusID = Convert.ToInt32(drpStatus.SelectedValue);
                    _objComplain.Decision = txtDecision.Text.Trim();
                    _objComplain.SanctionID = Convert.ToInt32(drpSanctTypr.SelectedValue);
                    _objComplain.Appeal = Convert.ToInt32(drpAppeal.SelectedValue );
                    _objComplain.Ecc_HQ_Decision = txtECCDecision.Text.Trim();
                    _objComplain.IsDeleted = false;
                    _objComplain.CreatedBy = UserId;
                    _objComplain.CreatedTime = DateTime.Now ;
                    _objComplain.UpdatedBy = UserId;
                    _objComplain.UpdatedTime = DateTime.Now;
                    

                    _objDb.tblComplainCollection.Insert(_objComplain);
                    _Case_ID = _objComplain.CaseID.ToString();
                    strstatus = "Add";
                }
                else if (CaseID != "")
                {

                    _objComplain = _objDb.tblComplainCollection.GetRow("CaseID="+ Convert.ToInt32( CaseID) + "");
                    _objComplain.Sub_Date = Convert.ToDateTime(txtSubDate.Text.Trim());
                    _objComplain.Kuchi = Convert.ToInt32(drpKuchi.SelectedValue);
                    _objComplain.CaseProID = Convert.ToInt32(drpCasePro.SelectedValue);
                    _objComplain.Tri_Date = Convert.ToDateTime(txtTriDate.Text.Trim());
                    _objComplain.ProvID = Convert.ToInt32(drpProvince.SelectedValue );
                    _objComplain.PolCen_ID = Convert.ToInt32(drpPC.SelectedValue);
                    _objComplain.PS = txtPS.Text.Trim();
                    _objComplain.Comp_GenderID = Convert.ToInt32(drpGender1.SelectedValue);
                    _objComplain.Comp_Cand_ID = Convert.ToInt32(drpCandidate.SelectedValue);
                    _objComplain.Comp_TypeID = Convert.ToInt32(drpComplaintType.SelectedValue);
                    _objComplain.Resp_GenderID = Convert.ToInt32(drpGender2.SelectedValue);
                    _objComplain.Resp_TypeID = Convert.ToInt32(drpRespondantType.SelectedValue);
                    _objComplain.AllagType_ID = Convert.ToInt32(drpAllegationType.SelectedValue);
                    _objComplain.AllegationSummary = txtSummary.Text.Trim();
                    _objComplain.Resp_OfficeID = Convert.ToInt32(drpResponOffice.SelectedValue);
                    _objComplain.StatusID = Convert.ToInt32(drpStatus.SelectedValue);
                    _objComplain.Decision = txtDecision.Text.Trim();
                    _objComplain.SanctionID = Convert.ToInt32(drpSanctTypr.SelectedValue);
                    _objComplain.Appeal = Convert.ToInt32(drpAppeal.SelectedValue);
                    _objComplain.Ecc_HQ_Decision = txtECCDecision.Text.Trim();
                    //_objComplain.IsDeleted = false;
                    _objComplain.CreatedBy = UserId;
                    _objComplain.CreatedTime = DateTime.Now;
                    _objComplain.UpdatedBy = UserId;
                    _objComplain.UpdatedTime = DateTime.Now;
                    _objDb.tblComplainCollection.Update(_objComplain);
                    strstatus = "Update";
                    _Case_ID = CaseID.ToString(); 
                }
                //Response.Redirect("ComplainDetail.aspx?CaseNo=" + ECCCommon.EncryptQueryString(_objComplain.CaseNo.ToString()) + "");     

            }
            finally
            {
                _objDb.Dispose();
            }
        }

        private string GetCaseNo(int provID)
        {
            ECCMS _objDB = new ECCMS();
            Complain _objComplain = new Complain();
            try
            {
                if (drpKuchi.SelectedValue == "1")
                    _CaseNO = "K-10-"+string.Format("{0:00}",provID)+"-" + string.Format("{0:0000}" , _objComplain.getMaxCaseNo(provID));
                else 
                _CaseNO = "A-10-"+ string.Format("{0:00}",provID)+"-" + string.Format("{0:0000}" , _objComplain.getMaxCaseNo(provID));
                return _CaseNO;
            }
            finally
            {
                _objDB.Dispose();
            }
        }

        private void _FillCombo()
        {
            ECCMS db = new ECCMS();

            try
            {
                DataTable dtProvince = db.lkpProvinceCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpProvince, dtProvince, "ProvNameEng", "ProvId", true);
                
                DataTable dtAllagType = db.lkpAllegationtypeCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpAllegationType, dtAllagType, "AllagType_Name", "AllagType_ID",true);

                DataTable dtBit = db.lkpBitCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpKuchi, dtBit, "BitName", "BitID", true);
                ECCCommon.FillCombo(ref drpAppeal, dtBit,"BitName","BitID",true);

                DataTable dtGender = db.lkpGendersCollection.GetAllAsDataTable();
                ECCCommon.FillCombo(ref drpGender1, dtGender, "GenderName", "GenderID", true);
                ECCCommon.FillCombo(ref drpGender2, dtGender, "GenderName", "GenderID", true);

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

        private void showEditData()
        {
            ECCMS _objDetail = new ECCMS();
            try
            {
                tblComplainRow _objRow = new tblComplainRow();
                lkpProvinceRow _objProvRow = new lkpProvinceRow();
                lkpDistrictRow _objDistRow = new lkpDistrictRow();
                lkpPollingCenterRow _objPCRow = new lkpPollingCenterRow();
                lkpCandidateRow _objCandRow = new lkpCandidateRow();

                _objRow = _objDetail.tblComplainCollection.GetRow("CaseID= "+ CaseID  + "");
                txtCaseNo.Text = _objRow.CaseNo.ToString();
                txtSubDate.Text = _objRow.Sub_Date.ToShortDateString();
                txtTriDate.Text = _objRow.Tri_Date.ToShortDateString();
                txtPS.Text = _objRow.PS.ToString();
                drpKuchi.SelectedValue = _objRow.Kuchi.ToString();
                txtSummary.Text = _objRow.AllegationSummary.ToString().Trim();
                txtDecision.Text = _objRow.Decision.ToString().Trim();
                txtECCDecision.Text = _objRow.Ecc_HQ_Decision.ToString().Trim();

                _objCandRow = _objDetail.lkpCandidateCollection.GetRow("Cand_ID=" + _objRow.Comp_Cand_ID);

                //_objProvRow = _objDetail.lkpProvinceCollection.GetRow("ProvID=" + _objCandRow.Prov_ID);
                
                
               
                
                _objPCRow = _objDetail.lkpPollingCenterCollection.GetRow("PolCen_ID=" + _objRow.PolCen_ID);
                _objDistRow = _objDetail.lkpDistrictCollection.GetRow("District_Code=" + _objPCRow.District_Code);
                drpDistrict.SelectedValue = _objPCRow.District_Code;
                //_objProvRow = _objDetail.lkpProvinceCollection.GetRow("ProvId=" + _objDistRow.Province_Id + "");
                drpProvince.SelectedValue = _objRow.ProvID.ToString();
                fillProvRelated();
                fillDistrictRelated();

                drpCasePro.SelectedValue = _objRow.CaseProID.ToString();
                drpPC.SelectedValue = _objRow.PolCen_ID.ToString();
                drpGender1.SelectedValue = _objRow.Comp_GenderID.ToString();
                drpGender2.SelectedValue = _objRow.Resp_GenderID.ToString();
                drpCandidate.SelectedValue = _objRow.Comp_Cand_ID.ToString();
                drpComplaintType.SelectedValue = _objRow.Comp_TypeID.ToString();
                drpRespondantType.SelectedValue = _objRow.Resp_TypeID.ToString();
                drpAllegationType.SelectedValue = _objRow.AllagType_ID.ToString();
                drpResponOffice.SelectedValue = _objRow.Resp_OfficeID.ToString();
                drpStatus.SelectedValue = _objRow.StatusID.ToString();
                drpSanctTypr.SelectedValue = _objRow.SanctionID.ToString();
                drpAppeal.SelectedValue = _objRow.Appeal.ToString();

               

               


            }
            finally
            {
                _objDetail.Dispose();
            }
        }


        private void fillProvRelated()
        
        {
            ECCMS _objdb = new ECCMS();
            try
            {
                DataTable dtDistrict = _objdb.lkpDistrictCollection.GetAsDataTable("Province_ID=" + drpProvince.SelectedValue + " or Province_ID=37", "District_Code");
                ECCCommon.FillCombo(ref drpDistrict, dtDistrict, "District_Name", "District_Code", true);

                DataTable dtCandidate = _objdb.lkpCandidateCollection.GetAsDataTable("Prov_ID=" + drpProvince.SelectedValue + " or Prov_ID = 37", "Cand_ID");
                ECCCommon.FillCombo(ref drpCandidate, dtCandidate, "Cand_No", "Cand_ID", true);
            }
            finally
            {
                _objdb.Dispose();
            }
        }
        private void fillDistrictRelated()
        {
            ECCMS _objdb = new ECCMS();
            try
            {
                DataTable dtPC = _objdb.lkpPollingCenterCollection.GetAsDataTable("District_Code=" + drpDistrict.SelectedValue + " or District_Code=3700", "PolCen_Code");
                ECCCommon.FillCombo(ref drpPC, dtPC, "PolCen_Code", "PolCen_Id", true);
            }
            finally
            {
                _objdb.Dispose();
            }
        }

        protected void drpProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillProvRelated();
        }

        protected void drpDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDistrictRelated();
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            ECCMS _objDB = new ECCMS();
            try
            {
                saveComplain();
                if (strstatus == "Add")
                {
                    setRedirectURL(true);
                }
                else if (strstatus == "Update")
                {
                    setRedirectURL(false);
                }
                else
                {
                    lblMsg.Text = ECCCommon.objCached.ErrorOccured_ActionCancelled;
                }
            }
            finally
            {
                _objDB.Dispose();
            }
        }

        private void setRedirectURL(bool IsInsert)
        {
            string keymessage = "";
            if (IsInsert == false)
            {
                keymessage = "Updated_SuccessFully";
            }
            else
            {
                keymessage = "Inserted_SuccessFully";
            }
            if (ViewState["URLReferer"] != null)
            {
                int intTempIndex = ViewState["URLReferer"].ToString().IndexOf("key");
                if ((ViewState["URLReferer"].ToString().IndexOf("ComplainList") + 1) > 1)
                {
                    Response.Redirect("ComplainDetail.aspx?CaseID=" + ECCCommon.EncryptQueryString(_Case_ID) + " &key=" + keymessage.ToString());     
                }
                else
                {
                    Response.Redirect("ComplainDetail.aspx?CaseID=" + ECCCommon.EncryptQueryString(_Case_ID) + " &key=" + keymessage.ToString());     
                }
            }
            else
            {
                Response.Redirect("ManageComplain.aspx");
            }
        }

        
    }
}
