<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/MasterPage.master" %>


<asp:Content runat="server" ContentPlaceHolderID="ContentPlace">


    <div>
        <p class="pStyle">Выполнили: <a href="#modal" class="button openModal">Коляго</a>, <a href="#modal1" class="button openModal">Голицын</a></p>

    </div>
    
    <div id="modal" class="modal">
        <div>
            <div class="text"> Коляго Артём</div>
            <a href="#close" title="Закрыть">Закрыть</a>
        </div>
    </div>
    
     <div id="modal1" class="modal">
        <div>
            <div class="text">Голицын Андрей</div>
            <a href="#close" title="Закрыть">Закрыть</a>
        </div>
    </div>

</asp:Content>


