﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace TCC_V2
{
    
    public partial class home_sc : System.Web.UI.Page
    {
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
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


            #region Votar
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, cv.confirma_votar from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor =" + usuario1 + " and cv.confirma_votar = 0;", ref dados))
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
                int index = 0;
                while (dados.Read())
                {
                    if (index == 0)
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
                        lbl_ti1.Text = dados["titulo"].ToString();
                        Label lbl_par1 = new Label();
                        lbl_par1.CssClass = "par_mini";
                        lbl_par1.Text = dados["descricao_eleicao"].ToString();
                        Panel caixa4 = new Panel();
                        caixa4.CssClass = "v_btn_6";
                        Button v_btn = new Button();
                        v_btn.CssClass = "v_btn_7";
                        v_btn.Text = "Votar";
                        v_btn.ID = dados["id_eleicao"].ToString();
                        v_btn.Click += new EventHandler(v_btn_Click);
                        caixa3.Controls.Add(img);
                        caixa3.Controls.Add(lbl_ti1);
                        caixa3.Controls.Add(lbl_par1);
                        caixa4.Controls.Add(v_btn);
                        caixa2.Controls.Add(caixa3);
                        caixa2.Controls.Add(caixa4);
                        caixa1.Controls.Add(caixa2);
                        Panel1.Controls.Add(caixa1);
                        index++;
                    }
                    else
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
                        lbl_ti1.Text = dados["titulo"].ToString();
                        Label lbl_par1 = new Label();
                        lbl_par1.CssClass = "par_mini";
                        lbl_par1.Text = dados["descricao_eleicao"].ToString();
                        Panel caixa4 = new Panel();
                        caixa4.CssClass = "v_btn_4";
                        Button v_btn = new Button();
                        v_btn.CssClass = "v_btn_5";
                        v_btn.Text = "Votar";
                        v_btn.ID = dados["id_eleicao"].ToString();
                        v_btn.Click += new EventHandler(v_btn_Click);
                        caixa3.Controls.Add(img);
                        caixa3.Controls.Add(lbl_ti1);
                        caixa3.Controls.Add(lbl_par1);
                        caixa4.Controls.Add(v_btn);
                        caixa2.Controls.Add(caixa3);
                        caixa2.Controls.Add(caixa4);
                        caixa1.Controls.Add(caixa2);
                        Panel1.Controls.Add(caixa1);
                        index++;
                    }
                    
                }
                                
            }

            #endregion

            #region Andamento
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votar from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor = " + usuario1 + " and cv.confirma_votar = 1 and e.data_termino is null ;", ref dados))
            {
                Panel caixa5 = new Panel();
                caixa5.CssClass = "box_resul_3";
                Panel caixa6 = new Panel();
                caixa6.CssClass = "campo_voto_fc_4";
                Panel caixa7 = new Panel();
                caixa7.CssClass = "cria_log_2";
                Panel img2 = new Panel();
                img2.CssClass = "img_mid";
                Label lbl_ti2 = new Label();
                lbl_ti2.CssClass = "texto_mini";
                lbl_ti2.Text = "Problemas na consulta ao servidor";
                Label lbl_par2 = new Label();
                lbl_par2.CssClass = "par_mini";
                lbl_par2.Text = "Problemas na consulta ao servidor";
                Panel caixa8 = new Panel();
                caixa8.CssClass = "v_btn_4";
                caixa7.Controls.Add(img2);
                caixa7.Controls.Add(lbl_ti2);
                caixa7.Controls.Add(lbl_par2);
                caixa6.Controls.Add(caixa7);
                caixa6.Controls.Add(caixa8);
                caixa5.Controls.Add(caixa6);
                Panel2.Controls.Add(caixa5);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Panel caixa5 = new Panel();
                    caixa5.CssClass = "box_resul_3";
                    Panel caixa6 = new Panel();
                    caixa6.CssClass = "campo_voto_fc_4";
                    Panel caixa7 = new Panel();
                    caixa7.CssClass = "cria_log_2";
                    Panel img2 = new Panel();
                    img2.CssClass = "img_mid";
                    Label lbl_ti2 = new Label();
                    lbl_ti2.CssClass = "texto_mini";
                    lbl_ti2.Text = dados["titulo"].ToString();
                    Label lbl_par2 = new Label();
                    lbl_par2.CssClass = "par_mini";
                    lbl_par2.Text = dados["descricao_eleicao"].ToString();
                    Label v_texto = new Label();
                    v_texto.CssClass = "v_texto_1";
                    v_texto.Text = "Em andamento";
                    Panel caixa8 = new Panel();
                    caixa8.CssClass = "v_btn_4";
                    Button v_btn_2 = new Button();
                    v_btn_2.CssClass = "v_btn_5";
                    v_btn_2.Text = "Ver";
                    v_btn_2.ID = dados["id_eleicao"].ToString();
                    v_btn_2.Click += new EventHandler(v_btn_2Click);
                    caixa7.Controls.Add(img2);
                    caixa7.Controls.Add(lbl_ti2);
                    caixa7.Controls.Add(lbl_par2);
                    caixa8.Controls.Add(v_btn_2);
                    caixa6.Controls.Add(caixa7);
                    caixa6.Controls.Add(v_texto);
                    caixa6.Controls.Add(caixa8);
                    caixa5.Controls.Add(caixa6);
                    Panel2.Controls.Add(caixa5);
                }
            }
            #endregion

            #region Finalizado
            if (!banco.Consult("select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votar from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor = " + usuario1 + " and cv.confirma_votar = 1 and e.data_termino is not null ;", ref dados))
            {
                Panel caixa9 = new Panel();
                caixa9.CssClass = "box_resul_3";
                Panel caixa10 = new Panel();
                caixa10.CssClass = "campo_voto_fc_4";
                Panel caixa11 = new Panel();
                caixa11.CssClass = "cria_log_2";
                Panel img3 = new Panel();
                img3.CssClass = "img_mid";
                Label lbl_ti3 = new Label();
                lbl_ti3.CssClass = "texto_mini";
                lbl_ti3.Text = "Problemas na consulta ao servidor";
                Label lbl_par3 = new Label();
                lbl_par3.CssClass = "par_mini";
                lbl_par3.Text = "Problemas na consulta ao servidor";
                Panel caixa12 = new Panel();
                caixa12.CssClass = "v_btn_4";
                caixa11.Controls.Add(img3);
                caixa11.Controls.Add(lbl_ti3);
                caixa11.Controls.Add(lbl_par3);
                caixa10.Controls.Add(caixa11);
                caixa10.Controls.Add(caixa12);
                caixa9.Controls.Add(caixa10);
                Panel3.Controls.Add(caixa9);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Panel caixa9 = new Panel();
                    caixa9.CssClass = "box_resul_3";
                    Panel caixa10 = new Panel();
                    caixa10.CssClass = "campo_voto_fc_4";
                    Panel caixa11 = new Panel();
                    caixa11.CssClass = "cria_log_2";
                    Panel img3 = new Panel();
                    img3.CssClass = "img_mid";
                    Label lbl_ti3 = new Label();
                    lbl_ti3.CssClass = "texto_mini";
                    lbl_ti3.Text = dados["titulo"].ToString();
                    Label lbl_par3 = new Label();
                    lbl_par3.CssClass = "par_mini";
                    lbl_par3.Text = dados["descricao_eleicao"].ToString();
                    Label v_texto2 = new Label();
                    v_texto2.CssClass = "v_texto_2";
                    v_texto2.Text = "Finalizado";
                    Panel caixa12 = new Panel();
                    caixa12.CssClass = "v_btn_4";

                    Button v_btn_3 = new Button();
                    v_btn_3.CssClass = "v_btn_5";
                    v_btn_3.Text = "Ver";
                    v_btn_3.ID = dados["id_eleicao"].ToString();
                    v_btn_3.Click += new EventHandler(v_btn_3Click);
                    caixa11.Controls.Add(img3);
                    caixa11.Controls.Add(lbl_ti3);
                    caixa11.Controls.Add(lbl_par3);
                    caixa12.Controls.Add(v_btn_3);
                    caixa10.Controls.Add(caixa11);
                    caixa10.Controls.Add(v_texto2);
                    caixa10.Controls.Add(caixa12);
                    caixa9.Controls.Add(caixa10);
                    Panel3.Controls.Add(caixa9);
                    //i++;
                }
            }
            #endregion
        }


        protected void v_btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Session["eleicao"] = clickedButton.ID;
            Response.Redirect("~/voto_sc.aspx");
        }


        protected void v_btn_2Click(object sender, EventArgs e)
        {
            Button clickedButton2 = (Button)sender;
            Session["eleicao"] = clickedButton2.ID;
            Response.Redirect("~/result.aspx");
        }


        protected void v_btn_3Click(object sender, EventArgs e)
        {
            Button clickedButton3 = (Button)sender;
            Session["eleicao"] = clickedButton3.ID;
            Response.Redirect("~/result_2.aspx");
        }

    }

}