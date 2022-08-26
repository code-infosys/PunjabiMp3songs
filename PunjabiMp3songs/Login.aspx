<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PunjabiMp3songs.Login" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="hcontrol">Login Here</h1>

    <asp:Panel ID="pnls" runat="server" DefaultButton="btnSubmit">

        <b>Email ID: </b>
        <asp:TextBox ID="txtEamailID" runat="server"></asp:TextBox>
        <b>Password: </b>
        <asp:TextBox ID="txtPw" TextMode="Password" runat="server"></asp:TextBox>

        <script>
            function fungo() {
                document.getElementById('<%=btnSubmit.ClientID%>').style.display = "none";
                 document.getElementById('fbtn').style.display = 'block';

             }
        </script>
        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" OnClientClick="fungo()" runat="server" Text="Login" />
        <span style="display: none;" id="fbtn" class="fackbutton">Wait...</span>
         
        <asp:Label ID="lblmsg" runat="server"></asp:Label>

 

    </asp:Panel>
</asp:Content>
