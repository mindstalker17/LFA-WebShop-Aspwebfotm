<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="LFA_shop.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="product_gridview" runat="server" AutoGenerateColumns="False" ItemType="LFA_shop.Models.productModel">
        <Columns>
            <asp:BoundField DataField="Product_id" HeaderText="SN" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:TemplateField HeaderText="Image">
                
                <ItemTemplate>
                    <img alt="" src="/Content/Image/<%#: Item.Image %>" height="50px" />
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
