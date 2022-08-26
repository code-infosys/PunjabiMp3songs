<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"   EnableViewStateMac="false" EnableViewState="false"  CodeBehind="latestalb.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.latestalb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <h3 class="pageTitle">Latest Albums</h3>
    
             <asp:ListView ID="ListViewFriendList" runat="server" DataSourceID="ObjectDataSource1">

                <EmptyDataTemplate>
                    <span>No data was returned.</span>
                </EmptyDataTemplate>

                <ItemTemplate>  
                        <a  href="/latest_album/<%#Eval("ID") %>/<%#Eval("AlbumName") %>"><%#Eval("AlbumName") %> <span class="highlight highlightOrange">(<%#Eval("SingerName") %>)</span> </a> <br />
                         
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
              
        


         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAlbums" TypeName="PunjabiMp3songs.StarMethods">  </asp:ObjectDataSource>
     

</asp:Content>
