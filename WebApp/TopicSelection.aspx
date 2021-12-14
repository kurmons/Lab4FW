<%@ Page Title="" UnobtrusiveValidationMode="None" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TopicSelection.aspx.cs" Inherits="WebApp.TopicSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Noslēguma darbu tēmas rezervēšana</h1>
    <asp:MultiView ID="mvTopicSelection" runat="server" ActiveViewIndex="0">
        <asp:View ID="vwTopicSelection" runat="server">
            <h2>1. solis - studiju līmeņa un tēmas izvēle:</h2>
            <asp:Label ID="lblQualifLevel" runat="server" Text="Studiju līmenis:" AssociatedControlID="ddlQualifLevel"></asp:Label>
            <asp:DropDownList ID="ddlQualifLevel" runat="server" AutoPostBack="True" DataSourceID="QualifLevel" DataTextField="LevelDescription" DataValueField="LevelId">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="QualifLevel" runat="server" SelectMethod="GetData" TypeName="DataModel.QualifLevel"></asp:ObjectDataSource>
            <asp:GridView ID="gvTopicSelection" runat="server" AutoGenerateColumns="False" CssClass="table" DataKeyNames="TopicID" DataSourceID="TopicSelectionDataSource" OnSelectedIndexChanged="gvTopicSelection_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Supervisor" HeaderText="Vadītājs" ReadOnly="True" SortExpression="Supervisor" />
                    <asp:BoundField DataField="Topic" HeaderText="Tēma" SortExpression="Topic" />
                    <asp:BoundField DataField="SelectionCnt" HeaderText="Rezervāciju skaits" ReadOnly="True" SortExpression="SelectionCnt" />
                    <asp:CommandField ButtonType="Button" SelectText="Izvēlēties" ShowSelectButton="True">
                    <ControlStyle CssClass="btn btn-xs" />
                    </asp:CommandField>
                </Columns>
                <EmptyDataTemplate>
                    <span class="alert-warning">Izvēlētajam studiju līmenim netiek piedāvāta neviena tēma</span>
                </EmptyDataTemplate>
                <SelectedRowStyle BackColor="Silver" />
            </asp:GridView>
            <asp:ObjectDataSource ID="TopicSelectionDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataModel.DataModelDataSetTableAdapters.TopicSelectionTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlQualifLevel" DefaultValue="0" Name="QualifLevel" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:View>
        <asp:View ID="vwStudentData" runat="server">
            <h2>2. solis - studenta datu ievade:</h2>
            <asp:Label ID="lblTopicName" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <asp:Label ID="lblTopicSupervisor" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <asp:Label ID="lblStudentName" runat="server" Text="Vārds:" AssociatedControlID="txtStudentName" CssClass="sr-only"></asp:Label>
            <asp:TextBox ID="txtStudentName" placeholder="Vārds" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valStudentName" runat="server" ErrorMessage="Vārds jānorāda obligāti" ControlToValidate="txtStudentName" CssClass="alert-danger"></asp:RequiredFieldValidator>
            <br>
            <asp:Label ID="lblStudentSurname" runat="server" Text="Uzvārds:" AssociatedControlID="txtStudentSurname" CssClass="sr-only"></asp:Label>
            <asp:TextBox ID="txtStudentSurname" placeholder="Uzvārds" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valStudentSurname" runat="server" ErrorMessage="Uzvārds jānorāda obligāti" ControlToValidate="txtStudentSurname" CssClass="alert-danger"></asp:RequiredFieldValidator>
            <br>
            <asp:Label ID="lblStudentId" runat="server" Text="Apliecības nr:" AssociatedControlID="txtStudentId" CssClass="sr-only"></asp:Label>
            <asp:TextBox ID="txtStudentId" placeholder="Apliecības nr" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valStudentId0" runat="server" ErrorMessage="Apl. nr. jānorāda obligāti" ControlToValidate="txtStudentId" CssClass="alert-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="valStudentId1" runat="server" ErrorMessage="Nepareizs apliecības nr." ValidationExpression="^[1-9]\d{2}[R|L|D|V][A-Z][A-Z]\d{3}$" CssClass="alert-danger" ControlToValidate="txtStudentId"></asp:RegularExpressionValidator>
            <br>
        </asp:View>
    </asp:MultiView>
    <asp:Button ID="btnBack" runat="server" Text="Atpakaļ" CausesValidation="False" CssClass="btn" OnClick="btnBack_Click" />
    &nbsp;
    <asp:Button ID="btnNext" runat="server" Text="Turpināt" CssClass="btn" OnClick="btnNext_Click" />
    &nbsp;
    <asp:Button ID="btnReserve" runat="server" Text="Rezervēt" CssClass="btn btn-primary" OnClick="btnReserve_Click" />
    <div class="well">
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>
</asp:Content>
