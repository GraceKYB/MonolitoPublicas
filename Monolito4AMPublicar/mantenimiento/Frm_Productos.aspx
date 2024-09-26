<%@ Page Title="" Language="C#" MasterPageFile="~/mantenimiento/Site1.Master" AutoEventWireup="true" CodeBehind="Frm_Productos.aspx.cs" Inherits="Monolito4AMPublicar.mantenimiento.Frm_Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
         <asp:HiddenField ID="hfProductId" runat="server" />
        <table style="width: 100%">
            <tr>
                <td align="center">Bienvenido al sistema:
                <asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <h2>PRODUCTOS MANTENIMIENTO..</h2>
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td align="center">
                    <table width="300px">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnk_nuevo" runat="server" OnClick="lnk_nuevo_Click">Nuevo</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lnk_guardar" runat="server" OnClick="lnk_guardar_Click">Guardar</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lnk_editar" Visible="false" runat="server" OnClick="lnk_editar_Click">Editar</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lnk_regresar" runat="server" OnClick="lnk_regresar_Click">Regresar</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%">
                        <tr>
                            <td align="center">
                                <table>
                                    <tr>
                                        <td>Nombre:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_nombre" Height="20px" Width="200px" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Cantidad:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_cantidad" Height="20px" Width="200px" runat="server" TextMode="Number">0</asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Proveedor:
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddl_proveedor" Height="20px" Width="200px" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                   
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
