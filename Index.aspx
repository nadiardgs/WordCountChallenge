<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WordCountChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Word Count Challenge</h1>
        <p></p>
        <p class="lead">Word Count Challenge é uma aplicação que permite contar o número de palavras digitadas na caixa de texto.</p>
        <p></p>
        <p>
            <asp:TextBox ID="textBox" TextMode="MultiLine" Height="100" Width="800" runat="server" ToolTip="Type your text here" Rows="10"></asp:TextBox>
        &nbsp;&nbsp;
            <asp:Label ID="lblMsg" runat="server" Visible="False" Font-Size="Medium" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Button ID="submitButton" Text="Enviar" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SubmitButton_Click"/>
        </p>
    </div>
</asp:Content>
