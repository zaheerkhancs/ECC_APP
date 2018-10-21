<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="_ReposdentTypeRPT.aspx.cs" Inherits="ECC_App._ReposdentTypeRPT" %>
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
                <span class="style2">Respondent Type Report </span>&nbsp; &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td >
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <table style="width: 908px" align="center">
        <tr>
            <td>
            <asp:Label ID="lblNoDataMsg" runat="server" 
                    style="color: #FF0000; font-size: small; font-weight: 700;"></asp:Label>
                <asp:GridView ID="_gvReport" runat="server" AutoGenerateColumns="False" 
                    style="text-align: center; font-size: small" Width="94%">
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
                        <asp:TemplateField HeaderText="Polling/Counting Official">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    Text='<%# Bind("R_Type1") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" 
                                    Text='<%# Bind("R_Type1") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Other IEC Official">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" 
                                    Text='<%# Bind("R_Type2") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" 
                                    Text='<%# Bind("R_Type2") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Goverment Official">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("R_Type3") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("R_Type3") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Security Official">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("R_Type4") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("R_Type4") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Candidate Agent">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# Bind("R_Type5") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox10" runat="server" 
                                    Text='<%# Bind("R_Type5") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Candidate">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# Bind("R_Type6") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox11" runat="server" 
                                    Text='<%# Bind("R_Type6") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ECC Official">
                            <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" Text='<%# Bind("R_Type7") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("R_Type7") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Other/UnKnown">
                            <ItemTemplate>
                                <asp:Label ID="Label14" runat="server" Text='<%# Bind("R_Type8") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox14" runat="server" Text='<%# Bind("R_Type8") %>'></asp:TextBox>
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





