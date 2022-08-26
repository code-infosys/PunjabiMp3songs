<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="MySongsList.aspx.cs" Inherits="PunjabiMp3songs.MySongsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
     <telerik:RadScriptManager ID="csescsd" runat="server" LoadScriptsBeforeUI="false"></telerik:RadScriptManager>

    <br />
    <h1 class="hcontrol">My Uploaded Song Detail</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="LinqDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
        <EmptyDataTemplate>
            <h3>No Uploaded File</h3>
        </EmptyDataTemplate>
        <Columns>
            <asp:TemplateField HeaderText="SNo.">
                  <ItemTemplate>
                          <%#Container.DataItemIndex+1 %>
                   </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="false" InsertVisible="False" SortExpression="ID"></asp:BoundField>
            
              <asp:CommandField ShowEditButton="True" ShowDeleteButton="True"></asp:CommandField>
            <asp:BoundField DataField="SongTitle" HeaderText="Song Title" SortExpression="SongTitle"></asp:BoundField> 
            <asp:BoundField DataField="SingerName" HeaderText="Singer Name" SortExpression="SingerName"></asp:BoundField> 
            <asp:BoundField DataField="SongUrl1" HeaderText="SongUrl1" SortExpression="SongUrl1"></asp:BoundField>

                                <asp:BoundField DataField="SongUrl2" HeaderText="SongUrl2" SortExpression="SongUrl2"></asp:BoundField>
                                <asp:BoundField DataField="SongUrl3" HeaderText="SongUrl3" SortExpression="SongUrl3"></asp:BoundField>
                                 <asp:BoundField DataField="MetaTitle" HeaderText="MetaTitle" SortExpression="MetaTitle"></asp:BoundField>
                                <asp:BoundField DataField="MetaTags" HeaderText="MetaTags" SortExpression="MetaTags"></asp:BoundField>
                                <asp:BoundField DataField="MetaDescription" HeaderText="MetaDescription" SortExpression="MetaDescription"></asp:BoundField>
                                 <asp:CheckBoxField DataField="IsApproved" HeaderText="IsApproved" SortExpression="IsApproved"></asp:CheckBoxField>
                           
              
             <asp:TemplateField HeaderText="Song File">
                  <ItemTemplate>
                      <asp:HiddenField ID="hidesongurl" runat="server" Value='<%#Eval("SongUrl1") %>' />


                      <%--<asp:Panel ID="pnlShow" runat="server" Visible='<%#Eval("SongUrl1").ToString().Length > 0 ? true : false %>'>
 --%>
                         <object type="application/x-shockwave-flash" data="dewplayer.swf?mp3=<%#Eval("SongUrl1") %>" width="200" height="20" id="dewplayer">
                             <param name="wmode" value="transparent" />
                             <param name="movie" value="dewplayer.swf?mp3=<%#Eval("SongUrl1") %>" />
                          </object>
                     <%-- </asp:Panel>--%>

                    
                         <object type="application/x-shockwave-flash" data="dewplayer.swf?mp3=<%#Eval("SongUrl2") %>" width="200" height="20" id="Object1">
                             <param name="wmode" value="transparent" />
                             <param name="movie" value="dewplayer.swf?mp3=<%#Eval("SongUrl2") %>" />
                          </object>
                       
                         <object type="application/x-shockwave-flash" data="dewplayer.swf?mp3=<%#Eval("SongUrl3") %>" width="200" height="20" id="Object2">
                             <param name="wmode" value="transparent" />
                             <param name="movie" value="dewplayer.swf?mp3=<%#Eval("SongUrl3") %>" />
                          </object>
                      

                  </ItemTemplate>
            </asp:TemplateField>
              
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


    <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSource1" ContextTypeName="PunjabiMp3songs.MSContextDataContext" EnableUpdate="True" OrderBy="DateAdded desc" TableName="TracksWrapers" Where="UsrId == @UsrId">
        <WhereParameters>
            <asp:SessionParameter SessionField="USERDIID" DefaultValue="0" Name="UsrId" Type="Decimal"></asp:SessionParameter>
        </WhereParameters>
    </asp:LinqDataSource>
 


</asp:Content>
