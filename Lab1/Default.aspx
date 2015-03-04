<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>АиП. Портфолио</title>
       <link href="StyleSheet.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p class="pStyle" align="center">Выполнили: Коляго, Голицын</p>
    </div>
        
          <p align="center">  <asp:HyperLink ID="HyperLinkTask1" runat="server" NavigateUrl="~/Task1.aspx" Target="_blank" CssClass="def" >Task 1</asp:HyperLink></p>
          <p align="center">  <asp:HyperLink ID="HyperLinkTask2" runat="server" NavigateUrl="~/Task2.aspx" Target="_blank" CssClass="def"  >Task 2</asp:HyperLink></p>  
        
    </form>
</body>
</html>
