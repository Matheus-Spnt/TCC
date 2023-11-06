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

        int i = 0;



        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["i"] != null)
            {
                i = Convert.ToInt32(Session["i"]);
            }
            else
            {
                i = 0;
            }


            #region Votar

            //            Panel caixa1 = new Panel();
            //            caixa1.CssClass = "box_resul_3";
            //            Panel caixa2 = new Panel();
            //            caixa2.CssClass = "campo_voto_fc_4";
            //            Panel caixa3 = new Panel();
            //            caixa3.CssClass = "cria_log_2";
            //            Panel img = new Panel();
            //            img.CssClass = "img_mid";
            //            Label lbl_ti1 = new Label();
            //            lbl_ti1.CssClass = "texto_mini";
            //            lbl_ti1.Text = "Tema: Presidente";
            //            Label lbl_par1 = new Label();
            //            lbl_par1.CssClass = "par_mini";
            //            lbl_par1.Text = "Lorem, ipsum dolor sit amet consectetur adipisicing elit.Dolore officiis illo voluptas magnam, magni tenetur numquam";
            //            Panel caixa4 = new Panel();
            //            caixa4.CssClass = "v_btn_4";
            //            Button v_btn = new Button();
            //            v_btn.CssClass = "v_btn_5";


            //            caixa3.Controls.Add(img);
            //            caixa3.Controls.Add(lbl_ti1);
            //            caixa3.Controls.Add(lbl_par1);
            //            caixa4.Controls.Add(v_btn);
            //            caixa2.Controls.Add(caixa3);
            //            caixa2.Controls.Add(caixa4);
            //            caixa1.Controls.Add(caixa2);
            //            Panel1.Controls.Add(caixa1);



            //Panel caixa13 = new Panel();
            //caixa1.CssClass = "box_resul_3";
            //Panel caixa14 = new Panel();
            //caixa2.CssClass = "campo_voto_fc_4";
            //Panel caixa15 = new Panel();
            //caixa3.CssClass = "cria_log_2";
            //Panel img4 = new Panel();
            //img.CssClass = "img_mid";
            //Label lbl_ti4 = new Label();
            //lbl_ti4.CssClass = "texto_mini";
            //lbl_ti4.Text = "Tema: Deputado Federal";
            //Label lbl_par4 = new Label();
            //lbl_par4.CssClass = "par_mini";
            //lbl_par4.Text = "Lorem, ipsum dolor sit amet consectetur adipisicing elit.Dolore officiis illo voluptas magnam, magni tenetur numquam";
            //Panel caixa16 = new Panel();
            //caixa4.CssClass = "v_btn_4";
            //Button v_btn_4 = new Button();
            //v_btn_4.CssClass = "v_btn_5";



            //caixa15.Controls.Add(img4);
            //caixa15.Controls.Add(lbl_ti4);
            //caixa15.Controls.Add(lbl_par4);
            //caixa16.Controls.Add(v_btn_4);
            //caixa14.Controls.Add(caixa15);
            //caixa14.Controls.Add(caixa16);
            //caixa13.Controls.Add(caixa14);
            //Panel4.Controls.Add(caixa13);






            #endregion

            #region Andamento

            //Panel caixa5 = new Panel();
            //caixa5.CssClass = "box_resul_3";
            //Panel caixa6 = new Panel();
            //caixa6.CssClass = "campo_voto_fc_4";
            //Panel caixa7 = new Panel();
            //caixa7.CssClass = "cria_log_2";
            //Panel img2 = new Panel();
            //img2.CssClass = "img_mid";
            //Label lbl_ti2 = new Label();
            //lbl_ti2.CssClass = "texto_mini";
            //lbl_ti2.Text = "Tema: Governador";
            //Label lbl_par2 = new Label();
            //lbl_par2.CssClass = "par_mini";
            //lbl_par2.Text = "Lorem, ipsum dolor sit amet consectetur adipisicing elit.Dolore officiis illo voluptas magnam, magni tenetur numquam";
            //Label v_texto = new Label();
            //v_texto.CssClass = "v_texto_1";
            //v_texto.Text = "Em andamento";
            //Panel caixa8 = new Panel();
            //caixa8.CssClass = "v_btn_4";
            //Button v_btn_2 = new Button();
            //v_btn_2.CssClass = "v_btn_5";

            //caixa7.Controls.Add(img2);
            //caixa7.Controls.Add(lbl_ti2);
            //caixa7.Controls.Add(lbl_par2);
            //caixa8.Controls.Add(v_btn_2);
            //caixa6.Controls.Add(caixa7);
            //caixa6.Controls.Add(v_texto);
            //caixa6.Controls.Add(caixa8);
            //caixa5.Controls.Add(caixa6);
            //Panel2.Controls.Add(caixa5);

            #endregion

            #region Finalizado

            //Panel caixa9 = new Panel();
            //caixa9.CssClass = "box_resul_3";
            //Panel caixa10 = new Panel();
            //caixa10.CssClass = "campo_voto_fc_4";
            //Panel caixa11 = new Panel();
            //caixa11.CssClass = "cria_log_2";
            //Panel img3 = new Panel();
            //img3.CssClass = "img_mid";
            //Label lbl_ti3 = new Label();
            //lbl_ti3.CssClass = "texto_mini";
            //lbl_ti3.Text = "Tema: Senador";
            //Label lbl_par3 = new Label();
            //lbl_par3.CssClass = "par_mini";
            //lbl_par3.Text = "Lorem, ipsum dolor sit amet consectetur adipisicing elit.Dolore officiis illo voluptas magnam, magni tenetur numquam";
            //Label v_texto2 = new Label();
            //v_texto2.CssClass = "v_texto_2";
            //v_texto2.Text = "Em andamento";
            //Panel caixa12 = new Panel();
            //caixa12.CssClass = "v_btn_4";
            //Button v_btn_3 = new Button();
            //v_btn_3.CssClass = "v_btn_5";


            //caixa11.Controls.Add(img3);
            //caixa11.Controls.Add(lbl_ti3);
            //caixa11.Controls.Add(lbl_par3);
            //caixa12.Controls.Add(v_btn_3);
            //caixa10.Controls.Add(caixa11);
            //caixa10.Controls.Add(v_texto2);
            //caixa10.Controls.Add(caixa12);
            //caixa9.Controls.Add(caixa10);
            //Panel3.Controls.Add(caixa9);

            #endregion


            //if (user1.GetUsuarioV() == 0)
            //{
            //    Panel1.Visible = true;
            //}
            //else
            //{
            //    if (user1.GetUsuarioV() == 0)
            //    {
            //        Panel1.Visible = false;
            //    }
            //}
            if (i == 0)
            {
                divPanel1.Visible = true;
                divPanel5.Visible = false;
            }
            else
            {
                if (i == 1)
                {
                    divPanel1.Visible = false;
                    divPanel5.Visible = true;
                }
            }


        }

        //private void v_btn_Click(object sender, EventArgs e, string idEleicao)
        //{
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/voto_sc.aspx");
        //}

        protected void v_btn1_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //string idEleicao = clickedButton.CommandArgument;
            //elect1.SetEleicaoId(idEleicao);
            i++;
            Session["i"] = i;
            Response.Redirect("~/voto_sc.aspx");
        }


        //private void v_btn_2Click(object sender, EventArgs e, string idEleicao)
        //{
        //    Button clickedButton = (Button)sender;
        //    idEleicao = clickedButton.Attributes["data-id-eleicao"];
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/result.aspx");
        //}

        protected void v_btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/result.aspx");
        }


        //private void v_btn_3Click(object sender, EventArgs e, string idEleicao)
        //{
        //    elect1.SetEleicaoId(idEleicao);
        //    Response.Redirect("~/result_2.aspx");
        //}

        protected void v_btn3_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //string idEleicao = clickedButton.CommandArgument;
            //elect1.SetEleicaoId(idEleicao);
            Response.Redirect("~/result_2.aspx");
        }

        protected void v_btn4_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //string idEleicao = clickedButton.CommandArgument;
            //elect1.SetEleicaoId(idEleicao);
            i++;
            Session["i"] = i;
            Response.Redirect("~/voto_sc.aspx");
        }


    }

}