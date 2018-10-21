<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="_SanctionTypeRPT.aspx.cs" Inherits="ECC_App._SanctionTypeRPT" %>
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
                <span class="style2">Sanction Type Report </span>&nbsp; &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td >
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <table style="width: 585px" align="center">
        <tr>
            <td>
            <asp:Label ID="lblNoDataMsg" runat="server" 
                    style="color: #FF0000; font-size: small; font-weight: 700;"></asp:Label>
                <asp:GridView ID="_gvReport" runat="server" AutoGenerateColumns="False" 
                    style="text-align: center; font-size: small" Width="93%">
                    <Columns>
                        <asp:BoundField DataField="ProvNameEng" HeaderText="Province Name" />
                        <asp:BoundField DataField="T_Intake" HeaderText="Case Intake" />
                        <asp:BoundField DataField="Case_A" HeaderText="Proiority A" />
                        <asp:BoundField DataField="Sanc_1" HeaderText="Warning" />
                        <asp:BoundField DataField="Sanc_1" HeaderText="Imposing Fine" />
                        <asp:BoundField DataField="Sanc_3" HeaderText="Recounting Ballots" />
                        <asp:BoundField DataField="Sanc_4" 
                            HeaderText="Removing a Candidate from the final list" />
                        <asp:BoundField DataField="Sanc_5" HeaderText="Invalidation of ballots" />
                        <asp:BoundField DataField="Sanc6" 
                            HeaderText="Prohibition from being election staff" />
                        <asp:BoundField DataField="Sanc7" 
                            HeaderText="Refering to public prosecution Office" />
                        <asp:BoundField DataField="Sanc8" HeaderText="Corrective Order" />
                        <asp:BoundField DataField="Sanc9" HeaderText="Re-Election" />
                        <asp:BoundField DataField="Sanc10" 
                            HeaderText="Prohibition from working in any Commision" />
                        <asp:BoundField DataField="Sanc11" HeaderText="Not Yet" />
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