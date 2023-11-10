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
    
    public partial class result : System.Web.UI.Page
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
                lbl_can1.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    guarda_candi[i] = dados["id_candidato"].ToString();
                    guarda_titulo[i] = dados["titulo"].ToString();
                    i++;
                }
                lbl_text1.Text = guarda_titulo[3];
            }


            #region Candidato1
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_candidato = " + Convert.ToInt32(guarda_candi[0]) + " and c.id_eleicao = " + eleicao1 + ";", ref dados))
            {
                lbl_can1.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    lbl_can1.Text = dados["nome_candidato"].ToString();
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