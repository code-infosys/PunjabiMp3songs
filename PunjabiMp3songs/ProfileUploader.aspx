<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="ProfileUploader.aspx.cs" Inherits="PunjabiMp3songs.ProfileUploader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="hcontrol">Manage Your Profile</h1>
    <br />
     
    <asp:Image ID="userimage" runat="server" style="width:80px;" />
     <br />

    <table>
        <tr>
            <td>Change Image </td><td>
                 <div class="file-uploader-button"> 
                        <img src="images/file-uploader-icon.png" /> 
                        <asp:FileUpload ID="FUimgCover" runat="server" CssClass="file-upload" />
                        Select Image
                    </div>
             </td>
        </tr>
        <tr>
            <td>Gmail Link: </td><td>
                <asp:TextBox ID="txtGmailLink" Width="200" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td>Facebook Link: </td><td>
                 <asp:TextBox ID="txtFbLInk" Width="200" runat="server"></asp:TextBox>
                                   </td>
        </tr>
        <tr>
            <td>Mobile No: </td><td><asp:TextBox ID="txtMobileNO" Width="200" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td >
                <fieldset>
                    <legend>Note: Fill Then if You Want To Change</legend>
                    <asp:TextBox ID="txtPassword" TextMode="Password" Width="200" runat="server"></asp:TextBox>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td> </td><td> <asp:Button OnClick="btnUpdate_Click" ID="btnUpdate" runat="server" Text="Update Profile" /> </td>
        </tr>
        
    </table>


    <br />
</asp:Content>
