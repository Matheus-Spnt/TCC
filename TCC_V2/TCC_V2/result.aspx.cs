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
    //public partial class result
    //{
    //    protected global::System.Web.UI.WebControls.Label lbl_text1;
    //    protected global::System.Web.UI.WebControls.Panel Panel1;
    //    protected global::System.Web.UI.WebControls.Label lbl_can2;
    //    protected global::System.Web.UI.WebControls.Label lbl_can3;
    //    protected global::System.Web.UI.WebControls.Label lbl_can4;
    //}

    public partial class result : System.Web.UI.Page
    {
        String[] guarda = new String[4];
        String[] guarda2 = new String[4];
        eleicao elect1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;

            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            MySqlDataReader dados = null;

            if (!banco.Consult("select c.id_candidato, e.id_eleicao, e.titulo from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_eleicao =" + elect1.GetEleicaoId() + ";", ref dados))
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
                while (dados.Read() || i < 4)
                {
                    guarda[i] = dados["c.id_candidato"].ToString();
                    guarda2[i] = dados["e.titulo"].ToString();
                    i++;
                }
                lbl_text1.Text = guarda2[3];
            }


            #region Candidato1
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + guarda[0] + " and c.id_eleicao = 1;", ref dados))
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
            #endregion

            #region Candidato2
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + guarda[1] + " and c.id_eleicao = " + elect1.GetEleicaoId() + " ;", ref dados))
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
            #endregion

            #region Candidato3
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + guarda[2] + " and c.id_eleicao = 1;", ref dados))
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
            #endregion

            #region Candidato4
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + guarda[3] + " and c.id_eleicao = 1;", ref dados))
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
            #endregion
        }
    }
}