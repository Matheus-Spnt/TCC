using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC_V2
{
    public class usuario
    {

        public String usuario_id;

        public void SetUsuarioId(String _usuario_id)
        {
            usuario_id = _usuario_id;
        }

        public String GetUsuarioId()
        {
            return usuario_id;
        }


    }
}