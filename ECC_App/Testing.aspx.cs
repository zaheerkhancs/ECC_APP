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
using System.IO;
using IOM.ECCMS.ECCDB; 

namespace ECC_App
{
    public partial class Testing : ECC.BaseController.BaseController 
    {
        string[] files;
        DataTable dt = new DataTable("datatable1");
        DataColumn dc;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FillGrid("", 0);
        }
        public void FillGrid(string category, int val)
        {
            DataTable dt = new DataTable("datatable1");
            DataColumn dc;
            DataRow dr;
            dr = dt.NewRow();

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "FileIcon";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "CaseNo";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "FilePath";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Description";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.DateTime");
            dc.ColumnName = "TimeUpload";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.DateTime");
            dc.ColumnName = "DateUpload";
            dt.Columns.Add(dc);



            //files list

            if (!Directory.Exists (Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim()+"\\")))
                Directory.CreateDirectory(Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim()+"\\"));
       
            files = Directory.GetFiles(Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim()+"\\"));
            
            foreach (string fileName in files)
            {
                dr = dt.NewRow();
                string fileImage = "";
                FileInfo fi = new FileInfo(fileName);
                if (fi.Extension == ".pdf")
                    fileImage = "images/pdf.gif";
                else if (fi.Extension == ".txt")
                    fileImage = "images/txt.gif";
                else if (fi.Extension == ".doc")
                    fileImage = "images/doc.gif";
                else if (fi.Extension == ".xls")
                    fileImage = "images/xls.gif";
                else
                    fileImage = "images/png.gif";

                dr[0] = fileImage;
                dr[1] = txtCasoNo2.Text.Trim();
                dr[2] = fi.FullName.ToString();
                dr[3] = txtDescp.Text.Trim();
                dr[4] = DateTime.Now.ToShortTimeString();
                dr[5] = DateTime.Now.Date  ;

                dt.Rows.Add(dr);

            }
            DataView dv = new DataView(dt);
            _gvList.DataSource = dv;
            _gvList.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string StrFileName = f_load.FileName;
            if (f_load.HasFile == true)
            {
                if (!Directory.Exists(Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim() + "\\")))
                    Directory.CreateDirectory(Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim() + "\\"));

                f_load.PostedFile.SaveAs(Server.MapPath(".\\uploadfile\\" + txtCasoNo2.Text.Trim() + "\\" + StrFileName));
                FillGrid("", 0);
            }
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            File.Delete(e.CommandArgument.ToString());
            FillGrid("", 0);
        }

        protected void btnSavePerson_Click(object sender, EventArgs e)
        {
            saveAttachment();
        }

        private void saveAttachment()
        {
            //ECCMS _objDb = new ECCMS();
            //try
            //{
            //    tblAttachmentRow _objAttach = new tblAttachmentRow();
            //    for (int i = 0; i <= _gvList.Rows.Count - 1; i++)
            //    {

            //        GridViewRow _grRow = this._gvList.Rows[i];
            //        _objAttach.CaseNo  = "";
            //        _objAttach.FilePath = (((Label)_grRow.FindControl("label2")).Text);
            //        _objAttach.Description  = (((Label)_grRow.FindControl("label3")).Text);
            //        _objAttach.TimeUpload  = Convert.ToDateTime  (((Label)_grRow.FindControl("label4")).Text);
            //        _objAttach.DateUpload = Convert.ToDateTime(((Label)_grRow.FindControl("label5")).Text);
            //        _objAttach.AttachType = true ;
            //        _objDb.tblAttachmentCollection.Insert(_objAttach);
            //    }


            //}
            //finally
            //{
            //    _objDb.Dispose();
            //}
        }
    }
}
