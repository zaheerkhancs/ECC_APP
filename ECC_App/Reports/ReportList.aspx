<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="ReportList.aspx.cs" Inherits="ECC_App.ReportList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
    .style2
    {
        font-family: Tahoma;
        font-weight: bold;
        font-size: small;
    }
    .style3
    {
        width: 146px;
        font-weight: bold;
        font-size: small;
        font-family: Tahoma;
        background-color: #293A21;
    }
    .style4
    {
        width: 146px;
        color: #FFFFFF;
        font-weight: bold;
        font-size: small;
        font-family: Tahoma;
        background-color: #293A21;
    }
    .style7
    {
        text-align: left;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%;" width="100%">
        <tr>
            <td class="style2" colspan="2">
                &nbsp; ECC Reports List</td>
        </tr>
        <tr>
            <td class="style3" rowspan="4" style="text-align: center; color: #FFFFFF;">
                <spa&nbsp; </span><spaProvincal Overview</span>Provincial OverView</td>
            <td style="text-align: left">
                <asp:LinkButton ID="ComplainProirity" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="ComplainProirity_Click">Complaint Priorties</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="Complaint_Status" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="Complaint_Status_Click">Status Of Complain</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="StatusA_Complaint" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="StatusA_Complaint_Click">Status of Type A Complaint</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" rowspan="5">&nbsp; Provincial Analysis</td>
            <td class="style7">
                <asp:LinkButton ID="RespondentType" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="RespondentType_Click">Respondent 
                Type</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="AllegationType" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="AllegationType_Click1">Allegation 
                Type</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="ComplainType" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="ComplainType_Click">Complaint 
                Type</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="SanctionType" runat="server" 
                    style="font-weight: 700; font-size: small" onclick="SanctionType_Click">Sanction 
                Type</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" rowspan="4">
                Complaints Analysis</td>
            <td class="style7">
                <asp:LinkButton ID="Complaint_Gender" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="Complaint_Gender_Click">Gender and Complainants</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:LinkButton ID="Respondent_Gender" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="Respondent_Gender_Click">Gender and Respondents</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="Complaint_Candidate" runat="server" 
                    style="font-weight: 700; font-size: small" 
                    onclick="Complaint_Candidate_Click">Complaints against candidate number</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" rowspan="8">
                National Aggregates</td>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic_Click">Allegation summary خلاصه اتهام</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic0" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic0_Click"> Complainant type نوعیت شخص شاکی </asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic1" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic1_Click">Respondant type نوعیت شخص مشتکی</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic2" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic2_Click"> Sanction type نوع تعزیر</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic3" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic3_Click">Status وضعیت</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic4" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic4_Click">PECC Decision</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:LinkButton ID="lnkStatistic5" runat="server" 
                    
                    style="font-weight: 700; font-size: small; font-family: Tahoma;" 
                    onclick="lnkStatistic5_Click">HeadQuarter Decision</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
