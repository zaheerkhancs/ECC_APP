<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="Respondent_Gender.aspx.cs" Inherits="ECC_App.Respondent_Gender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
    <style type="text/css">
        .style2
        {
            color: #FFFFFF;
            font-weight: bold;
            font-size: small;
        }
        .style3
        {
            text-align: left;
        }
        .style4
        {
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <table style="width: 100%;">
        <tr>
            <td style="background-color: #293A27">
                <span class="style2">Respondent Gender </span>&nbsp; &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td >
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <table style="width: 585px" align="center">
                        <tr>
            <td class="style4">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; font-size: small" Text="Select Province:"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="drpProvince" runat="server" Width="200px" 
                    onselectedindexchanged="drpProvince_SelectedIndexChanged" 
                    AutoPostBack="True">
                </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="rfv4" runat="server" 
                    ControlToValidate="drpProvince" ErrorMessage="Select Province" 
                    Font-Bold="False" Font-Names="Tahoma" Font-Size="Small" InitialValue="0">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
            <asp:Label ID="lblNoDataMsg" runat="server" 
                    style="color: #FF0000; font-size: small; font-weight: 700;"></asp:Label>
                <asp:GridView ID="_gvReport" runat="server" AutoGenerateColumns="False" 
                    style="text-align: center; font-size: small" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="GenderName" HeaderText="Respondent Gender" />
                        <asp:BoundField DataField="Case_Count" HeaderText="Total Case Numbers" />
                    </Columns>
                    <AlternatingRowStyle CssClass="even" />
                </asp:GridView>
            </td>
        </tr>
                </table>
                </ContentTemplate>
                </asp:UpdatePanel> 
                </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:LinkButton ID="lnkPDF" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="lnkPDF_Click">Export to 
                PDF |</asp:LinkButton>
                <asp:LinkButton ID="lnkExcel" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="lnkExcel_Click">Export 
                to Excel</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
    </table>   
</asp:Content>


