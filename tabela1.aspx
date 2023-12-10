<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabela1.aspx.cs" Inherits="ProjetoInter.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tabela Alunos</title>
    <link href="tabelas.css" rel="stylesheet"/>
</head>
   
<body>
    <form id="form1" runat="server">
        <div class="container">

            <header>
                <asp:Button ID="Button1" runat="server" Text="HOME" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Tabela Cursos" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="Tabela XML" OnClick="Button3_Click" />
            </header>

            <main>
                <h2>TABELA ALUNOS</h2>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Idade"></asp:Label>
                    <asp:TextBox ID="txtidade" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="RGM"></asp:Label>
                    <asp:TextBox ID="txtrgm" runat="server"></asp:TextBox>
                    </div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Curso"></asp:Label>
                    <asp:TextBox ID="txtcurso" runat="server"></asp:TextBox>
                </div>
            </main>

            <div class="crud">
                <asp:Button ID="BtnInserir" runat="server" Text="INSERIR" OnClick="BtnInserir_Click" />
                <asp:Button ID="BtnAlterar" runat="server" Text="ALTERAR" OnClick="BtnAlterar_Click"/>
                <asp:Button ID="BtnDeletar" runat="server" Text="DELETAR" OnClick="BtnDeletar_Click" />
                <asp:Button ID="BtnAtualizar" runat="server" Text="ATUALIZAR" OnClick="BtnAtualizar_Click" />
            </div>

            <asp:Label ID="confirmacao" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Horizontal" Height="100px" Width="450px"></asp:GridView>

            <h6>* Para alterar ou deletar, use o RGM como referência.</h6>
        </div>
    </form>
</body>
</html>
