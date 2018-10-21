<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="_StaticReport.aspx.cs" Inherits="ECC_App._StaticReport" %>
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
    <script runat="server">
    Int32  TotalsComplains,TotalIntake;
    Int32 GetComplains(Int32 NewTotal)
    {
        TotalsComplains += NewTotal;
        return NewTotal;
    }
    Int32 GetIntake(Int32 NewTotal)
    {
        TotalIntake += NewTotal;
        return NewTotal;
    }
    Int32 GetTotalComplains()
    {
        return TotalsComplains;
    }
    Int32 GetTotalIntake()
    {
        return TotalIntake;
    }
</script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <table style="width: 100%;">
        <tr>
            <td style="background-color: #293A27">
                <span class="style2">Statistic Report </span>&nbsp; &nbsp; &nbsp;
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
                    style="text-align: center; font-size: small" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="ProvNameEng" HeaderText="Province Name" />
                        <asp:BoundField DataField="Intake_Complains" HeaderText="Case Intake" />
                        <asp:TemplateField HeaderText="Priority A">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("CaseA") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("CaseA") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proirity B">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("caseB") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("caseB") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proirity C">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("caseC") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("caseC") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("TotalComplains") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("TotalComplains") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Polling Irregulation">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    Text='<%# Bind("Polling_Irregulation") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" 
                                    Text='<%# Bind("Polling_Irregulation") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Counting Irregulation ">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" 
                                    Text='<%# Bind("Counting_Irregulation") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" 
                                    Text='<%# Bind("Counting_Irregulation") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tally Center Result">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("Tally_Center") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("Tally_Center") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Access">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("Access") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Access") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Missing Materials">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# Bind("Missing_Material") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox10" runat="server" 
                                    Text='<%# Bind("Missing_Material") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Undue Influence ">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# Bind("Undue_influence") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox11" runat="server" 
                                    Text='<%# Bind("Undue_influence") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Others">
                            <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" Text='<%# Bind("Other") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("Other") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total">
                            <ItemTemplate>
                                <asp:Label ID="Label13" runat="server" Text='<%# Bind("Total_Allegation") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox13" runat="server" 
                                    Text='<%# Bind("Total_Allegation") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
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




