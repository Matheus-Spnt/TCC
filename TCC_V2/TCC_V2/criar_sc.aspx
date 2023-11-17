<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="criar_sc.aspx.cs" Inherits="TCC_V2.criar_sc" %>

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
    <title>Criar votação</title>
</head>
<body>
    <header class="hedr2">
        <img class="user_pic"  src="../IMG/Mask_group.svg" >
        <%--<p class="user_name">João da Silva</p>--%>
        <asp:Label ID="lbl_user1" class="user_name" runat="server" Text="Joao da Silva"></asp:Label>
        <h1 class="h1_user">SANTA ELEGE</h1>
        <a class="link_leave" href="user_sc.aspx">Voltar -></a>
    </header>
    <div class="bar_4"></div>
    <div class="vota" >
        <img class="vota_logo" src="../IMG/sparkles.svg" alt="Icone de votacao">
        <div class="bar_5" ></div>
        <p class="vota_txt_2" >Cadastrar</p>
    </div>
    <div class="box_resul_2" >
        <div class="campo_voto_fc_3">
            <form runat="server" >
                <div class="cria_log" >
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Titulo Votação:</p>  
                    <%--<input class="user1" type="text" name="Candidato" placeholder="João da Silva">--%>
                    <asp:TextBox ID="txt_titulo" placeholder="Eleição Presidencial" class="user1" runat="server"></asp:TextBox> <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Local:</p>  
                    <%--<input class="pass1" type="password" name="Candidato" placeholder="Senador"> --%>
                    <asp:TextBox ID="txt_local" class="pass1" placeholder="Santos" runat="server"></asp:TextBox>  <br>
                    <p style="margin-top: 5px; margin-left: 40px; margin-bottom: -1px; color:white;">Data Inicio:</p>  
                    <%--<input class="pass1" type="password" name="Candidato" placeholder="XYZ"> --%>
                    <asp:TextBox ID="txt_data_inicio" class="pass1" placeholder="YYYY-DD-MM" runat="server"></asp:TextBox> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Data Fim:</p>  
                    <%--<input class="user1" type="text" name="Candidato" placeholder="xxx"> <br>--%>
                    <asp:TextBox ID="txt_data_fim" class="user1" placeholder="YYYY-DD-MM" runat="server"></asp:TextBox> <br>
                    <p style="margin-top: 10px; margin-left: 40px; margin-bottom: -1px; color:white;">Dados Candidato:</p>
                    <%--<input class="user1" type="file" name="Candidato"> <br>--%>
                    <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 40px;" /> <br>
                </div>
                <%--<div class="cria_log" >
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
                </div> --%>
                <div class="v_btn_2">
                    <%--<input class="v_btn_" type="checkbox" name="conf"> --%>
                    <asp:CheckBox ID="cbm1" class="v_btn_" runat="server" />
                    <label style="color: white; margin-left: -150px; margin-top: 10px;" for="conf">Confirmo a criação da votação</label><br> 
                    <asp:Button ID="btn_upload" class="v_btn_3" runat="server" Text="Criar" />
                    <%--<input class="v_btn_3" type="submit" value="Criar">--%>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
