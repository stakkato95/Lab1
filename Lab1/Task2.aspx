<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task2.aspx.cs" Inherits="Task2" MasterPageFile="~/MasterPage.master"  %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlace">
    
    <p class="pStyle">
        Мгновенный перевод единиц веса и массы<br />
        Всё очень просто:<br />
        1. Найдите нужную единицу<br />
        2. Укажите её значение<br />
        3. Нажмите кнопку "Convert" и получите результат<br />
        Чтобы очистить поля нажмите "Clear"<br />
        Нужна помощь? Звоните +375 29 8821289/+375 29 9617728
    </p>
    <div>
        <asp:CustomValidator ID="MassValidator" runat="server" EnableViewState="true" ErrorMessage="Обязательным для заполнения является хотя бы одно поле" OnServerValidate="MassValidator_ServerValidate" ForeColor="Red"  />
        
        <table class="table">

            <tr>
                <td class="auto-style1">Килограмм </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxKg" runat="server" OnTextChanged="TextBoxKg_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorKg" runat="server" ErrorMessage="В килограммах введено не число" ForeColor="Red" ControlToValidate="TextBoxKg" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Фунт </td>
                <td>
                    <asp:TextBox ID="TextBoxFunt" runat="server" OnTextChanged="TextBoxFunt_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorFunt" runat="server" ErrorMessage="В фунтах введено не число" ForeColor="Red" ControlToValidate="TextBoxFunt" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>Унция </td>
                <td>
                    <asp:TextBox ID="TextBoxUnc" runat="server" OnTextChanged="TextBoxUnc_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorUnc" runat="server" ErrorMessage="В унциях введено не число" ForeColor="Red" ControlToValidate="TextBoxUnc" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Драхма </td>
                <td>
                    <asp:TextBox ID="TextBoxDrahma" runat="server" OnTextChanged="TextBoxDrahma_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorDrahma" runat="server" ErrorMessage="В драхмах введено не число" ForeColor="Red" ControlToValidate="TextBoxDrahma" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Гран</td>
                <td>
                    <asp:TextBox ID="TextBoxGran" runat="server" OnTextChanged="TextBoxGran_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorGran" runat="server" ErrorMessage="В гранах введено не число" ForeColor="Red" ControlToValidate="TextBoxGran" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Стоун</td>
                <td>
                    <asp:TextBox ID="TextBoxStoun" runat="server" OnTextChanged="TextBoxStoun_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidatorStoun" runat="server" ErrorMessage="В стоунах введено не число" ForeColor="Red" ControlToValidate="TextBoxStoun" EnableViewState="true" SetFocusOnError="true" ValidationExpression="\d*.,*\d*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonConvert" runat="server" OnClick="ButtonConvert_Click" Text="Convert" CausesValidation="true" ForeColor="red" /></td>
                <td>
                    <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" Font-Bold="True" CausesValidation="false" />
                </td>
            </tr>
        </table>









    </div>
</asp:Content>
