<%@ Page Language="C#"  MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true"
    CodeBehind="ManageComplain.aspx.cs" Inherits="ECC_App.ManageComplain" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"  %>
<%@ Register assembly="obout_Calendar2_Net" namespace="OboutInc.Calendar2" tagprefix="obout" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" >
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                    <td height="173" align="center" valign="top">
                        <br />
                        <b>Submit Complain Form</b><table border="0" cellspacing="2" class="style7" style="width: 922px">
                            <tr>
                                <td colspan="4" style="text-align: center">
                                    <asp:Label ID="lblMsg" runat="server" 
                                        style="text-align: center; color: #FF0000"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Submission Date</span><span class="style18">&nbsp; تاریخ تسلیم 
                                    دهی</span><span class="style15">: </span>
                                </td>
                                <td class="style16">
                                    <asp:TextBox ID="txtSubDate" runat="server" Width="183px"></asp:TextBox>
                                    <obout:Calendar ID="dptSub" runat="server" Columns="1" 
                                        DatePickerImagePath="~/images/Calendar.gif" DatePickerMode="True" 
                                        StyleFolder="images/orbitz" TextBoxId="txtSubDate">
                                    </obout:Calendar>
                                    <asp:RequiredFieldValidator ID="rfv" runat="server" 
                                        ControlToValidate="txtSubDate" ErrorMessage="Select a Valid Date" 
                                        Font-Bold="False">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style31">Candidate&#39;s #</span><span class="style18"> شماره نامزد</span><span 
                                        class="style24">:</span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpCandidate" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv8" runat="server" 
                                        ControlToValidate="drpCandidate" ErrorMessage="Select Candidate #" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style29">
                                    <span class="style26">Kuchi </span><span class="style14">کوچی:</span>
                                </td>
                                <td class="style32">
                                    <asp:DropDownList ID="drpKuchi" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv1" runat="server" 
                                        ControlToValidate="drpKuchi" ErrorMessage="Select Yes/No" Font-Bold="False" 
                                        InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style17">
                                    <span class="style31">Complainant type</span> <span class="style24">نوعیت شخص 
                                    شاکی</span><span
                                        class="style24">: </span>
                                </td>
                                <td class="style23">
                                    <asp:DropDownList ID="drpComplaintType" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv9" runat="server" 
                                        ControlToValidate="drpComplaintType" ErrorMessage="Select Compainant Type" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Case Number</span> <span class="style18">شماره قضیه</span><span
                                        class="style14">:</span>
                                </td>
                                <td class="style33">
                                    <asp:TextBox ID="txtCaseNo" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                                </td>
                                <td class="style19">
                                    <span class="style24"><span class="style27">Respondant gender</span> </span><span
                                        class="style24">جنسیت شخص مشتکی</span><span class="style20"><b>:</b></span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpGender2" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv10" runat="server" 
                                        ControlToValidate="drpGender2" ErrorMessage="Select Respondant Gender" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Case priority </span><span class="style18">اولویت بندی 
                                    قضیه</span><span
                                        class="style14">:</span>
                                </td>
                                <td class="style33">
                                    <asp:DropDownList ID="drpCasePro" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv3" runat="server" 
                                        ControlToValidate="drpCasePro" ErrorMessage="Select Case Proirity" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style31">Respondant type</span> <span class="style24">نوعیت شخص 
                                    مشتکی</span><span
                                        class="style20"><b>:</b></span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpRespondantType" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv11" runat="server" 
                                        ControlToValidate="drpRespondantType" ErrorMessage="Select Respondant Type" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style14"><span class="style27">Triage Date</span> </span><span class="style18">
                                        تاریخ اولویت بندی</span><span class="style14">:</span>
                                </td>
                                <td class="style33">
                                    <asp:TextBox ID="txtTriDate" runat="server" Width="183px"></asp:TextBox>
                                   
                                    <obout:Calendar ID="dtpTriDate" runat="server" Columns="1"
                                        DatePickerImagePath="~/images/Calendar.gif" DatePickerMode="True" 
                                        TextBoxId="txtTriDate" StyleFolder="images/orbitz">
                                    </obout:Calendar>
                                    <asp:RequiredFieldValidator ID="rfv2" runat="server" 
                                        ControlToValidate="txtTriDate" ErrorMessage="Select a Valid Date" 
                                        Font-Bold="False">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style31">Allegation type</span><span class="style24"> نوعیت اتهام</span><span
                                        class="style24">:</span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpAllegationType" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv12" runat="server" 
                                        ControlToValidate="drpAllegationType" ErrorMessage="Select Allegation Type" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Province</span> <span class="style18">ولایت</span><span class="style14">:
                                    </span>
                                </td>
                                <td class="style33">
                                    <asp:DropDownList ID="drpProvince" runat="server" Width="200px" AutoPostBack="True"
                                        OnSelectedIndexChanged="drpProvince_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv4" runat="server" 
                                        ControlToValidate="drpProvince" ErrorMessage="Select Province" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style24">&nbsp;</span><span class="style24"><span class="style27">Responsible 
                                    Office</span> </span><span class="style24">دفتر مربوطه مسؤل:</span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpResponOffice" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv13" runat="server" 
                                        ControlToValidate="drpResponOffice" ErrorMessage="Select Responsible Office" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">District Name</span><span class="style15"> ا</span><span class="style18">سم 
                                    ولسوالی</span><span class="style14">:</span>
                                </td>
                                <td class="style33">
                                    <asp:DropDownList ID="drpDistrict" runat="server" Width="200px" AutoPostBack="True"
                                        OnSelectedIndexChanged="drpDistrict_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv5" runat="server" 
                                        ControlToValidate="drpDistrict" ErrorMessage="Select District" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style31">Status</span> <span class="style24">وضعیت</span><span class="style24">:</span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpStatus" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv14" runat="server" 
                                        ControlToValidate="drpStatus" ErrorMessage="Select Status" Font-Bold="False" 
                                        InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Polling Center</span> <span class="style18">مرکز رأیدهی</span><span
                                        class="style14">: </span>
                                </td>
                                <td class="style33">
                                    <asp:DropDownList ID="drpPC" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="drpPC" 
                                        ErrorMessage="Select Polling Center" Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    <span class="style31">Sanction type</span><span class="style20"><b> نوع تعزیر:</b></span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpSanctTypr" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv15" runat="server" 
                                        ControlToValidate="drpSanctTypr" ErrorMessage="Select Sanction Type" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Polling Station</span> <span class="style18">محل رأیدهی</span><span
                                        class="style14">: </span>
                                </td>
                                <td class="style33">
                                    <asp:TextBox ID="txtPS" runat="server" Width="200px"></asp:TextBox>
                                </td>
                                <td class="style3">
                                    <span class="style20"><b>&nbsp; </b></span><span class="style24"><span class="style27">
                                        Appeal</span> </span><span class="style20"><b>استیناف: </b></span>
                                </td>
                                <td class="style21">
                                    <asp:DropDownList ID="drpAppeal" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv16" runat="server" 
                                        ControlToValidate="drpAppeal" ErrorMessage="Select Appeal" Font-Bold="False" 
                                        InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Complainant gender</span> <span class="style18">جنسیت شخص 
                                    شاکی</span><span
                                        class="style14">: </span>
                                </td>
                                <td class="style33">
                                    <asp:DropDownList ID="drpGender1" runat="server" Width="200px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfv7" runat="server" 
                                        ControlToValidate="drpGender1" ErrorMessage="Select Complainant Gender" 
                                        Font-Bold="False" InitialValue="0">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style22">
                                    &nbsp;
                                </td>
                                <td class="style4">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style20"><b>&nbsp;</b></span><span class="style25">Allegation summary</span>
                                    <span class="style18">خلاصه اتهام</span><span class="style14">:</span>
                                </td>
                                <td class="style21" colspan="3">
                                    <asp:TextBox ID="txtSummary" runat="server" Height="99px" TextMode="MultiLine" Width="692px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style25">Decision</span> <span class="style18">تصمیم</span><span class="style14">:</span>
                                </td>
                                <td class="style21" colspan="3">
                                    <asp:TextBox ID="txtDecision" runat="server" Height="99px" TextMode="MultiLine" Width="692px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style28">
                                    <span class="style18">تصمیم دفتر مرکزی کمیسیون شکایات انتخاباتی</span><span class="style2"><span
                                        class="style6"><br class="style9" />
                                    </span><span><span class="style25">ECC HQ Decision</span></span></span><span class="style11"><span
                                        class="style2"><span class="style14">:</span></span></span>
                                </td>
                                <td class="style21" colspan="3">
                                    <asp:TextBox ID="txtECCDecision" runat="server" Height="99px" TextMode="MultiLine"
                                        Width="692px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4" style="text-align: left">
                                    <asp:ValidationSummary ID="vs" runat="server" Font-Bold="False" 
                                        Font-Names="Tahoma" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style30">
                                    &nbsp;
                                </td>
                                <td class="style4" colspan="3">
                                    &nbsp;
                                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click1" Text="Save" 
                                        Width="94px" />
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="94px" />
                                </td>
                            </tr>
                        </table>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .style2
        {
            height: 26px;
        }
        .style3
        {
            font-size: small;
            text-align: right;
            font-family: "Times New Roman" , Times, serif;
            color: #FFFFFF;
            background-color: #293A21;
            width: 224px;
        }
        .style4
        {
            height: 26px;
            font-size: small;
            text-align: center;
        }
        .style6
        {
            font-weight: bold;
        }
        .style7
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
        }
        .style9
        {
            font-size: small;
            color: #FFFFFF;
        }
        .style11
        {
            height: 26px;
            font-size: x-small;
        }
        .style14
        {
            font-size: small;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style15
        {
            height: 26px;
            font-size: small;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style16
        {
            font-size: small;
            text-align: left;
            font-weight: bold;
            font-family: "Times New Roman" , Times, serif;
            background-color: #FFFFFF;
            width: 229px;
        }
        .style17
        {
            height: 26px;
            font-size: small;
            text-align: right;
            font-weight: bold;
            font-family: "Times New Roman" , Times, serif;
            color: #FFFFFF;
            background-color: #293A21;
            width: 224px;
        }
        .style18
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style19
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
            font-family: "Times New Roman" , Times, serif;
            color: #FFFFFF;
            background-color: #293A21;
            width: 224px;
        }
        .style20
        {
            color: #FFFFFF;
        }
        .style21
        {
            height: 26px;
            font-size: small;
            text-align: left;
        }
        .style22
        {
            text-align: left;
            width: 224px;
        }
        .style23
        {
            height: 26px;
            text-align: left;
        }
        .style24
        {
            font-weight: bold;
            color: #FFFFFF;
        }
        .style25
        {
            font-size: small;
            font-weight: bold;
            color: #FFFFFF;
            font-family: Tahoma;
        }
        .style26
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
            color: #FFFFFF;
            font-family: Tahoma;
        }
        .style27
        {
            font-family: Tahoma;
        }
        .style28
        {
            font-size: small;
            text-align: right;
            font-weight: bold;
            font-family: "Times New Roman" , Times, serif;
            color: #FFFFFF;
            background-color: #293A21;
        }
        .style29
        {
            height: 26px;
            font-size: small;
            text-align: right;
            font-weight: bold;
            font-family: "Times New Roman" , Times, serif;
            color: #FFFFFF;
            width: 241px;
            background-color: #293A21;
        }
        .style30
        {
        }
        .style31
        {
            font-weight: bold;
            color: #FFFFFF;
            font-family: Tahoma;
        }
        .style32
        {
            height: 26px;
            text-align: left;
            width: 229px;
        }
        .style33
        {
            text-align: left;
            width: 229px;
            direction: ltr;
        }
    </style>
</asp:Content>
