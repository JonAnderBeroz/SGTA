<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BEZWeb.aspx.vb" Inherits="BEZWebApp.BEZWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
  body{
      background-color:bisque; 
      border-color: brown;
      font-family: Courier New, Courier, monospace;
      
      text-align: center;
      
  }
#titulo{

    font-family:Berlin Sans FB;
    font-weight: bold;
}

#Solbutton{
    font-family: Courier New, Courier, monospace;
    color: white;
    background-color: black;
}

#DropDownBEZmota{
    font-family: Courier New, Courier, monospace;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="titulo" runat="server" Text="FAKTURA BATEN BEZ-a"></asp:Label>
        <br /><br />
        <div>
        </div>
        <asp:Label ID="LabOrdaindu" runat="server" Text="Ordaindu beharrekoa:" ></asp:Label>
        <asp:TextBox ID="txtDirua" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="€"></asp:Label>
        <p>
            <asp:Label ID="LabBEZmota" runat="server" Text="BEZ mota:"></asp:Label>
            <asp:DropDownList ID="DropDownBEZmota" runat="server">
                <asp:ListItem>orokorra</asp:ListItem>
                <asp:ListItem>murriztua</asp:ListItem>
                <asp:ListItem>oinarrizko produktua</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Solbutton" runat="server" Text="Soluzioa" />
        </p>
        <p>
            <asp:Label ID="LabBEZgabe" runat="server" Text="Totala BEZik gabe"></asp:Label>
            <asp:TextBox ID="txtBEZgabe" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LabBEZa" runat="server" Text="BEZa"></asp:Label>
            <asp:TextBox ID="txtBEZa" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
