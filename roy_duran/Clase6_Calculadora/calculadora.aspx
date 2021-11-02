<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculadora.aspx.cs" Inherits="Clase6_Calculadora.calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">CALCULADORA WEB</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblUser" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtValor1" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtValor2" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Number"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblResul" runat="server" Text="Resultado: "></asp:Label>
                        <asp:Label ID="lblResultado" runat="server"></asp:Label>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Calcular" Height="55px" Width="133px" OnClick="Button1_Click" />
                        <br />
                        <asp:RadioButton ID="rbSuma" runat="server" GroupName="operaciones" Text="Sumar" Checked="True" />
                        <br />
                        <asp:RadioButton ID="rbResta" runat="server" GroupName="operaciones" OnCheckedChanged="rbResta_CheckedChanged" Text="Restar" />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="44px" ImageUrl="~/home.png" OnClick="ImageButton1_Click" Width="90px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" ImageUrl="~/mail.png" OnClick="ImageButton2_Click" Width="72px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
