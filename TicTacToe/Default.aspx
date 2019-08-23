<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TicTacToe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>TICKER TACKER TOE</h1>
        <link href="App_Theme/style.css" rel="stylesheet" type="text/css" />

        <asp:Panel ID="Game" class="YourMove" runat="server" >
            <div>
                <asp:Button ID="Row1Column1" class="row1" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row1Column2" class="row1" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row1Column3" class="row1" onclick="PlayerMove" runat="server" />
            </div>
            <div>
                <asp:Button ID="Row2Column1" class="row2" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row2Column2" class="row2" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row2Column3" class="row2" onclick="PlayerMove" runat="server" />
            </div>
            <div>
                <asp:Button ID="Row3Column1" class="row3" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row3Column2" class="row3" onclick="PlayerMove" runat="server" />
                <asp:Button ID="Row3Column3" class="row3" onclick="PlayerMove" runat="server" />
            </div>
        </asp:Panel>
       
        <div>
            <asp:Button ID="Reset" class="Reset" Text="Reset" OnClick="ResetGame" runat="server" />
        </div>
        <h2>
            <asp:Label ID="Winner" class="Winner" runat="server" />
        </h2>
      
    </div>
    </form>
</body>
</html>
