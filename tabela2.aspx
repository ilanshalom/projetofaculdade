<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabela2.aspx.cs" Inherits="ProjetoInter.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tabela Cursos</title>
<link href="tabelas.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">

                <header>
                    <asp:Button ID="Button1" runat="server" Text="HOME" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Tabela Alunos" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Tabela JSON" OnClick="Button3_Click" />
                </header>

                <main>
                    <h2>TABELA CURSOS</h2>
                    <div>
                         <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                         <input id="txtcod" runat="server" type="number" min="1" max="20" />
                    </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                        <select id="txtnome" runat="server">
                             <option>ADS</option>
                             <option>ADM</option>
                             <option>ENF</option>
                             <option>MED</option>
                             <option>MKT</option>
                             <option>PP</option>
                             <option>ODONT</option>
                             <option>BIOME</option>
                             <option>FARMA</option>
                             <option>ND</option>
                         
                            </select>
                        
                    </div>
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Descrição"></asp:Label>
                        <asp:TextBox ID="txtdescricao" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Duração"></asp:Label>
                        <select id="txtduracao" runat="server">
                             <option>1 ANO</option>
                             <option>2 ANOS</option>
                             <option>3 ANOS</option>
                             <option>4 ANOS</option>
                             <option>5 ANOS</option>
                             <option>6 ANOS</option>
                             <option>7 ANOS</option>
                             <option>8 ANOS</option>
                             <option>9 ANOS</option>
                             <option>10 ANOS</option>
                             
                           

                        </select>
                    </div>
                </main>

                <div class="crud">
                    <asp:Button ID="BtnInserir" runat="server" Text="INSERIR" OnClick="BtnInserir_Click" />
                    <asp:Button ID="BtnAlterar" runat="server" Text="ALTERAR" OnClick="BtnAlterar_Click"/>
                    <asp:Button ID="BtnDeletar" runat="server" Text="DELETAR" OnClick="BtnDeletar_Click" />
                    <asp:Button ID="BtnAtualizar" runat="server" Text="ATUALIZAR" OnClick="BtnAtualizar_Click" />
                </div>

                <asp:Label ID="confirmacao" runat="server" Text=""></asp:Label>
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Horizontal" Height="100px" Width="450px" AutoGenerateColumns="true"></asp:GridView>
                
                <h6>* Para alterar ou deletar, use o Código como referência.</h6>
            </div>
        </div>
    </form>
</body>
</html>
