<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task1.aspx.cs" Inherits="Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBoxSourse" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonEncrypt" runat="server" OnClick="ButtonEncrypt_Click" Text="Convert" />
        <asp:TextBox ID="TextBoxEncrypted" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
