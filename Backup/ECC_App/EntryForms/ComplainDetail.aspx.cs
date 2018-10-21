using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Globalization;
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
using System.IO;

namespace ECC_App
{
    public partial class ComplainDetail : ECC.BaseController.BaseController 
    {
        ReportDocument rep = new ReportDocument();
        private String CaseID
        {
            get
            {
                if (Request.QueryString["CaseID"] != null)
                    return (ECCCommon.DecryptQueryString(Request.QueryString["CaseID"].ToString(CultureInfo.InvariantCulture)));
                return "";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                showData();
            if (Request.QueryString["key"] != null)
            {
                ECCCommon.SetlblMessage(Request.QueryString["key"].ToString(), ref lblMsg);
            }
        }

        private void showData()
        {
            ECCMS _objDetail = new ECCMS();
            try
            {
                tblComplainRow _objRow = new tblComplainRow();
                lkpProvinceRow _objProvRow = new lkpProvinceRow();
                lkpDistrictRow _objDistRow = new lkpDistrictRow();
                lkpPollingCenterRow _objPCRow = new lkpPollingCenterRow();
                lkpBitRow _objBitRow = new lkpBitRow();
                lkpCasepriorityRow _objCasePro = new lkpCasepriorityRow();
                lkpGendersRow _objGenderRow = new lkpGendersRow();
                lkpCandidateRow  _objCandRow = new lkpCandidateRow  ();
                lkpComplainanttypeRow _objComp_Type = new lkpComplainanttypeRow();
                lkpRespondanttypeRow _objResp_Type = new lkpRespondanttypeRow();
                lkpAllegationtypeRow _objAllega_Type = new lkpAllegationtypeRow();
                lkpResponsibleOfficeRow _objResp_Office = new lkpResponsibleOfficeRow();
                lkpSanctionRow _objSanc = new lkpSanctionRow();
                lkpStatusRow _objStatusRow = new lkpStatusRow();

                _objRow = _objDetail.tblComplainCollection.GetRow("CaseID=" + CaseID  +"");

                txtCaseNo.Text = _objRow.CaseNo.ToString() ;
                txtSubDate.Text = _objRow.Sub_Date.ToShortDateString();
                txtTriDate.Text = _objRow.Tri_Date.ToShortDateString();
                txtPS.Text = _objRow.PS.ToString();
                txtSummary.Text = _objRow.AllegationSummary.ToString().Trim();
                txtDecision.Text = _objRow.Decision.ToString().Trim();
                txtEccHQDecision.Text = _objRow.Ecc_HQ_Decision.ToString().Trim();

                _objBitRow = _objDetail.lkpBitCollection.GetRow("BitID=" + _objRow.Kuchi);
                txtKuchi.Text = _objBitRow.BitName.ToString().Trim();

                _objBitRow = _objDetail.lkpBitCollection.GetRow("BitID=" + _objRow.Appeal);
                txtAppeal.Text = _objBitRow.BitName.ToString().Trim();

                _objCasePro = _objDetail.lkpCasepriorityCollection.GetRow("CaseProID=" + _objRow.CaseProID);
                txtCasePro.Text = _objCasePro.CaseProName.ToString().Trim();

                _objCandRow = _objDetail.lkpCandidateCollection.GetRow("Cand_ID=" + _objRow.Comp_Cand_ID );
                txtCandidateNo.Text = _objCandRow.Cand_No.ToString().Trim();

               // _objProvRow = _objDetail.lkpProvinceCollection.GetRow("ProvID=" + _objCandRow.Prov_ID);


                _objPCRow = _objDetail.lkpPollingCenterCollection.GetRow("PolCen_ID=" + _objRow.PolCen_ID);
                txtPC.Text = _objPCRow.PolCen_Code;

                _objDistRow = _objDetail.lkpDistrictCollection.GetRow("District_Code=" + _objPCRow.District_Code);
                txtDistrict.Text = _objDistRow.District_Name.ToString().Trim();

               // _objProvRow = _objDetail.lkpProvinceCollection.GetRow("Provid=" + _objDistRow.Province_Id + "");
               // txtProvince.Text = _objProvRow.ProvNameEng.ToString().Trim();
                _objProvRow = _objDetail.lkpProvinceCollection.GetRow("ProvID=" + _objRow.ProvID  +"");
                txtProvince.Text = _objProvRow.ProvNameEng.ToString();

                _objGenderRow = _objDetail.lkpGendersCollection.GetRow("GenderID=" + _objRow.Comp_GenderID);
                txtGender1.Text = _objGenderRow.GenderName.ToString().Trim();

                _objGenderRow = _objDetail.lkpGendersCollection.GetRow("GenderID=" + _objRow.Resp_GenderID );
                txtGender2.Text = _objGenderRow.GenderName.ToString().Trim();

                _objComp_Type = _objDetail.lkpComplainanttypeCollection.GetRow("Comp_typeID=" + _objRow.Comp_TypeID);
                txtComp_Type.Text = _objComp_Type.Comp_Name.ToString().Trim();

                _objResp_Type = _objDetail.lkpRespondanttypeCollection.GetRow("RespType_ID=" + _objRow.Resp_TypeID);
                txtResp_Type.Text = _objResp_Type.RespType_Name.ToString().Trim();

                _objAllega_Type = _objDetail.lkpAllegationtypeCollection.GetRow("AllagType_ID=" + _objRow.AllagType_ID);
                txtAllage_Type.Text = _objAllega_Type.AllagType_Name.ToString().Trim();

                _objResp_Office = _objDetail.lkpResponsibleOfficeCollection.GetRow("Resp_OfficeID=" + _objRow.Resp_OfficeID);
                txtResp_Office.Text = _objResp_Office.Resp_OfficeName.ToString().Trim();

                _objStatusRow = _objDetail.lkpStatusCollection.GetRow("StatusID=" + _objRow.StatusID);
                txtStatus.Text = _objStatusRow.StatusName.ToString().Trim();

                _objSanc = _objDetail.lkpSanctionCollection.GetRow("SacntionID=" + _objRow.SanctionID);
                txtSanction.Text = _objSanc.SacntionName.ToString().Trim();



            }
            finally
            {
                _objDetail.Dispose();
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    rep.Load(Server.MapPath("~//Reports//ComplainRpt.rpt"));
            //    rep.SetDatabaseLogon("sa","hx3b8");
            //    rep.SetParameterValue(0, txtCaseNo.Text.Trim());
            //    rep.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "");
            //}
            //catch 
            //{
                
            //}
        }

    }
}
