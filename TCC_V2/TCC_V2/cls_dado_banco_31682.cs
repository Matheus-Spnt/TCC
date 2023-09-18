using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace cls_dado_banco_31682
{
    public class cls_dado_banco_31682
    {
        #region Strings
        private string _linhaConexao;
        MySqlConnection conexao = null;

        public string linhaConexao
        {
            set { _linhaConexao = value; }
            //get { return _linhaConexao; }
        }
        #endregion

        #region Construtor
        public cls_dado_banco_31682()
        {

        }
        #endregion

        #region Conectar
        private bool Conectar()
        {
            bool worked = true;
            conexao = new MySqlConnection(_linhaConexao);
            try
            {
                conexao.Open();
            }
            catch
            {
                worked = false;
            }
            return worked;
        }
        #endregion

        #region Consult
        /// <summary>
        /// Recupera dados da consulta do banco de dados
        /// </summary>
        public bool Consult(string comandoSELECT, ref MySqlDataReader dados)
        {
            if (Conectar())
            {
                bool worked = true;
                MySqlCommand cSQL = new MySqlCommand(comandoSELECT, conexao);
                try
                {
                    dados = cSQL.ExecuteReader();
                }
                catch
                {
                    worked = false;
                }
                return worked;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Executar
        public bool Executar(string comando)
        {
            if (Conectar())
            {
                bool worked = true;
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                try
                {
                    cSQL.ExecuteNonQuery();
                }
                catch
                {
                    worked = false;
                }
                Closing();
                return worked;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Execute with paramiters
        public bool Execute(string sql, List<MySqlParameter> valores)
        {
            try
            {
                bool worked = true;
                if (Conectar())
                {
                    MySqlCommand cSQL = new MySqlCommand(sql, conexao);
                    cSQL.Parameters.Clear();
                    for (int i = 0; i < valores.Count; i++)
                    {
                        cSQL.Parameters.Add(valores[i]);
                    }
                    try
                    {
                        cSQL.ExecuteNonQuery();

                    }
                    catch
                    {
                        worked = false;
                    }
                }
                else
                {
                    return false;
                }
                Closing();
                return worked;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Close
        public void Closing()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();                
            }
        }
        #endregion
    }
}
