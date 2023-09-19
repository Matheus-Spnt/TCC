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
        .img_prin {
            margin-left: -1000px; 
        }
        
    </style>
    <title>Santa Elege</title>
</head>  
<body>
    <header class="hedr">
        <h1 class="h1_main">SANTA ELEGE</h1>
        <a class="link_log" href="login.aspx">Login</a>
    </header>
    <img class="img_prin" src="" alt=" ">
    <img class="text_b1" src="../IMG/title-one.svg" >
    <h1 class="funci">Como funciona ?</h1>
    <div class="space_1">
        <img class="icones" src="../IMG+/ttl3_(1).svg" >
        <!--Manter caso a imagem não sirva os espaços de icones estão prontos-->
        <!-- <div class="sqr_1">svg
            <img class="img_texto_1" src="C:\Users\vinic\Downloads\wallet.png" alt="Imagem 1">
            <h2 class="h2_1">Faça o Login</h2>
        </div>
        <div class="sqr_2">
            <img class="img_texto_1" src="file:/tcc/IMG/vote.svg" alt="Imagem 2">
            <h2 class="h2_1">Faça seu Voto</h2>
        </div>
        <div class="sqr_3">
            <img class="img_texto_1" src="caminho_da_imagem" alt="Imagem 3">
            <h2 class="h2_1">Receba seu comprovante</h2>
        </div>
        <div class="sqr_4">
            <img class="img_texto_1" src="caminho_da_imagem" alt="Imagem 4">
            <h2 class="h2_1">E acompanhe os resultados</h2>
        </div> -->

    <!-- <img class="img_prin" src="file:///D:/tcc-last/title-one%20(1).svg" alt="">  -->
        <!-- <img class="icones" src="file:///D:/tcc-last/ttl3%20(1).svg" > -->

    </div>
    <div class="space_2"> 
        <div class="bar_sobre">
            <!--Só colocar a img da palavra sobre-->
            <img class="img_sobre" src="../IMG/SOBRE.svg" alt="palavra sobre" >
        </div>
        <h1 class="sobre_box">MISSÃO: Fomentamos a transparencia e buscamos a lealdade do cliente buscando uma relação duradoura<br><br>VISÃO: Somos a chave para a resposta mais justa<br><br>VALORES:Orientados para o sucesso e pela busca do alto desempenho.</h1>
    </div>
    <div class="space_3">
        <h1 class="txt_cad">FAÇA PARTE DE ALGO NOVO</h1>
        <form action="cads.aspx" target="_self" runat="server" >
            <input class="btn_cad" type="submit" value="Cadastro">
        </form>
    </div>
    <footer class="foot_index">
        <!--Essas divs sem classes são as que fazem a separação em conjunto com as bars-->
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
