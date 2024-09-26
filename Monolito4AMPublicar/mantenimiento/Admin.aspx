<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Monolito4AMPublicar.mantenimiento.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Perfil de administrador</h1>
            <asp:Button ID="btn_cerrar_sesion" runat="server" Text="Cerrar sesion" OnClick="btn_cerrar_Click"/>
        </div>
        <asp:Label ID="lbl_session" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="cerrarsesion" OnClick="cerrarsesion_Click" runat="server">LinkButton</asp:LinkButton>
    </form>
</body>
</html>
