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
    //public partial class voto_sc
    //{
    //    #region Candidato1
    //    protected global::System.Web.UI.WebControls.Label lbl_nm;
    //    protected global::System.Web.UI.WebControls.Label lbl_part;
    //    protected global::System.Web.UI.WebControls.Label lbl_num;
    //    protected global::System.Web.UI.WebControls.RadioButton rbd_1;
    //    #endregion
    //    #region Candidato2
    //    protected global::System.Web.UI.WebControls.Label lbl_nm2;
    //    protected global::System.Web.UI.WebControls.Label lbl_part2;
    //    protected global::System.Web.UI.WebControls.Label lbl_num2;
    //    protected global::System.Web.UI.WebControls.RadioButton rbd_2;
    //    #endregion
    //    #region Candidato3
    //    protected global::System.Web.UI.WebControls.Label lbl_nm3;
    //    protected global::System.Web.UI.WebControls.Label lbl_part3;
    //    protected global::System.Web.UI.WebControls.Label lbl_num3;
    //    protected global::System.Web.UI.WebControls.RadioButton rbd_3;
    //    #endregion
    //    #region Candidato4
    //    protected global::System.Web.UI.WebControls.Label lbl_nm4;
    //    protected global::System.Web.UI.WebControls.Label lbl_part4;
    //    protected global::System.Web.UI.WebControls.Label lbl_num4;
    //    protected global::System.Web.UI.WebControls.RadioButton rbd_4;
    //    #endregion
    //    protected global::System.Web.UI.WebControls.CheckBox chb_1;
    //    protected global::System.Web.UI.WebControls.Label lblMsg;


    //}

    public partial class voto_sc : System.Web.UI.Page
    {
        String[] guarda = new String[4];
        String[] guarda2 = new String[4];
        usuario user1;
        eleicao elect1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();

            
            int i = 0;

            MySqlDataReader dados = null;

            if (!banco.Consult("select c.id_candidato, e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) where c.id_eleicao =" + elect1.GetEleicaoId() +";", ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read() || i < 4)
                {
                    guarda[i] = dados["c.id_candidato"].ToString();
                    i++;
                }
            }


            #region Candidato1
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, c.numero_urna, p.nome_partido, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + guarda[0] + " and c.id_eleicao =" + elect1.GetEleicaoId() + ";", ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                lbl_nm.Text = dados["c.nm_candidato"].ToString();
                lbl_part.Text = dados["p.nome_partido"].ToString();
                lbl_num.Text = dados["c.numero_urna"].ToString();
                guarda2[0] = dados["p.id_partido"].ToString();
            }
            #endregion

            #region Candidato2
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, c.numero_urna, p.nome_partido, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + guarda[1] + " and c.id_eleicao =" + elect1.GetEleicaoId() + ";", ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                lbl_nm2.Text = dados["c.nm_candidato"].ToString();
                lbl_part2.Text = dados["p.nome_partido"].ToString();
                lbl_num2.Text = dados["c.numero_urna"].ToString();
                guarda2[1] = dados["p.id_partido"].ToString();
            }
            #endregion

            #region Candidato3
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, c.numero_urna, p.nome_partido, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + guarda[2] + " and c.id_eleicao =" + elect1.GetEleicaoId() + ";", ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                lbl_nm3.Text = dados["c.nm_candidato"].ToString();
                lbl_part3.Text = dados["p.nome_partido"].ToString();
                lbl_num3.Text = dados["c.numero_urna"].ToString();
                guarda2[2] = dados["p.id_partido"].ToString();
            }
            #endregion

            #region Candidato4
            if (!banco.Consult("select c.nm_candidato, c.id_candidato, c.numero_urna, p.nome_partido, p.id_partido,e.id_eleicao from candidato c join eleicao e on(c.id_eleicao = e.id_eleicao) join partido p on(c.id_partido = p.id_partido) where c.id_candidato = " + guarda[3] + " and c.id_eleicao =" + elect1.GetEleicaoId() + ";", ref dados))
            {
                lblMsg.Text = "Problemas na consulta ao servidor";
                banco.Closing();
                return;
            }

            if (dados.HasRows)
            {
                lbl_nm.Text = dados["c.nm_candidato"].ToString();
                lbl_part.Text = dados["p.nome_partido"].ToString();
                lbl_num.Text = dados["c.numero_urna"].ToString();
                guarda2[3] = dados["p.id_partido"].ToString();
            }
            #endregion
        }

        private void btn_votar(object sender, EventArgs e)
        {
            #region Candidato1
            if (rbd_1.Checked && chb_1.Checked)
            {
                string newcode = "1";
                MySqlDataReader dados = null;
                if (!banco.Consult("Select max(id_nome)+1 from voto", ref dados))
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


                string comando = "insert into voto values (" + newcode + ", " + user1.GetUsuarioId() + ", " + guarda2[0] + ", " + guarda[0] + " )";

                if (!banco.Executar(comando))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    comando = "insert into eleitor confirma_voto (" + elect1.GetEleicaoId() + ", " + user1.GetUsuarioId() + ", true)";

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

            #region Candidato2
            if (rbd_2.Checked && chb_1.Checked)
            {
                string newcode = "1";
                MySqlDataReader dados = null;
                if (!banco.Consult("Select max(id_nome)+1 from voto", ref dados))
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


                string comando = "insert into voto values (" + newcode + ", " + user1.GetUsuarioId() + ", " + guarda2[1] + ", " + guarda[1] + " )";

                if (!banco.Executar(comando))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    comando = "insert into eleitor confirma_voto (" + elect1.GetEleicaoId() + ", " + user1.GetUsuarioId() + ", true)";

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

            #region Candidato3
            if (rbd_3.Checked && chb_1.Checked)
            {
                string newcode = "1";
                MySqlDataReader dados = null;
                if (!banco.Consult("Select max(id_nome)+1 from voto", ref dados))
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


                string comando = "insert into voto values (" + newcode + ", " + user1.GetUsuarioId() + ", " + guarda2[2] + ", " + guarda[2] + " )";

                if (!banco.Executar(comando))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    comando = "insert into eleitor confirma_voto (" + elect1.GetEleicaoId() + ", " + user1.GetUsuarioId() + ", true)";

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

            #region Candidato4
            if (rdb_4.Checked && chb_1.Checked)
            {
                string newcode = "1";
                MySqlDataReader dados = null;
                if (!banco.Consult("Select max(id_nome)+1 from voto", ref dados))
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


                string comando = "insert into voto values (" + newcode + ", " + user1.GetUsuarioId() + ", " + guarda2[3] + ", " + guarda[3] + " )";

                if (!banco.Executar(comando))
                {
                    lblMsg.Text = "Problemas na votação";
                    banco.Closing();
                    return;
                }
                else
                {
                    comando = "insert into eleitor confirma_voto (" + elect1.GetEleicaoId() + ", " + user1.GetUsuarioId() + ", true)";

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