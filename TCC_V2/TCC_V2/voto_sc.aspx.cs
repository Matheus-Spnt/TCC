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
    public partial class voto_sc : System.Web.UI.Page
    {
        String[] guarda_candidato = new String[4];
        String[] guarda_partido = new String[4];
        int eleicao1;
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();

            eleicao1 = Convert.ToInt32(Session["eleicao"]);
            usuario1 = Convert.ToInt32(Session["user"]);

            int i = 0;

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

            string candidatoEleicaoQuery = "SELECT c.id_candidato, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) WHERE c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> candidatoEleicaoParametros = new List<MySqlParameter>
            {
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(candidatoEleicaoQuery, candidatoEleicaoParametros, ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    guarda_candidato[i] = dados["id_candidato"].ToString();
                    i++;
                }
            }

            #region Candidato1
            string detalhesCandidatoQuery = "SELECT c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) JOIN partido p ON (c.id_partido = p.id_partido) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> detalhesCandidatoParametros = new List<MySqlParameter>
            {
                new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[0])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(detalhesCandidatoQuery, detalhesCandidatoParametros, ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.Read())
            {
                lbl_nm.Text = dados["nome_candidato"].ToString();
                lbl_part.Text = dados["nome"].ToString();
                lbl_num.Text = dados["numero_urna"].ToString();
                guarda_partido[0] = dados["id_partido"].ToString();
            }
            #endregion


            #region Candidato2
            detalhesCandidatoQuery = "SELECT c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) JOIN partido p ON (c.id_partido = p.id_partido) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> detalhesCandidatoParametros2 = new List<MySqlParameter>
            {
                new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[1])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(detalhesCandidatoQuery, detalhesCandidatoParametros2, ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.Read())
            {
                lbl_nm2.Text = dados["nome_candidato"].ToString();
                lbl_part2.Text = dados["nome"].ToString();
                lbl_num2.Text = dados["numero_urna"].ToString();
                guarda_partido[1] = dados["id_partido"].ToString();
            }
            #endregion

            #region Candidato3
            detalhesCandidatoQuery = "SELECT c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) JOIN partido p ON (c.id_partido = p.id_partido) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> detalhesCandidatoParametros3 = new List<MySqlParameter>
            {
                new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[2])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(detalhesCandidatoQuery, detalhesCandidatoParametros3, ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.Read())
            {
                lbl_nm3.Text = dados["nome_candidato"].ToString();
                lbl_part3.Text = dados["nome"].ToString();
                lbl_num3.Text = dados["numero_urna"].ToString();
                guarda_partido[2] = dados["id_partido"].ToString();
            }
            #endregion

            #region Candidato4
            detalhesCandidatoQuery = "SELECT c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido, e.id_eleicao FROM candidato c JOIN eleicao e ON (c.id_eleicao = e.id_eleicao) JOIN partido p ON (c.id_partido = p.id_partido) WHERE c.id_candidato = @CandidatoID AND c.id_eleicao = @EleicaoID;";
            List<MySqlParameter> detalhesCandidatoParametros4 = new List<MySqlParameter>
            {
                new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[3])),
                new MySqlParameter("@EleicaoID", eleicao1)
            };

            if (!banco.ConsultaPar(detalhesCandidatoQuery, detalhesCandidatoParametros4, ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.Read())
            {
                lbl_nm4.Text = dados["nome_candidato"].ToString();
                lbl_part4.Text = dados["nome"].ToString();
                lbl_num4.Text = dados["numero_urna"].ToString();
                guarda_partido[3] = dados["id_partido"].ToString();
            }
            #endregion
        }

        protected void btn_votar_Click(object sender, EventArgs e)
        {
            #region Candidato1
            if (rbd_1.Checked && chb_1.Checked)
            {
                
                string insertVotoQuery = "INSERT INTO voto (data_voto, id_partido, id_candidato, id_eleitor) VALUES (@DataVoto, @PartidoID, @CandidatoID, @EleitorID);";
                List<MySqlParameter> insertVotoParametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@DataVoto", DateTime.Now.ToString("yyyy-MM-dd")),
                    new MySqlParameter("@PartidoID", Convert.ToInt32(guarda_partido[0])),
                    new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[0])),
                    new MySqlParameter("@EleitorID", usuario1)
                };

                if (!banco.Execute(insertVotoQuery, insertVotoParametros))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    string insertConfirmaVotoQuery = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES (@EleitorID, @EleicaoID, 1);";
                    List<MySqlParameter> insertConfirmaVotoParametros = new List<MySqlParameter>
                    {
                        new MySqlParameter("@EleitorID", usuario1),
                        new MySqlParameter("@EleicaoID", eleicao1)
                    };

                    if (!banco.Execute(insertConfirmaVotoQuery, insertConfirmaVotoParametros))
                    {
                        lblMsg.Text = "Problemas na votação";
                        banco.Closing();
                        return;
                    }
                    else
                    {
                        Response.Redirect("~/home_sc.aspx");
                    }
                }
            }

            #endregion
            else
            {
                #region Candidato2
                if (rbd_2.Checked && chb_1.Checked)
                {
                    string insertVotoQuery = "INSERT INTO voto (data_voto, id_partido, id_candidato, id_eleitor) VALUES (@DataVoto, @PartidoID, @CandidatoID, @EleitorID);";
                    List<MySqlParameter> insertVotoParametros2 = new List<MySqlParameter>
                    {
                        new MySqlParameter("@DataVoto", DateTime.Now.ToString("yyyy-MM-dd")),
                        new MySqlParameter("@PartidoID", Convert.ToInt32(guarda_partido[1])),
                        new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[1])),
                        new MySqlParameter("@EleitorID", usuario1)
                    };

                    if (!banco.Execute(insertVotoQuery, insertVotoParametros2))
                    {
                        lblMsg.Text = "Problemas na votação";
                        banco.Closing();
                        return;
                    }
                    else
                    {
                        string insertConfirmaVotoQuery = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES (@EleitorID, @EleicaoID, 1);";
                        List<MySqlParameter> insertConfirmaVotoParametros = new List<MySqlParameter>
                        {
                            new MySqlParameter("@EleitorID", usuario1),
                            new MySqlParameter("@EleicaoID", eleicao1)
                        };

                        if (!banco.Execute(insertConfirmaVotoQuery, insertConfirmaVotoParametros))
                        {
                            lblMsg.Text = "Problemas na votação";
                            banco.Closing();
                            return;
                        }
                        else
                        {
                            Response.Redirect("~/home_sc.aspx");
                        }
                    }
                }
                #endregion
                else
                {
                    #region Candidato3
                    if (rbd_3.Checked && chb_1.Checked)
                    {
                        string insertVotoQuery = "INSERT INTO voto (data_voto, id_partido, id_candidato, id_eleitor) VALUES (@DataVoto, @PartidoID, @CandidatoID, @EleitorID);";
                        List<MySqlParameter> insertVotoParametros3 = new List<MySqlParameter>
                        {
                            new MySqlParameter("@DataVoto", DateTime.Now.ToString("yyyy-MM-dd")),
                            new MySqlParameter("@PartidoID", Convert.ToInt32(guarda_partido[2])),
                            new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[2])),
                            new MySqlParameter("@EleitorID", usuario1)
                        };

                        if (!banco.Execute(insertVotoQuery, insertVotoParametros3))
                        {
                            lblMsg.Text = "Problemas na votação";
                            banco.Closing();
                            return;
                        }
                        else
                        {
                            string insertConfirmaVotoQuery = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES (@EleitorID, @EleicaoID, 1);";
                            List<MySqlParameter> insertConfirmaVotoParametros = new List<MySqlParameter>
                            {
                                new MySqlParameter("@EleitorID", usuario1),
                                new MySqlParameter("@EleicaoID", eleicao1)
                            };

                            if (!banco.Execute(insertConfirmaVotoQuery, insertConfirmaVotoParametros))
                            {
                                lblMsg.Text = "Problemas na votação";
                                banco.Closing();
                                return;
                            }
                            else
                            {
                                Response.Redirect("~/home_sc.aspx");
                            }
                        }



                    }
                    #endregion
                    else
                    {
                        #region Candidato4
                        if (rdb_4.Checked && chb_1.Checked)
                        {
                            string insertVotoQuery = "INSERT INTO voto (data_voto, id_partido, id_candidato, id_eleitor) VALUES (@DataVoto, @PartidoID, @CandidatoID, @EleitorID);";
                            List<MySqlParameter> insertVotoParametros4 = new List<MySqlParameter>
                            {
                                new MySqlParameter("@DataVoto", DateTime.Now.ToString("yyyy-MM-dd")),
                                new MySqlParameter("@PartidoID", Convert.ToInt32(guarda_partido[3])),
                                new MySqlParameter("@CandidatoID", Convert.ToInt32(guarda_candidato[3])),
                                new MySqlParameter("@EleitorID", usuario1)
                            };

                            if (!banco.Execute(insertVotoQuery, insertVotoParametros4))
                            {
                                lblMsg.Text = "Problemas na votação";
                                banco.Closing();
                                return;
                            }
                            else
                            {
                                string insertConfirmaVotoQuery = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES (@EleitorID, @EleicaoID, 1);";
                                List<MySqlParameter> insertConfirmaVotoParametros = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@EleitorID", usuario1),
                                    new MySqlParameter("@EleicaoID", eleicao1)
                                };

                                if (!banco.Execute(insertConfirmaVotoQuery, insertConfirmaVotoParametros))
                                {
                                    lblMsg.Text = "Problemas na votação";
                                    banco.Closing();
                                    return;
                                }
                                else
                                {
                                    Response.Redirect("~/home_sc.aspx");
                                }
                            }
                        }
                        #endregion
                    }
                }
            }       
        }
    }
}