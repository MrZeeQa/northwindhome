<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="InsertShipper.aspx.cs" Inherits="InsertShipper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Voeg een nieuwe shipper toe</h2><br />
    <asp:Panel ID="PanelFormInsert" runat="server">
 Voer de bedrijfsnaam in:<br />
 <asp:TextBox ID="TextBoxCompanyName" runat="server" /><br /><br />
 Voer de telefoonnummer in:<br />
 <asp:TextBox ID="TextBoxTelephoneNumber" runat="server" />
 <br /><br /><br />
 <asp:Button ID="ButtonSubmit" Text="Verzenden" runat="server" OnClick="ButtonSubmit_Click" />
    <asp:Label ID="LabelErrorMessage" runat="server" />

    </asp:Panel>
    <asp:Panel ID="PanelUserMessage" runat="server">
        De gegevens werden correct opgeslagen.
    </asp:Panel>
</asp:Content>

