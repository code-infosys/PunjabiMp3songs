<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUUp.Master" AutoEventWireup="true" CodeBehind="AssignTop20.aspx.cs" Inherits="PunjabiMp3songs.AssignTop20" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="LinqDataSource1" AutoGenerateColumns="False" DataKeyNames="ID" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True"></asp:CommandField>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
            <asp:TemplateField HeaderText="Song Name">
                <ItemTemplate>
                    <%#Stname(Convert.ToDecimal(Eval("SongID"))) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="SongID" HeaderText="SongID" SortExpression="SongID"></asp:BoundField>
            <asp:BoundField DataField="DateAdded" HeaderText="DateAdded" SortExpression="DateAdded"></asp:BoundField>
            <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive"></asp:CheckBoxField>
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
    <asp:LinqDataSource runat="server" EntityTypeName="" ID="LinqDataSource1" ContextTypeName="PunjabiMp3songs.MSContextDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" OrderBy="DateAdded desc" TableName="Top20MonthMappings"></asp:LinqDataSource>
</asp:Content>
