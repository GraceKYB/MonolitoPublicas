<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="Monolito4AMPublicar.registrar" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registro </title>
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Lato&display=swap" rel="stylesheet">
    <!-- Estilos CSS -->
    <link rel="stylesheet" href="css/styleRegistro.css">
    <!-- Favicon -->


</head>
<body>
    <main>
        <article>
            <section>
                <form runat="server">
                    <h1>Registrate</h1>

                    
                    <asp:TextBox ID="txt_cedula" runat="server" placeholder="Ingrese su cedula" autocomplete="off"></asp:TextBox>

                    <center>
                        <asp:Label ID="lbl_sms_cedula" runat="server" Text=""></asp:Label>
                    </center>


                    
                    <asp:TextBox ID="txt_nombres" runat="server" placeholder="Ingrese sus nombres" autocomplete="off"></asp:TextBox>

                    <center>
                        <asp:Label ID="lbl_sms_nombres" runat="server" Text=""></asp:Label>
                    </center>


                    
                    <asp:TextBox ID="txt_direccion" runat="server" placeholder="Ingrese su direccion" autocomplete="off"></asp:TextBox>

                    <center>
                        <asp:Label ID="lbl_sms_direccion" runat="server" Text=""></asp:Label>
                    </center>

                   
                    <asp:TextBox ID="txt_contraseña" runat="server" placeholder="Ingrese su contraseña" TextMode="Password"  autocomplete="off"></asp:TextBox>

                    <center>
                        <asp:Label ID="lbl_sms_contra" runat="server" Text=""></asp:Label>
                    </center>

                   
                    <asp:TextBox ID="txt_correo" runat="server" placeholder="Ingrese su correo" autocomplete="off"></asp:TextBox>

                    <center>
                        <asp:Label ID="lbl_sms_correo" runat="server" Text=""></asp:Label>
                    </center>

                    <asp:DropDownList ID="ddl_Perfil" runat="server"></asp:DropDownList>

                    <asp:Button ID="btn_Registrar" runat="server" Text="Registrar" OnClick="btn_Registrar_Click1" />
                    <br />
                    <center>
                        <asp:Label ID="lbl_mensajes" runat="server" Text=""></asp:Label>
                    </center>
                    <br />
                    <asp:LinkButton ID="lnk_regresa" runat="server" OnClick="lnk_regresa_Click">Regresar</asp:LinkButton>


                </form>
            </section>
        </article>
    </main>

</body>
</html>
