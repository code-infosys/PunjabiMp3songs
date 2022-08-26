<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master"   EnableViewStateMac="false" EnableViewState="false"  AutoEventWireup="true" CodeBehind="ByMonthTracks.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.ByMonthTracks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        li
        { 
            list-style:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
     <h3 class="pageTitle">By Month Single Tracks</h3>
    <asp:Panel ID="PNLmonths" runat="server">

        <ul >

            <li><a class="aresfe" href="/single_-tracks/1/January 2014">January </a></li>

            <li><a class="aresfe" href="/single_-tracks/2/February 2014">February </a></li>
            <li><a class="aresfe" href="/single_-tracks/3/March 2014">March </a></li>
            <li><a class="aresfe" href="/single_-tracks/4/April 2014">April </a></li>
            <li><a class="aresfe" href="/single_-tracks/5/May 2014">May </a></li>
            <li><a class="aresfe" href="/single_-tracks/6/June 2014">June </a></li>
            <li><a class="aresfe" href="/single_-tracks/7/July 2014">July </a></li>
            <li><a class="aresfe" href="/single_-tracks/8/August 2014">August </a></li>
            <li><a class="aresfe" href="/single_-tracks/9/September 2014">September </a></li>
            <li><a class="aresfe" href="/single_-tracks/10/October 2014">October </a></li>
            <li><a class="aresfe" href="/single_-tracks/11/November 2014">November </a></li>
            <li><a class="aresfe" href="/single_-tracks/12/December 2014">December </a></li>
        </ul>
    </asp:Panel>
    <asp:Panel ID="pnlSongs" runat="server" Visible="false">

        <ul>


            <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">

                <EmptyDataTemplate>
                    <span>No data was returned.</span>
                </EmptyDataTemplate>

                <ItemTemplate> 
                    <li><a class="aresfe" href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"><%#Eval("SongTitle") %> <span class="highlight highlightOrange">(<%#Eval("SingerName") %>)</span> </a>
                        
                    </li>
                </ItemTemplate>


                <LayoutTemplate>

                    <div id="itemPlaceholderContainer" runat="server" style=""><span runat="server" id="itemPlaceholder" /></div>
                    <div style="margin-top: 10px;">
                        <asp:DataPager runat="server" ID="DataPager2">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                <asp:NumericPagerField></asp:NumericPagerField>
                                <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </div>
                </LayoutTemplate>


            </asp:ListView>

        </ul>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTracksByMonth" TypeName="PunjabiMp3songs.StarMethods">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="monthid" DefaultValue="0" Name="month" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:ObjectDataSource>


    </asp:Panel>
</asp:Content>
