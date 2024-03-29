<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result_2.aspx.cs" Inherits="TCC_V2.result_2" %>

<!DOCTYPE html>
<html>
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
        <img class="user_pic" src="../IMG/Mask_group.svg" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="home_sc.aspx">Voltar -></a>
    </header>
    <div class="bar_4"></div>
    <%--<h1 class="titilo_vota" >Senador</h1>--%>
    <asp:Label ID="lbl_text2" class="titilo_vota" runat="server" Text="Senador"></asp:Label>
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
            <%--<p class="user_name_3">Rafael Caridade</p>--%>
            <%--<asp:Panel ID="Panel1" runat="server">--%>
                <asp:Label ID="lbl_can1" class="user_name_3" runat="server" Text=""></asp:Label>
            <%--</asp:Panel>--%>
            

        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_4">
            <%--<p class="user_name_3">Monica Araujo</p>--%>
            <asp:Label ID="lbl_can2" class="user_name_3" runat="server" Text="Monica Araujo"></asp:Label>
        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_5">
            <%--<p class="user_name_3">Gabriel Lopes</p>--%>
            <asp:Label ID="lbl_can3" class="user_name_3" runat="server" Text="Gabriel Lopes"></asp:Label>
        </div>
        
        <div class="campo_voto_fc_2">
            <img class="user_pic_6">
            <%--<p class="user_name_3">Juliana Santos</p>--%>
            <asp:Label ID="lbl_can4" class="user_name_3" runat="server" Text="Juliana Santos"></asp:Label>
        </div>
    </div>
</body>
</html>
