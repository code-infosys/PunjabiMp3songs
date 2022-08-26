<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"  EnableViewStateMac="false" EnableViewState="false"  CodeBehind="Top20MonthlyTracks.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.Top20MonthlyTracks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 class="hcontrol">TOP 20 Monthly Single Tracks</h1>

     <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">
         
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
         
        <ItemTemplate>  

               <a class="aresfe" href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"> <%#Eval("SongTitle") %>  <span class="highlight highlightOrange">(<%#Eval("SingerName") %>)</span>  </a>
           <br />
        </ItemTemplate>


        <LayoutTemplate>

            <div id="itemPlaceholderContainer" runat="server" style=""><span runat="server" id="itemPlaceholder" /></div>
            <div style="margin-top:10px;">
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

     
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTracksRecAndTop20weekAndTop20month" TypeName="PunjabiMp3songs.StarMethods">
            <SelectParameters>
                <asp:Parameter Type="String" DefaultValue="Top20month" Name="action" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
</asp:Content>
