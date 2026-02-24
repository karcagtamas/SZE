<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListShoppingItems.aspx.cs" Inherits="WebApplication1.Shopping.ListShoppingItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:DropDownList ID="ddlSelectedDate1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Date" DataValueField="ShoppingOccasionId"></asp:DropDownList> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MySqlServerConnString %>" SelectCommand="SELECT [ShoppingOccasionId], [Date] FROM [ShoppingOccasion]"></asp:SqlDataSource>
        <br />
        <asp:DropDownList ID="ddlSelectedDate2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Date" DataValueField="ShoppingOccasionId"></asp:DropDownList> 
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MySqlServerConnString %>" SelectCommand="SELECT ShoppingOccasionId, Date FROM ShoppingOccasion WHERE (Date &gt; GETDATE()) ORDER BY Date"></asp:SqlDataSource>
        <br />
        <asp:DropDownList ID="ddlSelectedDate3" runat="server"></asp:DropDownList> <br />
        <asp:DropDownList ID="ddlSelectedDate4" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Text" DataValueField="Value" AutoPostBack="True" OnSelectedIndexChanged="ddlSelectedDate4_SelectedIndexChanged"></asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetFutureShoppingOccasions" TypeName="WebApplication1.App_Code.ShoppingQueries"></asp:ObjectDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="ShoppingItemId" HeaderText="ShoppingItemId" SortExpression="ShoppingItemId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="UnitOfMeasure" HeaderText="Unit Of Measure" SortExpression="UnitOfMeasure" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetShoppingItems" TypeName="WebApplication1.App_Code.ShoppingQueries">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlSelectedDate4" DefaultValue="1" Name="occasionId" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <br />
    <p>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource3"></asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetShoppingItemGridViewModels" TypeName="WebApplication1.App_Code.ShoppingQueries">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlSelectedDate4" DefaultValue="1" Name="occasionId" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>
