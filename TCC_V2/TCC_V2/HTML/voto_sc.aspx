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
    <title>Votar</title>
</head>
<body>
    <header class="hedr2">
        <img class="user_pic"  src="../IMG/Mask_group.svg"  alt="Foto do usuário" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="home_sc.aspx">Voltar -></a>
    </header>
    <div class="bar_4"></div>
    
    <div class="campo_voto_fc">
        <img class="user_pic_2" src="../IMG/Mask_group.svg" >
        <p class="user_name_2">Candidato 1</p>
    </div>
    <div class="campo_voto_ab">
        <p class="per_1">Nome: </p>
        <%--<p class="res_1">Amanda Ramos</p>--%>
        <asp:Label ID="lbl_nm" class="res_1" runat="server" Text="Amanda Ramos"></asp:Label>
        <p class="per_2">Partido: </p>
        <%--<p class="res_2">Coalização</p>--%>
        <asp:Label ID="lbl_part" class="res_2" runat="server" Text="Coalização"></asp:Label>
        <p class="per_3">Número: </p>
        <%--<p class="res_3">38</p>--%>
        <asp:Label ID="lbl_num" class="res_3" runat="server" Text="38"></asp:Label>

        <!-- <img class="candidato_img" > -->
        
    </div>
    <div class="campo_voto_fc">
        <img class="user_pic_2" src="../IMG/Mask_group.svg" >
        <p class="user_name_2">Candidato 2</p>
    </div>
    <div class="campo_voto_ab">
        <p class="per_1">Nome: </p>
        <%--<p class="res_1">Antonio Marcos</p>--%>
        <asp:Label ID="lbl_nm2" class="res_1" runat="server" Text="Antonio Marcos"></asp:Label>
        <p class="per_2">Partido: </p>
        <%--<p class="res_2">Arcas</p>--%>
        <asp:Label ID="lbl_part2" class="res_2" runat="server" Text="Arcas"></asp:Label>
        <p class="per_3">Número: </p>
        <%--<p class="res_3">38</p>--%>
        <asp:Label ID="lbl_num2" class="res_3" runat="server" Text="38"></asp:Label>

        <!-- <img class="candidato_img" > -->
        
    </div>
    <div class="campo_voto_fc">
        <img class="user_pic_2" src="../IMG/Mask_group.svg" >
        <p class="user_name_2">Candidato 3</p>
    </div>
    <div class="campo_voto_ab">
        <p class="per_1">Nome: </p>
        <%--<p class="res_1">Mariana Cruz</p>--%>
        <asp:Label ID="lbl_nm3" class="res_1" runat="server" Text="Mariana Cruz"></asp:Label>
        <p class="per_2">Partido: </p>
        <%--<p class="res_2">DSR</p>--%>
        <asp:Label ID="lbl_part3" class="res_2" runat="server" Text="DSR"></asp:Label>
        <p class="per_3">Número: </p>
        <%--<p class="res_3">50</p>--%>
        <asp:Label ID="lbl_num3" class="res_3" runat="server" Text="50"></asp:Label>
        <!-- <img class="candidato_img" > -->
        
    </div>
    <div class="campo_voto_fc">
        <img class="user_pic_2" src="../IMG/Mask_group.svg" >
        <p class="user_name_2">Candidato 4</p>
    </div>
    <div class="campo_voto_ab">
        <p class="per_1">Nome: </p>
        <%--<p class="res_1">Fábio de Oliveira</p>--%>
        <asp:Label ID="lbl_nm4" class="res_1" runat="server" Text="Fabio de Oliveira"></asp:Label>
        <p class="per_2">Partido: </p>
        <%--<p class="res_2">Federação</p>--%>
        <asp:Label ID="lbl_part4" class="res_2" runat="server" Text="Federacao"></asp:Label>
        <p class="per_3">Número: </p>
        <%--<p class="res_3">95</p>--%>
        <asp:Label ID="lbl_num4" class="res_3" runat="server" Text="95"></asp:Label>
        <!-- <img class="candidato_img" > -->
        
    </div>
    <div class="v_btn">
        <form action="home_sc.html" target="_self">
            <%--<input class="v_btn_" type="checkbox" name="conf">--%>
            <asp:CheckBox ID="chb_1" class="v_btn_" runat="server" />
            <label style="color: white; margin-left: -80px; margin-top: 10px;" for="conf">Confirmo votar nesse candidato</label><br>
            <%--<input class="v_btn_1" type="submit" value="Votar">--%>
            <asp:Button class="v_btn_1" ID="btn_votar" runat="server" Text="Votar" />
        </form>
    </div>
</body>
</html>
