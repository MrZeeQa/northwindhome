<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ShippersOverview.aspx.cs" Inherits="ShippersOverview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Een overzicht van alle Shippers</h2>
    <br />
    <asp:GridView ID="GridViewShippers" runat="server"></asp:GridView>
</asp:Content>

