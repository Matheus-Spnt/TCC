using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;


namespace TCC_V2
{
    public partial class criar_eleitor : System.Web.UI.Page
    {
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
        }
        protected void btn_cad_Click(object sender, EventArgs e)
        {
            #region Teste
            if (cad_user.Text == "") { lblMsg.Text = "Nome do usuário é Obrigatório!"; return; }
            if (cad_user_nasc.Text == "") { lblMsg.Text = "Data de nascimento é Obrigatório!"; return; }
            if (cad_user_ender.Text == "") { lblMsg.Text = "Endereço é Obrigatório!"; return; }
            if (cad_user_titulo.Text == "") { lblMsg.Text = "Titulo de Eleitor é Obrigatório!"; return; }
            if (cad_user_zona.Text == "") { lblMsg.Text = "Numero da zona é Obrigatório!"; return; }
            if (cad_user_sec.Text == "") { lblMsg.Text = "Numero da seção é Obrigatório!"; return; }
            if (cad_user_pass1.Text == "") { lblMsg.Text = "Senha é Obrigatório!"; return; }
            if (cad_user_pass2.Text == "") { lblMsg.Text = "Confirmar senha é Obrigatório!"; return; }
            if (cad_user_cpf.Text == "") { lblMsg.Text = "RG do usuário é Obrigatório!"; return; }

            if (cad_user_pass1.Text != cad_user_pass2.Text)
            {
                lblMsg.Text = "Ambas as senhas devem ser iguais";
            }

            #endregion

            string comando = "INSERT INTO eleitor (nome_eleitor, data_nascimento, cpf, endereco, titulo_eleitor, zona_eleitoral, secao_eleitoral, senha) " +
            " VALUES (@NomeEleitor, @DataNascimento, @CpfEleitor, @Endereco, @TituloEleitor, @ZonaEleitoral, @SecaoEleitoral, @SenhaEleitor);";

            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("@NomeEleitor", cad_user.Text),
                new MySqlParameter("@DataNascimento", cad_user_nasc.Text),
                new MySqlParameter("@CpfEleitor", cad_user_cpf.Text),
                new MySqlParameter("@Endereco", cad_user_ender.Text),
                new MySqlParameter("@TituloEleitor", cad_user_titulo.Text),
                new MySqlParameter("@ZonaEleitoral", int.Parse(cad_user_zona.Text)),
                new MySqlParameter("@SecaoEleitoral", int.Parse(cad_user_sec.Text)),
                new MySqlParameter("@SenhaEleitor", cad_user_pass1.Text)
            };

            if (!banco.Execute(comando, parametros))
            {
                lblMsg.Text = "Problemas na criação de usuário";
                banco.Closing();
                return;
            }
            else
            {
                Response.Redirect("~/user_sc.aspx");
            }

        }
    }
}