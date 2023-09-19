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
    public partial class result
    {
        protected global::System.Web.UI.WebControls.Panel Panel1;
        protected global::System.Web.UI.WebControls.Label lbl_can2;
        protected global::System.Web.UI.WebControls.Label lbl_can3;
        protected global::System.Web.UI.WebControls.Label lbl_can4;
    }

    public partial class result : System.Web.UI.Page
    {


        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            MySqlDataReader dados = null;


            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = 1 and c.id_eleicao = 1;", ref dados))
            {
                Panel msg = new Panel();
                Label lbl_can1_msg = new Label();
                lbl_can1_msg.CssClass = "user_name_3";
                lbl_can1_msg.Text = "Problemas na consulta ao servidor";
                msg.Controls.Add(lbl_can1_msg);
                Panel1.Controls.Add(msg);
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Panel can1 = new Panel();
                    Label lbl_can1 = new Label();
                    lbl_can1.CssClass = "user_name_3";
                    lbl_can1.Text = dados["nm_candidato"].ToString();
                    can1.Controls.Add(lbl_can1);
                    Panel1.Controls.Add(can1);
                }
            }

            

            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = 2 and c.id_eleicao = 21;", ref dados))
            {
                lbl_can2.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    lbl_can2.Text = dados["nm_candidato"].ToString();

                }
            }

            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = 3 and c.id_eleicao = 1;", ref dados))
            {
                lbl_can3.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    lbl_can3.Text = dados["nm_candidato"].ToString();

                }
            }

            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = 4 and c.id_eleicao = 1;", ref dados))
            {
                lbl_can4.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    lbl_can4.Text = dados["nm_candidato"].ToString();

                }
            }


        }
    }
}