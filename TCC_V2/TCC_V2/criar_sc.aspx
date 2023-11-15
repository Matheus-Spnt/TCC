<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="criar_sc.aspx.cs" Inherits="TCC_V2.criar_sc" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="estilo.css" rel="stylesheet" type="text/css" >
    <title>Criar votação</title>
</head>
<body>
    <header class="hedr2">
        <img class="user_pic"  src="../IMG/Mask_group.svg" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="index.aspx">Sair -></a>
    </header>
    <div class="bar_4"></div>
    <div class="bar_4"></div>
    <div class="vota" >
        <img class="vota_logo" src="../IMG/sparkles.svg" alt="Icone de votacao">
        <div class="bar_5" ></div>
        <p class="vota_txt_2" >Cadastrar</p>
        <p class="vota_txt_2" >Criar</p> 
    </div>
    <div class="box_resul_2" >
        <div class="campo_voto_fc_3">
            <form action="tcc/HTML/user_sc.html" target="_self" >
                <div class="cria_log" >
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="João da Silva"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Cargo:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="Senador"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Partido:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="XYZ"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Numero:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="xxx"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Foto para identificação:</p>
                    <input class="user1" type="file" name="Candidato"> <br>
                </div>
                <div class="cria_log" >
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="João da Silva"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Cargo:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="Senador"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Partido:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="XYZ"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Numero:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="xxx"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Foto para identificação:</p>
                    <input class="user1" type="file" name="Candidato"> <br>
                </div> 
                <div class="cria_log" >
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="João da Silva"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Cargo:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="Senador"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Partido:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="XYZ"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Numero:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="xxx"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Foto para identificação:</p>
                    <input class="user1" type="file" name="Candidato"> <br>
                </div> 
                <div class="cria_log" >
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Nome:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="João da Silva"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Cargo:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="Senador"> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Partido:</p>  
                    <input class="pass1" type="password" name="Candidato" placeholder="XYZ"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Numero:</p>  
                    <input class="user1" type="text" name="Candidato" placeholder="xxx"> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Foto para identificação:</p>
                    <input class="user1" type="file" name="Candidato"> <br>
                </div> 
                <div class="v_btn_2">
                    <input class="v_btn_" type="checkbox" name="conf"> 
                    <label style="color: white; margin-left: -80px; margin-top: 10px;" for="conf">Confirmo a criação da votação</label><br> 
                    <input class="v_btn_3" type="submit" value="Criar">
                </div>
            </form>
        </div>
    </div>
</body>
</html>
