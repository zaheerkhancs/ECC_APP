<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="SearchFrm.aspx.cs" Inherits="ECC_App.SearchFrm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table width="100%">
            <tr>
                <td colspan="3">
                    &nbsp; &nbsp; &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <table style="width: 89%;">
                        <tr>
                            <td class="style26">
                                <span class="style25">Case Number</span>&nbsp;<span class="style27"><span 
                                    class="style18">شماره قضیه</span><span class="style14">:</span></span></td>
                            <td class="style32">
                                <asp:TextBox ID="txtCaseNo" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style33">
                                <span class="style24">Respondant type</span>&nbsp;<span class="style24">نوعیت شخص 
                                مشتکی</span><span class="style20"><b>:</b></span>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="drpRespondantType" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style26">
                                <span class="style25">Case priority </span><span class="style18">اولویت بندی 
                                قضیه</span><span class="style14">:</span></td>
                            <td class="style32">
                                <asp:DropDownList ID="drpCasePro" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                            <td class="style33">
                                <span class="style24">Sanction type</span><span class="style20"><b> نوع تعزیر:</b></span>&nbsp;</td>
                            <td class="style3">
                                <asp:DropDownList ID="drpSanctTypr" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style26">
                                <span class="style26">Kuchi </span><span class="style14">کوچی:</span>&nbsp;</td>
                            <td class="style32">
                                <asp:DropDownList ID="drpKuchi" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                            <td class="style33">
                                <span class="style24">Status</span>&nbsp;<span class="style24">وضعیت</span><span 
                                    class="style24">:</span>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="drpStatus" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style26">
                                <span class="style24"><span class="style27">Responsible Office</span> </span>
                                <span class="style24">دفتر مربوطه مسؤل:</span>&nbsp;</td>
                            <td class="style32">
                                <asp:DropDownList ID="drpResponOffice" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                            <td class="style33">
                                <span class="style31">Complainant type</span>&nbsp;<span class="style24">نوعیت شخص 
                                شاکی</span></td>
                            <td class="style3">
                                <asp:DropDownList ID="drpComplaintType" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                          <tr>
                            <td class="style26">
                                <span class="style25">Province</span>&nbsp;<span class="style18">ولایت</span><span 
                                    class="style14">:</span></td>
                            <td class="style32">
                                <asp:DropDownList ID="drpProvince" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td class="style3">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" Width="123px" 
                        onclick="btnSearch_Click" />
                    &nbsp;
                    <br />
                    <asp:Label ID="lblNoDataMsg" runat="server" 
                        style="color: #FF0000; font-weight: 700; font-size: small;"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="_gvList" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" Font-Names="Tahoma" 
                        Font-Size="Small" onpageindexchanging="_gvList_PageIndexChanging" 
                        onsorting="_gvList_Sorting" >
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgDetail" runat="server" 
                                        CommandArgument='<%# Eval("CaseID") %>' ImageUrl="~/images/view.gif" 
                                        oncommand="imgDetail_Command" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgEdit" runat="server" 
                                        CommandArgument='<%# Eval("CaseID") %>' ImageUrl="~/images/edt.gif" 
                                        oncommand="imgEdit_Command" Width="16px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgDelete" runat="server" 
                                        CommandArgument='<%# Eval("CaseID") %>' ImageUrl="~/images/del.gif" 
                                        oncommand="imgDelete_Command" />
                                    <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" 
                                        ConfirmText="Are you sure you want to Delete this Complain?" 
                                        TargetControlID="imgDelete">
                                    </cc1:ConfirmButtonExtender>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="CaseNo" HeaderText="Case No" ItemStyle-Width="100px">
                                <ItemStyle Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Sub_Date" DataFormatString="{0:d}" 
                                HeaderText="Submission Date" />
                            <asp:BoundField DataField="BitName" HeaderText="Kuchi" ItemStyle-Width="50px">
                                <ItemStyle Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CaseProName" HeaderText="Case Prority" />
                            <asp:BoundField DataField="Tri_Date" DataFormatString="{0:d}" 
                                HeaderText="Triage Date" />
                            <asp:BoundField DataField="PolCen_Code" HeaderText="PC Code" />
                            <asp:BoundField DataField="District_Name" HeaderText="District" />
                            <asp:BoundField DataField="ProvNameEng" HeaderText="Province" />
                            <asp:BoundField DataField="Cand_No" HeaderText="Candidate No" />
                            <asp:BoundField DataField="Resp_OfficeName" HeaderText="Responsible Office" />
                            <asp:BoundField DataField="CaseID" HeaderText="CaseID" Visible="False" />
                        </Columns>
                        <AlternatingRowStyle CssClass="even" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">


    <style type="text/css">
        .style3
        {
            text-align: left;
        }
        .style25
        {
            font-size: small;
            font-weight: bold;
            color: #FFFFFF;
            font-family: "Times New Roman", Times, serif;
        }
        .style18
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style14
        {
            font-size: small;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style26
        {
            font-size: small;
            color: #FFFFFF;
            text-align: right;
            width: 189px;
            font-family: "Times New Roman", Times, serif;
            background-color: #293A21;
        }
        .style27
        {
            font-family: "Times New Roman", Times, serif;
        }
        .style24
        {
            font-weight: bold;
            color: #FFFFFF;
        }
        .style20
        {
            color: #FFFFFF;
        }
        .style31
        {
            font-weight: bold;
            color: #FFFFFF;
            font-family: "Courier New", Courier, monospace;
        }
        .style32
        {
            text-align: left;
            width: 205px;
        }
    .style33
    {
        font-size: small;
        color: #FFFFFF;
        text-align: right;
        width: 202px;
        font-family: "Times New Roman", Times, serif;
        background-color: #293A21;
    }
    </style>


</asp:Content>

