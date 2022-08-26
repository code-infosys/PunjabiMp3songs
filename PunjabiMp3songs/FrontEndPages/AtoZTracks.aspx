<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"   EnableViewStateMac="false" EnableViewState="false"  CodeBehind="AtoZTracks.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.AtoZTracks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <h1 class="hcontrol">A to Z Single Tracks</h1>

     <asp:Literal ID="litabdc" runat="server"></asp:Literal>

     <asp:Panel ID="pnlSongs" runat="server" Visible="false">
    
     
    <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">
         
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
         
        <ItemTemplate>  
               <a class="aresfe" href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"> <%#Eval("SongTitle") %> <span class="highlight highlightOrange">(<%#Eval("SingerName") %>)</span></a>
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



        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTracksAtoZ" TypeName="PunjabiMp3songs.StarMethods">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="alphaid" Name="albpa" Type="String"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:ObjectDataSource>
        

    </asp:Panel>

</asp:Content>
