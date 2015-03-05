<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Task2.aspx.cs" Inherits="Task2" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlace">
        <div>


                             
            <table class="table"  >

                <tr>
                    <td class="auto-style1">Килограмм </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxKg" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="ValidatorKg" runat="server" ErrorMessage="В килограммах введено не число" ForeColor="Red" ControlToValidate="TextBoxKg" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Фунт </td>
                    <td>
                        <asp:TextBox ID="TextBoxFunt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="ValidatorFunt" runat="server" ErrorMessage="В фунтах введено не число" ForeColor="Red" ControlToValidate="TextBoxFunt" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td>Унция </td>
                    <td>
                        <asp:TextBox ID="TextBoxUnc" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="ValidatorUnc" runat="server" ErrorMessage="В унциях введено не число" ForeColor="Red" ControlToValidate="TextBoxUnc" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Драхма </td>
                    <td>
                        <asp:TextBox ID="TextBoxDrahma" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="ValidatorDrahma" runat="server" ErrorMessage="В драхмах введено не число" ForeColor="Red" ControlToValidate="TextBoxDrahma" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Гран</td>
                    <td>
                        <asp:TextBox ID="TextBoxGran" runat="server"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="ValidatorGran" runat="server" ErrorMessage="В гранах введено не число" ForeColor="Red" ControlToValidate="TextBoxGran" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Стоун</td>
                    <td>
                        <asp:TextBox ID="TextBoxStoun" runat="server"></asp:TextBox>
                       <asp:RegularExpressionValidator ID="ValidatorStoun" runat="server" ErrorMessage="В стоунах введено не число" ForeColor="Red" ControlToValidate="TextBoxStoun" EnableViewState="true" SetFocusOnError="true" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="ButtonConvert" runat="server" OnClick="ButtonConvert_Click" Text="Convert" CausesValidation="true" ForeColor="red" /></td>
                    <td ><asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" Font-Bold="True" CausesValidation="false" /></td>
                </tr>
            </table>







            

        </div>
    </asp:Content>