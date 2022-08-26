<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"   EnableViewStateMac="false" EnableViewState="false"  CodeBehind="latestalbDetail.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.latestalbDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="pageTitle">Album Tracks</h3>
     
    <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">

        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>

        <ItemTemplate>
            <a href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"><%#Eval("SongTitle") %> <span class="highlight highlightOrange">(<%#Eval("DownloadCount").ToString() %> Downloads) </span></a>

        </ItemTemplate>
         
        <LayoutTemplate>

            <div id="itemPlaceholderContainer" runat="server" style=""><span runat="server" id="itemPlaceholder" /></div>
            <div style="margin-top: 10px;">
                <asp:DataPager runat="server" ID="DataPager2">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="buttonWrapper buttonPink buttonArrowLeft" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                        <asp:NumericPagerField CurrentPageLabelCssClass="highlight highlightBlue" NumericButtonCssClass="highlight highlightOrange"></asp:NumericPagerField>
                        <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="buttonWrapper buttonPink buttonArrowRight" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
         
    </asp:ListView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAlbumsDetail" TypeName="PunjabiMp3songs.StarMethods">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="laID" Type="Decimal" DefaultValue="0" Name="albumid" />
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>
