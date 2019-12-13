<%@ Page Title="Session" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="NumerologyCalculator.Session" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div >   
        <br /> <br />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <br /> <br />
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
        <br /> <br />
        <asp:Button ID="ButtonSendData" runat="server" Text="Send Data" OnClick="ButtonSendData_Click" />
    </div>

    <br />
    <br />
</asp:Content>
