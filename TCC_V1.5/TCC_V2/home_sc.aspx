<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home_sc.aspx.cs" Inherits="TCC_V2.home_sc" %>

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
    <title>Criar votação</title>
</head>
<body>
    <form runat="server">
    <header class="hedr2">
        <img class="user_pic"  src="../IMG/Mask_group.svg" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="index.aspx">Sair -></a>
    </header>
    <div class="bar_4"></div>
    <h2 class="titulo_reco" >Recomendado</h2>
    <div class="vota" >
        <img class="vota_logo" src="../IMG/sparkles.svg" alt="Icone de votacao">
        <div class="bar_5" ></div>
        <p class="vota_txt_2" >Votacoes</p>
        <p class="vota_txt_2" >Resultados</p>
        <!-- <p class="vota_txt_2" >Criar</p> -->
    </div>
    
        <%--<asp:Panel ID="Panel1" runat="server">--%>
    <div id="divPanel1" runat="server" class="box_resul_3" visible="true" >
        <div class="campo_voto_fc_4">
            
            <div class="cria_log_2" >
                <img class="img_mid" src="" >
                <h3 class="texto_mini" >Tema: Presidente</h3>
                <%--<asp:Label ID="lbl_ti1" class="texto_mini" runat="server" Text="Tema: Presidente"></asp:Label>--%>
                <p class="par_mini" >Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam</p>
<%--                <asp:Label ID="lbl_par1" class="par_mini" runat="server" Text="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam"></asp:Label>--%>
            </div>
            <div class="v_btn_4">
                <form action="voto_sc.aspx" target="_self" >
                    <%--<input class="v_btn_5" type="submit" value="Votar">--%>
                    <asp:Button class="v_btn_5" ID="v_btn1" runat="server" Text="Votar" OnClick="v_btn1_Click" />
                </form>
            </div>
            
        </div>
    </div>
    <%--</asp:Panel>--%>

    <%--<asp:Panel ID="Panel4" runat="server">--%>
        <div id="divPanel4" runat="server" class="box_resul_3" visible="true"  >
        <div class="campo_voto_fc_4">
            
            <div class="cria_log_2" >
                <img class="img_mid" src="" >
                <h3 class="texto_mini" >Tema: Deputado Federal</h3>
                <%--<asp:Label ID="Label1" class="texto_mini" runat="server" Text="Tema: Deputado Federal"></asp:Label>--%>
                <p class="par_mini" >Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam</p>
                <%--<asp:Label ID="Label2" class="par_mini" runat="server" Text="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam"></asp:Label>--%>
            </div>
            <div class="v_btn_4">
                <form action="voto_sc.aspx" target="_self" >
                    <%--<input class="v_btn_5" type="submit" value="Votar">--%>
                    <asp:Button class="v_btn_5" ID="v_btn4" runat="server" Text="Votar" OnClick="v_btn4_Click" />
                </form>
            </div>
            
        </div>
    </div>
    <%--</asp:Panel>--%>

    
    <h2 class="titulo_reco_2" >Votacoes</h2>
    
    <%--<asp:Panel ID="Panel2" runat="server">--%>
    <div id="divPanel2" runat="server" visible="true" class="box_resul_4" >
        <div class="campo_voto_fc_4">                
            <div class="cria_log_2" >
                <img class="img_mid" src="" >
                <h3 class="texto_mini" >Tema: Governador</h3>
<%--                <asp:Label ID="lbl_ti2" class="texto_mini" runat="server" Text="Tema: Governador"></asp:Label>--%>
                <p class="par_mini" >Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam</p>
<%--                <asp:Label ID="lbl_par2" class="par_mini" runat="server" Text="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam"></asp:Label>--%>
            </div>
            <p class="v_texto_1" >Em Andamento</p>
            <div class="v_btn_4">
                <form action="result.aspx" target="_self" >
                    <%--<input class="v_btn_5" type="submit" value="Resultados">--%>
                    <asp:Button class="v_btn_5" ID="v_btn2" runat="server" Text="Votar" OnClick="v_btn2_Click" />
                </form>
            </div>            
        </div>
    </div>
    <%--</asp:Panel>--%>
    
    <%--<asp:Panel ID="Panel5" runat="server" Visible="False">--%>
        <div id="divPanel5" runat="server"  visible="false" class="box_resul_4" >
        <div class="campo_voto_fc_4">                
            <div class="cria_log_2" >
                <img class="img_mid" src="" >
                <h3 class="texto_mini" >Tema: Presidente</h3>
<%--                <asp:Label ID="Label3" class="texto_mini" runat="server" Text="Tema: Presidente"></asp:Label>--%>
                <p class="par_mini" >Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam</p>
<%--                <asp:Label ID="Label4" class="par_mini" runat="server" Text="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam"></asp:Label>--%>
            </div>
            <p class="v_texto_1" >Em Andamento</p>
            <div class="v_btn_4">
                <form action="result.aspx" target="_self" >
                    <input class="v_btn_5" class="v_btn_5" type="submit" value="Resultados">
                </form>
            </div>            
        </div>
    </div>
    <%--</asp:Panel>--%>

    <%--<asp:Panel ID="Panel3" runat="server">--%>
    <div id="divPanel3" runat="server"  visible="true" class="box_resul_4" >
        <div class="campo_voto_fc_4">                
            <div class="cria_log_2" >
                <img class="img_mid" src="" >
                <h3 class="texto_mini" >Tema: Senador</h3>
<%--                <asp:Label ID="lbl_ti3" class="texto_mini" runat="server" Text="Tema: Senador"></asp:Label>--%>
                <p class="par_mini" >Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam</p>
<%--                <asp:Label ID="lbl_par3" class="par_mini" runat="server" Text="Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore officiis illo voluptas magnam, magni tenetur numquam"></asp:Label>--%>
            </div>
            <p class="v_texto_2" >Finalizado</p>
            <div class="v_btn_4">
                <form action="result_2.aspx" target="_self" >
                    <%--<input class="v_btn_5" type="submit" value="Resultados">--%>
                    <asp:Button class="v_btn_5" ID="v_btn3" runat="server" Text="Votar" OnClick="v_btn3_Click" />
                </form>
            </div>            
        </div>
    </div>
    <%--</asp:Panel>--%>

    

    </form>
</body>
</html>
