using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_V2
{
    public class eleicao
    {

        public String eleicao_id;

        public void SetEleicaoId(String _eleicao_id)
        {
            eleicao_id = _eleicao_id;
        }

        public String GetEleicaoId()
        {
            return eleicao_id;
        }


    }
}