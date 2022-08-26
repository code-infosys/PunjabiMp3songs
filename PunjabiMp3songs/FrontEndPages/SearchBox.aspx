<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SearchBox.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.SearchBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="pageWrapper errorPageWrapper"> 
    
     <div class="pageContentWrapper">

        <h3 class="pageTitle">Search Here</h3>

        <p>You can search here by song and singer name wise.</p>

        <div class="textBreak"></div>
        <!-- 404 search form starts -->
        <div class="errorSearchForm">
             
             <asp:TextBox ID="txtSearch" CssClass="errorSearchFormField" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" OnClick="btnSearch_Click" CssClass="buttonWrapper errorSearchFormSubmitButton" runat="server" Text="Search" />
             
               
        </div>
        <!-- 404 search form ends -->
        <div class="pageBreak"></div>
    </div>
 </div>

    



    <div class="pageWrapper blogPageWrapper">
        <!-- blog posts wrapper starts -->
        <div class="blogPostsWrapper">

             

            <asp:ListView ID="ListViewSongs" runat="server" OnPagePropertiesChanged="ListViewSongs_PagePropertiesChanged">

                <EmptyDataTemplate>
                    <span>No data was returned.</span>
                </EmptyDataTemplate>

                <ItemTemplate>
                    
                    <div class="smallPostWrapper">
                        <img src="images/content/small-1-1.jpg" alt="" />
                        <div class="postExcerptWrapper">
                         <a  href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>">
                                <h4 class="smallPostTitle"><%#Eval("SongTitle") %> </h4> </a>
                            <p>Sing By <%#Eval("SingerName") %></p>
                        </div>
                        <div class="smallPostInfoWrapper">
                            <span class="singleIconWrapper singleIconText iconCalendarDark postInfo postDate postInfoNoMargin"><%# Convert.ToDateTime(Eval("DateAdded")).ToString("dd MMM yyyy") %></span>
                            <a class="smallPostMoreButton" href="/single_track_list/<%#Eval("ID") %>/<%#Eval("SongTitle") %>"><%#Eval("SongTitle") %>  view result</a>
                        </div>
                    </div>

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
             


        </div>
    </div>

</asp:Content>
