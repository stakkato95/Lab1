<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task1.aspx.cs" Inherits="Task1" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlace">

    <div>

        <div class="mainDiv">

            <p class="pStyle">Encrypter 10000<br/>
                Для того, чтобы шифровать/дешифровать строку введите значение в соостветствующие поля и нажмите Convert.<br/>
                Удачного шифрования!!!</p>
            <asp:TextBox ID="TextBoxSourse" runat="server" CssClass="TextBoxSourse" placeholder="Зашивровать строку..." ></asp:TextBox>
            <asp:Button ID="ButtonEncrypt" runat="server" OnClick="ButtonEncrypt_Click" Text="Convert" CssClass="ButtonEncrypt" CausesValidation="true" />
            <asp:TextBox ID="TextBoxEncrypted" runat="server" CssClass="TextBoxEncrypted" placeholder="Дешивровать строку..."></asp:TextBox>

            <asp:CustomValidator ID="EncryptValidator" runat="server" ErrorMessage="Введите шифруемую или дешивруемую строку" OnServerValidate="EncryptValidator_ServerValidate" ForeColor="Red"></asp:CustomValidator>

        </div>

    </div>
</asp:Content>
