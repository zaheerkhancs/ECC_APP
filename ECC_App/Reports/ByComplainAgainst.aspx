<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/MasterPages/MainPage.Master" CodeBehind="ByComplainAgainst.aspx.cs" Inherits="ECC_App.ByComplainAgainst" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="910" border="0" cellspacing="0" cellpadding="2px;">
  <tr>
  <td style="font-size: small; font-weight: 700; text-align: center">
      &nbsp;</td>
  </tr>
  <tr>
   <td>
       <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" 
           Width="100%" Font-Names="Tahoma" Font-Size="Small" 
           style="text-align: left">
           <Columns>
               <asp:BoundField DataField="ProvNameEng" HeaderText="Province" />
               <asp:BoundField DataField="Total_Complains" HeaderText="Total Complains" />
               <asp:BoundField DataField="Against_IEC" HeaderText="Against IEC" />
               <asp:BoundField DataField="Against_ECC" HeaderText="Against ECC" />
               <asp:BoundField DataField="Against_Candidate" HeaderText="Against Candidate" />
               <asp:BoundField DataField="Against_GOV" HeaderText="Against GOV" />
               <asp:BoundField DataField="Against_Others" 
                   HeaderText="Against Other Respondents" />
           </Columns>
           <AlternatingRowStyle CssClass="even" />
       </asp:GridView>
   </td>
  </tr>
  <tr>
  <td>
  <asp:LinkButton ID="lnkpdf" runat="server"
          style="font-size: small" onclick="lnkpdf_Click">Export to PDF</asp:LinkButton> 
      &nbsp; 
      <asp:LinkButton ID="lnkExcel" runat="server" 
          style="font-size: small" onclick="lnkExcel_Click">Export to Excel</asp:LinkButton>
  </td>
  </tr>
</table>
</asp:Content>
