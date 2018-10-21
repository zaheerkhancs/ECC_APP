using System;
using System.Globalization;
using System.Web;
using System.IO;
using System.Xml;
using System.Text;
using System.Security.Cryptography;
using System.Reflection;
using System.Configuration;
using System.Web.UI.WebControls;
using IOM.ECCMS.ECCDB;
using System.Data.Common;
using System.Collections;
using System.Web.Caching;
using System.Security;
using System.Web.Security;

namespace ECC.BaseController
{
    /// <summary>
    /// Summary description for BaseController.
    /// </summary>
    public class BaseController : System.Web.UI.Page
    {


        protected void LoadCache()
        {
            // Add code here if you want to load in to cache


        }

        public BaseController()
        {
        }

        protected override void OnError(System.EventArgs e)
        {
            if (HttpContext.Current.Error != null)
            {

                //ECCCommon.LogErrorToFile(HttpContext.Current.Error, HttpContext.Current.Request.FilePath.ToString(), "", "", true);
                //ECCCommon.SendErrorToMail(HttpContext.Current.Error, ECCCommon.ProjectName, HttpContext.Current.Request.FilePath.ToString(), ECCCommon.ToMail);
                Session["ErrorMsg"] = Server.GetLastError().Message;
                Response.Redirect("../DefaultError.aspx");
            }
        }

        private void EnvironmentLogin()
        {
            //Redirect the user to the Home page when Session is null
            string strUserId = "";
            strUserId = Environment.UserName;
            string[] strRole = Roles.GetRolesForUser(strUserId);

            if (strUserId != "")
            {
                MembershipUser user = Membership.GetUser(Environment.UserName);
                //MembershipUser user = Membership.GetUser(HttpContext.Current.User.IsInRole("role"));

                Session["UserID"] = strUserId;
                Session["UserName"] = strUserId;
                Session["Role"] = strRole[0].ToString(CultureInfo.InvariantCulture);
                Session.Timeout = 30;
            }
            else
            {
                Response.Write("Not Authorised user");
                Response.End();
            }
        }

        protected override void OnLoad(System.EventArgs e)
        {
            //This line of code ensures that the pages are not cached by the browser
            Response.Cache.SetExpires(DateTime.Now);

            //Load Common Message file into Cache
            if (!Page.IsPostBack)
            {
                if (System.Web.HttpContext.Current.Cache["CommonMsg"] == null)
                {
                    ECCCommon.objCached.loadMsg(ECCCommon.xmlMsgFilePath);
                    System.Web.HttpContext.Current.Cache["CommonMsg"] = ECCCommon.objCached;
                    var dependency = new CacheDependency(ECCCommon.xmlMsgFilePath);
                    System.Web.HttpContext.Current.Cache.Insert("CommonMsg", ECCCommon.objCached, dependency);
                }
                else
                {
                    ECCCommon.objCached = (Message) System.Web.HttpContext.Current.Cache["CommonMsg"];
                }
            }


            if (Session["UserId"] == null)
            {
                string authType =
                    System.Configuration.ConfigurationSettings.AppSettings.Get("Authentication").ToString(
                        CultureInfo.InvariantCulture);


                if (authType == "Windows")
                {
                    EnvironmentLogin();
                    LoadCache();
                }
                else if (authType == "Forms")
                {

                    string pageRequested = System.IO.Path.GetFileName(Convert.ToString(Request.Url));

                    if (pageRequested != null &&
                        pageRequested.ToLower().IndexOf("login.aspx", System.StringComparison.Ordinal) == -1)
                    {
                        Response.Redirect("~//Admin//Login.aspx"); //?key=Not_LoggedIn");
                    }
                }
                base.OnLoad(e);
            }

        }
    }
}
