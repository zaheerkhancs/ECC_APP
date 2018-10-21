<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/MasterPages/MainPage.Master" CodeBehind="_StatusTypeRPT.aspx.cs" Inherits="ECC_App._StatusTypeRPT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
    
    <style type="text/css">
        .style2
        {
            color: #FFFFFF;
            font-weight: bold;
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
                <span class="style2">Status Type Report </span>&nbsp; &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td >
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <table style="width: 783px" align="center">
        <tr>
            <td>
            <asp:Label ID="lblNoDataMsg" runat="server" 
                    style="color: #FF0000; font-size: small; font-weight: 700;"></asp:Label>
                <asp:GridView ID="_gvReport" runat="server" AutoGenerateColumns="False" 
                    style="text-align: center; font-size: small" Width="99%">
                    <Columns>
                        <asp:BoundField DataField="Prov_Code" 
                            HeaderText="Province Code" />
                        <asp:BoundField DataField="ProvNameEng" HeaderText="Province Name" />
                        <asp:BoundField DataField="T_Intake" HeaderText="Case Intake" />
                        <asp:BoundField DataField="Case_A" HeaderText="Proiority A" />
                        <asp:BoundField DataField="St_1" HeaderText="Intake" />
                        <asp:BoundField DataField="St_2" HeaderText="Investigation" />
                        <asp:BoundField DataField="St_3" HeaderText="Decision" />
                        <asp:BoundField DataField="St_4" 
                            HeaderText="Appeal/Review" />
                        <asp:BoundField DataField="St_5" HeaderText="ECC HQ Desicion" />
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
