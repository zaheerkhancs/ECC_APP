<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/MasterPages/MainPage.Master"  CodeBehind="_PECC_Decision.aspx.cs" Inherits="ECC_App._PECC_Decision" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <table width="910" border="0" cellspacing="0" cellpadding="2px;">
  <tr>
  <td style="font-size: small; font-weight: 700; ">
      <asp:Panel ID="pnlSearch" runat="server">
          Select Province:<asp:DropDownList ID="drpProvince" runat="server" 
          AutoPostBack="True"  Width="147px" 
          onselectedindexchanged="drpProvince_SelectedIndexChanged">
      </asp:DropDownList>
          <br />
          <asp:Label ID="lblNoDataMsg" runat="server" style="color: #FF0000"></asp:Label>
      </asp:Panel>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
  </tr>
  <tr>
   <td>
       <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" 
           Width="100%" Font-Names="Tahoma" Font-Size="Small" AllowPaging="True" 
           AllowSorting="True" onpageindexchanging="_gvList_PageIndexChanging" 
           onsorting="_gvList_Sorting">
           <Columns>
               <asp:BoundField DataField="CaseNo" HeaderText="Case No" ItemStyle-Width="100px" >
                   <ItemStyle Width="80px" />
               </asp:BoundField>
               <asp:BoundField DataField="Sub_Date" DataFormatString="{0:d}" 
                   HeaderText="Sub Date" />
               <asp:BoundField DataField="ProvNameEng" 
                   HeaderText="Province" />
               <asp:BoundField DataField="District_Name" HeaderText="District" />
               <asp:BoundField DataField="BitName" HeaderText="Kuchi" ItemStyle-Width="50px">
                   <ItemStyle Width="50px" />
               </asp:BoundField>
               <asp:BoundField DataField="PolCen_Code" HeaderText="PC Code" />
               <asp:BoundField DataField="Cand_No" HeaderText="Candidate No" />
               <asp:BoundField DataField="RespType_Name" HeaderText="Respondent Type" />
               <asp:BoundField DataField="AllagType_Name" 
                   HeaderText="Allegation" />
               <asp:BoundField DataField="SacntionName" HeaderText="Sanction" />
           </Columns>
           <AlternatingRowStyle CssClass="even" />
       </asp:GridView>
   </td>
  </tr>
</table>
    </ContentTemplate>
    </asp:UpdatePanel>
      <asp:LinkButton ID="lnkPDF" runat="server" onclick="lnkPDF_Click" 
          style="font-weight: 700; font-size: small">Export to PDF |</asp:LinkButton>
      <asp:LinkButton ID="lnkExcel" runat="server" onclick="lnkExcel_Click" 
          style="font-weight: 700; font-size: small">Export to Excel</asp:LinkButton>
</asp:Content>
