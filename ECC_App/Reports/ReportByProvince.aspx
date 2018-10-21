<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="ReportByProvince.aspx.cs" Inherits="ECC_App.ReportByProvince" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="910" border="0" cellspacing="0" cellpadding="2px;">
  <tr>
  <td style="font-size: small; font-weight: 700; text-align: center">
      </td>
  </tr>
  <tr>
   <td>
       <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" 
           Width="100%" Font-Names="Tahoma" Font-Size="Small" 
           style="text-align: left">
           <Columns>
               <asp:BoundField DataField="ProvID" HeaderText="ProvID" Visible="False" />
               <asp:BoundField DataField="ProvNameEng" HeaderText="Province Name" />
               <asp:BoundField DataField="NoComplain" HeaderText="No of Complains" />
               <asp:TemplateField HeaderText="View">
                   <ItemTemplate>
                       <asp:ImageButton ID="imgView" runat="server" 
                           CommandArgument='<%# Eval("ProvID") %>' ImageUrl="~/images/view.gif" 
                           oncommand="imgView_Command" />
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
           <AlternatingRowStyle CssClass="even" />
       </asp:GridView>
   </td>
  </tr>
  <tr>
  <td>
      <asp:LinkButton ID="lnkpdf" runat="server" onclick="lnkpdf_Click" 
          style="font-size: small">Export to PDF</asp:LinkButton> 
      &nbsp; 
      <asp:LinkButton ID="lnkExcel" runat="server" onclick="lnkExcel_Click" 
          style="font-size: small">Export to Excel</asp:LinkButton>
  </td>
  </tr>
</table>
</asp:Content>
