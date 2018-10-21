<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="_ComplaintTypeRPT.aspx.cs" Inherits="ECC_App._ComplaintTypeRPT" %>
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
                <span class="style2">Complaint Type Report </span>&nbsp; &nbsp; &nbsp;
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
                        <asp:TemplateField HeaderText="Priority A">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Case_A") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Case_A") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proirity B">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("case_B") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("case_B") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proirity C">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("case_C") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("case_C") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("T_CaseP") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("T_CaseP") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="IEC">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    Text='<%# Bind("IEC") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" 
                                    Text='<%# Bind("IEC") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FEFA">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" 
                                    Text='<%# Bind("FEFA") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" 
                                    Text='<%# Bind("FEFA") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Other Organziation">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("Other_Org") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("Other_Org") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Candidate Or Support">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("Candidate_Support") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Candidate_Support") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Individual">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# Bind("Individual") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox10" runat="server" 
                                    Text='<%# Bind("Individual") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Other/UnKnown">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# Bind("Others") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox11" runat="server" 
                                    Text='<%# Bind("Others") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="T_ComplaintT" HeaderText="Total" />
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
