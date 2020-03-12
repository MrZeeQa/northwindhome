<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ProductsByCategory.aspx.cs" Inherits="ProductsByCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:DropDownList ID="DropDownListCategories" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownListCategories_Redirect" /> 
    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridViewProducts_Redirect"> 
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="Productnaam" />
            <asp:BoundField DataField="QuantityPerUnit" HeaderText="Aantal/stuk" />
            <asp:BoundField DataField="UnitPrice" DataFormatString="&quot;{0:c}&quot;" HeaderText="Prijs" />
        </Columns>
    </asp:GridView>
</asp:Content>

