<%@ Page Title="" Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="Bag.aspx.cs" Inherits="Pages.Pages_Bag" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Select Type:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlTypeDropDown" DataTextField="type" DataValueField="type" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlTypeDropDown" runat="server" ConnectionString="<%$ ConnectionStrings:bagsConnection %>" SelectCommand="SELECT DISTINCT [type] FROM [Bags] ORDER BY [type]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>

