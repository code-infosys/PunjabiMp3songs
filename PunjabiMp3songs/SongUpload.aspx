<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="SongUpload.aspx.cs" Inherits="PunjabiMp3songs.SongUpload" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="css/uploadify.css" />
    <script type="text/javascript" src="scripts/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.uploadify.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div> 
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
        <h1 class="hcontrol">Upload Song Here</h1>
        
       
        <asp:TabContainer ID="TabContainer1"  runat="server" ActiveTabIndex="0" >
            <asp:TabPanel runat="server" HeaderText="Add Album" ID="tabDetail">
                <ContentTemplate>

                    <table>
                         
                        <tr>
                            <td>Album Name:</td>
                            <td>
                                <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Singer Name: </td>
                            <td>
                                <asp:TextBox ID="txtSingerName" runat="server"></asp:TextBox></td>
                        </tr>
                       
                        <tr>
                            <td>Album/Song Release Date:</td>
                            <td>
                                <asp:TextBox ID="txtSongReleaseDate" placeholder="mm/dd/yyyy" runat="server"></asp:TextBox>
                                <asp:CalendarExtender runat="server" Enabled="True" TargetControlID="txtSongReleaseDate" ID="txtSongReleaseDate_CalendarExtender"></asp:CalendarExtender>
                            </td>
                        </tr>
                       <%-- <tr>
                            <td>Song/Album Cover Image:</td>
                            <td>
                                <div class="file-uploader-button">

                                    <img src="images/file-uploader-icon.png" />

                                    <asp:FileUpload ID="FileUpImage" runat="server" CssClass="file-upload" />
                                    Select Image
                                </div>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>Album Tags:</td>
                            <td>
                                <asp:TextBox ID="txtTags" TextMode="MultiLine" placeholder="Eg: song name , singer, title etc" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Album Description:</td>
                            <td>
                                <asp:TextBox ID="txtDescription" placeholder="Describe about singer and song" TextMode="MultiLine" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <script>
                                    function fungo() {
                                        document.getElementById('<%=btnUPload.ClientID%>').style.display = "none";
                                        document.getElementById('fbtn').style.display = 'block';

                                    }
                                </script>



                                <asp:Button ID="btnUPload" OnClick="btnUPload_Click" OnClientClick="fungo()" runat="server" Text="Submit and Next" />
                                <span style="display: none; border-bottom: 1px solid; width: 100px;" id="fbtn" class="fackbutton">
                                    <img src="images/loading.gif" />
                                    <br />
                                    Uploading...</span>

                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                <asp:HiddenField ID="HideQsID" runat="server" />
                            </td>
                        </tr>

                    </table>

                </ContentTemplate>
            </asp:TabPanel>


            <asp:TabPanel runat="server" HeaderText="Add Songs" ID="tabUpload">

                <ContentTemplate>
                      <table>
                         
                        <tr>
                            <td>Song Name:</td>
                            <td>
                                <asp:TextBox ID="txtSongName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Song Url 1: </td>
                            <td>
                                <asp:TextBox ID="txtSongUrl1" runat="server"></asp:TextBox></td>
                        </tr>
                       <tr>
                            <td>Song Url 2: </td>
                            <td>
                                <asp:TextBox ID="txtSongUrl2" runat="server"></asp:TextBox></td>
                        </tr>

                           <tr>
                            <td>Song Url 3: </td>
                            <td>
                                <asp:TextBox ID="txtSongUrl3" runat="server"></asp:TextBox></td>
                        </tr>

                        
                        
                        <tr>
                            <td>Album Tags:</td>
                            <td>
                                <asp:TextBox ID="txtAlbumTags" TextMode="MultiLine" placeholder="Eg: song name , singer, title etc" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Album Description:</td>
                            <td>
                                <asp:TextBox ID="txtAlbumDescription" placeholder="Describe about singer and song" TextMode="MultiLine" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                          <tr>
                              <td>Is Add Top 20</td>
                              <td> <asp:CheckBox ID="chkTop20" runat="server" /> </td>
                          </tr>

                        <tr>
                            <td></td>
                            <td>
                                <script>
                                    function fungo() {
                                        document.getElementById('<%=btnUPload.ClientID%>').style.display = "none";
                                        document.getElementById('fbtn').style.display = 'block';

                                    }
                                </script>
                                 
                                <asp:Button ID="btnTrackUpload" OnClick="btnTrackUpload_Click" OnClientClick="fungo()" runat="server" Text="Submit" />
                                <span style="display: none; border-bottom: 1px solid; width: 100px;" id="Span1" class="fackbutton">
                                    <img src="images/loading.gif" />
                                    <br />
                                    Uploading...</span>

                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                
                            </td>
                        </tr>

                    </table>


                    <div style="overflow:auto;">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="LinqDataSourceAlbumWiseList" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                            <Columns>
                                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True"></asp:CommandField>
                                <asp:BoundField DataField="ID" Visible="false" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                 <asp:BoundField DataField="SongTitle" HeaderText="SongTitle" SortExpression="SongTitle"></asp:BoundField>
                                <asp:BoundField DataField="SongUrl1" HeaderText="SongUrl1" SortExpression="SongUrl1"></asp:BoundField>
                                <asp:BoundField DataField="SongUrl2" HeaderText="SongUrl2" SortExpression="SongUrl2"></asp:BoundField>
                                <asp:BoundField DataField="SongUrl3" HeaderText="SongUrl3" SortExpression="SongUrl3"></asp:BoundField>
                                 <asp:BoundField DataField="MetaTitle" HeaderText="MetaTitle" SortExpression="MetaTitle"></asp:BoundField>
                                <asp:BoundField DataField="MetaTags" HeaderText="MetaTags" SortExpression="MetaTags"></asp:BoundField>
                                <asp:BoundField DataField="MetaDescription" HeaderText="MetaDescription" SortExpression="MetaDescription"></asp:BoundField>
                                 <asp:CheckBoxField DataField="IsApproved" HeaderText="IsApproved" SortExpression="IsApproved"></asp:CheckBoxField>
                            </Columns>
                            <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                            <RowStyle BackColor="#EFF3FB"></RowStyle>

                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
                        </asp:GridView>
                        <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSourceAlbumWiseList" ContextTypeName="PunjabiMp3songs.MSContextDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" OrderBy="ID desc" TableName="TracksWrapers" Where="AlbumID == @AlbumID">
                            <WhereParameters>
                                <asp:QueryStringParameter QueryStringField="AlbumID" DefaultValue="0" Name="AlbumID" Type="Decimal"></asp:QueryStringParameter>
                            </WhereParameters>
                        </asp:LinqDataSource>
                    </div>



                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>

    </div>

    


</asp:Content>
