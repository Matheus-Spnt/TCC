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

            if (!banco.Consult("select nome_eleitor from eleitor where id_eleitor =" + usuario1 + ";", ref dados))
            {
                lbl_user1.Text = "Erro";
            }

            if (dados.Read())
            {
                lbl_user1.Text = dados["nome_eleitor"].ToString();
            }

            #endregion



            if (!banco.Consult("select c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_eleicao =" + eleicao1 + ";", ref dados))
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
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + Convert.ToInt32(guarda_candidato[0]) + " and c.id_eleicao =" + eleicao1 + ";", ref dados))
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
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + Convert.ToInt32(guarda_candidato[1]) + " and c.id_eleicao =" + eleicao1 + ";", ref dados))
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
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + Convert.ToInt32(guarda_candidato[2]) + " and c.id_eleicao =" + eleicao1 + ";", ref dados))
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
            if (!banco.Consult("select c.nome_candidato, c.id_candidato, c.numero_urna, p.nome, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + Convert.ToInt32(guarda_candidato[3]) + " and c.id_eleicao =" + eleicao1 + ";", ref dados))
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
                guarda_partido[3] = dados["id_partido"].ToString();
            }
            #endregion
        }

        protected void btn_votar_Click(object sender, EventArgs e)
        {
            #region Candidato1
            if (rbd_1.Checked && chb_1.Checked)
            {
                string newcode = "1";
                MySqlDataReader dados = null;
                if (!banco.Consult("Select count(id_voto)+1 from voto;", ref dados))
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


                string comando = "insert into voto (data_voto, id_partido, id_candidato, id_eleitor) values ('2023-09-12'  ," + Convert.ToInt32(guarda_partido[0]) + ", " + Convert.ToInt32(guarda_candidato[0]) + ",  " + usuario1 + ");";

                if (!banco.Executar(comando))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    comando = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES(" + usuario1 + ", " + eleicao1 + ", 1);";

                    if (!banco.Executar(comando))
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
                    string newcode = "1";
                    MySqlDataReader dados = null;
                    if (!banco.Consult("Select count(id_voto)+1 from voto;", ref dados))
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


                    string comando = "insert into voto (data_voto, id_partido, id_candidato, id_eleitor) values ('2023-09-12'  ," + Convert.ToInt32(guarda_partido[1]) + ", " + Convert.ToInt32(guarda_candidato[1]) + ",  " + usuario1 + ");";

                    if (!banco.Executar(comando))
                    {
                        lblMsg.Text = "Problemas na votação";
                        banco.Closing();
                        return;
                    }
                    else
                    {
                        comando = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES(" + usuario1 + ", " + eleicao1 + ", 1);";

                        if (!banco.Executar(comando))
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
                        string newcode = "1";
                        MySqlDataReader dados = null;
                        if (!banco.Consult("Select count(id_voto)+1 from voto;", ref dados))
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


                        string comando = "insert into voto (data_voto, id_partido, id_candidato, id_eleitor) values ('2023-09-12'  ," + Convert.ToInt32(guarda_partido[2]) + ", " + Convert.ToInt32(guarda_candidato[2]) + ",  " + usuario1 + ");";

                        if (!banco.Executar(comando))
                        {
                            lblMsg.Text = "Problemas na votação";
                            banco.Closing();
                            return;
                        }
                        else
                        {
                            comando = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES(" + usuario1 + ", " + eleicao1 + ", 1);";

                            if (!banco.Executar(comando))
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
                            string newcode = "1";
                            MySqlDataReader dados = null;
                            if (!banco.Consult("Select count(id_voto)+1 from voto;", ref dados))
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


                            string comando = "insert into voto (data_voto, id_partido, id_candidato, id_eleitor) values ('2023-09-12'  ," + Convert.ToInt32(guarda_partido[3]) + ", " + Convert.ToInt32(guarda_candidato[3]) + ",  " + usuario1 + ");";

                            if (!banco.Executar(comando))
                            {
                                lblMsg.Text = "Problemas na votação";
                                banco.Closing();
                                return;
                            }
                            else
                            {
                                comando = "INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) VALUES(" + usuario1 + ", " + eleicao1 + ", 1);";

                                if (!banco.Executar(comando))
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