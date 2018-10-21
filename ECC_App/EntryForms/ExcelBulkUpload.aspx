<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master"
    CodeBehind="ExcelBulkUpload.aspx.cs" Inherits="ECC_App.ExcelBulkUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style2
        {
            text-align: left;
        }
        .style3
        {
            text-align: center;
        }
        .style5
        {
            color: #FFFFFF;
            font-size: small;
            font-weight: bold;
            background-color: #293A21;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
            <table style="width: 100%;" width="100%">
                <tr>
                    <td class="style5" colspan="3">
                        Excel Bulk Data Upload</td>
                </tr>
                <tr>
                    <td style="text-align: left">
                        <asp:FileUpload ID="fuData" runat="server" />
                        &nbsp;<br />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="ValidateFileUpload"
                            ErrorMessage="Please select valid .xls file" Style="font-weight: 700; font-size: small"></asp:CustomValidator>
                             <script language="javascript" type="text/javascript">

       function ValidateFileUpload(Source, args)
{
  var fuData = document.getElementById('<%= fuData.ClientID %>'); 
  var FileUploadPath = fuData.value;
 
  if(FileUploadPath =='') 
  {
    // There is no file selected 
    args.IsValid = false;
  }
  else
  {
    var Extension = FileUploadPath.substring(FileUploadPath.lastIndexOf('.') + 1).toLowerCase();
 
    if (Extension == "xls" || Extension == "xlsx")
    {
      args.IsValid = true; // Valid file type
    }
    else
    {
      args.IsValid = false; // Not valid file type
    }
   }
}
</script>  
                    </td>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td class="style2">
                        &nbsp;
                    </td>
                </tr>
                       <tr>
                    <td style="text-align: left">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Excel Data" />
                        <b>
                            <asp:Label ID="lblMsg" runat="server" Style="text-align: center; color: #FF0000;
                                font-size: small"></asp:Label>
                        </b>
                    </td>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td class="style2">
                        &nbsp;
                    </td>
                </tr>
               <tr>
               <td>
                   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                   <ContentTemplate>
                   <table width = "80%"  >
             
                    <td class="style3" colspan="3" align="center">
                        <asp:GridView ID="_gvList" runat="server" Font-Names="Tahoma" Font-Size="Small" 
                            Width="80%" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Case_No" HeaderText="Case No" 
                                    ItemStyle-Width="90px" >
<ItemStyle Width="90px"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField DataField="Sub_Date" DataFormatString="{0:d}" 
                                    HeaderText="Submission Date" />
                                <asp:BoundField DataField="Kuchi"  />
                                <asp:BoundField DataField="CaseProID" />
                                <asp:BoundField DataField="Tri_Date" DataFormatString="{0:d}" 
                                    HeaderText="Triage Date" />
                                <asp:BoundField DataField="PolCen_ID"/>
                                <asp:BoundField DataField="PS" HeaderText="Polling Station" />
                                <asp:BoundField DataField="Comp_GenderID" />
                                <asp:BoundField DataField="Comp_Cand_ID" />
                                <asp:BoundField DataField="Comp_TypeID" />
                                <asp:BoundField DataField="Resp_Gender"  />
                                <asp:BoundField DataField="Resp_TypeID"  />
                                <asp:BoundField DataField="AllegaType_ID"  />
                                <asp:BoundField DataField="AllegaSummary" HeaderText="Allegation Summary" />
                                <asp:BoundField DataField="Resp_OfficeID"  />
                                <asp:BoundField DataField="StatusID"  />
                                <asp:BoundField DataField="Decision" HeaderText="Decision" />
                                <asp:BoundField DataField="SanctionID"  />
                                <asp:BoundField DataField="Appeal" />
                                <asp:BoundField DataField="Ecc_HQ_Decision" HeaderText="ECC HQ Decision" />
                                <asp:BoundField DataField="ProvID" HeaderText="" />
                            </Columns>
                            <HeaderStyle ForeColor="White" />
                            <AlternatingRowStyle CssClass="even" />
                        </asp:GridView>
                        Stoped Case No:<asp:Label ID="lblStoped" runat="server" Text=""></asp:Label>
                        <br />
                        Update Case No:<asp:Label ID="lblUpdated" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style5" colspan="3">
                        Total Records: <asp:Label ID="lbl_tot" runat="server" Text="0" 
                            style="color: #FFFFFF"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Inserted Records:
                        <asp:Label ID="lbl_Inserted" runat="server" Text="0"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Already Present Records:<asp:Label ID="lblPresent" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3" colspan="3">
                        <asp:Button ID="btnSave" runat="server" Text="Save" Width="87px" 
                            CausesValidation="False" onclick="btnSave_Click" />
                    
                    </td>
                </tr>
                   </table>
                   </ContentTemplate>
                   </asp:UpdatePanel>
                   
               </td>
               </tr>
            </table>
</asp:Content>
