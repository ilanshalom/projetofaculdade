<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ProjetoInter.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HOME</title>
    <link href="home.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>PROJETO TÓPICOS ESPECIAIS</h1>
            <main>
            <h3>Neste projeto apresentamos duas tabelas</h3>
            <asp:Button ID="Button1" runat="server" Text="ALUNOS" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="CURSOS" OnClick="Button2_Click" />
            </main>
            <asp:Button ID="Button3" runat="server" Text="INTEGRANTES DO GRUPO" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
