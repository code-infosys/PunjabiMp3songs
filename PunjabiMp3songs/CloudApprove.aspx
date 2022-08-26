<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="CloudApprove.aspx.cs" Inherits="PunjabiMp3songs.CloudApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <telerik:RadScriptManager ID="csescsd" runat="server" LoadScriptsBeforeUI="false"></telerik:RadScriptManager>

    <telerik:RadGrid ID="RadGrid1" runat="server" DataSourceID="LinqDataSource1" AllowPaging="True" CellSpacing="0" GridLines="None" AllowSorting="True" AllowFilteringByColumn="True">
        <MasterTableView DataKeyNames="ID" DataSourceID="LinqDataSource1" AutoGenerateColumns="False">
            <Columns>
                <telerik:GridBoundColumn DataField="ID" ReadOnly="True" HeaderText="ID" SortExpression="ID" UniqueName="ID" DataType="System.Decimal" FilterControlAltText="Filter ID column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="EmailID" HeaderText="EmailID" SortExpression="EmailID" UniqueName="EmailID" FilterControlAltText="Filter EmailID column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="MobileNumber" HeaderText="MobileNumber" SortExpression="MobileNumber" UniqueName="MobileNumber" FilterControlAltText="Filter MobileNumber column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="SongTitle" HeaderText="SongTitle" SortExpression="SongTitle" UniqueName="SongTitle" FilterControlAltText="Filter SongTitle column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="SingerName" HeaderText="SingerName" SortExpression="SingerName" UniqueName="SingerName" FilterControlAltText="Filter SingerName column"></telerik:GridBoundColumn>

                <telerik:GridTemplateColumn HeaderText="Song File Url">
                    <ItemTemplate>
                       http://www.punjabimp3songs.in/UploadsIm/<%#Eval("FileName") %> 
                    </ItemTemplate>
                </telerik:GridTemplateColumn>

                <telerik:GridBoundColumn DataField="DateAdded" HeaderText="DateAdded" SortExpression="DateAdded" UniqueName="DateAdded" DataType="System.DateTime" FilterControlAltText="Filter DateAdded column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IP" HeaderText="IP" SortExpression="IP" UniqueName="IP" FilterControlAltText="Filter IP column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="AboutSong" HeaderText="AboutSong" SortExpression="AboutSong" UniqueName="AboutSong" FilterControlAltText="Filter AboutSong column"></telerik:GridBoundColumn>
                <telerik:GridCheckBoxColumn DataField="IsApproved" HeaderText="IsApproved" SortExpression="IsApproved" UniqueName="IsApproved" DataType="System.Boolean" FilterControlAltText="Filter IsApproved column"></telerik:GridCheckBoxColumn>
                <telerik:GridTemplateColumn HeaderText="Play Song">
                    <ItemTemplate>


                        <object type="application/x-shockwave-flash" data="dewplayer.swf?mp3=UploadsIm/<%#Eval("FileName") %>" width="200" height="20" id="Object1">
                            <param name="wmode" value="transparent" />
                            <param name="movie" value="dewplayer.swf?mp3=UploadsIm/<%#Eval("FileName") %>" />
                        </object>

                        <a href="CloudApprove.aspx?songid=<%#Eval("ID") %>">Approve </a>

                    </ItemTemplate>
                </telerik:GridTemplateColumn>
            </Columns>

        </MasterTableView>

    </telerik:RadGrid>










    <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSource1" ContextTypeName="PunjabiMp3songs.MSContextDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" OrderBy="DateAdded desc" TableName="CloudUploadings"></asp:LinqDataSource>
</asp:Content>
