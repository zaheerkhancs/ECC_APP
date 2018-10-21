<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="Case_Priorty.aspx.cs" Inherits="ECC_App.Case_Priorty" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:Button ID="btnHiddenPerson" runat="Server" Style="display: none" />
        <cc1:ModalPopupExtender ID="mpePerson" runat="server" TargetControlID="btnHiddenPerson" PopupControlID="pnlPerson" CancelControlID="btnCancelPerson" BackgroundCssClass="modalBackground" PopupDragHandleControlID="PersonCaption" Drag="true">
        </cc1:ModalPopupExtender>
        <table style="width: 100%;" width="100%">
            <tr>
                <td class="style2">
                    <asp:Panel ID="pnlPerson" runat="server" CssClass="modalBox" Style="display: none;" Width="500px">
				      <asp:Panel ID="pnlManage" runat="server" CssClass="caption" Style="margin-bottom: 10px; cursor: hand;">
                          Case Proirity</asp:Panel>
				<asp:HiddenField ID="hidPersonEditIndex" runat="server" Value="-1" />
				<div class="divCol">
					Case Proority ID:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCaseProID" runat="server" MaxLength="64" Width="250" 
                        Enabled="False" ></asp:TextBox>
				</div>
				<div class="clearer">
				</div>
    <div class="divCol">
					Case Proirity Name:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCaseProName" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>
				<div class="clearer">
				</div>
				<div class="clearer">
				</div>
				<div style="white-space: nowrap; text-align: center;">
					<asp:Button ID="btnSavePerson" runat="server" Text="Save" OnClick="btnSavePerson_Click" CausesValidation="true"/>
					<asp:Button ID="btnCancelPerson" runat="server" CausesValidation="false" Text="Cancel"/>
				</div>
			</asp:Panel></td>
            </tr>
            <tr>
                <td class="style3">
                    Case Priority</td>
            </tr>
            <tr>
                <td class="style2">
                        <table style="width: 488px" align="center">
        <tr>
            <td colspan="3">
               <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" Font-Names="Tahoma" 
                        Font-Size="Small" Width="100%">
                        <Columns>
                            <asp:BoundField DataField="caseProID" HeaderText="Case Priorty ID" 
                                ItemStyle-Width="180px">
                                <ItemStyle Width="180px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="caseProName" HeaderText="Case Priority" 
                                ItemStyle-Width ="300px" >
                                <ItemStyle Width="300px" />
                            </asp:BoundField>
                            <asp:TemplateField ItemStyle-Width="10px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgEdit" runat="server" 
                                        CommandArgument='<%# Eval("caseProID") %>' ImageUrl="~/images/edt.gif" 
                                        oncommand="imgEdit_Command" Width="16px" />
                                </ItemTemplate>
                                <ItemStyle Width="10px" />
                            </asp:TemplateField>
                        </Columns>
                        <AlternatingRowStyle CssClass="even" />
                    </asp:GridView>
            </td>
        </tr>
                </table>
                </td>
            </tr>
        
            <tr>
                <td class="style2"></td>
            </tr>
        </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            font-weight: bold;
            font-size: small;
        }
    .clearer
    {
        width: 497px;
    }
    </style>

</asp:Content>

