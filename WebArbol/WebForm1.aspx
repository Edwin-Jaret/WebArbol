<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebArbol.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<script src="JS/JavaScript.js"></script>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Arbol Binario commit 3</h1>
            <fieldset>
                <legend>Operaciones</legend>
                <asp:Label ID="Label1" runat="server" Text="Valor"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button2" runat="server" Text="Mostrar Recorridos" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button4" runat="server" Text="Valor Máximo" OnClick="Button4_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button5" runat="server" Text="Valor Mínimo" OnClick="Button5_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button6" runat="server" Text="Balancear Arbol" OnClick="Button6_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button7" runat="server" Text="Buscar" OnClick="Button7_Click" />
            </fieldset>
            <br />
            <br />
            <fieldset>
                <legend>Mensajes</legend>
                <asp:TextBox ID="TextBox2" runat="server" Width="475px"></asp:TextBox>
            </fieldset>
        </div>
        <br />
        <br />
        <fieldset>
            <legend>Recorridos</legend>
            <asp:ListBox ID="ListBox1" runat="server" Height="203px" Width="656px"></asp:ListBox>
        </fieldset>
        <br />
        <br />
        <fieldset>
            <legend>Graficación</legend>
            <br />
            <canvas id="miCanvas" width="1000" height="800"></canvas>
        </fieldset>
    </form>
</body>
</html>
