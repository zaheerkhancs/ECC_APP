﻿using System;
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
using System.Web.Profile;

namespace ECC_App
{
    public partial class ManageUsers1 : ECC.BaseController.BaseController 
    {
        private MembershipUserCollection allUsers = Membership.GetAllUsers();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (!this.User.IsInRole("Administrator"))
                {
                    Session["ErrorMsg"] = "You are not authorized to view this page";
                    Response.Redirect("~\\Admin\\UnauthorizedAccess.aspx");
                }

                lblTotUsers.Text = allUsers.Count.ToString();
                lblOnlineUsers.Text = Membership.GetNumberOfUsersOnline().ToString();

                string[] alphabet = "A;B;C;D;E;F;G;H;I;J;K;L;M;N;O;P;Q;R;S;T;U;V;W;X;Y;Z;All".Split(';');
                rptAlphabet.DataSource = alphabet;
                rptAlphabet.DataBind();
            }
            if (User.IsInRole("User"))
            {
                lnkNewUser.Visible = false;
                gvwUsers.Columns[6].Visible = false;
                gvwUsers.Columns[5].Visible = false;
            }
        }

        private void BindUsers(bool reloadAllUsers)
        {
            if (reloadAllUsers)
                allUsers = Membership.GetAllUsers();

            MembershipUserCollection users = null;

            string searchText = "";
            if (!string.IsNullOrEmpty(gvwUsers.Attributes["SearchText"]))
                searchText = gvwUsers.Attributes["SearchText"];

            bool searchByEmail = false;
            if (!string.IsNullOrEmpty(gvwUsers.Attributes["SearchByEmail"]))
                searchByEmail = bool.Parse(gvwUsers.Attributes["SearchByEmail"]);

            if (searchText.Length > 0)
            {
                if (searchByEmail)
                    users = Membership.FindUsersByEmail(searchText);
                else
                    users = Membership.FindUsersByName(searchText);
            }
            else
            {
                users = allUsers;
            }

            gvwUsers.DataSource = users;
            gvwUsers.DataBind();
        }

        protected void rptAlphabet_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            gvwUsers.Attributes.Add("SearchByEmail", false.ToString());
            if (e.CommandArgument.ToString().Length == 1)
            {
                gvwUsers.Attributes.Add("SearchText", e.CommandArgument.ToString() + "%");
                BindUsers(false);
            }
            else
            {
                gvwUsers.Attributes.Add("SearchText", "");
                BindUsers(false);
            }

        }

        protected void gvwUsers_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var btn = e.Row.Cells[6].Controls[0] as ImageButton;
                if (btn != null)
                    btn.OnClientClick = "if (confirm('Are you sure you want to delete this user account?') == false) return false;";
            }
        }

        protected void gvwUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string userName = gvwUsers.DataKeys[e.RowIndex].Value.ToString();
            ProfileManager.DeleteProfile(userName);
            Membership.DeleteUser(userName);
            //new RecordDeletedEvent("asp_Users", userName, null).Raise();
            BindUsers(true);
            lblTotUsers.Text = allUsers.Count.ToString();


        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            bool searchByEmail = (ddlSearchTypes.SelectedValue == "E-mail");
            gvwUsers.Attributes.Add("SearchText", "%" + txtSearchText.Text + "%");
            gvwUsers.Attributes.Add("SearchByEmail", searchByEmail.ToString(CultureInfo.InvariantCulture));
            BindUsers(false);
        }
   
    }
}
