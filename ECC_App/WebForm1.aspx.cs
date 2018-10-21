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

namespace ECC_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string excelFileName = @"C:\Documents and Settings\Administrator\Desktop\DataEntry.xls";
            try
            {
                fuData.PostedFile.SaveAs(Server.MapPath("~\\uploadfile\\" + fuData.PostedFile.FileName));

                string excelFileName = Server.MapPath("~\\uploadfile\\" + fuData.PostedFile.FileName + "");
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";Extended Properties='Excel 8.0;HDR=Yes;'";

                string query = "SELECT * FROM [DataEntry$] where bitID<>null ";

                DataSet excelDataSet = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(query, strConn);

                da.Fill(excelDataSet);

                GridView1.DataSource = excelDataSet;
                GridView1.DataBind();
                //System.IO.File.Delete(Server.MapPath("..\\uploadfile\\"+ fuData.PostedFile.FileName  +""));
            }
            catch (Exception ex)
            {
                CustomValidator1.ErrorMessage = ex.Message ;
            }
        }
    }
}

