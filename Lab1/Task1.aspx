<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task1.aspx.cs" Inherits="Task1" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlace">

    <div>

        <div>

            <p class="pStyle"><h3>Encrypter 10000</h3>
                Для того, чтобы шифровать/дешифровать строку введите значение в соостветствующие поля и нажмите Convert.
                Удачного шифрования!!!</p>
            <asp:TextBox ID="TextBoxSourse" runat="server" CssClass="TextBoxSourse" placeholder="Зашифровать строку..." OnTextChanged="TextBoxSourse_TextChanged" ></asp:TextBox>
            <asp:Button ID="ButtonEncrypt" runat="server" OnClick="ButtonEncrypt_Click" Text="Convert" CssClass="ButtonEncrypt" CausesValidation="true" />
            <asp:TextBox ID="TextBoxEncrypted" runat="server" CssClass="TextBoxEncrypted" placeholder="Дешифровать строку..." OnTextChanged="TextBoxEncrypted_TextChanged"></asp:TextBox>

            <asp:CustomValidator ID="EncryptValidator" runat="server" ErrorMessage="Введите шифруемую или дешивруемую строку" OnServerValidate="EncryptValidator_ServerValidate" ForeColor="Red" Display="Dynamic"></asp:CustomValidator>
            <asp:CustomValidator ID="SpacesValidator" runat="server" ErrorMessage="Строка не должна содержать пробелы" OnServerValidate="SpacesValidator_ServerValidate" ForeColor="Red"></asp:CustomValidator>

        </div>

    </div>
</asp:Content>
