<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingItem.aspx.cs" Inherits="WebApplication1.Shopping.AddShoppingItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="ddlShoppingPlaces" runat="server"></asp:DropDownList> <br />
    <asp:DropDownList ID="ddlShoppingOccasions" runat="server"></asp:DropDownList> <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br />
    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox> <br />
    <asp:TextBox ID="txtUniOfMeasure" runat="server"></asp:TextBox> <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" /> <br />
    <asp:Literal ID="lResult" runat="server"></asp:Literal>
</asp:Content>
