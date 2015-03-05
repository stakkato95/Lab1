<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task1.aspx.cs" Inherits="Task1" MasterPageFile="~/MasterPage.master"%>

    <asp:Content runat="server" ContentPlaceHolderID="ContentPlace">
    <div>
        
        <div class="mainDiv" >
            <a href="Default.aspx">Main page</a>
       
            <p class="pStyle" >Encrypter 10000</p>
        <asp:TextBox ID="TextBoxSourse" runat="server" CssClass="TextBoxSourse" ></asp:TextBox>
        <asp:Button ID="ButtonEncrypt" runat="server" OnClick="ButtonEncrypt_Click" Text="Convert" CssClass="ButtonEncrypt" />
        <asp:TextBox ID="TextBoxEncrypted" runat="server" CssClass="TextBoxEncrypted"></asp:TextBox>
            

        </div>

  
    
    </div>
        </asp:Content>
