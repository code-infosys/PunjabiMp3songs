<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" EnableViewStateMac="false" EnableViewState="false" ViewStateMode="Disabled" CodeBehind="Default.aspx.cs" Inherits="PunjabiMp3songs.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .pageWrapper singlePostPageWrapper
        {
            background:none !important;
        }
        .singlePostContentWrapper
        {
            background:none !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- page wrapper starts -->
            <div class="pageWrapper landingPageWrapper">
                <!-- landing page logo wrapper starts -->
                <a href="#" class="landingLogoWrapper">
                    <img src="<%=Page.ResolveUrl("~/Theme/images/common/landingLogo.png") %>" class="landingLogo" alt="" /></a>
                <!-- landing page logo wrapper ends -->
            </div>
            <!-- page wrapper ends -->


</asp:Content>
