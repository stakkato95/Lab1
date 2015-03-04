<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task1.aspx.cs" Inherits="Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <div class="mainDiv" >
            <a href="Default.aspx">Main page</a>
       
            <p class="pStyle" >Encrypter 10000</p>
        <asp:TextBox ID="TextBoxSourse" runat="server" CssClass="TextBoxSourse" ></asp:TextBox>
        <asp:Button ID="ButtonEncrypt" runat="server" OnClick="ButtonEncrypt_Click" Text="Convert" CssClass="ButtonEncrypt" />
        <asp:TextBox ID="TextBoxEncrypted" runat="server" CssClass="TextBoxEncrypted"></asp:TextBox>
            

        </div>

  
    
    </div>
    </form>
</body>
</html>
