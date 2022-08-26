<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="YouUpload.aspx.cs" Inherits="PunjabiMp3songs.BackEndStar.YouUpload" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
    
        <telerik:RadProgressManager runat="server" ID="RadProgressManager" />


    <h2>You Songs Uploader</h2>

    <span style="color:red;">Note:</span>Fill Email Address and Mobile number should be a Valid. Otherwise your uploaded song will not approved.
    <br />
    <br />
      
    Email ID:
    <asp:TextBox ID="txtEmailID" runat="server" placeholder="Your Email ID" CssClass="contactField"></asp:TextBox>
    Mobile Number:
     <asp:TextBox ID="txtMobileNumber" runat="server" placeholder="Your Mobile Number" CssClass="contactField"></asp:TextBox>
    Song Name:
 <asp:TextBox ID="txtSongName" runat="server" placeholder="Song Name" CssClass="contactField"></asp:TextBox>
    Singer Name:
 <asp:TextBox ID="txtSingerName" runat="server" placeholder="Singer Name" CssClass="contactField"></asp:TextBox>

    About Song:
 <asp:TextBox ID="txtAboutSong" placeholder="About Your Song" runat="server" TextMode="MultiLine" CssClass="contactField"></asp:TextBox>
   
    Select Song File:
    
    <asp:FileUpload ID="FileUpload1" runat="server" />
 <br /><br />
    <img src="../images/loading.gif" id="dvimg"  style="display:none;"/>
   
    <asp:Button ID="buttonSubmit" runat="server" CssClass="btn" OnClick="btnUpload_Click" OnClientClick="document.getElementById('dvimg').style.display='block'" Text="Start Upload" />
       <telerik:RadProgressArea runat="server" ID="RadProgressArea1" />


        
     <asp:Label ID="lblMsg" runat="server" Visible="false" Text="Your Song Is Uploaded Successfully .while this is approved by Us then we will notify to you on your email address"></asp:Label>
   
</asp:Content>
