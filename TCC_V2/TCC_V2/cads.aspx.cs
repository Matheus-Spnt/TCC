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
    //public partial class cads
    //{
    //    protected global::System.Web.UI.WebControls.TextBox cad_user;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_nasc;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_ender;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_titulo;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_zona;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_sec;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_pass1;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_pass2;
    //    protected global::System.Web.UI.WebControls.TextBox cad_user_cpf;
    //    //protected global::System.Web.UI.WebControls.Button btn_cad;
    //    protected global::System.Web.UI.WebControls.Label lblMsg;
    //}

    public partial class cads : System.Web.UI.Page
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

            string newcode = "1";
            MySqlDataReader dados = null;

            #region Next code
            if (!banco.Consult("Select max(id_nome)+1 from eleitor", ref dados))
            {
                lblMsg.Text = "Problemas na consula ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                if (dados.Read())
                {
                    newcode = dados[0].ToString();
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            #endregion

            string comando = "insert into eleitor values (" + newcode + ",'" + cad_user.Text + "'," + cad_user_nasc.Text + "," + cad_user_cpf.Text + ",'" + cad_user_ender.Text + "'," + cad_user_titulo.Text + "," + cad_user_zona.Text + "," + cad_user_sec.Text + "," + cad_user_pass1.Text + ")";

            if (!banco.Executar(comando))
            {
                lblMsg.Text = "Problemas na criação de usuário";
                banco.Closing();
                return;
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
            

        }


    }
}