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
    //public partial class result_2
    //{
    //    protected global::System.Web.UI.WebControls.Label lbl_text2;
    //    protected global::System.Web.UI.WebControls.Panel Panel1;
    //    protected global::System.Web.UI.WebControls.Label lbl_can2;
    //    protected global::System.Web.UI.WebControls.Label lbl_can3;
    //    protected global::System.Web.UI.WebControls.Label lbl_can4;
    //}

    public partial class result_2 : System.Web.UI.Page
    {
        String[] guarda_candi = new String[4];
        String[] guarda_titulo = new String[4];
        int eleicao1;
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;

            eleicao1 = Convert.ToInt32(Session["eleicao"]);
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


            if (!banco.Consult("select c.id_candidato, e.id_eleicao, e.titulo from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_eleicao =" + eleicao1 + ";", ref dados))
            {
                //Panel msg = new Panel();
                //Label lbl_can1_msg = new Label();
                //lbl_can1_msg.CssClass = "user_name_3";
                lbl_can1.Text = "Problemas na consulta ao servidor";
                //msg.Controls.Add(lbl_can1_msg);
                //Panel1.Controls.Add(msg);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read() || i < 4)
                {
                    guarda_candi[i] = dados["id_candidato"].ToString();
                    guarda_titulo[i] = dados["titulo"].ToString();
                    i++;
                }
                lbl_text2.Text = guarda_titulo[3];
            }


            #region Candidato1
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + Convert.ToInt32(guarda_candi[0]) + " and c.id_eleicao = " + eleicao1 + ";", ref dados))
            {
                //Panel msg = new Panel();
                //Label lbl_can1_msg = new Label();
                //lbl_can1_msg.CssClass = "user_name_3";
                lbl_can1.Text = "Problemas na consulta ao servidor";
                //msg.Controls.Add(lbl_can1_msg);
                //Panel1.Controls.Add(msg);
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    //Panel can1 = new Panel();
                    //Label lbl_can1 = new Label();
                    //lbl_can1.CssClass = "user_name_3";
                    lbl_can1.Text = dados["nome_candidato"].ToString();
                    //can1.Controls.Add(lbl_can1);
                    //Panel1.Controls.Add(can1);
                }
            }
            #endregion

            #region Candidato2
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + Convert.ToInt32(guarda_candi[1]) + " and c.id_eleicao = " + eleicao1 + ";", ref dados))
            {
                lbl_can2.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    lbl_can2.Text = dados["nome_candidato"].ToString();

                }
            }
            #endregion

            #region Candidato3
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + Convert.ToInt32(guarda_candi[2]) + " and c.id_eleicao = " + eleicao1 + ";", ref dados))
            {
                lbl_can3.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    lbl_can3.Text = dados["nome_candidato"].ToString();

                }
            }
            #endregion

            #region Candidato4
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + Convert.ToInt32(guarda_candi[3]) + " and c.id_eleicao = " + eleicao1 + ";", ref dados))
            {
                lbl_can4.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    lbl_can4.Text = dados["nome_candidato"].ToString();

                }
            }
            #endregion
        }
    }
}