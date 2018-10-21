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
    public partial class ReportList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (this.User.IsInRole("User"))
            //{
            //    Session["ErrorMsg"] = "You are not authorized to view this page";
            //    Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
            //}
        }

        protected void ComplainProirity_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complain_Priorties.aspx");
        }

        protected void Complaint_Status_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Status.aspx");
        }

        protected void StatusA_Complaint_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\ComplaintStatusA.aspx");
        }

        protected void RespondentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Respondent.aspx");
        }

        protected void AllegationType_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Allegation.aspx");
        }

        protected void ComplainType_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_ComplainType.aspx");
        }

        protected void SanctionType_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Sanction.aspx");
        }

        protected void Complaint_Gender_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Gender.aspx");
        }

        protected void Respondent_Gender_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Respondent_Gender.aspx");
        }

        protected void Complaint_Candidate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\Complaint_Candidate.aspx");
        }

        protected void lnkStatistic_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_StaticReport.aspx");
        }

        protected void lnkStatistic0_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_ComplaintTypeRPT.aspx");
        }

        protected void lnkStatistic1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_ReposdentTypeRPT.aspx");
        }

        protected void lnkStatistic2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_SanctionTypeRPT.aspx");
        }

        protected void lnkStatistic3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_StatusTypeRPT.aspx");
        }

        protected void lnkStatistic4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_PECC_Decision.aspx");
        }

        protected void lnkStatistic5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Reports\\_HQ_Decision.aspx");
        }

    }
}
