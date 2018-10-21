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
using System.Data.OleDb;
using IOM.ECCMS.ECCDB;


namespace ECC_App
{
    public partial class ExcelBulkUpload : ECC.BaseController.BaseController 
    {
        Int32 _inserted, _iAlreadyinserted;
        string _CaseNotInserted,_CaseNumber,_CaseLen;
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
            if (this.User.IsInRole("SuperUser"))
            {
                Session["ErrorMsg"] = "You are not authorized to view this page";
                Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            _SaveExcelCase();
            System.IO.File.Delete(Server.MapPath(".\\uploadfile\\"+ Session["UserName"].ToString()+"DataEntry.xls"));
        }

        private void _SaveExcelCase()
        {
            ECCMS _dbobj = new ECCMS();
            _iAlreadyinserted = 0;
            _inserted = 0;
            try
            {
                tblComplainRow _objComplain = new tblComplainRow();

                for (int i = 0; i <= _gvList.Rows.Count - 1; i++)
                {

                    GridViewRow _grRow = this._gvList.Rows[i];
                  
                   
                       _CaseLen = _grRow.Cells[0].Text.Length.ToString();
                       if (_CaseLen == "4" && _grRow.Cells[2].Text == "2")
                           _CaseNumber = "A-10-" + string.Format("{0:00}", Convert.ToInt32 (_grRow.Cells[20].Text)) + "-" + _grRow.Cells[0].Text;
                       else if (_CaseLen == "4" && _grRow.Cells[2].Text == "1")
                           _CaseNumber = "K-10-" + string.Format("{0:00}",Convert.ToInt32( _grRow.Cells[20].Text)) + "-" + _grRow.Cells[0].Text;
                       else if (_CaseLen == "7" && _grRow.Cells[2].Text == "2")
                           _CaseNumber = "A-10-" + _grRow.Cells[0].Text;
                       else if (_CaseLen == "7" && _grRow.Cells[2].Text == "1")
                           _CaseNumber = "K-10-" + _grRow.Cells[0].Text;
                       else
                           _CaseNumber = _grRow.Cells[0].Text;

                       _objComplain = _dbobj.tblComplainCollection.GetRow("CaseNo=N'" + _CaseNumber + "' and ProvID= " + Convert.ToInt32(_grRow.Cells[20].Text) + " and isDeleted = 0");

                       if (_objComplain == null)
                       {
                           _inserted++;
                           _objComplain = new tblComplainRow();

                           _CaseNotInserted = _grRow.Cells[0].Text;
                       _objComplain.CaseNo = _CaseNumber;
                       _objComplain.Sub_Date = Convert.ToDateTime(_grRow.Cells[1].Text);
                       _objComplain.Kuchi = Convert.ToInt32(_grRow.Cells[2].Text);
                       _objComplain.CaseProID = Convert.ToInt32(_grRow.Cells[3].Text);
                       _objComplain.Tri_Date = Convert.ToDateTime(_grRow.Cells[4].Text);
                       _objComplain.ProvID = Convert.ToInt32(_grRow.Cells[20].Text);
                       _objComplain.PolCen_ID = Convert.ToInt32(_grRow.Cells[5].Text);
                       _objComplain.PS = _grRow.Cells[6].Text;
                       _objComplain.Comp_GenderID = Convert.ToInt32(_grRow.Cells[7].Text);
                       _objComplain.Comp_Cand_ID = Convert.ToInt32(_grRow.Cells[8].Text);
                       _objComplain.Comp_TypeID = Convert.ToInt32(_grRow.Cells[9].Text);
                       _objComplain.Resp_GenderID = Convert.ToInt32(_grRow.Cells[10].Text);
                       _objComplain.Resp_TypeID = Convert.ToInt32(_grRow.Cells[11].Text);
                       _objComplain.AllagType_ID = Convert.ToInt32(_grRow.Cells[12].Text);
                       _objComplain.AllegationSummary = _grRow.Cells[13].Text;
                       _objComplain.Resp_OfficeID = Convert.ToInt32(_grRow.Cells[14].Text);
                       _objComplain.StatusID = Convert.ToInt32(_grRow.Cells[15].Text);
                       _objComplain.Decision = _grRow.Cells[16].Text;
                       _objComplain.SanctionID = Convert.ToInt32(_grRow.Cells[17].Text);
                       _objComplain.Appeal = Convert.ToInt32(_grRow.Cells[18].Text);
                       _objComplain.Ecc_HQ_Decision = _grRow.Cells[19].Text;
                       _objComplain.IsDeleted = false;
                       _objComplain.CreatedBy = UserId;
                       _objComplain.CreatedTime = DateTime.Now;
                       _objComplain.UpdatedBy = UserId;
                       _objComplain.UpdatedTime = DateTime.Now;
                       _dbobj.tblComplainCollection.Insert(_objComplain);
                       lbl_Inserted.Text = _inserted.ToString();
                   }
                   else
                   {
                       _iAlreadyinserted++;
                       //lblMsg.Text = "Already Inserted" + lblMsg.Text + "//" + _objComplain.CaseNo.ToString();
                       _objComplain = _dbobj.tblComplainCollection.GetRow("CaseNo=N'" + _CaseNumber + "' and ProvID= " + Convert.ToInt32(_grRow.Cells[20].Text) + " and isDeleted = 0");
                           _objComplain.CaseNo = _CaseNumber ;
                       _CaseNotInserted = _grRow.Cells[0].Text;
                       _objComplain.Sub_Date = Convert.ToDateTime(_grRow.Cells[1].Text);
                       _objComplain.Kuchi = Convert.ToInt32(_grRow.Cells[2].Text);
                       _objComplain.CaseProID = Convert.ToInt32(_grRow.Cells[3].Text);
                       _objComplain.Tri_Date = Convert.ToDateTime(_grRow.Cells[4].Text);
                       _objComplain.ProvID = Convert.ToInt32(_grRow.Cells[20].Text);
                       _objComplain.PolCen_ID = Convert.ToInt32(_grRow.Cells[5].Text);
                       _objComplain.PS = _grRow.Cells[6].Text;
                       _objComplain.Comp_GenderID = Convert.ToInt32(_grRow.Cells[7].Text);
                       _objComplain.Comp_Cand_ID = Convert.ToInt32(_grRow.Cells[8].Text);
                       _objComplain.Comp_TypeID = Convert.ToInt32(_grRow.Cells[9].Text);
                       _objComplain.Resp_GenderID = Convert.ToInt32(_grRow.Cells[10].Text);
                       _objComplain.Resp_TypeID = Convert.ToInt32(_grRow.Cells[11].Text);
                       _objComplain.AllagType_ID = Convert.ToInt32(_grRow.Cells[12].Text);
                       _objComplain.AllegationSummary = _grRow.Cells[13].Text;
                       _objComplain.Resp_OfficeID = Convert.ToInt32(_grRow.Cells[14].Text);
                       _objComplain.StatusID = Convert.ToInt32(_grRow.Cells[15].Text);
                       _objComplain.Decision = _grRow.Cells[16].Text;
                       _objComplain.SanctionID = Convert.ToInt32(_grRow.Cells[17].Text);
                       _objComplain.Appeal = Convert.ToInt32(_grRow.Cells[18].Text);
                       _objComplain.Ecc_HQ_Decision = _grRow.Cells[19].Text;
                       _objComplain.IsDeleted = false;
                       _objComplain.UpdatedBy = UserId;
                       _objComplain.UpdatedTime = DateTime.Now;
                       _dbobj.tblComplainCollection.Update (_objComplain);
                       lblPresent.Text = _iAlreadyinserted.ToString();
                       lblUpdated.Text = lblUpdated.Text + "-(" + _grRow.Cells[0].Text+")";
                   }
                   // 
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = _CaseNotInserted.ToString();
                lblStoped.Text = _CaseNotInserted.ToString();
                System.IO.File.Delete(Server.MapPath(".\\uploadfile\\" + Session["UserName"].ToString() + "DataEntry.xls"));
            }
            finally
            {
                _dbobj.Dispose();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fuData.HasFile == true)
                {
                    //if (System.IO.File.Exists(Server.MapPath(".\\uploadfile\\" + Session["UserName"].ToString() + fuData.FileName)))
                    //    System.IO.File.Delete((Server.MapPath(".\\uploadfile\\" + Session["UserName"].ToString() + fuData.FileName)));
                    //else 

                    fuData.PostedFile.SaveAs(Server.MapPath(".\\uploadfile\\" + Session["UserName"].ToString() + fuData.FileName));

                    string excelFileName = Server.MapPath(".\\uploadfile\\" + Session["UserName"].ToString() + fuData.FileName + "");
                    string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";Extended Properties='Excel 8.0;HDR=Yes;'";

                    string query = "SELECT * FROM [MySheet$] where Case_No<>null";
                    DataTable _ExcelDt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(query, strConn);

                    da.Fill(_ExcelDt);
                    _gvList.DataSource = _ExcelDt;
                    _gvList.DataBind();
                    lbl_tot.Text = _ExcelDt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}
