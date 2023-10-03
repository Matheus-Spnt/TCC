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
    public partial class home_sc
    {
        protected global::System.Web.UI.WebControls.Panel Panel1;
        protected global::System.Web.UI.WebControls.Panel Panel2;
        protected global::System.Web.UI.WebControls.Panel Panel3;

    }

    public partial class home_sc : System.Web.UI.Page
    {
        int i;
        String[] guarda = new String[i];
        String[] guarda2 = new String[];
        String[] guarda3 = new String[];
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
                    guarda[i] = dados["e.id_eleicao"].ToString();

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
                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti1);
                    caixa3.Controls.Add(lbl_par1);
                    caixa4.Controls.Add(v_btn);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel1.Controls.Add(caixa1);
                    i++;
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
                    guarda2[i] = dados["e.id_eleicao"].ToString();

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
                    Button v_btn_2 = new Button();
                    v_btn_2.CssClass = "v_btn_5";
                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti2);
                    caixa3.Controls.Add(lbl_par2);
                    caixa4.Controls.Add(v_btn_2);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(v_texto);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel2.Controls.Add(caixa1);
                    i++;
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
                    guarda3[i] = dados["e.id_eleicao"].ToString();

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
                    Button v_btn_3 = new Button();
                    v_btn_3.CssClass = "v_btn_5";
                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti3);
                    caixa3.Controls.Add(lbl_par3);
                    caixa4.Controls.Add(v_btn_3);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(v_texto);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel2.Controls.Add(caixa1);
                    i++;
                }
            }
            #endregion
        }

        private void v_btn(object sender, EventArgs e)
        {
            elect1.SetEleicaoId(guarda[i]);
            Response.Redirect("~/voto_sc.aspx");

        }

        private void v_btn_2(object sender, EventArgs e)
        {
            elect1.SetEleicaoId(guarda2[i]);
            Response.Redirect("~/result.aspx");
        }

        private void v_btn_3(object sender, EventArgs e)
        {
            elect1.SetEleicaoId(guarda3[i]);
            Response.Redirect("~/result_2.aspx");
        }

    }

}