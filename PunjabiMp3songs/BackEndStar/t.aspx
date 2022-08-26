<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="t.aspx.cs" Inherits="PunjabiMp3songs.BackEndStar.t" %>
 
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Charting" Assembly="Telerik.Web.UI" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
    <telerik:RadFormDecorator ID="QsfFromDecorator" runat="server" DecoratedControls="All" EnableRoundedCorners="false" />
    
        <telerik:RadProgressManager runat="server" ID="RadProgressManager" />
        <asp:FileUpload runat="server" ID="FileUpload" />
        <br />
        <br />
         <telerik:RadButton ID="buttonSubmit" runat="server" Text="Start Processing" OnClick="btnUpload_Click">
        </telerik:RadButton>
        <br />
        <br />
        <telerik:RadProgressArea runat="server" ID="RadProgressArea1" />
 
 

         


 </div>
    </form>
</body>
</html>
