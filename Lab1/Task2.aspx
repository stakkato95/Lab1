<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task2.aspx.cs" Inherits="Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        килограмм&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxKg" runat="server" AutoPostBack="True"></asp:TextBox>
                <asp:RegularExpressionValidator ID="ValidatorKg" runat="server" ErrorMessage="В килограммах введено не число" ForeColor="Red" ControlToValidate="TextBoxKg" EnableViewState="true"  SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
        <br />
        фунт&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFunt" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        унция&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUnc" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        драхма&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxDrahma" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        гран&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxGran" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        тройская унция<asp:TextBox ID="TextBoxTroja" runat="server" AutoPostBack="True"></asp:TextBox>
    
        <br />
        <asp:Button ID="ButtonConvert" runat="server" OnClick="ButtonConvert_Click" Text="Convert" CausesValidation="true" />
    
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="True" DisplayMode="BulletList" HeaderText="Возникли следующие косяки"/>
    
    </div>
    </form>
</body>
</html>
