<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="AdministrationList.aspx.cs" Inherits="ECC_App.AdministrationList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        font-size: small;
        font-weight: bold;
        font-family: Tahoma;
    }
    .style3
    {
        width: 122px;
    }
    .style4
    {
        width: 122px;
        text-align: center;
        background-color: #293A21;
    }
    .style6
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Tahoma;
        font-size: small;
    }
    .style7
    {
        text-align: left;
    }
    .style8
    {
        width: 122px;
        text-align: right;
        color: #FFFFFF;
        font-weight: bold;
        font-size: small;
        font-family: Tahoma;
        background-color: #293A21;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;" width="100%">
        <tr>
            <td class="style3">
                &nbsp;
            </td>
            <td>
                &nbsp; <span class="style2">Administrator </span>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style4" rowspan="3">
                <span class="style6">User Administration</span>&nbsp;
            </td>
            <td class="style7">
                <asp:LinkButton ID="lnkManageUser" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="lnkManageUser_Click">Manage 
                User</asp:LinkButton>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="lnkChangeStatus" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="lnkChangeStatus_Click">Change 
                Status</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8" rowspan="8">
                Manage Lookups</td>
            <td class="style7">
                <asp:LinkButton ID="lnkCase_Proirity" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="lnkCase_Proirity_Click">Case Priorty</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton11" runat="server" 
                    style="font-weight: 700; font-size: small">Candidates</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton12" runat="server" 
                    style="font-weight: 700; font-size: small">Complaint Type</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton13" runat="server" 
                    style="font-weight: 700; font-size: small">Respondenet Type</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton14" runat="server" 
                    style="font-weight: 700; font-size: small">Allegation Type</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton15" runat="server" 
                    style="font-weight: 700; font-size: small">Responsible Office</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton16" runat="server" 
                    style="font-weight: 700; font-size: small">Status</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="LinkButton17" runat="server" 
                    style="font-weight: 700; font-size: small">Sanction</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>   
</asp:Content>


