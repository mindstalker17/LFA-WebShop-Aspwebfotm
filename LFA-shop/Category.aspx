<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="LFA_shop.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="category_gridview" runat="server" AutoGenerateColumns="False" Height="162px" ItemType="LFA_shop.Models.categoryModel" Width="360px">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="S.N" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
        </Columns>

    </asp:GridView>
</asp:Content>
