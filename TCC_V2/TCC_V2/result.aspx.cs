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

            string candidatoQuery = "SELECT c.id_candidato, e.id_eleicao, e.titulo FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoParametros = new List<MySqlParameter>
            {
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoQuery, candidatoParametros, ref dados))
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
            string candidatoDetalheQuery = "SELECT c.nome_candidato, c.id_candidato, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoDetalheParametros = new List<MySqlParameter>
            {
                 new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candi[0])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoDetalheQuery, candidatoDetalheParametros, ref dados))
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
            candidatoDetalheQuery = "SELECT c.nome_candidato, c.id_candidato, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoDetalheParametros2 = new List<MySqlParameter>
            {
                 new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candi[1])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoDetalheQuery, candidatoDetalheParametros2, ref dados))
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
            candidatoDetalheQuery = "SELECT c.nome_candidato, c.id_candidato, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoDetalheParametros3 = new List<MySqlParameter>
            {
                 new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candi[2])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoDetalheQuery, candidatoDetalheParametros3, ref dados))
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
            candidatoDetalheQuery = "SELECT c.nome_candidato, c.id_candidato, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoDetalheParametros4 = new List<MySqlParameter>
            {
                 new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candi[3])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoDetalheQuery, candidatoDetalheParametros4, ref dados))
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