using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_V2
{
    public class eleicao
    {

        public String eleicao_id;
        public String eleicao_nome;

        public void SetEleicaoId(String _eleicao_id)
        {
            eleicao_id = _eleicao_id;
        }

        public String GetEleicaoId()
        {
            return eleicao_id;
        }
        public void SetEleicaoNome(String _eleicao_nome)
        {
            eleicao_nome = _eleicao_nome;
        }

        public String GetEleicaoNome()
        {
            return eleicao_nome;
        }


    }
}