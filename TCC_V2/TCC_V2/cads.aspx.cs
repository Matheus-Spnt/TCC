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
    public partial class cads
    {
        protected global::System.Web.UI.WebControls.TextBox txtnmserie;
        protected global::System.Web.UI.WebControls.Label lblMsg;
    }

    public partial class cads : System.Web.UI.Page
    {

        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
        }


        private void btnenviar(object sender, EventArgs e)
        {
            #region Teste
            if (txtnmserie.Text == "") { lblMsg.Text = "Nome da série é Obrigatório!"; return; }
            if (txtnmor.Text == "") { lblMsg.Text = "Nome original da série é Obrigatório!"; return; }
            if (txtdesc.Text == "") { lblMsg.Text = "Descrição é Obrigatória!"; return; }
            if (txtsit.Text == "") { lblMsg.Text = "Situação da série é Obrigatória!"; return; }
            if (txtprinc.Text == "") { lblMsg.Text = "Nome do personagem principal da série é Obrigatório!"; return; }
            if (txtprinc2.Text == "") { lblMsg.Text = "Nome do personagem principal da série é Obrigatório!"; return; }
            if (txtcod.Text == "") { lblMsg.Text = "Nome do personagem coadijuvante da série é Obrigatório!"; return; }
            if (txtcod2.Text == "") { lblMsg.Text = "Nome do personagem coadijuvante da série é Obrigatório!"; return; }
            if (txtaprinc.Text == "") { lblMsg.Text = "Nome do ator(atriz) principal da série é Obrigatório!"; return; }
            if (txtaprinc2.Text == "") { lblMsg.Text = "Nome do ator(atriz) principal da série é Obrigatório!"; return; }
            if (txtacod.Text == "") { lblMsg.Text = "Nome do ator(atriz) coadijuvante da série é Obrigatório!"; return; }
            if (txtacod2.Text == "") { lblMsg.Text = "Nome do ator(atriz) coadijuvante da série é Obrigatório!"; return; }
            if (txtlan.Text == "") { lblMsg.Text = "Data de inicio da série é Obrigatório!"; return; }
            if (txtfim.Text == "") { lblMsg.Text = "Data de fim da série é Obrigatório!"; return; }
            #endregion

            string newcode = "1";
            MySqlDataReader dados = null;

            #region Next code
            if (!banco.Consult("Select max(cd_serie)+1 from serie", ref dados))
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

            string comando = "insert into produto values (" + newcode + ",'" + txtnmserie.Text + "'," + txtnmor.Text + "'," + txtsit.Text + "'," + txtdesc.Text + "'," + txtprinc.Text + "'," + txtprinc2.Text + "'," + txtcod.Text + "'," + txtcod2.Text + "'," + txtaprinc.Text + "'," + txtaprinc2.Text + "'," + txtacod.Text + "'," + txtacod2.Text + "'," + txtlan.Text + "'," + txtfim.Text + ",@foto)";

            if (!banco.Executar(comando))
            {
                lblMsg.Text = "Problemas na criação de usuário";
                banco.Closing();
                return;
            }

            Response.Redirect("~/login.aspx");

        }


    }
}