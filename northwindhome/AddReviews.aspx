<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="AddReviews.aspx.cs" Inherits="AddReviews" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:DropDownList ID="DropDownListProducts" runat="server" OnSelectedIndexChanged="DropDownListProducts_Redirect">
    </asp:DropDownList>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
      <ajaxToolkit:Rating ID="RatingProduct" runat="server"
   
    CurrentRating="0"
    StarCssClass="ratingStar"
    WaitingStarCssClass="savedRatingStar"
    FilledStarCssClass="filledRatingStar"
    EmptyStarCssClass="emptyRatingStar" Direction="LeftToRight" Height="40px">


    </ajaxToolkit:Rating>
    
    <br />
    <asp:TextBox ID="TextBoxReview" runat="server" Height="68px" Width="369px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
     <asp:Label ID="LabelErrorMessage" runat="server" />
</asp:Content>

