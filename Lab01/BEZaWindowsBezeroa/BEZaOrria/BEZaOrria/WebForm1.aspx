<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="BEZaOrria.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label id="ordainduBeharrekoaLabel" for="ordainduBeharrekoaInput"> Ordaindu beharrekoa</label>
        <asp:TextBox runat ="server" ID="ordainduBeharrekoaInput"/>
        <br />
        <label for="lstBEZMota" id="BEZaMotaLabel"> BEZa mota</label>
        <asp:DropDownList ID="lstBEZMota" runat="server">
            <asp:ListItem Value="orokorra" Selected="True">Orokorra</asp:ListItem>
            <asp:ListItem Value="murriztua">Murriztua</asp:ListItem>
            <asp:ListItem Value="oinarrizko produktuak">Oinarrizko produktuak</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="BEZaKalkulatuButton" runat="server" Text="Kalkulatu"></asp:Button>
        <asp:Label runat="server" ID="ordainduBeharrekoaLabel2"></asp:Label>
        <asp:Label runat="server" ID="BEZaMota2"></asp:Label>
        <asp:Label runat="server" ID="totalaBEZaGabe"></asp:Label>
        <asp:Label runat="server" ID="BEZa"></asp:Label>
    </form>
</body>
</html>
