<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="integrantes.aspx.cs" Inherits="ProjetoInter.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>sobre</title>
    <link href="StyleSheet2.css" rel="stylesheet" />
</head>
<body>
    <h2 class="titulo">Integrantes do projeto</h2>
    <form id="form1" runat="server">
        <div class="conteudo">
            <asp:Button ID="Button1" runat="server" Text="VOLTAR" OnClick="Button1_Click" Height="36px" Width="96px" />
            <br /> 
            <asp:Image ID="Image1" runat="server" ImageUrl="~/vinicius.jpg" ImageAlign="Right" Height="100px" TabIndex="1" Width="75px" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nome: Vinícius Yonagusuku Lima"></asp:Label>
              <br />  <br />
            <asp:Label ID="Label2" runat="server" Text="RGM: 131242057"></asp:Label>

        
            <br/> 
            <br />
            <br />  
            <asp:Image ID="Image2" runat="server" ImgageUrl="~/ilan.jpg.jpg" ImageAlign="Right" Height="100px" ImageUrl="ilan.jpg.jpg" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome: Ilan Enrique Garcia Garrido"></asp:Label>
            <br /> <br />
            <div class="imagen2">
            <asp:Label ID="Label4" runat="server" Text="RGM: 131271421 "></asp:Label>
               </div><br /> 
            <br />
            <br />  
            <asp:Image ID="Image3" runat="server" ImageUrl="~/man.jpg.jpg" ImageAlign="Right" Height="100px" style="margin-bottom: 0px" Width="75px" />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Nome:Manuela silva de Araujo"></asp:Label>
             <br /> <br />
            <div class="imagen3">
            <asp:Label ID="Label6" runat="server" Text="RGM:32290276 "></asp:Label>
                  <br /> 
           </div> <br />
           <br />  
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Rafa.jpe.jpg" ImageAlign="Right" Height="100px"  style="margin-bottom: 0px" Width="75px" />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Nome: Rafael viana "></asp:Label>
            <br /> <br />
            <div class="imagen4">
            <asp:Label ID="Label8" runat="server" Text="RGM:30954401 "></asp:Label>
              </div> <br /> 
            <br />
            <br />
            <asp:Image ID="Image5" runat="server" ImageUrl="~/angel.jpg" ImageAlign="Right" Height="100px" style="margin-block: 0px" Width="75px" />
            <br />
            <div>
            <asp:Label ID="Label9" runat="server" Text="Nome:Angel Alfonso Maita Nunez"></asp:Label>
               </div><br />
            <asp:Label ID="Label10" runat="server" Text="RGM:31279376 "></asp:Label>
            <br /><br />
            <br />
             <asp:Image ID="Image6" runat="server" ImageUrl="~/yuri.jpg" ImageAlign="Right" Height="100px" Width="75px" />
             <br />
            <div class="imagen5">
             &nbsp;</div> 
            <asp:Label ID="Label11" runat="server" Text="Nome:Yuri Castro Rodrigues da Cruz"></asp:Label>
            <br />

             <br /> 
             <asp:Label ID="Label12" runat="server" Text="RGM:31063373 "></asp:Label>
            <br /><br />
        </div>
    </form>
</body>
</html>
