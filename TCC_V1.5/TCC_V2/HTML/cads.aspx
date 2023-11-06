<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="estilo.css" rel="stylesheet" type="text/css"  >
    <link href="https://fonts.googleapis.com/css2?family=Oxanium&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Oxanium', sans-serif;
        }
    </style>
    <title>Cadastro</title>
</head>
<body>
    <form runat="server">
    <div class="squ">
        <div class="img_hoder" >
            <h1 style="margin-left: 95px; font-size: 55px; color:white;" >SANTA ELEGE</h1>
            <img class="foto_log3" src="../IMG/Group 36782.svg" alt="Logo Santa Elege" >
        </div>
        <div class="bar"></div>
        <div class="log2">
            <form action="login.aspx" target="_self" >
                <p style="font-size: 25px; margin-left: 40px; color:white;" >Cadastro</p>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="João da Silva"> --%>
                <asp:TextBox class="user1" placeholder="Joao da Silva" ID="cad_user" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Data de Nascimento:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="xx/xx/xxxx"> <br>--%>
                <asp:TextBox class="user1" placeholder="xx/xx/xxxx" ID="cad_user_nasc" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome da Mae:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="Maria da Silva"> <br>--%>
                <asp:TextBox class="user1" placeholder="Maria da Silva" ID="cad_user_mae" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Email:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="user123@example.com"> <br>--%>
                <asp:TextBox class="user1" placeholder="user123@example.com" ID="cad_user_email" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Celular:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="(xx)xxxxx-xxxx"> <br>--%>
                <asp:TextBox class="user1" placeholder="(xx)xxxxx-xxxx" ID="cad_user_cel" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Senha:</p>  
                <%--<input class="pass1" type="password" name="Senha" placeholder="******"> <br>--%>
                <asp:TextBox class="pass1" placeholder="******" ID="cad_user_pass1" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Confirmar Senha:</p>  
                <%--<input class="pass1" type="password" name="Senha" placeholder="******"> <br>--%>
                <asp:TextBox class="pass1" placeholder="******" ID="cad_user_pass2" runat="server"  ></asp:TextBox> <br>
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">RG:</p>  
                <%--<input class="user1" type="text" name="Usuário" placeholder="xx.xxx.xxx-x"> <br>--%>
                <asp:TextBox class="user1" placeholder="xx.xxx.xxx-x" ID="cad_user_rg" runat="server"  ></asp:TextBox> <br>
                <%--<input class="btn2" type="submit" value="Entrar">--%>
                <asp:Button class="btn2" ID="btn_cad" runat="server" Text="Cadastrar" />

            </form>
        </div>
            
    </div>
    </form>
</body>
</html>