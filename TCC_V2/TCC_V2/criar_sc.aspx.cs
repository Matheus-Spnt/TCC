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
    public partial class criar_sc : System.Web.UI.Page
    {
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario1 = Convert.ToInt32(Session["user"]);
            
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            MySqlDataReader dados = null;

            #region Nome

            if (!banco.Consult("select nome_eleitor from eleitor where id_eleitor =" + usuario1 + ";", ref dados))
            {
                lbl_user1.Text = "Erro";
            }

            if (dados.Read())
            {
                lbl_user1.Text = dados["nome_eleitor"].ToString();
            }

            #endregion

        }
    }
}