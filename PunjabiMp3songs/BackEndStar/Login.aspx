<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PunjabiMp3songs.BackEndStar.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
         .head
         {
              color:#ffffff !important;
             background:#000 !important;
         }
        .head a
        {
            color:#000 !important;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="hcontrol">Login Here</h1>

    <asp:Panel ID="pnls" runat="server" DefaultButton="btnSubmit">
        <table class="pastedtable">
            <tr>
                <td><b>Email ID: </b></td>
                <td>

                    <asp:TextBox ID="txtEamailID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><b>Password: </b></td>
                <td>
                    <asp:TextBox ID="txtPw" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <script>
                        function fungo() {
                            document.getElementById('<%=btnSubmit.ClientID%>').style.display = "none";
                            document.getElementById('fbtn').style.display = 'block';

                        }
                    </script>
                    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" OnClientClick="fungo()" runat="server" Text="Login" />
                    <span style="display: none;" id="fbtn" class="fackbutton">Wait...</span>



                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
