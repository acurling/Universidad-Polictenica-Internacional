<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="UPIWEB.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #000000;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 650px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">CALCULADORA WEB&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Image ID="Image1" runat="server" Height="152px" ImageUrl="~/Imagenes/bmo.jpg" Width="165px" />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lresultado" runat="server" BorderColor="#CC0000" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <br />
                    Valor 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtValor1" runat="server" BackColor="#FFFF99" BorderStyle="Double" Font-Size="Large" Height="49px" Width="163px"></asp:TextBox>
                    <br />
                </td>
                <td>Valor2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TxtValor2" runat="server" BackColor="#FFFF99" BorderStyle="Double" Font-Size="Large" Height="52px" Width="180px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioSuma" runat="server" Font-Size="X-Large" GroupName="b1" Text="Suma" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioResta" runat="server" Font-Size="X-Large" GroupName="b1" Text="Resta" />
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioMulti" runat="server" Font-Size="X-Large" GroupName="b1" Text="Multiplicación" />
                    <asp:RadioButton ID="RadioDivi" runat="server" Font-Size="X-Large" GroupName="b1" Text="División" />
                    <br />
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckSuma" runat="server" Font-Size="X-Large" Text="Suma" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckResta" runat="server" Font-Size="X-Large" Text="Resta" />
                    <asp:CheckBox ID="CheckMulti" runat="server" Font-Size="X-Large" Text="Multiplicar" />
                    <asp:CheckBox ID="CheckDivi" runat="server" Font-Size="X-Large" Text="División" />
                    <br />
                    <br />
                    <br />
                    <asp:DropDownList ID="Dropoperaciones" runat="server" Font-Size="X-Large" Height="37px" Width="203px">
                        <asp:ListItem>Suma</asp:ListItem>
                        <asp:ListItem>Resta</asp:ListItem>
                        <asp:ListItem>Multiplicación</asp:ListItem>
                        <asp:ListItem>División</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:ListBox ID="ListBox1" runat="server" Height="101px" Width="202px">
                        <asp:ListItem Value="Resta">Suma</asp:ListItem>
                        <asp:ListItem>Resta</asp:ListItem>
                        <asp:ListItem>Multiplicación</asp:ListItem>
                        <asp:ListItem>División</asp:ListItem>
                    </asp:ListBox>
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="Red" Height="77px" OnClick="Button1_Click" Text="CALCULAR" Width="200px" />
                    <asp:Button ID="Button2" runat="server" BackColor="#FF9933" Height="77px" OnClick="Button2_Click" Text="CALCULAR" Width="200px" />
                    <asp:Button ID="Button3" runat="server" BackColor="#CCFF99" Height="77px" OnClick="Button3_Click" Text="CALCULAR" Width="200px" />
                    <asp:Button ID="Button4" runat="server" BackColor="#6699FF" Height="77px" OnClick="Button1_Click" Text="CALCULAR" Width="200px" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
