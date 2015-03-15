<%@ Page Title="Distance" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Distance.aspx.vb" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        This app allows you to calculate distance.</p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="City" DataValueField="Id"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" DataSourceID="SqlDataSource1" DataTextField="City" DataValueField="Id"></asp:ListBox>
    </p>
<p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [City], [CityLatitude], [CityLongitude] FROM [City]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Calculate Distance" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

