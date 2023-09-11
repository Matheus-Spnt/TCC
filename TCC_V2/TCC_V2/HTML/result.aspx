<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="estilo.css" rel="stylesheet" type="text/css" >
    <link href="https://fonts.googleapis.com/css2?family=Oxanium&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Oxanium', sans-serif;
        }
    </style>
    <title>Resultados</title>
</head>
<body>
    <header class="hedr2">
        <img class="user_pic"  src="../IMG/Mask_group.svg" >
        <p class="user_name">João da Silva</p>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="home_sc.html">Voltar -></a>
    </header>
    <div class="bar_4"></div>
    <%--<h1 class="titilo_vota" >Governador</h1>--%>
    <asp:Label ID="lbl_text1" class="titilo_vota" runat="server" Text="Governador"></asp:Label>
    <div class="vota" >
        <img class="vota_logo" src="../IMG/sparkles.svg" alt="Icone de votação">
        <div class="bar_5" ></div>
        <p class="vota_txt_2" >Votações</p>
        <p class="vota_txt_4" >Resultados</p>
        <!-- <p class="vota_txt_2" >Criar</p> -->
    </div>
    
    <img class="grafico_result" src="../IMG/Graph-vt-result.svg">
    <!-- <div class="chart">
        <div class="no-chart-data">
            <div class="radial">
                <div class="outer-circle"></div>
                <div class="inner-circle"></div>
            </div>
        </div>
    </div> -->
    <div class="box_resul" >
        <div class="campo_voto_fc_2">
            <img class="user_pic_3">
            <%--<p class="user_name_3">Alexsandro Sousa Lima</p>--%>
            <asp:Label ID="lbl_can1" class="user_name_3" runat="server" Text="Alexandro Sousa Lima"></asp:Label>
        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_4">
            <%--<p class="user_name_3">Paula Barros Campos</p>--%>
            <asp:Label ID="lbl_can2" class="user_name_3" runat="server" Text="Paula Barros Campos"></asp:Label>
        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_5">
            <%--<p class="user_name_3">Felipe Cunha Jardim</p>--%>
            <asp:Label ID="lbl_can3" class="user_name_3" runat="server" Text="Felipe Cunha Jardim"></asp:Label>
        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_6">
            <%--<p class="user_name_3">Ana Rezende de Oliveira</p>--%>
            <asp:Label ID="lbl_can4" class="user_name_3" runat="server" Text="Ana Rezende de Oliveira"></asp:Label>
        </div>
    </div>
</body>
</html>
