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
    public partial class login
    {
        protected global::System.Web.UI.WebControls.TextBox log_user;
        protected global::System.Web.UI.WebControls.TextBox log_user_pass1;
        protected global::System.Web.UI.WebControls.Label lblMsg;
    }
    public partial class login : System.Web.UI.Page
    {
        usuario user1 = new usuario();
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
        }


        private void btn_log(object sender, EventArgs e)
        {
            if (log_user.Text == "") { lblMsg.Text = "Nome do usuário é Obrigatório!"; return; }
            if (log_user_pass1.Text == "") { lblMsg.Text = "Senha é Obrigatório!"; return; }

            MySqlDataReader dados = null;



            if (!banco.Consult("select nome_eleitor, id_eleitor, senha from eleitor where nome_eleitor = " + log_user.Text + " and senha = " + log_user_pass1.Text + ";", ref dados))
            {
                lblMsg.Text = "Usuário não existe. Favor Cadstrar";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                
                user1.SetUsuarioId(dados["id_eleitor"].ToString());
                Response.Redirect("~/home_sc.aspx");

            }
        }
    }
}