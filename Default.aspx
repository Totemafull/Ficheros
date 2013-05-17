<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ficheros</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Ruta: </td>
                <td><asp:TextBox ID="tb_Ruta" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Texto: </td>
                <td><asp:TextBox ID="tb_Texto" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <div><asp:Button ID="btn_CrearTXT" runat="server" Text="Crear TXT" /></div>
        <div><asp:Button ID="btn_leerTXT" runat="server" Text="Leer Txt" /></div>
        <br />
        <div><asp:Label ID="lbl_Mostrar" runat="server"></asp:Label></div>
    </div>
    </form>
</body>
</html>
