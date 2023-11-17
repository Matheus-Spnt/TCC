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
    public partial class user_sc : System.Web.UI.Page
    {
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario1 = Convert.ToInt32(Session["adm"]);

            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            MySqlDataReader dados = null;

            #region Nome

            string nomeQuery = "SELECT nome_eleitor FROM eleitor WHERE id_eleitor = @UsuarioID;";
            List<MySqlParameter> nomeParametros = new List<MySqlParameter>
            {
                new MySqlParameter("@UsuarioID", usuario1)
            };

            if (!banco.ConsultaPar(nomeQuery, nomeParametros, ref dados))
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