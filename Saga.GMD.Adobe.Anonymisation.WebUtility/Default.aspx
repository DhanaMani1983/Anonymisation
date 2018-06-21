<%@ Page Title="Adobe De-Anonymisation Utility" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Saga.GMD.Adobe.Anonymisation.WebUtility._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Adobe De-Anonymisation Utility</h1>
        <p class="lead">See de-anoymised Adobe data by searching for the Pers ID</p>
    </div>
    <p>
        <asp:Label ID="Pers_ID" runat="server" Text="Pers ID"></asp:Label>
        <asp:TextBox ID="Search_PersID" runat="server" Height="30px" OnTextChanged="Search_PersID_TextChanged" Width="255px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" Height="30px" OnClick="Button1_Click"/>
    </p>
    <hr />
    <div class="row">
        <div style="width: 518px; height: 400px; float:left">
            <asp:Label ID="Label1" runat="server" Text="Masked Data"></asp:Label>
            <br />
            <div id="obfuscatedData" style="height: 380px">
                <textarea id="TextArea1" name="S1" style="width: 500px; height: 350px" runat="server"></textarea></div>
        </div>
        <div style="width: 518px; height: 400px; float:right">
            <asp:Label ID="Label2" runat="server" Text="Unmasked Data"></asp:Label>
            <br />
            <div id="deAnonymisedData" style="height: 380px">
                <textarea id="TextArea2" cols="20" name="S2" rows="2" style="width: 500px; height: 350px" runat="server">
                </textarea></div>
        </div>
      <br />
      </div>
</asp:Content>
