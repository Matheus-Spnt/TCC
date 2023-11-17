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
    
    public partial class home_sc : System.Web.UI.Page
    {
        int i;
        List<string> guarda_eleicao = new List<string>();
        List<string> guarda_eleicao_nm = new List<string>();
        List<string> guarda_eleicao2 = new List<string>();
        List<string> guarda_eleicao_nm2 = new List<string>();
        List<string> guarda_eleicao3 = new List<string>();
        List<string> guarda_eleicao_nm3 = new List<string>();
        int idEleicao;
        int idEleicaoLocal;
        string nmEleicaoLocal;
        int usuario1;
        cls_dado_banco_31682.cls_dado_banco_31682 banco = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {

            usuario1 = Convert.ToInt32(Session["user"]);
            //usuario1 = (int)Session["user"];




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
                while (dados.Read())
                {
                    guarda_eleicao.Add(dados["id_eleicao"].ToString());
                    guarda_eleicao_nm.Add(dados["titulo"].ToString());
                    

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
                    //v_btn.Text = "Votar";
                    //v_btn.Click += new EventHandler(v_btn_Click);


                    for (int m = 0; m < guarda_eleicao_nm.Count; m++)
                    {
                        Button v_btn = new Button();
                        v_btn.CssClass = "v_btn_5";
                        v_btn.Text = "Votar";
                        v_btn.CommandArgument = m.ToString();
                        v_btn.Click += new EventHandler(v_btn_Click);
                        caixa4.Controls.Add(v_btn);
                    }



                    //v_btn.Click += new EventHandler(v_btn_Click(sender, e, ref ));
                    //EventHandler p = (sender, e) => v_btn_Click(sender, e);
                    //v_btn.Click += new EventHandler(p);
                    //v_btn.Click += Response.Redirect("~/voto_sc.aspx");

                    //foreach (Control control in Panel1.Controls)
                    //{
                    //    if (control is Button)
                    //    {
                    //        Button votoButton = (Button)control;
                    //        votoButton.CssClass = "v_btn_5";
                    //        votoButton.Click += new EventHandler(v_btn_Click);
                    //        votoButton.CommandArgument = idEleicao;
                    //        caixa4.Controls.Add(votoButton);
                    //    }
                    //}


                    caixa3.Controls.Add(img);
                    caixa3.Controls.Add(lbl_ti1);
                    caixa3.Controls.Add(lbl_par1);
                    //caixa4.Controls.Add(v_btn);
                    caixa2.Controls.Add(caixa3);
                    caixa2.Controls.Add(caixa4);
                    caixa1.Controls.Add(caixa2);
                    Panel1.Controls.Add(caixa1);
                    //i++;

                }
                Session["eleicao"] = guarda_eleicao;
                
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
                    Session["eleicao"] = dados["id_eleicao"].ToString();
                    guarda_eleicao2.Add(dados["id_eleicao"].ToString());
                    guarda_eleicao_nm2.Add(dados["titulo"].ToString());
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
                    v_btn_2.Click += new EventHandler(v_btn_2Click);

                    //for (int m = 0; m < guarda_eleicao_nm.Count; m++)
                    //{
                    //    Button v_btn_2 = new Button();
                    //    v_btn_2.CssClass = "v_btn_5";
                    //    v_btn_2.Text = "Ver";
                    //    v_btn_2.CommandArgument = m.ToString(); // Use o índice como CommandArgument
                    //    v_btn_2.Click += new EventHandler(v_btn_2Click);
                    //    caixa8.Controls.Add(v_btn_2);
                    //}

                    //Button v_btn_2 = new Button();
                    //v_btn_2.CssClass = "v_btn_5";
                    //v_btn_2.Attributes["data-id-eleicao"] = idEleicaoLocal;
                    //EventHandler p = (sender, e) => v_btn_2Click(sender, e, idEleicao);
                    //v_btn_2.Click += new EventHandler(p);

                    //foreach (Control control in Panel2.Controls)
                    //{
                    //    if (control is Button)
                    //    {
                    //        Button andamentoButton = (Button)control;
                    //        andamentoButton.Click += new EventHandler(v_btn_2Click);
                    //        andamentoButton.CommandArgument = idEleicaoLocal;
                    //        andamentoButton.CssClass = "v_btn_5";
                    //        caixa8.Controls.Add(andamentoButton);
                    //    }
                    //}


                    caixa7.Controls.Add(img2);
                    caixa7.Controls.Add(lbl_ti2);
                    caixa7.Controls.Add(lbl_par2);
                    caixa8.Controls.Add(v_btn_2);
                    caixa6.Controls.Add(caixa7);
                    caixa6.Controls.Add(v_texto);
                    caixa6.Controls.Add(caixa8);
                    caixa5.Controls.Add(caixa6);
                    Panel2.Controls.Add(caixa5);
                    //i++;
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
                Panel2.Controls.Add(caixa9);
                banco.Closing();
                return;
            }
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Session["eleicao"] = dados["id_eleicao"].ToString();
                    guarda_eleicao3.Add(dados["id_eleicao"].ToString());
                    guarda_eleicao_nm3.Add(dados["titulo"].ToString());
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
                    v_btn_3.Click += new EventHandler(v_btn_3Click);

                    //Button v_btn_3 = new Button();
                    //v_btn_3.CssClass = "v_btn_5";

                    //foreach (Control control in Panel3.Controls)
                    //{
                    //    if (control is Button)
                    //    {
                    //        Button finalizadoButton = (Button)control;
                    //        finalizadoButton.Click += new EventHandler(v_btn_3Click);
                    //        finalizadoButton.CommandArgument = idEleicaoLocal_2;
                    //        finalizadoButton.CssClass = "v_btn_5";
                    //        caixa12.Controls.Add(finalizadoButton);
                    //    }
                    //}


                    caixa11.Controls.Add(img3);
                    caixa11.Controls.Add(lbl_ti3);
                    caixa11.Controls.Add(lbl_par3);
                    caixa12.Controls.Add(v_btn_3);
                    caixa10.Controls.Add(caixa11);
                    caixa10.Controls.Add(v_texto2);
                    caixa10.Controls.Add(caixa12);
                    caixa9.Controls.Add(caixa10);
                    Panel2.Controls.Add(caixa9);
                    //i++;
                }
            }
            #endregion
        }


        //protected void v_btn_Click(object sender, EventArgs e, ref string nome_eleicao)
        //{
        //    //foreach (var item in guarda_eleicao_nm = nome_eleicao)
        //    //{

        //    //}
        //    for (int m = 0; m < i; m++)
        //    {
        //        idEleicao = guarda_eleicao_nm.IndexOf(nome_eleicao);
        //    }
        //    //for (int j = 0; j == idEleicao; j++)
        //    //{

        //    //}

        //    Session["eleicao"] = guarda_eleicao[idEleicao];
        //    Response.Redirect("~/voto_sc.aspx");
        //}

        //protected void v_btn_Click(object sender, EventArgs e, ref string nome_eleicao)
        //{
        //    List<string> cx = (List<string>)Session["eleicao"];
        //    //foreach (var item in guarda_eleicao_nm = nome_eleicao)
        //    //{

        //    //}
        //    for (int m = 0; m < i; m++)
        //    {
        //        idEleicao = guarda_eleicao_nm.IndexOf(nome_eleicao);
        //    }
            
            
        //    Response.Redirect("~/voto_sc.aspx");
        //}

        //List<string> cx = (List<string>)Session["eleicao"];


        //protected void v_btn_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/voto_sc.aspx");
        //}

        protected void v_btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int buttonIndex = int.Parse(clickedButton.CommandArgument);

            string nomeEleicao = guarda_eleicao_nm[buttonIndex];
            string idEleicao = guarda_eleicao[buttonIndex];

            Session["eleicao"] = idEleicao;
            Session["nome_eleicao"] = nomeEleicao;

            Response.Redirect("~/voto_sc.aspx");
        }

        //protected void v_btn_2Click(object sender, EventArgs e)
        //{
        //    // Obter o botão clicado
        //    Button clickedButton = (Button)sender;

        //    // Obter o índice do botão clicado
        //    int buttonIndex = int.Parse(clickedButton.CommandArgument);

        //    // Usar o índice para obter os valores correspondentes da lista
        //    string nomeEleicao = guarda_eleicao_nm[buttonIndex];
        //    string idEleicao = guarda_eleicao[buttonIndex];

        //    // Armazenar os valores na Session
        //    Session["eleicao"] = idEleicao;
        //    Session["nome_eleicao"] = nomeEleicao;

        //    // Redirecionar para a página desejada (por exemplo, voto_sc.aspx)
        //    Response.Redirect("~/result.aspx");
        //}

        protected void v_btn_2Click(object sender, EventArgs e)
        {
            Response.Redirect("~/result.aspx");
        }


        protected void v_btn_3Click(object sender, EventArgs e)
        {
            Response.Redirect("~/result_2.aspx");
        }

    }

}