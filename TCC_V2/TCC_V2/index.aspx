<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="estilo.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css2?family=Oxanium&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Oxanium', sans-serif;
        }        
    </style>
    <title>Santa Elege</title>
</head>  
<body>
    <header class="hedr">
        <h1 class="h1_main">SANTA ELEGE</h1>
        <a class="link_log" href="login.aspx">Login</a>
    </header>
    <img class="img_prin" src="../IMG/Milky Way.svg" alt=" ">
    <img class="text_b1" src="../IMG/title-one.svg" >
    <h1 class="funci">Como funciona ?</h1>
    <div class="space_1">
        <img class="icones" src="../IMG/ttl3_(1).svg" >
    </div>
    <div class="space_2"> 
        <div class="bar_sobre">
            <img class="img_sobre" src="../IMG/SOBRE.svg" alt="palavra sobre" >
        </div>
        <h1 class="sobre_box">MISSÃO: Fomentamos a transparencia e buscamos a lealdade do cliente buscando uma relação duradoura<br><br>VISÃO: Somos a chave para a resposta mais justa<br><br>VALORES:Orientados para o sucesso e pela busca do alto desempenho.</h1>
    </div>
    <div class="space_3">
        <h1 class="txt_cad">FAÇA PARTE DE ALGO NOVO</h1>
        <form action="login.aspx" target="_self" runat="server" >
            <input class="btn_cad" type="submit" value="Logar">
        </form>
    </div>
    <footer class="foot_index">
        <div></div>
        <div class="bar_2"></div>
        <div></div>
        <div class="bar_3"></div>
        <div class="feedback">
            <form action="/HTML/voto_sc.html" target="_self">
                <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Feedback</p>
                <input class="user1" type="text" name="Usuário" placeholder="Assunto"> <br>
                <input class="user1" style="height: 45px;" type="text" name="Usuário" placeholder="Comentário"> <br>
                <input class="btn2" type="submit" value="Enviar">
            </form>
        </div>
    </footer>
</body>
</html>
