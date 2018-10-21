<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="ComplainDetail.aspx.cs" Inherits="ECC_App.ComplainDetail" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script language="javascript" type="text/javascript">
    </script>

    <link href="Scripts/ModalDialogs.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .style4
        {
            text-align: left;
            font-style: normal;
        }
        .style15
        {
            font-size: 12px;
            background-color: #293A21;
            color: #FFFFFF;
            width: 269px;
            text-align: right;
            height: 23px;
        }
        .style16
        {
            text-align: left;
            font-style: normal;
            width: 229px;
            height: 23px;
        }
        .style17
        {
            text-align: right;
            color: #FFFFFF;
            font-size: small;
            width: 218px;
            height: 23px;
            background-color: #293A21;
        }
        .style8
        {
            font-size: 12px;
            background-color: #293A21;
            color: #FFFFFF;
            width: 269px;
            text-align: right;
            font-family: "Times New Roman", Times, serif;
        }
        .style10
        {
            font-family: Tahoma;
        }
        .style23
        {
            text-align: left;
            font-style: normal;
            width: 229px;
        }
        .style13
        {
            text-align: right;
            color: #FFFFFF;
            font-size: small;
            width: 218px;
            background-color: #293A21;
        }
        .style12
        {
            font-family: "Times New Roman", Times, serif;
            font-weight: normal;
            font-size: small;
        }
        .style24
        {
            font-size: 12px;
            background-color: #293A21;
            color: #FFFFFF;
            width: 269px;
            text-align: right;
        }
        .style20
        {
            text-align: right;
            color: #FFFFFF;
            font-size: small;
            width: 218px;
            font-family: "Times New Roman", Times, serif;
            background-color: #293A21;
        }
        .style22
        {
            text-align: right;
            color: #FFFFFF;
            font-weight: bold;
            font-size: small;
            width: 218px;
            font-family: "Times New Roman", Times, serif;
            background-color: #FFFFFF;
        }
        .style29
        {}
        .style30
        {
            text-align: left;
            font-style: normal;
            width: 111px;
        }
        .style31
        {
            font-family: Tahoma;
            font-weight: normal;
        }
        .style32
        {
            font-weight: normal;
        }
        .style33
        {
            font-family: "Times New Roman", Times, serif;
            font-weight: normal;
        }
        .style34
        {
            font-size: 12px;
            background-color: #293A21;
            color: #FFFFFF;
            width: 269px;
            text-align: right;
            height: 59px;
        }
        .style35
        {
            text-align: left;
            font-style: normal;
            height: 59px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td height="173" align="center" valign="top">
                <br />
                <form>
                <b>View Complain Detail Form<br />
                <asp:Label ID="lblMsg" runat="server" 
                    style="text-align: center; color: #FF0000; font-size: small"></asp:Label>
                </b><table border="0" cellspacing="2" class="style4" 
                    style="width: 922px">
                    <tr>
                        <td class="style15">
                            <span class="style31">Submission Date</span><span class="style33">&nbsp; تاریخ تسلیم 
                            دهی</span><span class="style32">: </span>
                        </td>
                        <td class="style16">
                            <asp:TextBox ID="txtSubDate" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style17">
                            <span class="style31">Candidate&#39;s #</span><span class="style33"> شماره نامزد</span><span 
                                class="style32">:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtCandidateNo" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            <span class="style31">Kuchi </span><span class="style29">کوچی:</span></td>
                        <td class="style23">
                            <asp:TextBox ID="txtKuchi" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                        <td class="style13">
                            <span class="style31">Complainant type</span> <span class="style12">نوعیت شخص 
                            شاکی</span><span class="style32">: </span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtComp_Type" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Case Number</span> <span class="style33">شماره قضیه</span><span 
                                class="style32">:</span></td>
                        <td class="style23">
                            <asp:TextBox ID="txtCaseNo" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style20">
                            <span class="style31">Respondant gender </span><span class="style33">جنسیت شخص 
                            مشتکی</span><span class="style29">:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtGender2" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Case priority </span><span class="style33">اولویت بندی 
                            قضیه</span><span 
                                class="style32">:</span></td>
                        <td class="style23">
                            <asp:TextBox ID="txtCasePro" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                        <td class="style20">
                            <span class="style31">Respondant type</span> <span class="style33">نوعیت شخص 
                            مشتکی</span><span class="style29">:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtResp_Type" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Triage Date </span><span class="style33">تاریخ اولویت بندی</span><span 
                                class="style32">:</span></td>
                        <td class="style23">
                            <asp:TextBox ID="txtTriDate" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style20">
                            <span class="style31">Allegation type</span><span class="style32"> نوعیت اتهام:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtAllage_Type" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Province</span> <span class="style33">ولایت</span><span 
                                class="style32">: </span>
                        </td>
                        <td class="style23">
                            <asp:TextBox ID="txtProvince" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                        <td class="style20">
                            &nbsp;<span class="style10">Responsible Office
                            </span>دفتر مربوطه مسؤل:</td>
                        <td class="style30">
                            <asp:TextBox ID="txtResp_Office" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">District Name</span><span class="style32"> ا</span><span 
                                class="style33">سم ولسوالی</span><span class="style32">:</span></td>
                        <td class="style23">
                            <asp:TextBox ID="txtDistrict" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                        <td class="style20">
                            <span class="style31">Status</span> <span class="style32">وضعیت:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtStatus" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Polling Center</span> <span class="style33">مرکز رأیدهی</span><span 
                                class="style32">: </span>
                        </td>
                        <td class="style23">
                            <asp:TextBox ID="txtPC" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                        <td class="style20">
                            <span class="style31">Sanction type</span><span class="style29"> نوع تعزیر:</span></td>
                        <td class="style30">
                            <asp:TextBox ID="txtSanction" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Polling Station</span> <span class="style33">محل رأیدهی</span><span 
                                class="style32">: </span>
                        </td>
                        <td class="style23">
                            <asp:TextBox ID="txtPS" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style20">
                            <b>&nbsp; </b> <span class="style31">Appeal </span><span class="style29">استیناف:
                            </span>
                        </td>
                        <td class="style30">
                            <asp:TextBox ID="txtAppeal" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                                                                </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Complainant gender</span> <span class="style33">جنسیت شخص 
                            شاکی</span><span class="style32">: </span>
                        </td>
                        <td class="style23">
                            <asp:TextBox ID="txtGender1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="259px" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style22">
                            &nbsp;
                        </td>
                        <td class="style30">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style34">
                            <b>&nbsp;</b><span class="style31">Allegation summary</span> <span class="style33">
                            خلاصه اتهام</span><span class="style32">:</span></td>
                        <td class="style35" colspan="3">
                            <asp:TextBox ID="txtSummary" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Height="99px" TextMode="MultiLine" Width="743px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style31">Decision</span> <span class="style33">تصمیم</span><span 
                                class="style32">:</span></td>
                        <td class="style4" colspan="3">
                            <asp:TextBox ID="txtDecision" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Height="99px" TextMode="MultiLine" Width="743px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            <span class="style33">تصمیم دفتر مرکزی کمیسیون شکایات انتخاباتی</span><span class="style11"><span 
                                class="style29"><br />
                            </span>
                            <span class="style31">ECC HQ Decision</span><span class="style29">:</span></span></td>
                        <td class="style4" colspan="3">
                            <asp:TextBox ID="txtEccHQDecision" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Height="99px" TextMode="MultiLine" Width="743px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    </table>
</asp:Content>
