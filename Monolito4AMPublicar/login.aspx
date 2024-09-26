<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Monolito4AMPublicar.login" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Login</title>
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Lato&display=swap" rel="stylesheet">
    <!-- Estilos CSS -->
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <main>
        <article>
            <section>
                <form runat="server">
                    <h1>Inicia Sesion</h1>

                    <p>
                        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label> </p>
                    <asp:TextBox ID="txt_cedula" placeholder="Ingrese su cedula" runat="server" autocomplete="off"></asp:TextBox>
                    <p>Contraseña</p>
                    <asp:TextBox ID="txt_pass" placeholder="*******" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
                    <br />
                    <center>
                        <asp:Label ID="lbl_sms_datos" runat="server" Text="" style="font-Size:x-large"></asp:Label>
                    </center>
                    
                    <br />
                    <asp:LinkButton ID="lnk_registrar" runat="server" OnClick="lnk_registrar_Click">Registrarse</asp:LinkButton>

                    <asp:LinkButton ID="lnk_olvido" runat="server" OnClick="lnk_olvido_Click">Olvido su contraseña</asp:LinkButton>

                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="lnk_recuperar_Click">Recuperar su contraseña</asp:LinkButton>

                </form>
            </section>
        </article>
    </main>

</body>
</html>
