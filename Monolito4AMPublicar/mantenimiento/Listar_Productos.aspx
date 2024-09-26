<%@ Page Title="" Language="C#" MasterPageFile="~/mantenimiento/Site1.Master" AutoEventWireup="true" CodeBehind="Listar_Productos.aspx.cs" Inherits="Monolito4AMPublicar.mantenimiento.Listar_Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table style="width: 100%">
            <tr>
                <td align="center">Bienvenido al sistema:
                    <asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <h2>PRODUCTOS</h2>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <table>
                        <tr>
                            <td align="center">
                                <asp:LinkButton ID="lnk_nuevo" runat="server">Nuevo producto</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table style="width: 100%">
                                    <tr>
                                        <td>Buscar por:</td>
                                        <td>
                                            <asp:DropDownList ID="ddl_criterio" Width="120px" runat="server">
                                                <asp:ListItem Text="Nombre" Value="N"></asp:ListItem>
                                                <asp:ListItem Text="Proveedor" Value="N"></asp:ListItem>
                                                <asp:ListItem Text="Codigo" Value="N"></asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_buscar" Width="300px" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:ImageButton ID="img_lupa" runat="server" Width="20px" ImageUrl="~/mantenimiento/lupa.png" OnClick="img_lupa_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" align="center">
                                            <asp:GridView ID="grv_pro" AutoGenerateColumns="False"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-responsive table-bordered" OnSelectedIndexChanged="grv_pro_SelectedIndexChanged">
                                                <AlternatingRowStyle BackColor="White" />
                                                <Columns>
                                                    <asp:TemplateField HeaderText="░">
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="img_editar" runat="server"  Width="20px" ImageUrl="~/mantenimiento/editar.png" CommandArgument='<%#Eval("pro_id") %>' CommandName="Editar" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="░">
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="img_eliminar" runat="server" Width="20px" ImageUrl="~/mantenimiento/eliminar.png" CommandArgument='<%#Eval("pro_id") %>' CommandName="Eliminar" OnClientClick="return confirm('Desea eliminar..')" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ID">
                                                        <ItemTemplate>
                                                            <asp:Label ID="pro_id" runat="server" Text='<%#Eval("pro_id")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Proveedor">
                                                        <ItemTemplate>
                                                            <asp:Label ID="prov_id" runat="server" Text='<%#Eval("prov_id") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Nombre">
                                                        <ItemTemplate>
                                                            <asp:Label ID="pro_nombre" runat="server" Text='<%#Eval("pro_nombre") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Cantidad">
                                                        <ItemTemplate>
                                                            <asp:Label ID="pro_cantidad" runat="server" Text='<%#Eval("pro_cantidad") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Estado">
                                                        <ItemTemplate>
                                                            <asp:Label ID="pro_estado" runat="server" Text='<%#Eval("pro_estado") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    
                                                </Columns>
                                                <EditRowStyle BackColor="#7C6F57" />
                                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#E3EAEB" />
                                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                                            </asp:GridView>
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
