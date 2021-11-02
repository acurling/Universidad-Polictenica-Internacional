<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Clase6_Calculadora.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            background-image: url("FondoAzul.png");
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 245px;
        }
        .auto-style3 {
            width: 671px;
        }
        .auto-style4 {
            width: 172px;
        }
        .auto-style5 {
            width: 245px;
            height: 150px;
        }
        .auto-style6 {
            height: 150px;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            width: 245px;
            height: 40px;
        }
        .auto-style9 {
            height: 40px;
        }
        .auto-style10 {
            color: #FFFFFF;
            font-size: medium;
            font-weight: bold;
        }
        .auto-style11 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="5" style="text-align: center; color: #FFFFFF; background-color: #0000FF"><strong>INGRESO AL SISTEMA<br />
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="247px" ImageUrl="~/User.png" Width="276px" />
                        <br />
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td colspan="3" rowspan="2" class="auto-style7">
                        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Usuario"></asp:Label>
&nbsp;
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                        <br />
                        <br />
&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="White" Text="Clave"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
                        <br />
                        <br />
                        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMensaje" runat="server" BackColor="#FFFF66" CssClass="auto-style11" ForeColor="#F70000"></asp:Label>
                        </strong>
                        <br />
&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:Button ID="btnIngresar" runat="server" BackColor="Blue" CssClass="auto-style10" ForeColor="White" OnClick="btnIngresar_Click" Text="Ingresar" Width="150px" />
                        </strong></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
