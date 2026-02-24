<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingOccasion.aspx.cs" Inherits="WebApplication1.Shopping.AddShoppingOccasion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Calendar ID="cndDate" runat="server"></asp:Calendar><br />
        <asp:TextBox ID="txtDesc" runat="server" Width="211px"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" /><br />
        <asp:Literal ID="lResult" runat="server"></asp:Literal>
    </p>
</asp:Content>
