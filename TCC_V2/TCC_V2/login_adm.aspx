<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_adm.aspx.cs" Inherits="TCC_V2.login_adm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="estilo.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css2?family=Oxanium&display=swap" rel="stylesheet"/>
    <style>
        body {
            font-family: 'Oxanium', sans-serif;
        }
    </style>
    <title>Login Adiministrador</title>
</head>
<body>
    <form runat="server">
        <div class="squ">
        <div class="img_hoder">
            <h1 style="margin-left: 95px; font-size: 55px; color:white;">SANTA ELEGE</h1>
            <img class="foto_log1" src="../IMG/IMG-computer-LOG.svg" alt="Imagem de login">    
        </div>
        <div class="bar"></div>
        <div class="log1">
            <form action="home_sc.aspx" target="_self">
                <p style="font-size: 25px; margin-left: 40px; color:white;">Login</p>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">CPF:</p>
                <%--<input class="user1" type="text" name="Usuário" placeholder="user123@example.com"> <br>--%>
                <asp:TextBox class="user1" placeholder="XXXXXXXXXXX" ID="log_user" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Senha:</p>  
                <%--<input class="pass1" type="password" name="Senha" placeholder="******"> <br>--%>
                <asp:TextBox class="pass1" placeholder="******" ID="log_user_pass1" runat="server"  ></asp:TextBox> <br>
                <a style="margin-top: 10px; visibility:hidden; margin-left: 40px; margin-bottom: -1px; color:lightskyblue; float: left;" href="cads.aspx">Cadastre-se</a>  
                <%--<input class="btn1" type="submit" value="Entrar">--%>
                <asp:Button class="btn1" ID="btn_log" OnClick="btn_log_Click" runat="server" Text="Entrar" />
            </form>
            <asp:Label ID="lblMsg" class="mens" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
