<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="AddProducts.aspx.cs" Inherits="AddProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="PanelFormInsert" runat="server">
    <table cellpadding="0" cellspacing="0" border="0">
 <tr height="26">
 <td>Naam product: </td>
 <td><asp:TextBox ID="TextBoxProductName" runat="server" /></td>
 </tr>
 <tr height="26">
 <td>Leverancier: </td>
 <td><asp:DropDownList ID="DropDownListSuppliers" runat="server" AutoPostBack="false" OnSelectedIndexChanged="DropDownListSuppliers_Redirect"  /></td>
 </tr>
 <tr height="26">
 <td>Categorie: </td>
 <td><asp:DropDownList ID="DropDownListCategories" runat="server" AutoPostBack="false" OnSelectedIndexChanged="DropDownListCategories_Redirect"  /></td>
 </tr>
 <tr height="26">
 <td>Hoeveelheid/stuk: </td>
 <td><asp:TextBox ID="TextBoxQuantityPerUnit" runat="server" /></td>

 </tr>
 <tr height="26">
 <td>Eenheidsprijs: </td>
 <td><asp:TextBox ID="TextBoxUnitPrice" runat="server" /></td>
 </tr>
 <tr height="26">
 <td><asp:Button ID="ButtonSubmit" Text="Verzenden" runat="server"
 onclick="ButtonSubmit_Click" /></td>
 </tr>
 </table>
 <asp:Label ID="LabelErrorMessage" runat="server" />
    </asp:Panel>
    <asp:Panel ID="PanelUserMessage" runat="server">
        De gegevens werden correct opgeslagen.
    </asp:Panel>
</asp:Content>

