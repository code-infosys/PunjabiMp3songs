<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" EnableViewStateMac="false" EnableViewState="false" CodeBehind="SongDetail.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.SongDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Literal ID="LitTopInfo" runat="server"></asp:Literal>
      

    <div class="clear"></div>

    <asp:Literal ID="litSongBind" runat="server"></asp:Literal>

    <p class="track">
        <asp:LinkButton ID="lbtnPlay" OnClick="lbtnPlay_Click" runat="server">Play Online</asp:LinkButton>
    </p>
    <asp:HiddenField ID="hideSongPlay" runat="server" />
    <asp:Literal ID="LitPlayer" runat="server"></asp:Literal>


     


    <asp:Literal ID="litPostedByINFO" runat="server"></asp:Literal>


    <div class="head">
        <div class="fb-like" data-href="http://www.punjabimp3songs.in<%=Request.RawUrl.ToString()%>" data-layout="standard" data-action="like" data-show-faces="true" data-share="true"></div>
         
         
        <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>


      

        <script type="text/javascript" src="http://s7.addthis.com/js/300/addthis_widget.js#pubid=ra-53565a5a46086bbb"></script>

        <div id="addthis_responsive_sharing_8vvj"></div>


        <div id="fb-root"></div>
        <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>


        <div class="fb-comments" data-href="http://www.punjabimp3songs.in<%=Request.RawUrl.ToString()%>" data-numposts="5" data-colorscheme="dark"></div>

        <div style="clear: both;"></div>
    </div>
    <div>



        <div class="clear"></div>
    </div>

</asp:Content>
