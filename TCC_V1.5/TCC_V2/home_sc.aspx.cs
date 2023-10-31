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
    //public partial class home_sc
    //{
    //    protected global::System.Web.UI.WebControls.Panel Panel1;
    //    protected global::System.Web.UI.WebControls.Panel Panel2;
    //    protected global::System.Web.UI.WebControls.Panel Panel3;

    //}

    public partial class home_sc : System.Web.UI.Page
    {
        //int i;
        //String[] guarda = new String[i];
        //String[] guarda2 = new String[];
        //String[] guarda3 = new String[];
        string idEleicao;
        string idEleicaoLocal;
        string idEleicaoLocal_2;
        eleicao elect1 = new eleicao();
        usuario user1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {


            banco = new cls_dado_banco_31682.cls_dado_banco_31682();
            banco.linhaConexao = cls_con_banco_31682.cls_con_banco_31682.Local();
            MySqlDataReader dados = null;

            #region Votar
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votado from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.td_eleitor = " + user1.GetUsuarioId() + " and cv.confirma_votado = false ;", ref dados))
            {
                Panel caixa1 = new Panel();
                caixa1.CssClass = "box_resul_3";
                Panel caixa2 = new Panel();
                caixa2.CssClass = "campo_voto_fc_4";
                Panel caixa3 = new Panel();
                caixa3.CssClass = "cria_log_2";
                Panel img = new Panel();
                img.CssClass = "img_mid";
                Label lbl_ti1 = new Label();
                lbl_ti1.CssClass = "texto_mini";
                lbl_ti1.Text = "Problemas na consulta ao servidor";
                Label lbl_par1 = new Label();
                lbl_par1.CssClass = "par_mini";
                lbl_par1.Text = "Problemas na consulta ao servidor";
                Panel caixa4 = new Panel();
                caixa4.CssClass = "v_btn_4";
                caixa3.Controls.Add(img);
                caixa3.Controls.Add(lbl_ti1);
                caixa3.Controls.Add(lbl_par1);
                caixa2.Controls.Add(caixa3);
                caixa2.Controls.Add(caixa4);
                caixa1.Controls.Add(caixa2);
                Panel1.Controls.Add(caixa1);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    idEleicao = dados["id_eleicao"].ToString();
                    Panel caixa1 = new Panel();
                    caixa1.CssClass = "box_resul_3";
                    Panel caixa2 = new Panel();
                    caixa2.CssClass = "campo_voto_fc_4";
                    Panel caixa3 = new Panel();
                    caixa3.CssClass = "cria_log_2";
                    Panel img = new Panel();
                    img.CssClass = "img_mid";
                    Label lbl_ti1 = new Label();
                    lbl_ti1.CssClass = "texto_mini";
                    lbl_ti1.Text = dados["titulo"].ToString();
                    Label lbl_par1 = new Label();
                    lbl_par1.CssClass = "par_mini";
                    lbl_par1.Text = dados["descricao_eleicao"].ToString();
                    Panel caixa4 = new Panel();
                    caixa4.CssClass = "v_btn_4";
                    //Button v_btn = new Button();
                    //v_btn.CssClass = "v_btn_5";
                    //EventHandler p = (sender, e) => v_btn_Click(sender, e, idEleicao);
                    //v_btn.Click += new EventHandler(p);

                    foreach (Control control in Panel1.Controls)
                    {
                        if (control is Button)
                        {
                            Button votoButton = (Button)control;
                            votoButton.CssClass = "v_btn_5";
                            votoButton.Click += new EventHandler(v_btn_Click);
                            votoButton.CommandArgument = idEleicao;
                            caixa4.Controls.Add(votoButton);
                        }
                    }


                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti1);
                    caixa3.Controls.Add(lbl_par1);
                    //caixa4.Controls.Add(votoButton);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel1.Controls.Add(caixa1);
                    //i++;
                }
            }

            #endregion

            #region Andamento
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votado from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.td_eleitor = " + user1.GetUsuarioId() + " and cv.confirma_votado = true and e.data_termino is null ;", ref dados))
            {
                Panel caixa1 = new Panel();
                caixa1.CssClass = "box_resul_3";
                Panel caixa2 = new Panel();
                caixa2.CssClass = "campo_voto_fc_4";
                Panel caixa3 = new Panel();
                caixa3.CssClass = "cria_log_2";
                Panel img = new Panel();
                img.CssClass = "img_mid";
                Label lbl_ti2 = new Label();
                lbl_ti2.CssClass = "texto_mini";
                lbl_ti2.Text = "Problemas na consulta ao servidor";
                Label lbl_par2 = new Label();
                lbl_par2.CssClass = "par_mini";
                lbl_par2.Text = "Problemas na consulta ao servidor";
                Panel caixa4 = new Panel();
                caixa4.CssClass = "v_btn_4";
                caixa3.Controls.Add(img);
                caixa3.Controls.Add(lbl_ti2);
                caixa3.Controls.Add(lbl_par2);
                caixa2.Controls.Add(caixa3);
                caixa2.Controls.Add(caixa4);
                caixa1.Controls.Add(caixa2);
                Panel2.Controls.Add(caixa1);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    //guarda2[i] = dados["e.id_eleicao"].ToString();
                    idEleicaoLocal = dados["id_eleicao"].ToString();
                    Panel caixa1 = new Panel();
                    caixa1.CssClass = "box_resul_3";
                    Panel caixa2 = new Panel();
                    caixa2.CssClass = "campo_voto_fc_4";
                    Panel caixa3 = new Panel();
                    caixa3.CssClass = "cria_log_2";
                    Panel img = new Panel();
                    img.CssClass = "img_mid";
                    Label lbl_ti2 = new Label();
                    lbl_ti2.CssClass = "texto_mini";
                    lbl_ti2.Text = dados["titulo"].ToString();
                    Label lbl_par2 = new Label();
                    lbl_par2.CssClass = "par_mini";
                    lbl_par2.Text = dados["descricao_eleicao"].ToString();
                    Label v_texto = new Label();
                    v_texto.CssClass = "v_texto_1";
                    v_texto.Text = "Em andamento";
                    Panel caixa4 = new Panel();
                    caixa4.CssClass = "v_btn_4";
                    //Button v_btn_2 = new Button();
                    //v_btn_2.CssClass = "v_btn_5";
                    //v_btn_2.Attributes["data-id-eleicao"] = idEleicaoLocal;
                    //EventHandler p = (sender, e) => v_btn_2Click(sender, e, idEleicao);
                    //v_btn_2.Click += new EventHandler(p);

                    foreach (Control control in Panel2.Controls)
                    {
                        if (control is Button)
                        {
                            Button andamentoButton = (Button)control;
                            andamentoButton.Click += new EventHandler(v_btn_2Click);
                            andamentoButton.CommandArgument = idEleicaoLocal;
                            andamentoButton.CssClass = "v_btn_5";
                            caixa4.Controls.Add(andamentoButton);
                        }
                    }


                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti2);
                    caixa3.Controls.Add(lbl_par2);
                    //caixa4.Controls.Add(v_btn_2);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(v_texto);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel2.Controls.Add(caixa1);
                    //i++;
                }
            }
            #endregion

            #region Finalizado
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votado from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.td_eleitor = " + user1.GetUsuarioId() + " and cv.confirma_votado = true and e.data_termino is not null ;", ref dados))
            {
                Panel caixa1 = new Panel();
                caixa1.CssClass = "box_resul_3";
                Panel caixa2 = new Panel();
                caixa2.CssClass = "campo_voto_fc_4";
                Panel caixa3 = new Panel();
                caixa3.CssClass = "cria_log_2";
                Panel img = new Panel();
                img.CssClass = "img_mid";
                Label lbl_ti3 = new Label();
                lbl_ti3.CssClass = "texto_mini";
                lbl_ti3.Text = "Problemas na consulta ao servidor";
                Label lbl_par3 = new Label();
                lbl_par3.CssClass = "par_mini";
                lbl_par3.Text = "Problemas na consulta ao servidor";
                Panel caixa4 = new Panel();
                caixa4.CssClass = "v_btn_4";
                caixa3.Controls.Add(img);
                caixa3.Controls.Add(lbl_ti3);
                caixa3.Controls.Add(lbl_par3);
                caixa2.Controls.Add(caixa3);
                caixa2.Controls.Add(caixa4);
                caixa1.Controls.Add(caixa2);
                Panel2.Controls.Add(caixa1);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    //guarda3[i] = dados["e.id_eleicao"].ToString();
                    idEleicaoLocal_2 = dados["id_eleicao"].ToString();
                    Panel caixa1 = new Panel();
                    caixa1.CssClass = "box_resul_3";
                    Panel caixa2 = new Panel();
                    caixa2.CssClass = "campo_voto_fc_4";
                    Panel caixa3 = new Panel();
                    caixa3.CssClass = "cria_log_2";
                    Panel img = new Panel();
                    img.CssClass = "img_mid";
                    Label lbl_ti3 = new Label();
                    lbl_ti3.CssClass = "texto_mini";
                    lbl_ti3.Text = dados["titulo"].ToString();
                    Label lbl_par3 = new Label();
                    lbl_par3.CssClass = "par_mini";
                    lbl_par3.Text = dados["descricao_eleicao"].ToString();
                    Label v_texto = new Label();
                    v_texto.CssClass = "v_texto_2";
                    v_texto.Text = "Em andamento";
                    Panel caixa4 = new Panel();
                    caixa4.CssClass = "v_btn_4";
                    //Button v_btn_3 = new Button();
                    //v_btn_3.CssClass = "v_btn_5";

                    foreach (Control control in Panel3.Controls)
                    {
                        if (control is Button)
                        {
                            Button finalizadoButton = (Button)control;
                            finalizadoButton.Click += new EventHandler(v_btn_3Click);
                            finalizadoButton.CommandArgument = idEleicaoLocal_2;
                            finalizadoButton.CssClass = "v_btn_5";
                            caixa4.Controls.Add(finalizadoButton);
                        }
                    }


                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti3);
                    caixa3.Controls.Add(lbl_par3);
                    //caixa4.Controls.Add(v_btn_3);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(v_texto);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel2.Controls.Add(caixa1);
                    //i++;
                }
            }
            #endregion
        }

        //private void v_btn_Click(object sender, EventArgs e, string idEleicao)
        //{
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/voto_sc.aspx");
        //}

        protected void v_btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string idEleicao = clickedButton.CommandArgument;
            elect1.SetEleicaoId(idEleicao);
            Response.Redirect("~/voto_sc.aspx");
        }


        //private void v_btn_2Click(object sender, EventArgs e, string idEleicao)
        //{
        //    Button clickedButton = (Button)sender;
        //    idEleicao = clickedButton.Attributes["data-id-eleicao"];
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/result.aspx");
        //}

        protected void v_btn_2Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string idEleicao = clickedButton.CommandArgument;
            elect1.SetEleicaoId(idEleicao);
            Response.Redirect("~/result.aspx");
        }


        //private void v_btn_3Click(object sender, EventArgs e, string idEleicao)
        //{
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/result_2.aspx");
        //}

        protected void v_btn_3Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string idEleicao = clickedButton.CommandArgument;
            elect1.SetEleicaoId(idEleicao);
            Response.Redirect("~/result_2.aspx");
        }

    }

}