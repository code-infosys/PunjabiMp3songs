<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="singletrack.aspx.cs" Inherits="PunjabiMp3songs.singletrack" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="Stylesheet" type="text/css" href="css/uploadify.css" />
    <script type="text/javascript" src="scripts/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.uploadify.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div> 
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
        <h1 class="hcontrol">Upload Single Track Here</h1>
        
       
        <asp:TabContainer ID="TabContainer1"  runat="server" ActiveTabIndex="0" >
            

            <asp:TabPanel runat="server" HeaderText="Add Songs" ID="tabUpload">

                <ContentTemplate>
                      <table>
                         
                        <tr>
                            <td>Song Name:</td>
                            <td>
                                <asp:TextBox ID="txtSongName" runat="server"></asp:TextBox></td>
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
                            <td>Singer Name:</td>
                            <td>
                                <asp:TextBox ID="txtSingerName" runat="server"></asp:TextBox></td>
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
                            <td>Album/Song Release Date:</td>
                            <td>
                                <asp:TextBox ID="txtSongReleaseDate" placeholder="mm/dd/yyyy" runat="server"></asp:TextBox>
                                <asp:CalendarExtender runat="server" Enabled="True" TargetControlID="txtSongReleaseDate" ID="CalendarExtender1"></asp:CalendarExtender>
                            </td>
                        </tr>
                       
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
                                 
                                <asp:Button ID="btnUPload" OnClick="btnUPload_Click" OnClientClick="fungo()" runat="server" Text="Submit" />
                                <span style="display: none; border-bottom: 1px solid; width: 100px;" id="Span1" class="fackbutton">
                                    <img src="images/loading.gif" />
                                    <br />
                                    Uploading...</span>

                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                 
                            </td>
                        </tr>

                    </table>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>

    </div>
</asp:Content>
