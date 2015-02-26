<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>АиП. Портфолио</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Выполнили: Коляго, Голицын</p>
    </div>
        <p>
            <asp:HyperLink ID="HyperLinkTask1" runat="server" NavigateUrl="~/Task1.aspx" Target="_blank">Task 1</asp:HyperLink>
            <asp:HyperLink ID="HyperLinkTask2" runat="server" NavigateUrl="~/Task2.aspx" Target="_blank">Task 2</asp:HyperLink>
        </p>
    </form>
</body>
</html>
