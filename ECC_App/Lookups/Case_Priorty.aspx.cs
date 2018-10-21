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
    public partial class Case_Priorty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                showData();
        }

        protected void btnSavePerson_Click(object sender, EventArgs e)
        {
            ECCMS _objDb = new ECCMS();
            try
            {
                if (txtCaseProID.Text.Trim() == "")
                {
                    lkpCasepriorityRow _objRow = new lkpCasepriorityRow();
                    _objRow.CaseProID = Convert.ToInt32( txtCaseProID.Text);
                    _objRow.CaseProName = txtCaseProName.Text.Trim();
                    _objDb.lkpCasepriorityCollection.Insert(_objRow);
                }
                else
                {
                    lkpCasepriorityRow _objRow = new lkpCasepriorityRow();
                    _objRow.CaseProID = Convert.ToInt32(txtCaseProID.Text);
                    _objRow.CaseProName = txtCaseProName.Text.Trim();
                    _objDb.lkpCasepriorityCollection.Update(_objRow);
                }
                showData();
            }
            finally
            { 
            }
        }

        protected void btnCancelPerson_Click(object sender, EventArgs e)
        {

        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            ECCMS _objDb = new ECCMS();
            try
            {
                lkpCasepriorityRow _objRow = new lkpCasepriorityRow();
                _objRow = _objDb.lkpCasepriorityCollection.GetRow("CaseProID=" + Convert.ToInt32(e.CommandArgument) + "");
                txtCaseProID.Text = _objRow.CaseProID.ToString() ;
                txtCaseProName.Text = _objRow.CaseProName.ToString();

                mpePerson.Show();
            }
            finally
            {
                _objDb.Dispose();
            }
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {

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
            ECCMS _objDb = new ECCMS();
            DataTable dt = new DataTable();
            try
            {
                dt = _objDb.lkpCasepriorityCollection.GetAllAsDataTable();
                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {
                _objDb.Dispose();
            }
            return dt;
        }

        protected void _gvList_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}
