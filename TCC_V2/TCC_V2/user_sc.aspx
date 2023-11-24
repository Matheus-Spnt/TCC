<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_sc.aspx.cs" Inherits="TCC_V2.user_sc" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="estilo.css" rel="stylesheet" type="text/css" >
    <link href="https://fonts.googleapis.com/css2?family=Oxanium&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Oxanium', sans-serif;
        }
    </style>
    <title>Adiministrador</title>
</head>
<body>
    <header class="hedr2">
        <img class="user_pic" src="../IMG/Mask_group.svg" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="index.aspx">Sair -></a>
    </header>
    <div class="bar_4"></div>
    <div class="vota" >
        <img class="vota_logo" src="../IMG/sparkles.svg" alt="Icone de votação">
        <div class="bar_5" ></div>
        <p class="vota_txt_2" >Elei&ccedil;a&#771;o</p>
        <p class="vota_txt_2" >Cadastrar</p>
    </div>
    <h2 class="texto_parte1" >Cadastrar Vota&ccedil;a&#771;o</h2>
    <div class="voto_box1" >
        <img class="voto_img" src="" >
        <p class="voto_texto" >
            Clique no bota&#771;o abaixo para criar a vota&ccedil;a&#771;o.
        </p>
        <div class="bar_6" ></div>
        <form action="criar_sc.aspx" target="_self" >
            <input type="submit" value="Criar" id="votar" class="btn_votar1">
        </form>
        
    </div>
    <div class="bar_7" ></div>
    <h2 class="texto_parte2" >Cadastrar Eleitor</h2>
    <div class="voto_box3" >
        <img class="voto_img" src="" >
        <p class="voto_texto" >
            Clique no bota&#771;o abaixo para cadastrar um Eleitor.
        </p>
        <div class="bar_6" ></div>
        <form action="criar_eleitor.aspx" target="_self" >
            <input type="submit" value="Criar" id="resultado" class="btn_votar1">
        </form>
    </div>
</body>
</html>